using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manegement_System
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            bookidfeild.Clear();
            titlefeild.Clear();
            authorfeild.Clear();
            isbnfeild.Clear();
            categoryfeild.Clear();
            pricefeild.Clear();
        }

        private void deletebookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=LibraryDB;Integrated Security=True");
                conn.Open();

                string query = "DELETE FROM Books WHERE BookID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bookidfeild.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Book Deleted Successfully!");
                else
                    MessageBox.Show("Invalid Book ID!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updatebookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=LibraryDB;Integrated Security=True");
                conn.Open();

                string query = "UPDATE Books SET Title=@Title, Author=@Author, ISBN=@ISBN, Category=@Cat, Price=@Price WHERE BookID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", bookidfeild.Text);
                cmd.Parameters.AddWithValue("@Title", titlefeild.Text);
                cmd.Parameters.AddWithValue("@Author", authorfeild.Text);
                cmd.Parameters.AddWithValue("@ISBN", isbnfeild.Text);
                cmd.Parameters.AddWithValue("@Cat", categoryfeild.Text);
                cmd.Parameters.AddWithValue("@Price", pricefeild.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Book Updated Successfully!");
                else
                    MessageBox.Show("Book ID not found!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addbookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=LibraryDB;Integrated Security=True");
                conn.Open();

                string query = "INSERT INTO Books (BookID, Title, Author, ISBN, Category, Price) VALUES (@ID, @Title, @Author, @ISBN, @Cat, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", bookidfeild.Text);
                cmd.Parameters.AddWithValue("@Title", titlefeild.Text);
                cmd.Parameters.AddWithValue("@Author", authorfeild.Text);
                cmd.Parameters.AddWithValue("@ISBN", isbnfeild.Text);
                cmd.Parameters.AddWithValue("@Cat", categoryfeild.Text);
                cmd.Parameters.AddWithValue("@Price", pricefeild.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
