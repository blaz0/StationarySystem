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

        private void ProductsForm_Load(object sender, EventArgs e) 
        {
            // Load form.
            // Fill tables.
            // Only visible to stationery manager.
            this.productDetailTableAdapter.Fill(this.sepdbDataSet.productDetail);
            // Fill product table.
            this.productTableAdapter.Fill(this.sepdbDataSet.product); 
            // Maximise window automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // Using MVC.
            User loggedInUser = Program.GetCurrentUser();
            // If stationery manager show extra detailed table.
            if (loggedInUser.UserId == 1) 
            {
                detailsDataGrid.Visible = true;
            }
            else 
            // Everyone else doesn't see this.
            {
                detailsDataGrid.Visible = false;
            }
        }

        // When home button is clicked.
        private void BtnHome_Click(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
            
        }

        // When profile button is clicked.
        private void BtnProfile_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            this.Close();
        }

        // When logout button is clicked.
        private void PictureBox1_Click(object sender, EventArgs e) 
        {
            // Load form.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Close();
        }

        // When search button is clicked.
        private void SearchBtn_Click(object sender, EventArgs e) 
        {
            string searchValue = SearchBox.Text;
            // Search for matches containing the search value.
            productBindingSource.Filter = "name LIKE '*" + searchValue + "*'"; 

        }

        // Reset search and clear filter.
        private void ClearSearchBtn_Click(object sender, EventArgs e) 
        {
            productBindingSource.Filter = null;
        }

        // When home button is clicked.
        private void BtnHome_Click_1(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }

        // When profile button is clicked.
        private void BtnProfile_Click_1(object sender, EventArgs e) 
        {
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When create stationery request button is clicked.
        private void CreateRequestBtn_Click_1(object sender, EventArgs e)  
        {
            // Using MVC.
            Product selectedProduct = Program.GetCurrentProduct(); 
            // Converting cells to values.
            string selectedstock = productDataGrid.CurrentRow.Cells[2].Value.ToString();
            // Only allow user to continue if the product is in stock.
            if (selectedstock == "Out of Stock!") 
            {
                MessageBox.Show("Sorry, this product is currently unavailable.");
            }
            else
            {
                if (productDataGrid.SelectedCells.Count > 0)
                {
                    // Converting cells to values.
                    string selectedCellID = productDataGrid.CurrentRow.Cells[0].Value.ToString(); 
                    selectedProduct.productid = Convert.ToInt32(selectedCellID); 
                    // Load form.
                    CreateStationeryRequestForm statRequest = new CreateStationeryRequestForm(); 
                    statRequest.Show();
                    this.Close();
                }
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

        // When requests button is clicked.
        private void BtnSystemSettings_Click(object sender, EventArgs e)  
        {
            // Load form.
            RequestsForm form = new RequestsForm(); 
            form.Show();
            this.Close();
        }

        // When back button is clicked.
        private void BackBtn_Click_1(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }
    }
}
