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
        public CreateStationeryRequestForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Hide();
        }

        private void ProductsLbl_Click(object sender, EventArgs e)
        {}
    }
}