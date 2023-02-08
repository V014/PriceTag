using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Prices
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        // link the database
        Connection con = new Connection();
        StyleDataGrid style = new StyleDataGrid();

        public Home()
        {
            InitializeComponent();
        }
        //loads data into a data grid
        public void LoadData(string query, DataGridView dataGrid)
        {
            var conn = con.GetConnection();
            var DB = new SQLiteDataAdapter(query, conn);
            var DS = new DataSet();
            var DT = new DataTable();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGrid.DataSource = DT;
            conn.Close();
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
            Stock stock = new Stock();
            stock.Show();
        }
    }
}
