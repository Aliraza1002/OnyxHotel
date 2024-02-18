namespace OnyxHotel
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchButton = new System.Windows.Forms.Button();
            this.postalCodeTB = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.roomIcon = new System.Windows.Forms.PictureBox();
            this.reservationIcon = new System.Windows.Forms.PictureBox();
            this.taskIcon = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.hotelIconImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Controls.Add(this.postalCodeTB);
            this.splitContainer1.Panel1.Controls.Add(this.postalCodeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stateTB);
            this.splitContainer1.Panel1.Controls.Add(this.stateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.streetTB);
            this.splitContainer1.Panel1.Controls.Add(this.streetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // postalCodeTB
            // 
            resources.ApplyResources(this.postalCodeTB, "postalCodeTB");
            this.postalCodeTB.Name = "postalCodeTB";
            // 
            // postalCodeLabel
            // 
            resources.ApplyResources(this.postalCodeLabel, "postalCodeLabel");
            this.postalCodeLabel.Name = "postalCodeLabel";
            // 
            // stateTB
            // 
            resources.ApplyResources(this.stateTB, "stateTB");
            this.stateTB.Name = "stateTB";
            // 
            // stateLabel
            // 
            resources.ApplyResources(this.stateLabel, "stateLabel");
            this.stateLabel.Name = "stateLabel";
            // 
            // streetTB
            // 
            resources.ApplyResources(this.streetTB, "streetTB");
            this.streetTB.Name = "streetTB";
            // 
            // streetLabel
            // 
            resources.ApplyResources(this.streetLabel, "streetLabel");
            this.streetLabel.Name = "streetLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.ForeColor = System.Drawing.Color.Gray;
            this.timeLabel.Name = "timeLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.ForeColor = System.Drawing.Color.Gray;
            this.dateLabel.Name = "dateLabel";
            // 
            // roomLabel
            // 
            resources.ApplyResources(this.roomLabel, "roomLabel");
            this.roomLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.roomLabel.Name = "roomLabel";
            // 
            // reservationLabel
            // 
            resources.ApplyResources(this.reservationLabel, "reservationLabel");
            this.reservationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.reservationLabel.Name = "reservationLabel";
            // 
            // taskLabel
            // 
            resources.ApplyResources(this.taskLabel, "taskLabel");
            this.taskLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.taskLabel.Name = "taskLabel";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Name = "panel5";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Name = "panel3";
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.logoutLabel.Name = "logoutLabel";
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomIcon
            // 
            resources.ApplyResources(this.roomIcon, "roomIcon");
            this.roomIcon.Name = "roomIcon";
            this.roomIcon.TabStop = false;
            this.roomIcon.Click += new System.EventHandler(this.roomIcon_Click);
            // 
            // reservationIcon
            // 
            resources.ApplyResources(this.reservationIcon, "reservationIcon");
            this.reservationIcon.Name = "reservationIcon";
            this.reservationIcon.TabStop = false;
            this.reservationIcon.Click += new System.EventHandler(this.reservationIcon_Click);
            // 
            // taskIcon
            // 
            resources.ApplyResources(this.taskIcon, "taskIcon");
            this.taskIcon.Name = "taskIcon";
            this.taskIcon.TabStop = false;
            this.taskIcon.Click += new System.EventHandler(this.taskIcon_Click);
            // 
            // logoutIcon
            // 
            resources.ApplyResources(this.logoutIcon, "logoutIcon");
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // hotelIconImage
            // 
            resources.ApplyResources(this.hotelIconImage, "hotelIconImage");
            this.hotelIconImage.Name = "hotelIconImage";
            this.hotelIconImage.TabStop = false;
            this.hotelIconImage.Click += new System.EventHandler(this.hotelIconImage_Click);
            // 
            // Reservation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.roomIcon);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.reservationIcon);
            this.Controls.Add(this.taskIcon);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.logoutIcon);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hotelIconImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox roomIcon;
        private System.Windows.Forms.PictureBox reservationIcon;
        private System.Windows.Forms.PictureBox taskIcon;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox hotelIconImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox postalCodeTB;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox streetTB;
    }
}