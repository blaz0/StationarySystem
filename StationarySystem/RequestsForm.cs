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
        private void RequestsForm_Load(object sender, EventArgs e) //processes to be achieved when the page loads
        {
            //load page
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest); //fill datagridview with table data
            User selectedUser = Program.GetCurrentUser(); //using MVC
            Product selectedProduct = Program.GetCurrentProduct(); //using MVC
            int findUserID = selectedUser.UserId;
            stationeryrequestBindingSource2.Filter = "Convert([userID], System.String) LIKE '" + findUserID + "'";
            //ensure these buttons are not visible when the page initially loads
            SaveBtn.Visible = false;
            CancelLbl.Visible = false;
            Qty.Visible = false;
            QuantityLbl.Visible = false;
            //maximise the window automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void LogOutBtn_Click(object sender, EventArgs e) //when the logout button is clicked
        {
            LoginForm loginPage = new LoginForm(); //load form
            loginPage.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e) //when the home button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Hide();
        }

        private void BtnProfile_Click(object sender, EventArgs e) //when the profile button is clicked
        {
            ProfileFormX profilePage = new ProfileFormX(); //load form
            profilePage.Show();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e) //when the cancel request button is clicked
        {
            User selectedUser = Program.GetCurrentUser(); //using MVC
            //convert cells into values
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value); 
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString();

            //only allow for a request to be cancelled if the status is "Submitted"
            if (requestStatus == "Submitted")
            {
                //confirmation button in case the user accidentally/unintentionally clicks the button
                if (MessageBox.Show("Are you sure you want to cancel this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    this.stationeryrequestTableAdapter.DeleteByRequestID(selectedRequestID); //delete the request from the database
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet1.stationeryrequest); //refresh the tableview
                }
                else
                {
                    //user clicked no
                    //the action is cancelled, return to "My Requests" page
                }
            }
            else
            {
                //if the request status is not "Submitted", then display a message box 
                MessageBox.Show("Sorry, this request cannot be cancelled.");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e) //when the search button is clicked
        {
            string searchValue = SearchBox.Text;
            //use a LIKE query to filter the tableview based on the contents of the searchbox
            stationeryrequestBindingSource2.Filter = "name LIKE '*" + searchValue + "*'";
        }
        
        private void EditBtn_Click(object sender, EventArgs e) //when the edit button is clicked
        {
            string requestStatus = requestDataGrid.CurrentRow.Cells[7].Value.ToString(); //gets the current selected row
            //only allow the request to be edited if the status is "Submitted"
            if (requestStatus == "Submitted")
            {
                Product selectedProduct = Program.GetCurrentProduct(); //using MVC
                string selectedCellID = requestDataGrid.CurrentRow.Cells[2].Value.ToString(); //converting from cell to string
                selectedProduct.productid = Convert.ToInt32(selectedCellID); //converting to int
                //disable these buttons when updating the quantity, reduce potential errors
                requestDataGrid.Enabled = false;
                CancelBtn.Enabled = false;
                SaveBtn.Visible = true;
                CancelLbl.Visible = true;
                Qty.Visible = true;
                QuantityLbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Sorry, this request cannot be edited."); //display when the status is not "Submitted"
            }
        }

        private void CancelLbl_Click(object sender, EventArgs e) //when the cancel button is clicked
        {
            RequestsForm form = new RequestsForm(); //load form
            form.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e) //when the save button is clicked
        {
            if (MessageBox.Show("Are you sure you want to update the quantity?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //user clicked yes
                //convert the encessary table cells to values
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                int productPrice = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
                int quantity = Convert.ToInt32(Qty.Value);
                int totalPrice = (quantity * productPrice);
                //the database table is updated
                stationeryrequestTableAdapter.UpdateQuantity(quantity, totalPrice, selectedRequestID);
                RequestsForm form = new RequestsForm(); //reload form
                form.Show();
                this.Close();
            }
            else
            {
                //user clicked no
                //the action is cancelled, return to "My Requests" page
            }
        }

        private void BtnNotifications_Click(object sender, EventArgs e) //when the products button in the navigation bar is clicked
        {
            ProductsForm products = new ProductsForm(); //load form
            products.Show();
            this.Close();
        }

        private void BtnSystemSettings_Click(object sender, EventArgs e) //when the requests button in the navigation bar is clicked
        {
            RequestsForm form = new RequestsForm(); //load form
            form.Show();
            this.Close();
        }

        private void ClearSearchBtn_Click(object sender, EventArgs e) //when the clear search button is clicked
        {
            User selectedUser = Program.GetCurrentUser(); //using MVC
            int findUserID = selectedUser.UserId;
            //the "clear search" will reset the tableview, but will continue to only show the requests for the user based on their userid
            stationeryrequestBindingSource2.Filter = "Convert([userID], System.String) LIKE '" + findUserID + "'";
        }

        private void BackBtn_Click(object sender, EventArgs e) //when the back button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
        }

    }
}
