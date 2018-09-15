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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sepdbDataSet.product);
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;

            try
            {
                sepdb_SQLTableAdapters.productTableAdapter product = new sepdb_SQLTableAdapters.productTableAdapter();
                sepdb_SQL.productDataTable dt = product.GetData();
                //DataColumn fullName = new DataColumn("fullname");
                //fullName.Expression = string.Format("{0}+' '+{1}", "firstName", "lastName");
                //dt.Columns.Add(fullName);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("data table found");
                    //DataRow dr = dt.Rows[0];
                    // Display values                    
                    //txtFName.Text = dr["fullname"].ToString();
                    //txtID.Text = dr["userid"].ToString();
                    //txtEmail.Text = dr["emailAddress"].ToString();
                    //txtCC.Text = dr["costCentre"].ToString();
                    //txtPhoneNo.Text = dr["phoneNumber"].ToString();
                    //txtNickname.Text = dr["nickname"].ToString();
                }
                else {
                    MessageBox.Show("Unable to retrive product details");
                    return;
                }
            }
            catch (Exception ex) {
                //exception handling displayed in message box
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileFormX profileForm = new ProfileFormX();
            profileForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void productDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in productDataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Equals("0"))
                        {
                            string cellString = Convert.ToString(cell.Value);
                            cell.Value = "Out Of Stock!";
                        }
                    }
                }
            }
        }
    }
}
