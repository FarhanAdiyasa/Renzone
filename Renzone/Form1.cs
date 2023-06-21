using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoFullscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Gray;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lblSalah.Visible = true;
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!IsValidEmail(email))
            {
                emailInv.Visible = true;
                txtEmail.Focus();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
