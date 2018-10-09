using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sepdbDataSet.productDetail' table. You can move, or remove it, as needed.
            this.productDetailTableAdapter.Fill(this.sepdbDataSet.productDetail);
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sepdbDataSet.product);
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser();

            if (loggedInUser.userId == 1)
            {
                detailsDataGrid.Visible = true;
            }
            else
            {
                detailsDataGrid.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
            //DataRow dr = dt.Rows[0];
            //int userID = int.Parse(dr["userid"].ToString());
            //MessageBox.Show("Login OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }

       private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text;
            productBindingSource.Filter = "name LIKE '*" + searchValue + "*'";

        }
        
        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = null;
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void createRequestBtn_Click_1(object sender, EventArgs e)
        {
            Product selectedProduct = Program.getCurrentProduct();
            string selectedstock = productDataGrid.CurrentRow.Cells[2].Value.ToString();
            if (selectedstock == "Out of Stock!")
            {
                MessageBox.Show("Sorry, this product is currently unavailable.");
            }
            else
            {
                if (productDataGrid.SelectedCells.Count > 0)
                {
                    string selectedCellID = productDataGrid.CurrentRow.Cells[0].Value.ToString();
                    //string selectedCellPrice = productDataGrid.CurrentRow.Cells[2].Value.ToString();
                    selectedProduct.productid = Convert.ToInt32(selectedCellID);
                    //selectedProduct.price = Convert.ToInt32(selectedCellPrice);

                    CreateStationeryRequestForm statRequest = new CreateStationeryRequestForm();
                    statRequest.Show();
                    this.Close();
                }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }
    }
}
