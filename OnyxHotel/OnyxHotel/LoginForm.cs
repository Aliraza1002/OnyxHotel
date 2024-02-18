using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnyxHotel
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtpassword.Text == "1234")
            {
                new mainPageForm().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void viewPassButton_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '•')
            {
                hidePassButton.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void hidePassButton_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                viewPassButton.BringToFront();
                txtpassword.PasswordChar = '•';
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLenguge = new ChangeLanguage();
            switch (comboBox1.SelectedIndex)
            {
                case 0: changeLenguge.UpdateConfig("language", "en-Ca");
                    Application.Restart();
                    break;
                case 1: changeLenguge.UpdateConfig("language", "es");
                    Application.Restart();
                    break;
                case 2: changeLenguge.UpdateConfig("language", "fr");
                    Application.Restart();
                    break;
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
