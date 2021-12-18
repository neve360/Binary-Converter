using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string dec;
        int decc = 0;
        string final;
        int operazioni;
        int i;
        public Form2()
        {
            InitializeComponent();
            noriga();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void noriga()
        {
            pictureBox2.Visible = false;
        }
        public void n_dec_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(n_dec.Text, "[^0-9]"))
            {
                MessageBox.Show("Inserisci solo numeri");
                n_dec.Text = "";
            }

            if (n_dec.Text.Trim() == string.Empty)
            {
                return;
            }

            dec = n_dec.Text;
            decc = Convert.ToInt32(dec);
            tabella.Text = "";
            




        }

        private void buttonswit_Click(object sender, EventArgs e)
        {
            final = Convert.ToString(decc, 2);
            txtResult.Text = final;
            divisioni.Text = "";
            pictureBox2.Visible = true;

            char[] numeri = final.ToCharArray();
            Array.Reverse(numeri);
            foreach (var number in numeri)
            {

                tabella.Text += Environment.NewLine + number;

            }
            divisioni.Text += Environment.NewLine + dec;
            operazioni = decc;
            for (i = 0; i <= 30; i++)
            {

                operazioni /= 2;
                divisioni.Text += Environment.NewLine + decimal.Truncate(operazioni);
            }
            
        }

        public void tabella_TextChanged_1(object sender, EventArgs e)
        {
            tabella.ForeColor = Color.White;
        }

        public void divisioni_TextChanged_1(object sender, EventArgs e)
        {
            divisioni.ForeColor = Color.White;




        }

        public void reset_Click_1(object sender, EventArgs e)
        {
            divisioni.Text = "";
            tabella.Text = "";
            n_dec.Text = "";
            txtResult.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
