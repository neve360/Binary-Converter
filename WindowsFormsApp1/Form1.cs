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
    public partial class initial_screen : Form
    {

        public initial_screen()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel_converter.Visible = false;
        }

        private void hideMenu()
        {
            if (panel_converter.Visible == true)
            {
                panel_converter.Visible = false;
            }
        }

        private void showMenu(Panel subMenu)
        {
            if (panel_converter.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void select_convertor_Click(object sender, EventArgs e)
        {
            showMenu(panel_converter);
        }

        private void dectobin_Click(object sender, EventArgs e)
        {

            openChildForm(new Form2());
            hideMenu();
        }

        private void dectott_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formpanelchild.Controls.Add(childForm);
            formpanelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void initial_screen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Darra Alessandro 2021");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideMenu();
        }
    }
   

}