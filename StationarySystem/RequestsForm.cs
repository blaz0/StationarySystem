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
            // TODO: This line of code loads data into the 'sepdbDataSet.stationeryrequest' table. You can move, or remove it, as needed.
            this.stationeryrequestTableAdapter.Fill(this.sepdbDataSet.stationeryrequest);
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
    }
}
