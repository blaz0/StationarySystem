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

        private void ProductsLbl_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            cancel.Font = new Font(cancel.Font, FontStyle.Underline);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            cancel.Font = new Font(cancel.Font, FontStyle.Regular);
        }
    }
}
