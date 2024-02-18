namespace OnyxHotel
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.hotelIconImage = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameIcon = new System.Windows.Forms.PictureBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.hidePassButton = new System.Windows.Forms.Button();
            this.viewPassButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelIconImage
            // 
            resources.ApplyResources(this.hotelIconImage, "hotelIconImage");
            this.hotelIconImage.Name = "hotelIconImage";
            this.hotelIconImage.TabStop = false;
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.loginLabel.Name = "loginLabel";
            // 
            // usernameIcon
            // 
            resources.ApplyResources(this.usernameIcon, "usernameIcon");
            this.usernameIcon.Name = "usernameIcon";
            this.usernameIcon.TabStop = false;
            // 
            // passwordIcon
            // 
            resources.ApplyResources(this.passwordIcon, "passwordIcon");
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Name = "panel2";
            // 
            // exitLabel
            // 
            resources.ApplyResources(this.exitLabel, "exitLabel");
            this.exitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // clearLabel
            // 
            resources.ApplyResources(this.clearLabel, "clearLabel");
            this.clearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.BackColor = System.Drawing.Color.Brown;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtpassword
            // 
            resources.ApplyResources(this.txtpassword, "txtpassword");
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.ForeColor = System.Drawing.Color.Gray;
            this.txtpassword.Name = "txtpassword";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Name = "txtUserName";
            // 
            // hidePassButton
            // 
            resources.ApplyResources(this.hidePassButton, "hidePassButton");
            this.hidePassButton.Name = "hidePassButton";
            this.hidePassButton.UseVisualStyleBackColor = true;
            this.hidePassButton.Click += new System.EventHandler(this.hidePassButton_Click);
            // 
            // viewPassButton
            // 
            resources.ApplyResources(this.viewPassButton, "viewPassButton");
            this.viewPassButton.Name = "viewPassButton";
            this.viewPassButton.UseVisualStyleBackColor = true;
            this.viewPassButton.Click += new System.EventHandler(this.viewPassButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewPassButton);
            this.Controls.Add(this.hidePassButton);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.usernameIcon);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.hotelIconImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hotelIconImage;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox usernameIcon;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button hidePassButton;
        private System.Windows.Forms.Button viewPassButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

