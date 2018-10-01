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
        public int userIDparam = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'sepdbDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.sepdbDataSet.users);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
            //DataRow dr = dt.Rows[0];
            //int userID = int.Parse(dr["userid"].ToString());
            //MessageBox.Show("Login OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProfileFormX profile = new ProfileFormX();
            profile.userIDparam = userIDparam;
            profile.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void orderTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void productPic_Click(object sender, EventArgs e)
        {
            ProductsForm allproducts = new ProductsForm();
            allproducts.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }
        
        private void btnRequests_Click(object sender, EventArgs e)
        {
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RequestsForm requests = new RequestsForm();
            requests.Show();
            this.Hide();
        }
    }
}
