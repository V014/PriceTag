using System;
using System.Media;
using System.Windows.Forms;

namespace Prices
{
    public partial class AddItem : Form
    {
        Connection con = new Connection();
        public AddItem()
        {
            InitializeComponent();
        }
        // refresh fields
        private void refreshFields()
        {
            txt_name.Text = "";
            txt_price.Text = "";
            txt_qauntity.Text = "0";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string comaprison = con.ReadString($"SELECT Name FROM Stock WHERE Name LIKE '{txt_name.Text}' AND Quantity LIKE '{txt_qauntity.Text}' AND Price LIKE '{txt_price.Text}'");
            if (comaprison == "")
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO Stock VALUES(NULL, '{txt_name.Text}', '{txt_qauntity.Text}', '{txt_price.Text}', '{txt_stock.Text}')");
                    SoundPlayer save = new SoundPlayer(@"sfx/click.wav");
                    save.Play();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SoundPlayer save = new SoundPlayer(@"sfx/error.wav");
                save.Play();
                MessageBox.Show("This item is already in the books!");
                refreshFields();
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if ((asciiCode >= 48 && asciiCode <= 57))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Numbers Only Please!", "Error: Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }
    }
}
