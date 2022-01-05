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
    public partial class Form2 : Form
    {
        Library library = new Library();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //
            int id = 0;
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            string postcode = txtPostcode.Text;
            string gender = txtGender.Text;
            int number = int.Parse(txtNumber.Text);
            string guardian = txtGuardian.Text;
            //
            if(age >= 18)
            {
                library.AddMember(name, age, address, postcode, gender);
                library.AddSenior(name, age, address, postcode, gender, number);
                MessageBox.Show("Member Added - Senior: " + id + " " + name + " " + age + "/n" + address + " " + postcode + gender + number, guardian);
            }
            else
            {
                library.AddJunior(name, age, address, postcode, gender, number, guardian);
                MessageBox.Show("Member Added - Junior: " + id + " " + name + " " + age + "/n" + address + " " + postcode + gender + number, guardian);
            }

        }

        private void btnListMembers_Click(object sender, EventArgs e)
        {
            library.ListMember();
        }

        private void btnListSeniors_Click(object sender, EventArgs e)
        {

        }

        private void ListJuniors_Click(object sender, EventArgs e)
        {

        }
    }
}
