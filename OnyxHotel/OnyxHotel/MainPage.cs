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

namespace OnyxHotel
{
    public partial class mainPageForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2062678\Desktop\OnyxHotel\OnyxHotel\RoomDataBase.mdf;Integrated Security=True");
        private int imageNumber = 0;
        private void LoadNextImage()
        {
            timer1.Start();
            imageNumber++;
            if(imageNumber > 3)
            {
                imageNumber = 0;
            }
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"hotel{imageNumber}"));
            LoadChecked();
        }
        private void LoadPreviousImage()
        {
            timer1.Start();
            imageNumber--;
            if (imageNumber < 0 )
            {
                imageNumber = 3;
            }
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"hotel{imageNumber}"));
            LoadChecked();
        }
        private void LoadChecked()
        {
            if(imageNumber == 0)
            {
                RadioButton1.Checked=true;
            }
             else if (imageNumber == 1)
            {
                RadioButton2.Checked = true;
            }
            else if (imageNumber == 2)
            {
                RadioButton3.Checked = true;
            }
            else
            {
                RadioButton4.Checked = true;
            }
        }
        public mainPageForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            clock.Start();
        }

        private void taskIcon_Click(object sender, EventArgs e)
        {
            new Tasks().Show();
            this.Hide();
        }

        private void reservationIcon_Click(object sender, EventArgs e)
        {
            new Reservation().Show();
            this.Hide ();
        }
        
        private void roomIcon_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Hide();
        }

        private void mainPageForm_Load(object sender, EventArgs e)
        {
            RadioButton1.Checked = true;
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"hotel{imageNumber}"));

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImage();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }
    }
}
