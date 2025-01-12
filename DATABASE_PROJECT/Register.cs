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

namespace DATABASE_PROJECT
{
    public partial class Regestrationpage : Form
    {
        public Regestrationpage()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            {
                // Get the values from the textboxes
                string firstName = guna2TextBox1.Text;
                string lastName = guna2TextBox2.Text;
                string email = guna2TextBox3.Text;
                string contact = guna2TextBox4.Text;
                string address = guna2TextBox5.Text;
                string UserID = guna2TextBox15.Text;
                string password = guna2TextBox6.Text;
                string role = guna2TextBox16.Text;

                // Validate the inputs (basic checks)
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) ||
                    string.IsNullOrEmpty(address) || string.IsNullOrEmpty(UserID) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Connection string (replace with your actual connection string)
                string connectionString = "Data Source=Fazalkhan\\SQLEXPRESS;Initial Catalog=darazsystem;Integrated Security=True;Encrypt=False";

                // SQL Insert query
                string query = "INSERT INTO Users (FirstName, LastName, Email, Contact, Address, UserID, Password, Role) " +
                               "VALUES (@FirstName, @LastName, @Email, @Contact, @Address, @UserID, @Password, @Role)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Set up the SQL command with parameters
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", firstName);
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@UserID", UserID);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Role", role);

                            // Execute the insert command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registration successful!");

                                // Optionally, close the current form and show the login form
                                this.Hide(); // Hide the registration form
                                loginform loginForm = new loginform();
                                loginForm.Show(); // Show the login form
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
    }
}
