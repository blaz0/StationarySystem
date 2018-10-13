
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
        private void LoginBtn_Click(object sender, EventArgs e) //On Login button click
        {
            string staffID = StaffIDTF.Text;
            string staffPassword = PasswordTF.Text;
            loadingCircle.Visible = true; //loading circle visible

            // Check for missing ID - later disable login button until values is filled
            if (string.IsNullOrEmpty(StaffIDTF.Text))
            {
                //if fields are empty/null
                MessageBox.Show("Please enter your Staff ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StaffIDTF.Focus();
                return;
            }
            try
            {
                //populate data points in User class
                sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
                sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
                if (dt.Rows.Count > 0)
                {
                    User loggedInUser = Program.getCurrentUser();
                    DataRow dr = dt.Rows[0];
                    loggedInUser.userId = int.Parse(dr["userid"].ToString());
                    loggedInUser.firstName = dr["firstname"].ToString();
                    loggedInUser.lastName = dr["lastname"].ToString();
                    loggedInUser.emailAddress = dr["emailAddress"].ToString();
                    loggedInUser.phoneNo = dr["phoneNumber"].ToString();
                    loggedInUser.costCentre = dr["costCentre"].ToString();
                    loggedInUser.nickname = dr["nickname"].ToString();
                    //load form
                    Home homepage = new Home(); 
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login details incorrect."); //display message
                    StaffIDTF.Focus();
                    //clear fields
                    StaffIDTF.Text = "";
                    PasswordTF.Text = "";
                    loadingCircle.Visible = false; //loading circle not visible
                    return;
                }
            }
            catch (Exception ex) //error handling
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StaffIDTF.Text = "";
                PasswordTF.Text = "";
                return; 
            }
        }

        private void PasswordTF_TextChanged(object sender, EventArgs e) //check username and password fields
        {
            if (KeyChar == (char)13)
            {
                LoginBtn.PerformClick();
            }
            if (String.IsNullOrWhiteSpace(PasswordTF.Text)) //only enable login button when both fields have text in them
            {
                LoginBtn.Enabled = false;
            }
            else
            {
                LoginBtn.Enabled = true;
            }
        }

        private void closeLbl_Click(object sender, EventArgs e) //close application when clicked
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
