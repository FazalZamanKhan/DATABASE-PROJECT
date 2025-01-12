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
    public partial class Customerservice : Form
    {
        private string connectionString = "Data Source=Fazalkhan\\SQLEXPRESS;Initial Catalog=darazsystem;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string
        private string userID; // To hold the UserID passed from loginform

        public Customerservice(string userIDFromLogin)
        {
            InitializeComponent();
            userID = userIDFromLogin; // Save UserID for later use
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // This event can handle any actions needed when the text changes in guna2TextBox1
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Get the text from guna2TextBox1
            string complaintDetails = guna2TextBox1.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(complaintDetails))
            {
                MessageBox.Show("Please enter your complaint details.");
                return;
            }

            // Insert the complaint into the Complaints table
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Complaints (UserID, Details) VALUES (@UserID, @Details)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Details", complaintDetails);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Complaint submitted successfully!");
                            guna2TextBox1.Clear(); // Clear the textbox after submission
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit the complaint. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Update password
            string newPassword = guna2TextBox2.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                            guna2TextBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Update first name
            string newFirstName = guna2TextBox3.Text;

            if (string.IsNullOrWhiteSpace(newFirstName))
            {
                MessageBox.Show("Please enter a new first name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Users SET FirstName = @FirstName WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", newFirstName);
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("First name updated successfully!");
                            guna2TextBox3.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the first name. Please try again.");
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

