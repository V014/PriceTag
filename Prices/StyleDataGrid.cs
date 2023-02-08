using System.Drawing;
using System.Windows.Forms;

namespace Prices
{
    class StyleDataGrid
    {
        // styling of the datagrid
        public void theme(DataGridView dataGrid)
        {
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGrid.BackgroundColor = Color.FromArgb(17, 17, 17);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.ColumnHeadersHeight = 30;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11);
            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 8);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 8);

        }
    }
}
