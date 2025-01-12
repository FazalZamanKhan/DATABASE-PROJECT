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
    public partial class Search : Form
    {
        private string connectionString = "Data Source=Fazalkhan\\SQLEXPRESS;Initial Catalog=darazsystem;Integrated Security=True;Encrypt=False";
        public Search()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            // TODO: This line of code loads data into the 'darazsystemDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.darazsystemDataSet1.Products);

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = guna2TextBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                // If the text box is empty, load all products
                LoadAllProducts();
            }
            else
            {
                // Search for the product based on the entered name
                SearchProductsByName(searchQuery);
            }

        }
        private void LoadAllProducts()
        {
            string query = "SELECT ProductID, Name, Description, Price, Stock FROM Products";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    guna2DataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }






        private void SearchProductsByName(string productName)
        {
            string query = "SELECT ProductID, Name, Description, Price, Stock FROM Products WHERE Name LIKE @ProductName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", "%" + productName + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Check if any product was found
                    if (dataTable.Rows.Count > 0)
                    {
                        // Bind the result to the DataGridView
                        guna2DataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        // If no product is found, show a message
                        DataTable noDataTable = new DataTable();
                        noDataTable.Columns.Add("Message");
                        noDataTable.Rows.Add("No product found");
                        guna2DataGridView1.DataSource = noDataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching products: " + ex.Message);
                }
            }
        }

    }
}
