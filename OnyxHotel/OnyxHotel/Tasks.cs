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
    public partial class Tasks : Form
    {
       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2062678\Desktop\OnyxHotel\OnyxHotel\RoomDataBase.mdf;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Task";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Tasks()
        {
            InitializeComponent();
        }

        private void hotelIconImage_Click(object sender, EventArgs e)
        {
            new mainPageForm().Show();
            this.Hide();
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            Clock.Start();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void taskIcon_Click(object sender, EventArgs e)
        {
            new Tasks().Show();
            this.Hide();
        }

        private void roomIcon_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Hide();
        }

        private void reservationIcon_Click(object sender, EventArgs e)
        {
            new Reservation().Show();
            this.Hide();
        }

        private void roomLabel_Click(object sender, EventArgs e)
        {

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Task values('" + TaskIdBox.Text + "','" + TaskBox.Text + "','" + DepartmentText.Text + "')", Con);
            //SqlCommand cmd = new SqlCommand("Insert into Room Tabel values")
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task Succesfully Added");
            Con.Close();
            populate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Task where TaskId = " + TaskIdBox.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Task Sucesfully Deleted");
            Con.Close();
            populate();
        }

        private void TaskIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void taskLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
