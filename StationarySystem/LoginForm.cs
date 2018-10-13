
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class LoginForm : Form
    {
        public char KeyChar { get; set; }

        public LoginForm() => InitializeComponent();

        // On Login button click.
        private void LoginBtn_Click(object sender, EventArgs e) 
        {
            string staffID = StaffIDTF.Text;
            string staffPassword = PasswordTF.Text;
            // Loading circle visible.
            loadingCircle.Visible = true; 

            // Check for missing ID - later disable login button until values is filled.
            if (string.IsNullOrEmpty(StaffIDTF.Text))
            {
                //if fields are empty/null.
                MessageBox.Show("Please enter your Staff ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StaffIDTF.Focus();
                return;
            }
            try
            {
                // Populate data points in User class.
                sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
                sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
                if (dt.Rows.Count > 0)
                {
                    User loggedInUser = Program.GetCurrentUser();
                    DataRow dr = dt.Rows[0];
                    loggedInUser.UserId = int.Parse(dr["userid"].ToString());
                    loggedInUser.FirstName = dr["firstname"].ToString();
                    loggedInUser.LastName = dr["lastname"].ToString();
                    loggedInUser.EmailAddress = dr["emailAddress"].ToString();
                    loggedInUser.PhoneNo = dr["phoneNumber"].ToString();
                    loggedInUser.CostCentre = dr["costCentre"].ToString();
                    loggedInUser.Nickname = dr["nickname"].ToString();
                    loggedInUser.RoleId = int.Parse(dr["roleID"].ToString());
                    // Load form.
                    Home homepage = new Home(); 
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    // Display message.
                    MessageBox.Show("Login details incorrect."); 
                    StaffIDTF.Focus();
                    // Clear fields.
                    StaffIDTF.Text = "";
                    PasswordTF.Text = "";
                    // Loading circle not visible.
                    loadingCircle.Visible = false;
                    return;
                }
            }
            // Error handling.
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StaffIDTF.Text = "";
                PasswordTF.Text = "";
                StaffIDTF.Focus();
                loadingCircle.Visible = false;
                return; 
            }
        }

        // Check username and password fields.
        private void PasswordTF_TextChanged(object sender, EventArgs e) 
        {
            if (KeyChar == (char)13)
            {
                LoginBtn.PerformClick();
            }
            // Only enable login button when both fields have text in them.
            if (String.IsNullOrWhiteSpace(PasswordTF.Text)) 
            {
                LoginBtn.Enabled = false;
            }
            else
            {
                LoginBtn.Enabled = true;
            }
        }

        // Close application when clicked.
        private void CloseLbl_Click(object sender, EventArgs e) 
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
