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
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }
        private void RequestsForm_Load(object sender, EventArgs e)
        {
            loadingCircle1.Visible = false;
            User selectedUser = Program.getCurrentUser();
            Product selectedProduct = Program.getCurrentProduct();
            int findUserID = selectedUser.userId;
            stationeryrequestBindingSource.Filter = "Convert([userID], System.String) LIKE '*" + findUserID + "*'";
            // TODO: This line of code loads data into the 'sepdbDataSet.stationeryrequest' table. You can move, or remove it, as needed.
            this.stationeryrequestTableAdapter.GetDataByProductID();
           

            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
            loadingCircle1.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
            loadingCircle1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profilePage = new ProfileFormX();
            profilePage.Show();
            this.Close();
            loadingCircle1.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = Program.getCurrentUser();
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
            //int selectedProductID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[2].Value);
            string requestStatus = requestDataGrid.CurrentRow.Cells[6].Value.ToString();
            //string requestedDate = requestDataGrid.CurrentRow.Cells[3].Value.ToString();
            loadingCircle1.Visible = true;

            if (requestStatus == "Submitted")
            {
                if (MessageBox.Show("Are you sure you want to cancel this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    this.stationeryrequestTableAdapter.DeleteByRequestID(selectedRequestID);
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
                }
                else
                {
                    // user clicked no
                    //nothing happens, return to "My Requests" page
                }
            }
            else
            {
                MessageBox.Show("Sorry, this request cannot be cancelled.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text;
            stationeryrequestBindingSource.Filter = "productID LIKE '*" + searchValue + "*'";
            loadingCircle1.Visible = true;
        }
        
        private void editBtn_Click(object sender, EventArgs e)
        {
            string requestStatus = requestDataGrid.CurrentRow.Cells[6].Value.ToString();
            loadingCircle1.Visible = true;
            if (requestStatus == "Submitted")
            {
                Product selectedProduct = Program.getCurrentProduct();
                string selectedCellID = requestDataGrid.CurrentRow.Cells[2].Value.ToString();
                selectedProduct.productid = Convert.ToInt32(selectedCellID);
                requestDataGrid.Enabled = false;
                cancelBtn.Enabled = false;
                UpdateRequest update = new UpdateRequest();
                update.Show();

                sepdbDataSet.stationeryrequestDataTable dt = stationeryrequestTableAdapter.GetDataByProductID();
                DataRow dr = dt.Rows[0];
                selectedProduct.productid = int.Parse(dr["productID"].ToString());
                selectedProduct.supplierid = int.Parse(dr["supplierID"].ToString());
                selectedProduct.name = dr["name"].ToString();
                selectedProduct.description = dr["description"].ToString();
                selectedProduct.stock = int.Parse(dr["stock"].ToString());
                selectedProduct.price = int.Parse(dr["price"].ToString());
                selectedProduct.stockLevel = dr["stockLevel"].ToString();
            }
            else
            {
                MessageBox.Show("Sorry, this request cannot be edited.");
            }
        }

    }
}
