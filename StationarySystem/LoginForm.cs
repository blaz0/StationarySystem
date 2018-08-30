using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Login login = new Login("admin", "abcd");

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string staffID = StaffIDTF.Text;
            string staffPassword = PasswordTF.Text;

            if(login.isLoggedIn(staffID, staffPassword))
            {
                MessageBox.Show("Login successful.");
            }
            else
            {
                MessageBox.Show("Login details incorrect.");
            }
        }
    }
}
