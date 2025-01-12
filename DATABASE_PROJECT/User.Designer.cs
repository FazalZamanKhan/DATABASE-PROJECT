namespace DATABASE_PROJECT
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sellerbutton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerbutton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.adminbutton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logisticsbutton = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(287, 42);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(202, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "SELECT A ROLE";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // sellerbutton
            // 
            this.sellerbutton.BackColor = System.Drawing.Color.White;
            this.sellerbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerbutton.Location = new System.Drawing.Point(63, 124);
            this.sellerbutton.Name = "sellerbutton";
            this.sellerbutton.Size = new System.Drawing.Size(87, 27);
            this.sellerbutton.TabIndex = 1;
            this.sellerbutton.Text = "SELLER";
            this.sellerbutton.Click += new System.EventHandler(this.sellerbutton_Click);
            // 
            // customerbutton
            // 
            this.customerbutton.BackColor = System.Drawing.Color.White;
            this.customerbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbutton.Location = new System.Drawing.Point(224, 124);
            this.customerbutton.Name = "customerbutton";
            this.customerbutton.Size = new System.Drawing.Size(127, 27);
            this.customerbutton.TabIndex = 2;
            this.customerbutton.Text = "CUSTOMER";
            this.customerbutton.Click += new System.EventHandler(this.customerbutton_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.White;
            this.adminbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbutton.Location = new System.Drawing.Point(438, 124);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(83, 27);
            this.adminbutton.TabIndex = 3;
            this.adminbutton.Text = "ADMIN";
            // 
            // logisticsbutton
            // 
            this.logisticsbutton.BackColor = System.Drawing.Color.White;
            this.logisticsbutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logisticsbutton.ForeColor = System.Drawing.Color.Black;
            this.logisticsbutton.Location = new System.Drawing.Point(605, 124);
            this.logisticsbutton.Name = "logisticsbutton";
            this.logisticsbutton.Size = new System.Drawing.Size(127, 27);
            this.logisticsbutton.TabIndex = 4;
            this.logisticsbutton.Text = "LOGISTICS";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources.images;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(240, 229);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(311, 187);
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.logisticsbutton);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.customerbutton);
            this.Controls.Add(this.sellerbutton);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "User";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel sellerbutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel customerbutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel adminbutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel logisticsbutton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}