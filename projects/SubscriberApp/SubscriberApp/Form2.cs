using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("You are subscribed to all channel", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Eğer boşsa, devam etme
                }

                form1.name = textBox1.Text.ToString();
                form1.Show(); // Formu açmayı da ekleyelim istersen
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
