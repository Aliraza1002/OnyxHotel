namespace OnyxHotel
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.roomIcon = new System.Windows.Forms.PictureBox();
            this.reservationIcon = new System.Windows.Forms.PictureBox();
            this.taskIcon = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.hotelIconImage = new System.Windows.Forms.PictureBox();
            this.TaskBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskIdBox = new System.Windows.Forms.TextBox();
            this.DepartmentText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            resources.ApplyResources(this.roomLabel, "roomLabel");
            this.roomLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Click += new System.EventHandler(this.roomLabel_Click);
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
            this.taskLabel.Click += new System.EventHandler(this.taskLabel_Click);
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
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RoomGridView
            // 
            resources.ApplyResources(this.RoomGridView, "RoomGridView");
            this.RoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RoomGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersVisible = false;
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
            // TaskBox
            // 
            resources.ApplyResources(this.TaskBox, "TaskBox");
            this.TaskBox.Name = "TaskBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TaskIdBox
            // 
            resources.ApplyResources(this.TaskIdBox, "TaskIdBox");
            this.TaskIdBox.Name = "TaskIdBox";
            // 
            // DepartmentText
            // 
            resources.ApplyResources(this.DepartmentText, "DepartmentText");
            this.DepartmentText.Name = "DepartmentText";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Tasks
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskIdBox);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RoomGridView);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelIconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.TextBox TaskBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaskIdBox;
        private System.Windows.Forms.TextBox DepartmentText;
        private System.Windows.Forms.Label label6;
    }
}