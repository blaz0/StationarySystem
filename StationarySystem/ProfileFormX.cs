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
            User loggedInUser = Program.GetCurrentUser(); //using MVC
            // Display values                    
            TxtFName.Text = loggedInUser.Fullname;
            TxtID.Text = loggedInUser.UserId.ToString();
            TxtEmail.Text = loggedInUser.EmailAddress;
            TxtCC.Text = loggedInUser.CostCentre;
            TxtPhoneNo.Text = loggedInUser.PhoneNo;
            TxtNickname.Text = loggedInUser.Nickname;
            //editing buttons not visible yet
            CancelBtn.Visible = false;
            SaveBtn.Visible = false;
        }

        public bool IsValidEmail(string source) //check if email is valid
        {
            return new EmailAddressAttribute().IsValid(source);
        }
                
        private void BtnHome_Click(object sender, EventArgs e)  //when home button is clicked
        {
            Home homepage = new Home(); //load page
            homepage.Show();
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm loginPage = new LoginForm(); //load page
            loginPage.Show();
            this.Close();
        }

        private void BtnProfile_Click(object sender, EventArgs e) //when profile button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load page
            profile.Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e) //when edit button is clicked
        {
            //show editing buttons
            this.CancelBtn.Visible = true;
            this.SaveBtn.Visible = true;
            //change readonly status
            this.TxtEmail.ReadOnly = false;
            this.TxtPhoneNo.ReadOnly = false;
            //clearly show user what fields can and cannot be edited
            this.TxtEmail.BackColor = Color.LightGray;
            this.TxtPhoneNo.BackColor = Color.LightGray;
        }

        private void CancelBtn_Click(object sender, EventArgs e) //when cancel button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load page
            profile.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e) //when save button is clicked
        {
            User selectedUser = Program.GetCurrentUser(); //using MVC
            sepdbDataSetTableAdapters.usersTableAdapter usersTable = new sepdbDataSetTableAdapters.usersTableAdapter();
            usersTable.UpdateUserDetails(TxtEmail.Text, TxtPhoneNo.Text, Convert.ToInt32(TxtID.Text)); //update user details using SQL statement
            selectedUser.EmailAddress = TxtEmail.Text; //update fields
            selectedUser.PhoneNo = TxtPhoneNo.Text; //update fields

            if (IsValidEmail(TxtEmail.Text) == false || TxtEmail.Text == null) //check if email is valid
            {
                MessageBox.Show("Please enter a valid email address."); //message box
            }
            else {

                ProfileFormX profile = new ProfileFormX(); //load page
                profile.Show();
                this.Close();
            }
        }

        private void TxtPhoneNo_TextChanged(object sender, EventArgs e) //check if only numbers are entered
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(TxtPhoneNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    TxtPhoneNo.Text = TxtPhoneNo.Text.Remove(TxtPhoneNo.Text.Length - 1); //remove non-numeric character
                }
        }
        
        private void Button2_Click(object sender, EventArgs e) //when products button is clicked
        {
            ProductsForm products = new ProductsForm();  //load page
            products.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e) //when requests button is clicked
        {
            RequestsForm form = new RequestsForm(); //load page
            form.Show();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm logout = new LoginForm(); //load page
            logout.Show();
            this.Close();
        }
    }
}
