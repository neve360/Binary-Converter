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
    public partial class Form3 : Form
    {
        string dec;
        int decc = 0;
        string final;
        int binario = 0;
        int i;

        public Form3()
        {
            InitializeComponent();
        }

        private void n_dec_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(n_dec.Text, "[^0-1]"))
            {
                MessageBox.Show("Inserisci solo numeri da 0 a 1");
                n_dec.Text = "";
            }

            if (n_dec.Text.Trim() == string.Empty)
            {
                return;
            }

            dec = n_dec.Text;
            decc = Convert.ToInt32(dec);
            

        }

        private void buttonswit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dec.Length; i++)
            {
                if (dec[dec.Length - i - 1] == '0') continue;
                binario += (int)Math.Pow(2, i);

                
            }
            string final = Convert.ToString(binario);
            txtResult.Text = final;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            n_dec.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
