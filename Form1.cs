using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class frmFirstForm : Form
    {
        public frmFirstForm()
        {
            InitializeComponent();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void frmFirstForm_Load(object sender, EventArgs e)
        {

        }
    }
}
