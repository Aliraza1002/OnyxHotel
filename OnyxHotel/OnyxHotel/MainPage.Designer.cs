namespace OnyxHotel
{
    partial class mainPageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.RadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButton4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButton3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.hotelIconImage = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.taskIcon = new System.Windows.Forms.PictureBox();
            this.reservationIcon = new System.Windows.Forms.PictureBox();
            this.roomIcon = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Name = "panel2";
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Name = "panel5";
            // 
            // taskLabel
            // 
            resources.ApplyResources(this.taskLabel, "taskLabel");
            this.taskLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.taskLabel.Name = "taskLabel";
            // 
            // reservationLabel
            // 
            resources.ApplyResources(this.reservationLabel, "reservationLabel");
            this.reservationLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.reservationLabel.Name = "reservationLabel";
            // 
            // roomLabel
            // 
            resources.ApplyResources(this.roomLabel, "roomLabel");
            this.roomLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.roomLabel.Name = "roomLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.ForeColor = System.Drawing.Color.Gray;
            this.dateLabel.Name = "dateLabel";
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.ForeColor = System.Drawing.Color.Gray;
            this.timeLabel.Name = "timeLabel";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.RadioButton2);
            this.panel6.Controls.Add(this.RadioButton4);
            this.panel6.Controls.Add(this.RadioButton3);
            this.panel6.Controls.Add(this.RadioButton1);
            this.panel6.Name = "panel6";
            // 
            // RadioButton2
            // 
            resources.ApplyResources(this.RadioButton2, "RadioButton2");
            this.RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton2.CheckedState.BorderThickness = 0;
            this.RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton2.UncheckedState.BorderThickness = 2;
            this.RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton4_CheckedChanged);
            // 
            // RadioButton4
            // 
            resources.ApplyResources(this.RadioButton4, "RadioButton4");
            this.RadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton4.CheckedState.BorderThickness = 0;
            this.RadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton4.UncheckedState.BorderThickness = 2;
            this.RadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioButton4.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton3_CheckedChanged);
            // 
            // RadioButton3
            // 
            resources.ApplyResources(this.RadioButton3, "RadioButton3");
            this.RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton3.CheckedState.BorderThickness = 0;
            this.RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton3.UncheckedState.BorderThickness = 2;
            this.RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RadioButton1
            // 
            resources.ApplyResources(this.RadioButton1, "RadioButton1");
            this.RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton1.CheckedState.BorderThickness = 0;
            this.RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioButton1.UncheckedState.BorderThickness = 2;
            this.RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // guna2Button3
            // 
            resources.ApplyResources(this.guna2Button3, "guna2Button3");
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // hotelIconImage
            // 
            resources.ApplyResources(this.hotelIconImage, "hotelIconImage");
            this.hotelIconImage.Name = "hotelIconImage";
            this.hotelIconImage.TabStop = false;
            // 
            // logoutIcon
            // 
            resources.ApplyResources(this.logoutIcon, "logoutIcon");
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // taskIcon
            // 
            resources.ApplyResources(this.taskIcon, "taskIcon");
            this.taskIcon.Name = "taskIcon";
            this.taskIcon.TabStop = false;
            this.taskIcon.Click += new System.EventHandler(this.taskIcon_Click);
            // 
            // reservationIcon
            // 
            resources.ApplyResources(this.reservationIcon, "reservationIcon");
            this.reservationIcon.Name = "reservationIcon";
            this.reservationIcon.TabStop = false;
            this.reservationIcon.Click += new System.EventHandler(this.reservationIcon_Click);
            // 
            // roomIcon
            // 
            resources.ApplyResources(this.roomIcon, "roomIcon");
            this.roomIcon.Name = "roomIcon";
            this.roomIcon.TabStop = false;
            this.roomIcon.Click += new System.EventHandler(this.roomIcon_Click);
            // 
            // guna2Button1
            // 
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // mainPageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.roomIcon);
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
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainPageForm";
            this.Load += new System.EventHandler(this.mainPageForm_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox hotelIconImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.PictureBox taskIcon;
        private System.Windows.Forms.PictureBox reservationIcon;
        private System.Windows.Forms.PictureBox roomIcon;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButton2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButton4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButton3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}