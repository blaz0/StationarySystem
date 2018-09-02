using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StationarySystem
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"server = localhost; user id = root; password = J@sonDerul0?; persistsecurityinfo=True;database=sepdb");
            MySqlCommand cmd = new MySqlCommand("Select * from user where username=@username", con);

            txtName.Text = "Maxine Koh";
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            txtFName.ReadOnly = true;
            txtFName.Text = "Maxine Koh";

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "MaxineK@bigpond.net.au";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.Text = "4";
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            txtCC.Text = "FDAB1004";
        }
    }
}
