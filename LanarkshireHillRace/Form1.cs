using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanarkshireHillRace
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string txtUser = txtUsername.Text;
            string txtPass = txtPassword.Text;

            if(txtPass == "" || txtUser == "")
            {
                MessageBox.Show("Enter Username & Password");
            }
            else if(txtUser == "admin" && txtPass == "password")
            {
                MessageBox.Show("LOGIN SUCCESSFULL.");
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
    }
}
