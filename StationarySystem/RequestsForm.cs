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

        
    }
}
