using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && textPassword.Text == "admin123")
            {
                MessageBox.Show("Login Success");
            }
            else {
                MessageBox.Show("Login Fail");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            textPassword.Clear();
        }
    }
}
