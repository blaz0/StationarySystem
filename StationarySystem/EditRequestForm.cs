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
    public partial class EditRequestForm : Form
    {
        public EditRequestForm()
        {
            InitializeComponent();
        }

        private void EditRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            cancelLbl.Font = new Font(cancelLbl.Font, FontStyle.Underline);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            cancelLbl.Font = new Font(cancelLbl.Font, FontStyle.Regular);
        }
    }
}
