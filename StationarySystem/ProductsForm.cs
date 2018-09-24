using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationarySystem
{
    public partial class ProductsForm : Form
    {
        public int userIDparam = 0;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            //SearchBox.Text = "";
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sepdbDataSet.product);
            // TODO: This line of code loads data into the 'sepdbDataSet.product' table. You can move, or remove it, as needed.
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;

            foreach (System.Windows.Forms.DataGridViewRow r in productDataGrid.Rows)
            {
                productDataGrid.Rows[r.Index].Selected = false;
                productDataGrid.Rows[r.Index].ReadOnly = true;
            }
            foreach (System.Windows.Forms.DataGridViewRow r in detailsDataGrid.Rows)
            {
                detailsDataGrid.Rows[r.Index].Selected = false;
                detailsDataGrid.Rows[r.Index].ReadOnly = true;
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
            //sepdbDataSet.usersDataTable dt = user.Login(staffID, staffPassword);
            //DataRow dr = dt.Rows[0];
            //int userID = int.Parse(dr["userid"].ToString());
            //MessageBox.Show("Login OK", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProfileFormX profile = new ProfileFormX();
            profile.userIDparam = userIDparam;
            profile.Show();
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
        {}

        private void productDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToDecimal(productDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) >= 0.00M)// && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                productDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = Color.Orange, BackColor = Color.Blue };
            }
            else
            {
                productDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = productDataGrid.DefaultCellStyle;
            }
        }

        private void productDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text;
            detailsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                //sepdb_SQLTableAdapters.productTableAdapter product = new sepdb_SQLTableAdapters.productTableAdapter();
                //sepdb_SQL.productDataTable dt = product.GetByProductName(searchValue);

                bool valueResult = false;
                foreach (DataGridViewRow row in detailsDataGrid.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            detailsDataGrid.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + SearchBox.Text, "Not found");
                    return;
                }

                foreach (System.Windows.Forms.DataGridViewRow r in detailsDataGrid.Rows)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(searchValue.ToUpper()))
                    {
                        detailsDataGrid.Rows[r.Index].Visible = true;
                        detailsDataGrid.Rows[r.Index].Selected = false;
                    }
                    else
                    {
                        detailsDataGrid.CurrentCell = null;
                        detailsDataGrid.Rows[r.Index].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                //exception handling displayed in message box
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text;
            productDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                //sepdb_SQLTableAdapters.productTableAdapter product = new sepdb_SQLTableAdapters.productTableAdapter();
                //sepdb_SQL.productDataTable dt = product.GetByProductName(searchValue);

                bool valueResult = false;
                foreach (DataGridViewRow row in productDataGrid.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            productDataGrid.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + SearchBox.Text, "Not found");
                    return;
                }

                foreach (System.Windows.Forms.DataGridViewRow r in productDataGrid.Rows)
                {
                    if ((r.Cells[0].Value).ToString().ToUpper().Contains(searchValue.ToUpper()))
                    {
                        productDataGrid.Rows[r.Index].Visible = true;
                        productDataGrid.Rows[r.Index].Selected = false;
                    }
                    else
                    {
                        productDataGrid.CurrentCell = null;
                        productDataGrid.Rows[r.Index].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                //exception handling displayed in message box
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.DataGridViewRow r in productDataGrid.Rows)
            {
                productDataGrid.Rows[r.Index].Visible = true;
            }
            foreach (System.Windows.Forms.DataGridViewRow r in detailsDataGrid.Rows)
            {
                detailsDataGrid.Rows[r.Index].Visible = true;
            }
            SearchBox.Text = "Search for products";
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home homepage = new Home();
            homepage.Show();
            this.Hide();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            ProfileFormX profile = new ProfileFormX();
            profile.userIDparam = userIDparam;
            profile.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStationeryRequestForm statRequest = new CreateStationeryRequestForm();
            statRequest.Show();
            this.Hide();
        }
    }
}
