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
            // Load form.
            // Fill datagridview with table data.
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest); 
            // Using MVC.
            User selectedUser = Program.GetCurrentUser(); 
            Product selectedProduct = Program.GetCurrentProduct(); 
            int findUserID = selectedUser.UserId;
            stationeryrequestBindingSource2.Filter = "Convert([userID], System.String) LIKE '" + findUserID + "'";
            // Ensure these buttons are not visible when the page initially loads.
            SaveBtn.Visible = false;
            CancelLbl.Visible = false;
            Qty.Visible = false;
            QuantityLbl.Visible = false;
            // Maximise the window automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        // When the logout button is clicked.
        private void LogOutBtn_Click(object sender, EventArgs e) 
        {
            // Load form.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Hide();
        }

        // When the home button is clicked.
        private void BtnHome_Click(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Hide();
        }

        // When the profile button is clicked.
        private void BtnProfile_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProfileFormX profilePage = new ProfileFormX(); 
            profilePage.Show();
            this.Close();
        }

        // When the cancel request button is clicked.
        private void CancelBtn_Click(object sender, EventArgs e) 
        {
            // Using MVC.
            User selectedUser = Program.GetCurrentUser(); 
            // Convert cells into values.
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value); 
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString();

            // Only allow for a request to be cancelled if the status is "Submitted".
            if (requestStatus == "Submitted")
            {
                // Confirmation button in case the user accidentally/unintentionally clicks the button.
                if (MessageBox.Show("Are you sure you want to cancel this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // User clicked yes.
                    // Delete the request from the database.
                    this.stationeryrequestTableAdapter.DeleteByRequestID(selectedRequestID); 
                    // Refresh the tableview.
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest); 
                }
                else
                {
                    // User clicked no.
                    // The action is cancelled, return to "My Requests" page.
                }
            }
            else
            {
                // If the request status is not "Submitted", then display a message box. 
                MessageBox.Show("Sorry, this request cannot be cancelled.");
            }
        }

        // When the search button is clicked.
        private void SearchBtn_Click(object sender, EventArgs e) 
        {
            string searchValue = SearchBox.Text;
            // Use a LIKE query to filter the tableview based on the contents of the searchbox.
            stationeryrequestBindingSource2.Filter = "name LIKE '*" + searchValue + "*'";
        }

        // When the edit button is clicked.
        private void EditBtn_Click(object sender, EventArgs e) 
        {
            // Gets the current selected row.
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString(); 
            // Only allow the request to be edited if the status is "Submitted".
            if (requestStatus == "Submitted")
            {
                // Using MVC.
                Product selectedProduct = Program.GetCurrentProduct(); 
                // Converting from cell to string.
                string selectedCellID = requestDataGrid.CurrentRow.Cells[2].Value.ToString(); 
                // Converting to int.
                selectedProduct.productid = Convert.ToInt32(selectedCellID); 
                // Disable these buttons when updating the quantity, reduce potential errors.
                requestDataGrid.Enabled = false;
                CancelBtn.Enabled = false;
                SaveBtn.Visible = true;
                CancelLbl.Visible = true;
                Qty.Visible = true;
                QuantityLbl.Visible = true;
            }
            else
            {
                // Display when the status is not "Submitted".
                MessageBox.Show("Sorry, this request cannot be edited."); 
            }
        }

        // When the cancel button is clicked.
        private void CancelLbl_Click(object sender, EventArgs e) 
        {
            // Load form.
            RequestsForm form = new RequestsForm(); 
            form.Show();
        }

        // When the save button is clicked.
        private void SaveBtn_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Are you sure you want to update the quantity?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // User clicked yes.
                // Convert the encessary table cells to values.
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                int productPrice = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
                int quantity = Convert.ToInt32(Qty.Value);
                int totalPrice = (quantity * productPrice);
                // The database table is updated.
                stationeryrequestTableAdapter.UpdateQuantity(quantity, totalPrice, selectedRequestID);
                // Load form.
                RequestsForm form = new RequestsForm(); 
                form.Show();
                this.Close();
            }
            else
            {
                // User clicked no.
                // The action is cancelled, return to "My Requests" page.
            }
        }

        // When the products button in the navigation bar is clicked.
        private void BtnNotifications_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProductsForm products = new ProductsForm(); 
            products.Show();
            this.Close();
        }

        // When the requests button in the navigation bar is clicked.
        private void BtnSystemSettings_Click(object sender, EventArgs e) 
        {
            // Load form.
            RequestsForm form = new RequestsForm(); 
            form.Show();
            this.Close();
        }

        // When the clear search button is clicked.
        private void ClearSearchBtn_Click(object sender, EventArgs e) 
        {
            // Using MVC.
            User selectedUser = Program.GetCurrentUser(); 
            int findUserID = selectedUser.UserId;
            // The "clear search" will reset the tableview, but will continue to only show the requests for the user based on their userid.
            stationeryrequestBindingSource2.Filter = "Convert([userID], System.String) LIKE '" + findUserID + "'";
        }

        // When the back button is clicked.
        private void BackBtn_Click(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }

    }
}
