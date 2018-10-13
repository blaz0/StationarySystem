using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace StationarySystem
{
    public partial class ProfileFormX : Form
    {
        public ProfileFormX() => InitializeComponent();
        private void Profile_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.sepdb_SQL.users); //fill table adapter
            //maximise screen automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            //get current user information
            sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
            User loggedInUser = Program.getCurrentUser(); //using MVC
            // Display values                    
            txtFName.Text = loggedInUser.fullname;
            txtID.Text = loggedInUser.userId.ToString();
            txtEmail.Text = loggedInUser.emailAddress;
            txtCC.Text = loggedInUser.costCentre;
            txtPhoneNo.Text = loggedInUser.phoneNo;
            txtNickname.Text = loggedInUser.nickname;
            //editing buttons not visible yet
            cancelBtn.Visible = false;
            saveBtn.Visible = false;
        }

        public bool IsValidEmail(string source) //check if email is valid
        {
            return new EmailAddressAttribute().IsValid(source);
        }
                
        private void btnHome_Click(object sender, EventArgs e)  //when home button is clicked
        {
            Home homepage = new Home(); //load page
            homepage.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm loginPage = new LoginForm(); //load page
            loginPage.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e) //when profile button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load page
            profile.Show();
            this.Close();
        }

        private void editBtn_Click(object sender, EventArgs e) //when edit button is clicked
        {
            //show editing buttons
            this.cancelBtn.Visible = true;
            this.saveBtn.Visible = true;
            //change readonly status
            this.txtEmail.ReadOnly = false;
            this.txtPhoneNo.ReadOnly = false;
            //clearly show user what fields can and cannot be edited
            this.txtEmail.BackColor = Color.LightGray;
            this.txtPhoneNo.BackColor = Color.LightGray;
        }

        private void cancelBtn_Click(object sender, EventArgs e) //when cancel button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load page
            profile.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e) //when save button is clicked
        {
            User selectedUser = Program.getCurrentUser(); //using MVC
            sepdbDataSetTableAdapters.usersTableAdapter usersTable = new sepdbDataSetTableAdapters.usersTableAdapter();
            usersTable.UpdateUserDetails(txtEmail.Text, txtPhoneNo.Text, Convert.ToInt32(txtID.Text)); //update user details using SQL statement
            selectedUser.emailAddress = txtEmail.Text; //update fields
            selectedUser.phoneNo = txtPhoneNo.Text; //update fields

            if (IsValidEmail(txtEmail.Text) == false || txtEmail.Text == null) //check if email is valid
            {
                MessageBox.Show("Please enter a valid email address."); //message box
            }
            else {

                ProfileFormX profile = new ProfileFormX(); //load page
                profile.Show();
                this.Close();
            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e) //check if only numbers are entered
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    txtPhoneNo.Text = txtPhoneNo.Text.Remove(txtPhoneNo.Text.Length - 1); //remove non-numeric character
                }
        }
        
        private void button2_Click(object sender, EventArgs e) //when products button is clicked
        {
            ProductsForm products = new ProductsForm();  //load page
            products.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //when requests button is clicked
        {
            RequestsForm form = new RequestsForm(); //load page
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm logout = new LoginForm(); //load page
            logout.Show();
            this.Close();
        }
    }
}
