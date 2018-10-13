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
        private void CreateStationeryRequestForm_Load(object sender, EventArgs e) //what the use will see when the page initially loads
        {
            //load form
            loadingCircle.Visible = false; //loading circle not visible
            loadingCircle1.Visible = false; //loading circle not visible
            //maximise window automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser(); //using MVC
            Product selectedProduct = Program.getCurrentProduct(); //using MVC
            //updating the Product class
            sepdbDataSet.productDataTable dt = productTableAdapter.GetDataByProductID(selectedProduct.productid);
            DataRow dr = dt.Rows[0];
            selectedProduct.productid = int.Parse(dr["productID"].ToString());
            selectedProduct.supplierid = int.Parse(dr["supplierID"].ToString());
            selectedProduct.name = dr["name"].ToString();
            selectedProduct.description = dr["description"].ToString();
            selectedProduct.stock = int.Parse(dr["stock"].ToString());
            selectedProduct.price = int.Parse(dr["price"].ToString());
            selectedProduct.stockLevel = dr["stockLevel"].ToString();
            //updating textfields
            productNameTxt.Text = selectedProduct.name;
            priceTxt.Text = "$" + selectedProduct.price.ToString() + ".00"; //formatting
            int qtyCount = Convert.ToInt32(qty.Value); //convert numericupdown to value
            totalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00";  //formatting
            descriptionTxt.Text = selectedProduct.description;
        }
            private void pictureBox1_Click(object sender, EventArgs e) //when logout button is clicked
        {
            loadingCircle1.Visible = true; //loading circle visible
            LoginForm loginPage = new LoginForm(); //load form
            loginPage.Show();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)  //when home button is clicked
        {
            loadingCircle1.Visible = true;  //loading circle visible
            Home homepage = new Home(); //load form 
            homepage.Show();
            this.Close();
        }
        private void btnProfile_Click(object sender, EventArgs e)  //when profile button is clicked
        {
            loadingCircle1.Visible = true;  //loading circle visible
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
        }
        private void submitBtn_Click(object sender, EventArgs e) //when submit button is clicked
        {
            loadingCircle.Visible = true;  //loading circle visible
            Product selectedProduct = Program.getCurrentProduct(); //using MVC
            User selectedUser = Program.getCurrentUser(); //using MVC
            int quantity = Convert.ToInt32(qty.Value); //converting numericupdown to value
            int totalPrice = Convert.ToInt32(quantity * selectedProduct.price);
            //adding a stationery request to the database table by populating with required data
            sepdbDataSetTableAdapters.stationeryrequestTableAdapter statReq = new sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            statReq.SubmitStatReq(selectedUser.userId, selectedProduct.productid, DateTime.Today + "", "Submitted", quantity, totalPrice); 
            //show when request has been submitted
            MessageBox.Show("Your Product Request has been Submitted.");
            ProductsForm productform = new ProductsForm(); //load page
            productform.Show();
            this.Close();
        }
        private void btnNotifications_Click(object sender, EventArgs e) //when products button is clicked
        {
            ProductsForm products = new ProductsForm(); //load page
            products.Show();
            this.Close();
        }
        private void btnSystemSettings_Click(object sender, EventArgs e) //when requests button is clicked
        {
            RequestsForm form = new RequestsForm(); //load page
            form.Show();
            this.Close();
        }
        private void backBtn_Click(object sender, EventArgs e) //when back button is clicked
        {
            Home homepage = new Home();  //load page
            homepage.Show();
            this.Close();
        }
        private void qty_ValueChanged(object sender, EventArgs e) //automatically update when the numericupdown changes
        {
            int qtyCount = Convert.ToInt32(qty.Value); //convert numericupdown to value
            Product selectedProduct = Program.getCurrentProduct(); //using MVC
            totalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00"; //ensure appropriate layout to user
        }
    }
}
