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
    public partial class CreateStationeryRequestForm : Form
    {
        public CreateStationeryRequestForm() => InitializeComponent();

        private void CreateStationeryRequest_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser();
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void CreateStationeryRequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
