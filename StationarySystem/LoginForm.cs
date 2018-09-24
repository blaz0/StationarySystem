
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class LoginForm : Form
    {
        public char KeyChar { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        //On Login button click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string staffID = StaffIDTF.Text;
            string staffPassword = PasswordTF.Text;


            // Check for missing ID - later disable login button until values is filled
            if (string.IsNullOrEmpty(StaffIDTF.Text))
            {
                MessageBox.Show("Please enter your Staff ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StaffIDTF.Focus();
                return;
            }

            try
            {
                sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
                sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    int userID = int.Parse(dr["userid"].ToString());
                    //MessageBox.Show("Login OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProfileFormX profile = new ProfileFormX();
                    Home homepage = new Home();
                    //Form1 profile = new Form1();
                    profile.userIDparam = userID;
                    profile.Show();
                    this.Hide();
                }
                else
                {
                    //StaffIDTF.Clear();
                    //PasswordTF.Clear();
                    MessageBox.Show("Login details incorrect.");
                    StaffIDTF.Focus();
                    StaffIDTF.Text = "";
                    PasswordTF.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StaffIDTF.Text = "";
                PasswordTF.Text = "";
                return; 
            }
           
        }

        private void PasswordTF_TextChanged(object sender, EventArgs e)
        {
            //PasswordTF.PasswordChar = '*';

            if (KeyChar == (char)13)
                LoginBtn.PerformClick();
            if (String.IsNullOrWhiteSpace(PasswordTF.Text))
            {
                LoginBtn.Enabled = false;
            }
            else
            {
                LoginBtn.Enabled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
