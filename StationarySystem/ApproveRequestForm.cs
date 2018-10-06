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
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ApproveRequestForm form = new ApproveRequestForm();
            form.Show();
            this.Close();
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to approve this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                
            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reject this stationery request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes

            }
            else
            {
                // user clicked no
                //nothing happens, return to "My Requests" page
            }
        }

        
    }
}
