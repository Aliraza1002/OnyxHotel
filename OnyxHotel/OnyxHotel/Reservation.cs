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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2062678\Desktop\OnyxHotel\OnyxHotel\RoomDataBase.mdf;Integrated Security=True");

        
        private void taskIcon_Click(object sender, EventArgs e)
        {
            new Tasks().Show();
            this.Hide();
        }

        private void reservationIcon_Click(object sender, EventArgs e)
        {
            new Reservation().Show();
            this.Hide();
        }

        private void roomIcon_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Hide();
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new policy().Show();
            this.Hide();
        }

        private void hotelIconImage_Click(object sender, EventArgs e)
        {
            new mainPageForm().Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string street = streetTB.Text;
            string state = stateTB.Text;
            string postalCode = postalCodeTB.Text;

            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://google.com/maps?q=");

            if (street != string.Empty)
            {
                queryAddress.Append(street + "," + "+");
            }
            if (state != string.Empty)
            {
                queryAddress.Append(state + "," + "+");
            }
            if (postalCode != string.Empty)
            {
                queryAddress.Append(postalCode + "," + "+");
            }


            webBrowser1.Navigate(queryAddress.ToString());
        }
    }
}
