using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class ProfileFormX : Form
    {
        //public int userIDparam = 0;
        public ProfileFormX()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.sepdb_SQL.users);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'sepdbDataSet2.user' table. You can move, or remove it, as needed
            sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
            //debugging -> sepdbDataSet.usersDataTable dt = user.Login("12875795", "julia");
            User loggedInUser = Program.getCurrentUser();
            // Display values                    
            txtFName.Text = loggedInUser.fullname;
            txtID.Text = loggedInUser.userId.ToString();
            txtEmail.Text = loggedInUser.emailAddress;
            txtCC.Text = loggedInUser.costCentre;
            txtPhoneNo.Text = loggedInUser.phoneNo;
            txtNickname.Text = loggedInUser.nickname;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            txtFName.ReadOnly = true;
            //txtFName.Text = "Maxine Koh";

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = true;
            //txtEmail.Text = "MaxineK@bigpond.net.au";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            //txtID.Text = "4";
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            txtCC.ReadOnly = true;
            //txtCC.Text = "FDAB1004";
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
//                this.usersTableAdapter.Login(this.sepdbDataSet.users, usernameToolStripTextBox.Text, passwordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }
    }
}
