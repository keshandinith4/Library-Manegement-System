using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manegement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String username = textusername.Text;
            String password = textpassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login Successfull");
                Dashboard f2 = new Dashboard();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
