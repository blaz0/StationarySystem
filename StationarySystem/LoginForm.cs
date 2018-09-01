﻿using MySql.Data.MySqlClient;
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
            MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd=password;persistsecurityinfo=True;database=sepdb");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from user where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", staffID);
            cmd.Parameters.AddWithValue("@password", staffPassword);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            rdr.Close();
            //Testing
            //System.Windows.MessageBox.Show(rdr[0].ToString());
            //System.Windows.MessageBox.Show(rdr[1].ToString());
            //System.Windows.MessageBox.Show(rdr[2].ToString());
            //System.Windows.MessageBox.Show(rdr[3].ToString());

            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
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
