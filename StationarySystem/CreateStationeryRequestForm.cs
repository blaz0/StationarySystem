﻿using System;
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
    public partial class CreateStationeryRequestForm : Form
    {
        public CreateStationeryRequestForm() => InitializeComponent();

        private void CreateStationeryRequestForm_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            User loggedInUser = Program.getCurrentUser();
            userIDTxt.Text = "User ID: " + loggedInUser.userId.ToString();
            Product selectedProduct = Program.getCurrentProduct();

            sepdbDataSet.productDataTable dt = productTableAdapter.GetDataByProductID(selectedProduct.productid);
            DataRow dr = dt.Rows[0];
            selectedProduct.productid = int.Parse(dr["productID"].ToString());
            selectedProduct.supplierid = int.Parse(dr["supplierID"].ToString());
            selectedProduct.name = dr["name"].ToString();
            selectedProduct.description = dr["description"].ToString();
            selectedProduct.stock = int.Parse(dr["stock"].ToString());
            selectedProduct.price = int.Parse(dr["price"].ToString());
            selectedProduct.stockLevel = dr["stockLevel"].ToString();
            
            productNameTxt.Text = selectedProduct.name;
            priceTxt.Text = "$" + selectedProduct.price.ToString() + ".00";
            int qtyCount = Convert.ToInt32(qty.Value);
            totalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00";
            descriptionTxt.Text = selectedProduct.description;
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
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
            int qtyCount = Convert.ToInt32(qty.Value);
            Product selectedProduct = Program.getCurrentProduct();
            totalPriceTxt.Text = "$" + (qtyCount * selectedProduct.price) + ".00";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Product selectedProduct = Program.getCurrentProduct();
            int userid = Convert.ToInt32(userIDTxt.Text);
            int productid = selectedProduct.productid;
            sepdbDataSetTableAdapters.stationeryrequestTableAdapter statReq = new sepdbDataSetTableAdapters.stationeryrequestTableAdapter();
            //statReq.SubmittedStatReq(6, userid, productid, "03/10/2018", "Submitted");

            DataRow workRow = sepdbDataSet.requestedstationery.NewRow();
            workRow[""]


            MessageBox.Show("Product Request Submitted.");
            Home homepage = new Home();
            homepage.Show();
            this.Close();
        }
    }
}
