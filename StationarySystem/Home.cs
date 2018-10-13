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
        private void Homepage_Load(object sender, EventArgs e) //when the page initially loads
        {
            loadingCircle.Visible = false; //loading circle not visible
            //maximise the windows automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.GetCurrentUser(); //using MVC
            welcomeTxt.Text = "Welcome " + loggedInUser.FirstName; //create personalised message
            //display different buttons depending on the user's role
            if (loggedInUser.RoleId == 1) //stationery manager
            {
                btnStockLevel.Visible = true;
                stockPicture.Visible = true;
                btnSettings.Visible = false;
                settingsPicture.Visible = false;
                approveReqBtn.Visible = true;
                okPicture.Visible = true;
            }
            else if (loggedInUser.RoleId == 3) //system admin
            {
                btnStockLevel.Visible = true;
                stockPicture.Visible = true;
                btnSettings.Visible = true;
                settingsPicture.Visible = true;
                approveReqBtn.Visible = true; //visible but no accessible
                okPicture.Visible = true; //visible but no accessible
            }
            else //users
            {
                btnStockLevel.Visible = false;
                stockPicture.Visible = false;
                btnSettings.Visible = false;
                settingsPicture.Visible = false;
                approveReqBtn.Visible = false;
                okPicture.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e) //when profile button is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e) //when product button is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            ProductsForm allproducts = new ProductsForm(); //load form
            allproducts.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //when logout picture is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            LoginForm loginPage = new LoginForm(); //load form
            loginPage.Show();
            this.Close();
        }

        private void productPic_Click(object sender, EventArgs e) //when product picture is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            ProductsForm allproducts = new ProductsForm(); //load form
            allproducts.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e) //when home button is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
        }
        
        private void btnRequests_Click(object sender, EventArgs e)//when requests button is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            RequestsForm requests = new RequestsForm(); //load form
            requests.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//when requests picture is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            RequestsForm requests = new RequestsForm(); //load form
            requests.Show();
            this.Close();
        }

        private void btnProfile2_Click(object sender, EventArgs e)//when profile button is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //when profile picture is clicked
        {
            loadingCircle.Visible = true; //show loading circle
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }

        private void okPicture_Click(object sender, EventArgs e)  //when approve/deny picture is clicked
        {
            User selectedUser = Program.GetCurrentUser(); //using MVC
            if (selectedUser.UserId == 4) //system admin does not have access to approve/deny requests
            {
                MessageBox.Show("You do not have access to this button.");
            }
            else
            {
                ApproveRequestForm approve = new ApproveRequestForm();//load form
                approve.Show();
                this.Close();
            }
        }

        private void approveReqBtn_Click(object sender, EventArgs e)  //when approve/deny button is clicked
        {
            User selectedUser = Program.GetCurrentUser(); //using MVC
            if (selectedUser.UserId == 4) //system admin does not have access to approve/deny requests
            {
                MessageBox.Show("You do not have access to this button."); //displayed message
            }
            else
            {
                ApproveRequestForm approve = new ApproveRequestForm();//load form
                approve.Show();
                this.Close();
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e) //when product button is clicked
        {
            ProductsForm products = new ProductsForm();//load form
            products.Show();
            this.Close();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e) //when request button is clicked
        {
            RequestsForm form = new RequestsForm();//load form
            form.Show();
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm loginPage = new LoginForm();//load form
            loginPage.Show();
            this.Close();
        }
    }
}
