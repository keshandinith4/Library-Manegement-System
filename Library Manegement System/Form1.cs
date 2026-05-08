using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string username = textusername.Text;
            string password = textpassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            SqlConnection con = new SqlConnection(
               @"Data Source=DESKTOP-QN51LET;
               Initial Catalog=Librarydb;
               Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Users WHERE Username=@username AND Password=@password", con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Successful");

                Dashboard f2 = new Dashboard();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
