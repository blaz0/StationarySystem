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

        private void ApproveRequestForm_Load(object sender, EventArgs e)
        {
            loadingCircle1.Visible = false;
            string selectedStatus = "Submitted";
            stationeryrequestBindingSource.Filter = "status LIKE '*" + selectedStatus + "*'";
            if (this.stationeryrequestTableAdapter == null)
            {
                Label l1 = new Label();
                l1.Text = "There are no new stationery requests";
                this.Controls.Add(l1);
            }
            // TODO: This line of code loads data into the 'sepdbDataSet.stationeryrequest' table. You can move, or remove it, as needed.
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }
                
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Close();
            loadingCircle1.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
            loadingCircle1.Visible = true;
        }

        public static int subtractQuantity(int originalQty, int amount)
        {
            return originalQty - amount;
        }

        public static int addQuantity(int originalQty, int amount)
        {
            return originalQty + amount;
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
            int selectedProductID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[2].Value);
            int selectedAmount = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[4].Value);
            int stock = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[8].Value);
            int reducedAmount = subtractQuantity(stock, selectedAmount);

            if(stock == 0)
            {
                MessageBox.Show("There is no more stock for this product.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to approve this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    //Product selectedProduct = Program.getCurrentProduct();

                    stationeryrequestTableAdapter.UpdateStatus("Approved", selectedRequestID);
                    stationeryrequestTableAdapter.UpdateStock(reducedAmount, selectedProductID);
                    this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
                    
                }
                else
                {
                    // user clicked no
                    //nothing happens, return to "My Requests" page
                    loadingCircle1.Visible = true;
                }
            }
            
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reject this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                stationeryrequestTableAdapter.UpdateStatus("Denied", selectedRequestID);
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
                loadingCircle1.Visible = true;
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
                loadingCircle1.Visible = true;
            }
        }

        private void requestDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

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
