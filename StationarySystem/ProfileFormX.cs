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

            cancelBtn.Visible = false;
            saveBtn.Visible = false;
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.cancelBtn.Visible = true;
            this.saveBtn.Visible = true;
            this.txtEmail.ReadOnly = false;
            this.txtPhoneNo.ReadOnly = false;
            this.txtEmail.BackColor = Color.LightGray;
            this.txtPhoneNo.BackColor = Color.LightGray;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = Program.getCurrentUser();
            sepdbDataSetTableAdapters.usersTableAdapter usersTable = new sepdbDataSetTableAdapters.usersTableAdapter();
            usersTable.UpdateUserDetails(txtEmail.Text, txtPhoneNo.Text, Convert.ToInt32(txtID.Text));
            selectedUser.emailAddress = txtEmail.Text;
            selectedUser.phoneNo = txtPhoneNo.Text;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }
    }
}
