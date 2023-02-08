using System;
using System.Media;
using System.Windows.Forms;

namespace Prices
{
    public partial class Stock : MetroFramework.Forms.MetroForm
    {
        Home app = new Home();
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();
        public Stock()
        {
            InitializeComponent();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
        }
        // load the database
        private void Stock_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT Name, Price, Quantity, stock FROM stock";
            app.LoadData(cmd, stockData);
            stockData.Show();
            style.theme(stockData);
        }
        // delete from database
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SoundPlayer error = new SoundPlayer(@"error.wav");
            SoundPlayer save = new SoundPlayer(@"click.wav");

            error.Play();
            DialogResult dialogResult = MessageBox.Show("Delete Item?","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(stockData.CurrentRow.Cells[0].Value.ToString()); // collect id from selected row
                    string queryDelete = "DELETE FROM Stock WHERE id = '" + id + "'";
                    con.ExecuteQuery(queryDelete);
                    string queryRecords = "SELECT * FROM Stock";
                    app.LoadData(queryRecords, stockData);
                    save.Play();
                }
                catch (Exception)
                {
                    error.Play();
                    MessageBox.Show("Failed to delete item");
                }
            }
        }
        // refresh the data grid
        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
