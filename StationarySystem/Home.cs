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
            loadingCircle.Visible = false;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser();
            // TODO: This line of code loads data into the 'sepdbDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.sepdbDataSet.users);
            welcomeTxt.Text = "Welcome " + loggedInUser.firstName;
            if (loggedInUser.userId == 1)
            {
                btnStockLevel.Visible = true;
                stockPicture.Visible = true;
                btnSettings.Visible = false;
                settingsPicture.Visible = false;
                approveReqBtn.Visible = true;
                okPicture.Visible = true;
            }
            else if (loggedInUser.userId == 4)
            {
                btnStockLevel.Visible = true;
                stockPicture.Visible = true;
                btnSettings.Visible = true;
                settingsPicture.Visible = true;
                approveReqBtn.Visible = true;
                okPicture.Visible = true;
            }
            else
            {
                btnStockLevel.Visible = false;
                stockPicture.Visible = false;
                btnSettings.Visible = false;
                settingsPicture.Visible = false;
                approveReqBtn.Visible = false;
                okPicture.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

        private void productPic_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }
        
        private void btnRequests_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Close();
        }

        private void btnProfile2_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            loadingCircle.Visible = true;
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void okPicture_Click(object sender, EventArgs e)
        {
            User selectedUser = Program.getCurrentUser();
            if (selectedUser.userId == 4)
            {
                MessageBox.Show("You do not have access to this button.");
            }
            else
            {
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
            }
        }

        private void approveReqBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = Program.getCurrentUser();
            if (selectedUser.userId == 4)
            {
                MessageBox.Show("You do not have access to this button.");
            }
            else
            {
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();
            this.Close();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            RequestsForm form = new RequestsForm();
            form.Show();
            this.Close();
        }
    }
}
