using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Prices
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        // link the database
        Connection con = new Connection();
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
        // style the datagrid
        public void DataGridStyle(DataGridView dataGrid)
        {
            //dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dataGrid.BackgroundColor = Color.FromArgb(34,34,34);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51,51,51);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 14);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 14);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 14);
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
                DataGridStyle(searchData);
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
