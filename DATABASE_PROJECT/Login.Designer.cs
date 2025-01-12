namespace DATABASE_PROJECT
{
    partial class loginform
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.registerbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Innerloginpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Logintextbox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.USERNAMELABEL = new System.Windows.Forms.Label();
            this.Logintextbox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Loginbutton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Innerloginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel1.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources.loginimage1;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.registerbutton);
            this.splitContainer1.Panel1.Controls.Add(this.Innerloginpanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(110);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Bisque;
            this.splitContainer1.Panel2.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources.loginimage11;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 574;
            this.splitContainer1.TabIndex = 0;
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.White;
            this.registerbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerbutton.FillColor = System.Drawing.Color.White;
            this.registerbutton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.ForeColor = System.Drawing.Color.Black;
            this.registerbutton.Location = new System.Drawing.Point(387, 399);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(175, 39);
            this.registerbutton.TabIndex = 0;
            this.registerbutton.Text = "REGISTER";
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // Innerloginpanel
            // 
            this.Innerloginpanel.BackColor = System.Drawing.Color.Black;
            this.Innerloginpanel.Controls.Add(this.Logintextbox2);
            this.Innerloginpanel.Controls.Add(this.Passwordlabel);
            this.Innerloginpanel.Controls.Add(this.USERNAMELABEL);
            this.Innerloginpanel.Controls.Add(this.Logintextbox1);
            this.Innerloginpanel.Controls.Add(this.Loginbutton);
            this.Innerloginpanel.Location = new System.Drawing.Point(12, 12);
            this.Innerloginpanel.Name = "Innerloginpanel";
            this.Innerloginpanel.Size = new System.Drawing.Size(449, 145);
            this.Innerloginpanel.TabIndex = 0;
            // 
            // Logintextbox2
            // 
            this.Logintextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Logintextbox2.DefaultText = "";
            this.Logintextbox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Logintextbox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Logintextbox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Logintextbox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Logintextbox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Logintextbox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logintextbox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Logintextbox2.Location = new System.Drawing.Point(34, 99);
            this.Logintextbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logintextbox2.Name = "Logintextbox2";
            this.Logintextbox2.PasswordChar = '\0';
            this.Logintextbox2.PlaceholderText = "";
            this.Logintextbox2.SelectedText = "";
            this.Logintextbox2.Size = new System.Drawing.Size(186, 29);
            this.Logintextbox2.TabIndex = 4;
            this.Logintextbox2.TextChanged += new System.EventHandler(this.Logintextbox2_TextChanged);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.White;
            this.Passwordlabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(34, 77);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(106, 18);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "PASSWORD";
            this.Passwordlabel.Click += new System.EventHandler(this.Passwordlabel_Click);
            // 
            // USERNAMELABEL
            // 
            this.USERNAMELABEL.AutoSize = true;
            this.USERNAMELABEL.BackColor = System.Drawing.Color.White;
            this.USERNAMELABEL.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMELABEL.Location = new System.Drawing.Point(34, 15);
            this.USERNAMELABEL.Name = "USERNAMELABEL";
            this.USERNAMELABEL.Size = new System.Drawing.Size(101, 18);
            this.USERNAMELABEL.TabIndex = 2;
            this.USERNAMELABEL.Text = "USERNAME";
            // 
            // Logintextbox1
            // 
            this.Logintextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Logintextbox1.DefaultText = "";
            this.Logintextbox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Logintextbox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Logintextbox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Logintextbox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Logintextbox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Logintextbox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logintextbox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Logintextbox1.Location = new System.Drawing.Point(34, 38);
            this.Logintextbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logintextbox1.Name = "Logintextbox1";
            this.Logintextbox1.PasswordChar = '\0';
            this.Logintextbox1.PlaceholderText = "";
            this.Logintextbox1.SelectedText = "";
            this.Logintextbox1.Size = new System.Drawing.Size(186, 25);
            this.Logintextbox1.TabIndex = 1;
            this.Logintextbox1.TextChanged += new System.EventHandler(this.Logintextbox1_TextChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.OrangeRed;
            this.Loginbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbutton.FillColor = System.Drawing.Color.White;
            this.Loginbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.Black;
            this.Loginbutton.Location = new System.Drawing.Point(335, 101);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(102, 33);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "LOGIN";
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "LOGIN PAGE";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Innerloginpanel.ResumeLayout(false);
            this.Innerloginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Panel Innerloginpanel;
        private Guna.UI2.WinForms.Guna2Button Loginbutton;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label USERNAMELABEL;
        private Guna.UI2.WinForms.Guna2TextBox Logintextbox1;
        private Guna.UI2.WinForms.Guna2TextBox Logintextbox2;
        private Guna.UI2.WinForms.Guna2Button registerbutton;
    }
}

