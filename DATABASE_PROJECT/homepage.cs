using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_PROJECT
{
    public partial class homepage : Form
    {
        private string userID;
        public homepage(string userIDFromLogin)
        {
            InitializeComponent();
            userID = userIDFromLogin;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darazsystemDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.darazsystemDataSet.Categories);
            guna2DataGridView1.DataSource = this.darazsystemDataSet.Categories;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            // Instantiate the Cart form
            Cart cartForm = new Cart();

            // Optionally hide the current homepage form
            this.Hide();

            // Show the Cart form
            cartForm.Show();
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Search searchForm = new Search();

            // Hide the current homepage form (optional, if you want to close the homepage)
            this.Hide(); // This hides the homepage form, you can also use this.Close() to close it.

            // Show the search form
            searchForm.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            // Assuming userID was retrieved at login and passed to the homepage form
            string userIDFromLogin = "yourLoggedInUserID"; // Replace this with the actual logic to retrieve the userID.

            // Instantiate the Customerservice form and pass the userID
            Customerservice customerServiceForm = new Customerservice(userIDFromLogin);

            // Optionally hide the homepage form
            this.Hide();

            // Show the Customerservice form
            customerServiceForm.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.FillBy(this.darazsystemDataSet.Categories);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
