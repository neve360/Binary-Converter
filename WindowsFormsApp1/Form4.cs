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
    public partial class Form4 : Form
    {
        string dec;
        int decc = 0;
        string final;
        int operazioni = 0;
        int i;
        int op_num = 0;
        int op_inz = 0;

        public Form4()
        {
            InitializeComponent();
            noriga();
        }

        private void noriga()
        {
            pictureBox2.Visible = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void n_dec_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(n_dec.Text, "[^0-9]"))
            {
                MessageBox.Show("Inserisci solo numeri da 0 a 9");
                n_dec.Text = "";
            }

            if (n_dec.Text.Trim() == string.Empty)
            {
                return;
            }

            dec = n_dec.Text;
            decc = Convert.ToInt32(dec);

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonswit_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            txtResult.Text = "";
            divisioni.Text = "";
            tabella.Text = "";
            final = Convert.ToString(decc, 8);
            txtResult.Text = final;
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

                operazioni /= 8;
                
                op_inz *= 8;
                op_num = operazioni - op_inz;
                divisioni.Text += Environment.NewLine + decimal.Truncate(op_num);
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            n_dec.Text = "";
            txtResult.Text = "";
            divisioni.Text = "";
            tabella.Text = "";

        }
    }
}
