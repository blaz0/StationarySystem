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
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.Show();
            this.Close();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to approve this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                Product selectedProduct = Program.getCurrentProduct();
                int selectedRequestID = Convert.ToInt32(requestDataGrid.CurrentRow.Cells[0].Value);
                stationeryrequestTableAdapter.UpdateStatus("Approved", selectedRequestID);
                ApproveRequestForm approve = new ApproveRequestForm();
                approve.Show();
                this.Close();
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
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
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
            }
        }

        private void requestDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
