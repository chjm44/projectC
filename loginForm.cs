using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Text = "ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Text = "Email";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblID.Text = "휴대폰";
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
            this.CenterToScreen();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm main = new mainForm();
            this.Dispose();
            main.ShowDialog();
        }
    }
}
