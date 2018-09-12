
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
                sepdb_SQLTableAdapters.usersTableAdapter user = new sepdb_SQLTableAdapters.usersTableAdapter();
                sepdb_SQL.usersDataTable dt = user.Login(staffID, staffPassword);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    int userID = int.Parse(dr["userid"].ToString());
                    //MessageBox.Show("Login OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProfileFormX profile = new ProfileFormX();
                    Home homepage = new Home();
                    //Form1 profile = new Form1();
                    profile.userIDparam = userID;
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    //StaffIDTF.Clear();
                    //PasswordTF.Clear();
                    MessageBox.Show("Login details incorrect.");
                    StaffIDTF.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            //Create SqlConnection
            //SqlConnection con = new SqlConnection(@"server=localhost;uid=root;pwd=password;persistsecurityinfo=True;database=sepdb");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from user where username=@username and password=@password", con);
            //cmd.Parameters.AddWithValue("@username", staffID);
            //cmd.Parameters.AddWithValue("@password", staffPassword);
            //SqlDataReader rdr = cmd.ExecuteReader();

            //rdr.Read();
            //rdr.Close();
            //Testing
                //System.Windows.MessageBox.Show(rdr[0].ToString());
                //System.Windows.MessageBox.Show(rdr[1].ToString());
                //System.Windows.MessageBox.Show(rdr[2].ToString());
                //System.Windows.MessageBox.Show(rdr[3].ToString());

            //MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adapt.Fill(ds);
            //con.Close();
            //int count = ds.Tables[0].Rows.Count;

            //if (count == 1)
           // {
             //   this.Hide();
               // //ProfileFormX profile = new ProfileFormX();
               // Form1 profile = new Form1();
               // profile.Show();
          //  }
            //else
            {
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
