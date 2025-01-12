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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sellerbutton_Click(object sender, EventArgs e)
        {
            

        }

        private void customerbutton_Click(object sender, EventArgs e)
        {
            loginform loginForm = new loginform();
            loginForm.Show();
        }
    }
}
