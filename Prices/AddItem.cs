using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Media;

namespace Prices
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        // refresh fields
        private void refreshFields()
        {
            txt_name.Text = "";
            txt_price.Text = "";
            txt_qauntity.Text = "0";
        }
        // deny strings in number fields
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btn_add_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Name FROM Stock WHERE Name LIKE '" + txt_name.Text + "' AND Quantity LIKE '" + txt_qauntity.Text + "' AND Price LIKE '" + txt_price.Text + "'";
            string comaprison = con.ReadString(sql);
            if(comaprison == "")
            {
                try
                {
                    string cmd = "INSERT INTO Stock(Name, Quantity, Price) VALUES('"+ txt_name.Text +"', '"+ txt_qauntity.Text +"', '"+ txt_price.Text +"')";
                    con.ExecuteQuery(cmd);
                    SoundPlayer save = new SoundPlayer(@"click.wav");
                    save.Play();
                }
                catch(Exception)
                {
                    MessageBox.Show("Failed to record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SoundPlayer save = new SoundPlayer(@"error.wav");
                save.Play();
                MessageBox.Show("This item is already in the books!");
                refreshFields();
            }
        }
    }
}
