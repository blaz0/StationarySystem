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
    public partial class ApproveRequestForm : Form
    {
        public ApproveRequestForm()
        {
            InitializeComponent();
        }

        // Processes to be achieved when the page loads.
        private void ApproveRequestForm_Load(object sender, EventArgs e) 
        {
            // Load page.
            // Don't display the loading circle.
            LoadingCircle1.Visible = false; 
            string selectedStatus = "Submitted";
            // Place filter on the table to display only requests that have a status of "Submitted".
            stationeryrequestBindingSource.Filter = "status LIKE '*" + selectedStatus + "*'"; 
            //fill datagridview with table data.
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
            // Maximise the window automatically.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        // When the home button is clicked.
        private void BtnHome_Click(object sender, EventArgs e) 
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
            // Display loading circle.
            LoadingCircle1.Visible = true; 
        }

        // When the profile button is clicked.
        private void BtnProfile_Click(object sender, EventArgs e) 
        {
            // Load form.
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
            //display loading circle.
            LoadingCircle1.Visible = true; 
        }

        // When the approve button is clicked.
        private void ApproveBtn_Click(object sender, EventArgs e)  
        {
            // Convert cells into values.
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
            int selectedProductID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[2].Value);
            int selectedAmount = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[4].Value);
            int stock = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
            // Subtract the approved quantity from the existing quantity.
            int reducedAmount = Product.SubtractQuantity(stock, selectedAmount); 
            // Check if there is enough stock.
            if (Product.CheckQuantity(stock, selectedAmount) == true)
            {
                // Show messagebox with yes/no options.
                if (MessageBox.Show("Are you sure you want to approve this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // User clicked yes.
                    // Update request status.
                    stationeryrequestTableAdapter.UpdateStatus("Approved", selectedRequestID);
                    // Update product amount.
                    stationeryrequestTableAdapter.UpdateStock(reducedAmount, selectedProductID);
                    // Refresh table view.
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest); 
                }
                else
                {
                    // User clicked no.
                    // Nothing happens, return to "My Requests" page.
                    LoadingCircle1.Visible = true;
                }
            }
            // If stock equals 0.
            else if (stock == 0) 
            {
                MessageBox.Show("There is no more stock for this product.");
            }
            // If there is not enough stock.
            else
            {
                MessageBox.Show("There is not enough stock to approve this request.");
            }
        }

        // When the reject button is clicked.
        private void RejectBtn_Click(object sender, EventArgs e)  
        {
            // Display confirmation display box.
            if (MessageBox.Show("Are you sure you want to reject this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // User clicked yes.
                // Convert cells into values.
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                // Update database row for the request.
                stationeryrequestTableAdapter.UpdateStatus("Denied", selectedRequestID);
                // Load form.
                ApproveRequestForm approve = new ApproveRequestForm(); 
                approve.Show();
                this.Close();
                // Display loading circle.
                LoadingCircle1.Visible = true; 
            }
            else
            {
                // User clicked no.
                // Nothing happens, return to "My Requests" page.
                // Display loading circle.
                LoadingCircle1.Visible = true; 
            }
        }

        //When the products button is clicked.
        private void btnNotifications_Click(object sender, EventArgs e)  
        {
            // Load form.
            ProductsForm products = new ProductsForm(); 
            products.Show();
            this.Close();
        }

        // When the requests button is clicked.
        private void btnSystemSettings_Click(object sender, EventArgs e)  
        {
            // Load form.
            RequestsForm form = new RequestsForm(); 
            form.Show();
            this.Close();
        }

        //When the logout button is clicked.
        private void pictureBox1_Click(object sender, EventArgs e)  
        {
            // Load form.
            LoginForm loginPage = new LoginForm(); 
            loginPage.Show();
            this.Close();
        }

        // When the back button is clicked.
        private void backBtn_Click(object sender, EventArgs e)  
        {
            // Load form.
            Home homepage = new Home(); 
            homepage.Show();
            this.Close();
        }
    }
}
