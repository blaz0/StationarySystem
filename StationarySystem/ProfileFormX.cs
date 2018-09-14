using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class ProfileFormX : Form
    {
        public ProfileFormX()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sepdb_SQL.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.sepdb_SQL.users);
            // TODO: This line of code loads data into the 'sepdbDataSet3.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sepdb_SQL.users);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'sepdbDataSet2.user' table. You can move, or remove it, as needed

            try
            {
                sepdb_SQLTableAdapters.usersTableAdapter user = new sepdb_SQLTableAdapters.usersTableAdapter();
                //sepdbDataSet.usersDataTable dt = user.Login("12875795", "julia");
                sepdb_SQL.usersDataTable dt = user.GetByUserId(userIDparam);
                DataColumn fullName = new DataColumn("fullname");
                fullName.Expression = string.Format("{0}+' '+{1}", "firstName", "lastName");
                dt.Columns.Add(fullName);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    // Display values                    
                    txtFName.Text = dr["fullname"].ToString();
                    txtID.Text = dr["userid"].ToString();
                    txtEmail.Text = dr["emailAddress"].ToString();
                    txtCC.Text = dr["costCentre"].ToString();
                    txtPhoneNo.Text = dr["phoneNumber"].ToString();
                    txtNickname.Text = dr["nickname"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to retrive user details");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"server=localhost;uid=sa;pwd=password; persistsecurityinfo=True;database=sepdb");
            //SqlCommand cmd = new SqlCommand("Select * from user where username=@username", con);

            //txtName.Text = "Maxine Koh";
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            txtFName.ReadOnly = true;
            //txtFName.Text = "Maxine Koh";

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = true;
            //txtEmail.Text = "MaxineK@bigpond.net.au";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            //txtID.Text = "4";
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            txtCC.ReadOnly = true;
            //txtCC.Text = "FDAB1004";
        }

        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
//                this.usersTableAdapter.Login(this.sepdbDataSet.users, usernameToolStripTextBox.Text, passwordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void loginToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNickname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void txtCC_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
