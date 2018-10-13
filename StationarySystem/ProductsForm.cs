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
        public ProductsForm() => InitializeComponent();
        private void ProductsForm_Load(object sender, EventArgs e) //contents user sees when form is initially loaded
        {
            //load form
            //fill tables
            this.productDetailTableAdapter.Fill(this.sepdbDataSet.productDetail); //only visible to stationery manager
            this.productTableAdapter.Fill(this.sepdbDataSet.product); //fill product table
            //maximise  window automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.GetCurrentUser(); //using MVC
            if (loggedInUser.UserId == 1) //if stationery manager show extra detailed table
            {
                detailsDataGrid.Visible = true;
            }
            else //everyone else doesn't see this
            {
                detailsDataGrid.Visible = false;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e) //when home button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
            
        }

        private void BtnProfile_Click(object sender, EventArgs e) //when profile button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e) //when logout button is clicked
        {
            LoginForm loginPage = new LoginForm(); //load form
            loginPage.Show();
            this.Close();
        }

       private void SearchBtn_Click(object sender, EventArgs e) //when search button is clicked
        {
            string searchValue = SearchBox.Text;
            productBindingSource.Filter = "name LIKE '*" + searchValue + "*'"; //search for matches containing the search value

        }
        
        private void ClearSearchBtn_Click(object sender, EventArgs e) //reset search and clear filter
        {
            productBindingSource.Filter = null;
        }

        private void BtnHome_Click_1(object sender, EventArgs e) //when home button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
        }

        private void BtnProfile_Click_1(object sender, EventArgs e) //when profile button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }

        private void CreateRequestBtn_Click_1(object sender, EventArgs e)  //when create stationery request button is clicked
        {
            Product selectedProduct = Program.GetCurrentProduct(); //using MVC
            string selectedstock = productDataGrid.CurrentRow.Cells[2].Value.ToString(); //converting cell to value
            if (selectedstock == "Out of Stock!") //only allow user to continue if the product is in stock
            {
                MessageBox.Show("Sorry, this product is currently unavailable.");
            }
            else
            {
                if (productDataGrid.SelectedCells.Count > 0)
                {
                    string selectedCellID = productDataGrid.CurrentRow.Cells[0].Value.ToString(); //converting cell to value
                    selectedProduct.productid = Convert.ToInt32(selectedCellID); //converting cell to value
                    CreateStationeryRequestForm statRequest = new CreateStationeryRequestForm(); //load form
                    statRequest.Show();
                    this.Close();
                }
            }
        }

        private void BtnNotifications_Click(object sender, EventArgs e)  //when product button is clicked
        {
            ProductsForm products = new ProductsForm(); //load form
            products.Show();
            this.Close();
        }

        private void BtnSystemSettings_Click(object sender, EventArgs e)  //when requests button is clicked
        {
            RequestsForm form = new RequestsForm(); //load form
            form.Show();
            this.Close();
        }

        private void BackBtn_Click_1(object sender, EventArgs e) //when back button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
        }
    }
}
