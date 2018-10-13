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
        private void CreateStationeryRequestForm_Load(object sender, EventArgs e) 
        {
            // Load form.
            // Loading circle not visible.
            LoadingCircle1.Visible = false; 
            // Maximise window automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            // Using MVC.
            User loggedInUser = Program.GetCurrentUser(); 
            Product selectedProduct = Program.GetCurrentProduct(); 
            // Updating the Product class.
            sepdbDataSet.productDataTable dt = productTableAdapter.GetDataByProductID(selectedProduct.productid);
            DataRow dr = dt.Rows[0];
            selectedProduct.productid = int.Parse(dr["productID"].ToString());
            selectedProduct.supplierid = int.Parse(dr["supplierID"].ToString());
            selectedProduct.name = dr["name"].ToString();
            selectedProduct.description = dr["description"].ToString();
            selectedProduct.stock = int.Parse(dr["stock"].ToString());
            selectedProduct.price = int.Parse(dr["price"].ToString());
            selectedProduct.stockLevel = dr["stockLevel"].ToString();
            // Updating textfields.
            ProductNameTxt.Text = selectedProduct.name;
            // Formatting.
            PriceTxt.Text = "$" + selectedProduct.price.ToString() + ".00";
            // Convert numericupdown to value.
            int qtyCount = Convert.ToInt32(Qty.Value); 
            // Formatting.
            TotalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00";  
            DescriptionTxt.Text = selectedProduct.description;
        }

        // When logout button is clicked.
        private void PictureBox1_Click(object sender, EventArgs e) 
        {
            // Loading circle visible.
            LoadingCircle1.Visible = true;
            // Load form.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Close();
        }

        // When home button is clicked.
        private void BtnHome_Click(object sender, EventArgs e)  
        {
            // Loading circle visible.
            LoadingCircle1.Visible = true;
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }

        // When profile button is clicked.
        private void BtnProfile_Click(object sender, EventArgs e)  
        {
            // Loading circle visible.
            LoadingCircle1.Visible = true;
            // Load form.
            ProfileFormX profile = new ProfileFormX(); 
            profile.Show();
            this.Close();
        }

        // When submit button is clicked.
        private void SubmitBtn_Click(object sender, EventArgs e) 
        {
            // Loading circle visible.
            loadingCircle.Visible = true;
            // Using MVC.
            Product selectedProduct = Program.GetCurrentProduct(); 
            User selectedUser = Program.GetCurrentUser();
            // Converting numericupdown to value.
            int quantity = Convert.ToInt32(Qty.Value); 
            int totalPrice = Convert.ToInt32(quantity * selectedProduct.price);
            // Adding a stationery request to the database table by populating with required data.
            sepdbDataSetTableAdapters.stationeryrequestTableAdapter statReq = new sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            statReq.SubmitStatReq(selectedUser.UserId, selectedProduct.productid, DateTime.Today + "", "Submitted", quantity, totalPrice); 
            // Show when request has been submitted.
            MessageBox.Show("Your Product Request has been Submitted.");
            // Load form.
            ProductsForm productform = new ProductsForm(); 
            productform.Show();
            this.Close();
        }

        // When products button is clicked.
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
        private void BackBtn_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProductsForm products = new ProductsForm(); 
            products.Show();
            this.Close();
        }

        // Automatically update when the numericupdown changes.
        private void Qty_ValueChanged(object sender, EventArgs e) 
        {
            // Convert numericupdown to value.
            int qtyCount = Convert.ToInt32(Qty.Value);
            // Using MVC.
            Product selectedProduct = Program.GetCurrentProduct(); 
            // Formatting.
            TotalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00"; 
        }
    }
}
