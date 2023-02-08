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
            string name = txt_name.Text;
            string quantity = txt_qauntity.Text;
            int price = int.Parse(txt_price.Text);
            int stock = int.Parse(txt_stock.Text);

            string comaprison = con.ReadString($"SELECT Name FROM Stock WHERE Name LIKE '{name}' AND Quantity LIKE '{quantity}' AND Price LIKE '{price}'");
            if (comaprison == "")
            {
                try
                {
                    con.ExecuteQuery($"INSERT INTO Stock VALUES(NULL, '{name}', '{quantity}', '{price}', '{stock}', 0)");

                    SoundPlayer save = new SoundPlayer(@"sfx/click.wav");
                    save.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
