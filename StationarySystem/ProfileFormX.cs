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
            this.usersTableAdapter.Fill(this.sepdb_SQL.users); 
            // Maximise screen automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // Get current user information.
            sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
            // Using MVC.
            User loggedInUser = Program.GetCurrentUser(); 
            // Display values.                 
            TxtFName.Text = loggedInUser.Fullname;
            TxtID.Text = loggedInUser.UserId.ToString();
            TxtEmail.Text = loggedInUser.EmailAddress;
            TxtCC.Text = loggedInUser.CostCentre;
            TxtPhoneNo.Text = loggedInUser.PhoneNo;
            TxtNickname.Text = loggedInUser.Nickname;
            // Editing buttons not visible yet.
            CancelBtn.Visible = false;
            SaveBtn.Visible = false;
        }

        // Check if email is valid.
        public bool IsValidEmail(string source) 
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        // When home button is clicked.
        private void BtnHome_Click(object sender, EventArgs e)  
        {
            // Load page.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }

        // When logout button is clicked.
        private void PictureBox3_Click(object sender, EventArgs e) 
        {
            // Load page.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Close();
        }

        // When profile button is clicked
        private void BtnProfile_Click(object sender, EventArgs e) 
        {
            // Load page.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When edit button is clicked.
        private void EditBtn_Click(object sender, EventArgs e) 
        {
            // Show editing buttons.
            this.CancelBtn.Visible = true;
            this.SaveBtn.Visible = true;
            // Change readonly status.
            this.TxtEmail.ReadOnly = false;
            this.TxtPhoneNo.ReadOnly = false;
            // Clearly show user what fields can and cannot be edited.
            this.TxtEmail.BackColor = Color.LightGray;
            this.TxtPhoneNo.BackColor = Color.LightGray;
        }

        // When cancel button is clicked.
        private void CancelBtn_Click(object sender, EventArgs e) 
        {
            // Load page.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When save button is clicked.
        private void SaveBtn_Click(object sender, EventArgs e) 
        {
            // Using MVC.
            User selectedUser = Program.GetCurrentUser(); 
            sepdbDataSetTableAdapters.usersTableAdapter usersTable = new sepdbDataSetTableAdapters.usersTableAdapter();
            // Update user details using SQL statement.
            usersTable.UpdateUserDetails(TxtEmail.Text, TxtPhoneNo.Text, Convert.ToInt32(TxtID.Text));
            // Update fields.
            selectedUser.EmailAddress = TxtEmail.Text; 
            selectedUser.PhoneNo = TxtPhoneNo.Text;
            // Check if email is valid.
            if (IsValidEmail(TxtEmail.Text) == false || TxtEmail.Text == null) 
            {
                MessageBox.Show("Please enter a valid email address."); 
            }
            else {
                // Load page.
                ProfileFormX profile = new ProfileFormX(); 
                profile.Show();
                this.Close();
            }
        }

        // Check if only numbers are entered.
        private void TxtPhoneNo_TextChanged(object sender, EventArgs e) 
        {
                if (System.Text.RegularExpressions.Regex.IsMatch(TxtPhoneNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    // Remove non-numeric character.
                    TxtPhoneNo.Text = TxtPhoneNo.Text.Remove(TxtPhoneNo.Text.Length - 1); 
                }
        }

        // When products button is clicked.
        private void Button2_Click(object sender, EventArgs e) 
        {
            // Load page.
            ProductsForm products = new ProductsForm();  
            products.Show();
            this.Close();
        }

        // When requests button is clicked.
        private void Button1_Click(object sender, EventArgs e) 
        {
            // Load page.
            RequestsForm form = new RequestsForm(); 
            form.Show();
            this.Close();
        }

        // When logout button is clicked.
        private void PictureBox1_Click(object sender, EventArgs e) 
        {
            // Load page.
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Close();
        }
    }
}
