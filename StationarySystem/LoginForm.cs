using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace StationarySystem
{
    public partial class LoginForm : Form
    {
        public char KeyChar { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        //On Login button click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string staffID = StaffIDTF.Text;
            string staffPassword = PasswordTF.Text;

            //Create SqlConnection
            SqlConnection con = new SqlConnection(@"server = localhost; user id = root; password = J@sonDerul0?; persistsecurityinfo=True;database=sepdb");
            SqlCommand cmd = new SqlCommand("Select * from user where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", staffID);
            cmd.Parameters.AddWithValue("@password", staffPassword);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;

            if (count == 1)
            {
                this.Hide();
                Profile profile = new Profile();
                profile.Show();
            }
            else
            {
                StaffIDTF.Clear();
                PasswordTF.Clear();
                MessageBox.Show("Login details incorrect.");
            }
        }

        private void PasswordTF_TextChanged(object sender, EventArgs e)
        {
            PasswordTF.PasswordChar = '*';

            if (KeyChar == (char)13)
                LoginBtn.PerformClick();
        }

        private void StaffIDTF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
