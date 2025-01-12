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

    public partial class loginform : Form
    {
        private string connectionString = "Data Source=Fazalkhan\\SQLEXPRESS;Initial Catalog=darazsystem;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string

        public loginform()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void Logintextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            string userID = Logintextbox1.Text; // Assuming Logintextbox1 is the username input
            string password = Logintextbox2.Text; // Assuming PasswordTextbox is the password input

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE UserID = @UserID AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                            {
                                // If the user is a customer, open homepage.cs
                                homepage homepageForm = new homepage(userID);
                                homepageForm.Show();
                                this.Hide(); // Optionally hide the login form
                            }
                            else
                            {
                                MessageBox.Show("Only customers are allowed to log in here.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void registerbutton_Click(object sender, EventArgs e)
        {
            Regestrationpage registrationForm = new Regestrationpage();
            registrationForm.Show();
            this.Hide();

        }

        private void Logintextbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
