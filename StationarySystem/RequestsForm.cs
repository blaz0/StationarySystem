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
            // TODO: This line of code loads data into the 'sepdbDataSet1.stationeryrequest' table. You can move, or remove it, as needed.
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest);
            User selectedUser = Program.getCurrentUser();
            Product selectedProduct = Program.getCurrentProduct();
            int findUserID = selectedUser.userId;
            stationeryrequestBindingSource2.Filter = "Convert([userID], System.String) LIKE '" + findUserID + "'";
            //DataTable mergedTable = stationeryrequestTableAdapter.GetDataByProductID();

            saveBtn.Visible = false;
            cancelLbl.Visible = false;
            qty.Visible = false;
            quantityLbl.Visible = false;

            //this.stationeryrequestTableAdapter.FillBy(this.sepdbDataSet.stationeryrequest);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profilePage = new ProfileFormX();
            profilePage.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = Program.getCurrentUser();
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
            //int selectedProductID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[2].Value);
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString();
            //string requestedDate = requestDataGrid.CurrentRow.Cells[3].Value.ToString();

            if (requestStatus == "Submitted")
            {
                if (MessageBox.Show("Are you sure you want to cancel this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    this.stationeryrequestTableAdapter.DeleteByRequestID(selectedRequestID);
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest);
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
            stationeryrequestBindingSource.Filter = "name LIKE '*" + searchValue + "*'";
        }
        
        private void editBtn_Click(object sender, EventArgs e)
        {
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString();
            if (requestStatus == "Submitted")
            {
                Product selectedProduct = Program.getCurrentProduct();
                string selectedCellID = requestDataGrid.CurrentRow.Cells[2].Value.ToString();
                selectedProduct.productid = Convert.ToInt32(selectedCellID);
                requestDataGrid.Enabled = false;
                cancelBtn.Enabled = false;
                saveBtn.Visible = true;
                cancelLbl.Visible = true;
                qty.Visible = true;
                quantityLbl.Visible = true;

            }
            else
            {
                MessageBox.Show("Sorry, this request cannot be edited.");
            }
        }

        private void cancelLbl_Click(object sender, EventArgs e)
        {
            RequestsForm form = new RequestsForm();
            form.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update the quantity?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                int productPrice = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
                int quantity = Convert.ToInt32(qty.Value);
                int totalPrice = (quantity * productPrice);

                stationeryrequestTableAdapter.UpdateQuantity(quantity, totalPrice, selectedRequestID);
                RequestsForm form = new RequestsForm();
                form.Show();
                this.Close();
                
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
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
