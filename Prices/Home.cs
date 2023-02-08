using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Prices
{
    public partial class Home : Form
    {
        // link the database
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();

        public Home()
        {
            InitializeComponent();
            LoadData(searchData);
            style.theme(searchData);
            lbl_products.Text = LoadProducts();
            lbl_product_stock.Text = LoadStock();
            lbl_stock_value.Text = LoadStockValue();
        }
        //loads data into a data grid
        private void LoadData(DataGridView dataGrid)
        {
            con.LoadData("SELECT * FROM stock", dataGrid);
            dataGrid.Columns[0].Visible = false;
        }
        // count the items in database
        private string LoadProducts()
        {
            string stock = con.ReadString("SELECT COUNT(id) FROM stock");
            return stock;
        }
        // count the stock of items
        private string LoadStock()
        {
            string stock = con.ReadString("SELECT SUM(stock) FROM stock");
            return stock;
        }
        // stock value
        private string LoadStockValue()
        {
            string stock = con.ReadString("SELECT SUM(price) FROM stock");
            return stock;
        }
        // react when user starts typing
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_search.Text != "")
            {
                string cmd = "SELECT Name, Price, Quantity, stock FROM stock WHERE Name LIKE '%" + txt_search.Text + "%'";
                con.LoadData("SELECT Name, Price, Quantity, stock FROM stock WHERE Name LIKE '%" + txt_search.Text + "%'", searchData);
                //LoadData(cmd, searchData);
                searchData.Show();
                style.theme(searchData);
            }
            else
            {
                searchData.Hide();
            }
        }
        // open the database
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem item = new AddItem();
            item.Show();
        }
        // when user wants to update a record
        private void btn_update_Click(object sender, EventArgs e)
        {

        }
        // when user wants to delete a record
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SoundPlayer error = new SoundPlayer(@"error.wav");
            SoundPlayer save = new SoundPlayer(@"click.wav");

            error.Play();
            DialogResult dialogResult = MessageBox.Show("Delete Item?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(searchData.CurrentRow.Cells[0].Value.ToString()); // collect id from selected row
                    string queryDelete = "DELETE FROM Stock WHERE id = '" + id + "'";
                    con.ExecuteQuery(queryDelete);
                    string queryRecords = "SELECT * FROM Stock";
                    con.LoadData(queryRecords, searchData);
                    save.Play();
                }
                catch (Exception)
                {
                    error.Play();
                    MessageBox.Show("Failed to delete item");
                }
            }
        }
    }
}
