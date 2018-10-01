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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser();
            // TODO: This line of code loads data into the 'sepdbDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.sepdbDataSet.users);
            welcomeTxt.Text = "Welcome " + loggedInUser.firstName;
            if (loggedInUser.id == 1)
            {
                btnNotification.Visible = true;
                notifyPicture.Visible = true;
                btnSettings.Visible = true;
                settingsPicture.Visible = true;
            }
            else
            {
                btnNotification.Visible = false;
                notifyPicture.Visible = false;
                btnSettings.Visible = false;
                settingsPicture.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

        private void productPic_Click(object sender, EventArgs e)
        {
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }
        
        private void btnRequests_Click(object sender, EventArgs e)
        {
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Close();
        }

        private void btnProfile2_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }
    }
}
