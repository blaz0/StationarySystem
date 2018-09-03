using System;
using System.Data;
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
            // TODO: This line of code loads data into the 'sepdbDataSet3.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.sepdbDataSet1.users);
            // TODO: This line of code loads data into the 'sepdbDataSet2.user' table. You can move, or remove it, as needed
            try
            {
                sepdbDataSetTableAdapters.usersTableAdapter user = new sepdbDataSetTableAdapters.usersTableAdapter();
                //sepdbDataSet.usersDataTable dt = user.Login("12875795", "julia");
                sepdbDataSet.usersDataTable dt = user.GetDataByUserId(userIDparam);
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

                }
                else
                {
                    MessageBox.Show("Unablke to retrive user details");
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
            //txtEmail.Text = "MaxineK@bigpond.net.au";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //txtID.Text = "4";
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
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
    }
}
