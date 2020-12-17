using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Entry_of_Products
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void companyRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyRegistration obj = new frmCompanyRegistration();
            obj.Show();
        }

        private void modelRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelRegistration obj = new frmModelRegistration();
            obj.Show();
        }

        private void supplierRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierRegistration obj = new frmSupplierRegistration();
            obj.Show();
        }

        private void newProductInforamationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewProductInfo obj = new frmNewProductInfo();
            obj.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseEntry obj = new frmPurchaseEntry();
            obj.Show();
        }
    }
}
