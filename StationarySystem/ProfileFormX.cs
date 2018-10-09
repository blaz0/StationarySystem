using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

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
            loadingCircle.Visible = false;
            loadingCircle1.Visible = false;
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

        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
                
        private void btnHome_Click(object sender, EventArgs e)
        {
            loadingCircle1.Visible = true;
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadingCircle1.Visible = true;
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadingCircle1.Visible = true;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            loadingCircle1.Visible = true;
            this.cancelBtn.Visible = true;
            this.saveBtn.Visible = true;
            this.txtEmail.ReadOnly = false;
            this.txtPhoneNo.ReadOnly = false;
            this.txtEmail.BackColor = Color.LightGray;
            this.txtPhoneNo.BackColor = Color.LightGray;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            User selectedUser = Program.getCurrentUser();
            sepdbDataSetTableAdapters.usersTableAdapter usersTable = new sepdbDataSetTableAdapters.usersTableAdapter();
            usersTable.UpdateUserDetails(txtEmail.Text, txtPhoneNo.Text, Convert.ToInt32(txtID.Text));
            selectedUser.emailAddress = txtEmail.Text;
            selectedUser.phoneNo = txtPhoneNo.Text;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    txtPhoneNo.Text = txtPhoneNo.Text.Remove(txtPhoneNo.Text.Length - 1);
                }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(IsValidEmail(txtEmail.Text)== false || txtEmail.Text == null)
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Text = txtEmail.Text.Remove(txtEmail.Text.Length - 20);
            }
        }
    }
}
