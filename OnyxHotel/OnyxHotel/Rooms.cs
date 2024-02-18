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
    public partial class Rooms : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2062678\Desktop\OnyxHotel\OnyxHotel\RoomDataBase.mdf;Integrated Security=True");    
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Room";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Rooms()
        {
            InitializeComponent();
        }

        private void reservationIcon_Click(object sender, EventArgs e)
        {
            new Reservation().Show();
            this.Hide();
        }

        private void logoutIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taskIcon_Click(object sender, EventArgs e)
        {
            new Tasks().Show();
            this.Hide();
        }

        private void hotelIconImage_Click(object sender, EventArgs e)
        {
            new mainPageForm().Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Room values('" + RoomIdTextBox.Text + "','" + RoomTypeBox.SelectedItem.ToString() + "','" + RoomStatusBox.SelectedItem.ToString() + "','" + EmailTextBox.Text + "','" + PhoneTextBox.Text + "','" + FirstNameTextBox.Text + "','" + SecondNameTextBox.Text +"')", Con);
            //SqlCommand cmd = new SqlCommand("Insert into Room Tabel values")
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Succesfully Added");
            Con.Close();
            populate();
           
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //RoomIdTextBox.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            //RoomIdTextBox.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
           // RoomTypeBox.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
            //RoomStatusBox.Text = RoomGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query ="delete from Room where RoomId = "+ RoomIdTextBox.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Sucesfully Deleted");
            Con.Close();
            populate();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Room set RoomType = '" + RoomTypeBox.SelectedItem.ToString() + "',RoomStatus = '" + RoomStatusBox.SelectedItem.ToString() + "', Email ='"+EmailTextBox.Text+"', Fname ='"+FirstNameTextBox.Text+"', Sname ='"+SecondNameTextBox.Text+"', PhoneNumber ='"+PhoneTextBox.Text+"'where RoomId = " + RoomIdTextBox.Text ;

            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Sucesfully Edited");
            Con.Close();
            populate();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void reservationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
