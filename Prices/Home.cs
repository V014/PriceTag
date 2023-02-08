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
            LoadData();
            style.theme(data_search);
            lbl_products.Text = LoadProducts();
            lbl_product_stock.Text = LoadStock();
            lbl_stock_value.Text = LoadStockValue();
        }
        //loads data into a data grid
        private void LoadData()
        {
            con.LoadData("SELECT ID, Name, Quantity, Price, Stock, Purchased FROM stock", data_search);
            data_search.Columns[0].Visible = false;
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
                con.LoadData("SELECT Name, Price, Quantity, stock FROM stock WHERE Name LIKE '%" + txt_search.Text + "%'", data_search);
                //LoadData(cmd, searchData);
                data_search.Show();
                style.theme(data_search);
            }
            else
            {
                data_search.Hide();
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
            int inserted = 0;
            try
            {
                DataGridViewRow selectedRow = data_search.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                string quantity = selectedRow.Cells[2].Value.ToString();
                int price = int.Parse(selectedRow.Cells[3].Value.ToString());
                int stock = int.Parse(selectedRow.Cells[4].Value.ToString());
                int purchased = int.Parse(selectedRow.Cells[5].Value.ToString());

                con.ExecuteQuery($"UPDATE stock SET Name = '{name}', Quantity = '{quantity}', Price = {price}, Stock = {stock}, Purchased = {purchased} WHERE ID = {id}");
                LoadData();
                inserted++;
            }
            catch (Exception)
            {
                MessageBox.Show("Reduce motion for stability", "Assistant");
            }
        }
        // when user wants to delete a record
        private void btn_delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Delete Item?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(data_search.CurrentRow.Cells[0].Value.ToString()); // collect id from selected row
                    string queryDelete = $"DELETE FROM Stock WHERE id = {id}";
                    con.ExecuteQuery(queryDelete);
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to delete item");
                }
            }
        }
        // when a user is doen editing details
        private void data_search_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btn_update_Click(sender, e);
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            btn_update_Click(sender, e);
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            data_search.Rows.Add();
        }
    }
}
