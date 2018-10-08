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
    public partial class UpdateRequest : Form
    {
        public UpdateRequest()
        {
            InitializeComponent();
        }

        private void UpdateRequest_Load(object sender, EventArgs e)
        {
            Product selectedProduct = Program.getCurrentProduct();
            productID.Text = selectedProduct.name;


        }
    }
}
