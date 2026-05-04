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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            Books f2 = new Books();
            f2.Show();
            this.Hide();
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            Members f2 = new Members();
            f2.Show();
            this.Hide();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            Reports f2 = new Reports();
            f2.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}
