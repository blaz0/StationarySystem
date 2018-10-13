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

        private void ApproveRequestForm_Load(object sender, EventArgs e) //processes to be achieved when the page loads
        {
            //load page
            LoadingCircle1.Visible = false; //don't display the loading circle
            string selectedStatus = "Submitted";
            stationeryrequestBindingSource.Filter = "status LIKE '*" + selectedStatus + "*'"; //place filter on the table to display only requests that have a status of "Submitted"
            //fill datagridview with table data
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
            //maximise the window automatically
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }
                
        private void BtnHome_Click(object sender, EventArgs e) //when the home button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
            LoadingCircle1.Visible = true; //display loading circle
        }

        private void BtnProfile_Click(object sender, EventArgs e) //when the profile button is clicked
        {
            ProfileFormX profile = new ProfileFormX(); //load form
            profile.Show();
            this.Close();
            LoadingCircle1.Visible = true; //display loading circle
        }

        public static int SubtractQuantity(int originalQty, int amount) 
        {
            return originalQty - amount; //subtract quantity from the original quantity
        }

        public static int AddQuantity(int originalQty, int amount)
        {
            return originalQty + amount; //add quantity to the original quantity
        }

        public static bool CheckQuantity(int currentStock, int amount) 
        {
            if (currentStock >= amount) //check if there is enough stock
            {
                return true;
            }
            return false;
        }

        private void approveBtn_Click(object sender, EventArgs e)  //when the approve button is clicked
        {
            //convert cells into values
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
            int selectedProductID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[2].Value);
            int selectedAmount = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[4].Value);
            int stock = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
            int reducedAmount = SubtractQuantity(stock, selectedAmount); //subtract the approved quantity fromt he existing quantity
            //check if there is enough stock
            if (CheckQuantity(stock, selectedAmount) == true)
            {
                //show messagebox with yes/no options
                if (MessageBox.Show("Are you sure you want to approve this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    stationeryrequestTableAdapter.UpdateStatus("Approved", selectedRequestID); //update request status
                    stationeryrequestTableAdapter.UpdateStock(reducedAmount, selectedProductID); //update product amount
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest); //refresh table view
                }
                else
                {
                    // user clicked no
                    //nothing happens, return to "My Requests" page
                    LoadingCircle1.Visible = true;
                }
            }
            else if(stock == 0) //if stock equals 0
            {
                MessageBox.Show("There is no more stock for this product.");
            }
            else //if there is not enough stock
            {
                MessageBox.Show("There is not enough stock to approve this request.");
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)  //when the reject button is clicked
        {
            //display confirmation display box
            if (MessageBox.Show("Are you sure you want to reject this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value); //convert cells into values
                stationeryrequestTableAdapter.UpdateStatus("Denied", selectedRequestID); //update database row for the request
                ApproveRequestForm approve = new ApproveRequestForm(); //load form
                approve.Show();
                this.Close();
                LoadingCircle1.Visible = true; //display loading circle
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
                LoadingCircle1.Visible = true; //display loading circle
            }
        }
        
        private void btnNotifications_Click(object sender, EventArgs e)  //when the products button is clicked
        {
            ProductsForm products = new ProductsForm(); //load form
            products.Show();
            this.Close();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)  //when the requests button is clicked
        {
            RequestsForm form = new RequestsForm(); //load form
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //when the logout button is clicked
        {
            LoginForm loginPage = new LoginForm(); //load form
            loginPage.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)  //when the back button is clicked
        {
            Home homepage = new Home(); //load form
            homepage.Show();
            this.Close();
        }
    }
}
