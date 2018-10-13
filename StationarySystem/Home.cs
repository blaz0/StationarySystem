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
        public Home() => InitializeComponent();

        // When the page initially loads.
        private void Homepage_Load(object sender, EventArgs e) 
        {
            // Loading circle not visible.
            loadingCircle.Visible = false; 
            // Maximise the windows automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // Using MVC.
            User loggedInUser = Program.GetCurrentUser(); 
            // Create personalised message.
            WelcomeTxt.Text = "Welcome " + loggedInUser.FirstName; 
            // Display different buttons depending on the user's role.
            // Stationery manager.
            if (loggedInUser.RoleId == 1) 
            {
                BtnStockLevel.Visible = true;
                StockPicture.Visible = true;
                BtnSettings.Visible = false;
                SettingsPicture.Visible = false;
                ApproveReqBtn.Visible = true;
                OkPicture.Visible = true;
            }
            // System admin.
            else if (loggedInUser.RoleId == 3) 
            {
                BtnStockLevel.Visible = true;
                StockPicture.Visible = true;
                BtnSettings.Visible = true;
                SettingsPicture.Visible = true;
                // Visible but no accessible.
                ApproveReqBtn.Visible = true;
                // Visible but no accessible.
                OkPicture.Visible = true; 
            }
            else // Users.
            {
                BtnStockLevel.Visible = false;
                StockPicture.Visible = false;
                BtnSettings.Visible = false;
                SettingsPicture.Visible = false;
                ApproveReqBtn.Visible = false;
                OkPicture.Visible = false;
            }
        }

        // When profile button is clicked.
        private void BtnProfile_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When product button is clicked.
        private void BtnProducts_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            ProductsForm allproducts = new ProductsForm(); 
            allproducts.Show();
            this.Close();
        }

        // When logout picture is clicked
        private void PictureBox2_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Close();
        }

        // When product picture is clicked
        private void ProductPic_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            ProductsForm allproducts = new ProductsForm(); 
            allproducts.Show();
            this.Close();
        }

        // When home button is clicked
        private void BtnHome_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }

        // When requests button is clicked
        private void BtnRequests_Click(object sender, EventArgs e)
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            RequestsForm requests = new RequestsForm(); 
            requests.Show();
            this.Close();
        }

        // When requests picture is clicked
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            RequestsForm requests = new RequestsForm(); 
            requests.Show();
            this.Close();
        }

        // When profile button is clicked
        private void BtnProfile2_Click(object sender, EventArgs e)
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When profile picture is clicked.
        private void PictureBox1_Click(object sender, EventArgs e) 
        {
            // Show loading circle.
            loadingCircle.Visible = true;
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When approve/deny picture is clicked.
        private void OkPicture_Click(object sender, EventArgs e)  
        {
            // Using MVC.
            User selectedUser = Program.GetCurrentUser();
            // System admin does not have access to approve/deny requests.
            if (selectedUser.UserId == 4) 
            {
                MessageBox.Show("You do not have access to this button.");
            }
            else
            {
                // Load form.
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
            }
        }

        // When approve/deny button is clicked.
        private void ApproveReqBtn_Click(object sender, EventArgs e)  
        {
            // Using MVC.
            User selectedUser = Program.GetCurrentUser(); 
            // System admin does not have access to approve/deny requests.
            if (selectedUser.UserId == 4) 
            {
                MessageBox.Show("You do not have access to this button."); 
            }
            else
            {
                // Load form.
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
            }
        }

        // When product button is clicked.
        private void BtnNotifications_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProductsForm products = new ProductsForm();
            products.Show();
            this.Close();
        }

        // When request button is clicked.
        private void BtnSystemSettings_Click(object sender, EventArgs e) 
        {
            // Load form.
            RequestsForm form = new RequestsForm();
            form.Show();
            this.Close();
        }

        // When logout button is clicked.
        private void PictureBox2_Click_1(object sender, EventArgs e) 
        {
            // Load form.
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }
    }
}
