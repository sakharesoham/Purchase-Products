using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Purchase_Entry_of_Products
{
    public partial class frmSupplierRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=MobileShop");

        void clear()
        {
            txtSupplierName.Text = "";
            txtMobileNumber.Text = "";
            txtAddress.Text = "";
            txtGSTin.Text = "";
            txtBankAccountNumber.Text = "";
            txtBankBranch.Text = "";
            txtIFSC.Text = "";
            txtBankCity.Text = "";
                
        }

        public frmSupplierRegistration()
        {
            InitializeComponent();
            con.Open();
            
        }

        private void frmSupplierRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupplierName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierName.Focus();
                }
                else
                {
                    txtMobileNumber.Focus();
                }
            }
        }

        private void txtMobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMobileNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMobileNumber.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
                else
                {
                    txtGSTin.Focus();
                }
            }
        }

        private void txtGSTin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGSTin.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGSTin.Focus();
                }
                else
                {
                    txtBankAccountNumber.Focus();
                }
            }
        }

        private void txtBankAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankAccountNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankAccountNumber.Focus();
                }
                else
                {
                    txtBankBranch.Focus();
                }
            }
        }

        private void txtBankBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankBranch.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankBranch.Focus();
                }
                else
                {
                    txtIFSC.Focus();
                }
            }
        }

        private void txtIFSC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIFSC.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIFSC.Focus();
                }
                else
                {
                    txtBankCity.Focus();
                }
            }
        }

        private void txtBankCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankCity.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankCity.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }
        string payment;
        private void btnSave_Click(object sender, EventArgs e)
        {
           try
            {
                if (rbtnCash.Checked)
                    payment = "Cash";
                else if (rbtnCheque.Checked)
                    payment = "Cheque";

                SqlCommand cmd = new SqlCommand("Pro_SupplierInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@SupplierName", SqlDbType.NVarChar);
                p1.Value = txtSupplierName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierMobileNumber", SqlDbType.BigInt);
                p1.Value = txtMobileNumber.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierAddress", SqlDbType.NVarChar);
                p1.Value = txtAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierGSTin", SqlDbType.NVarChar);
                p1.Value = txtGSTin.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierBankAccountNumber", SqlDbType.NVarChar);
                p1.Value = txtBankAccountNumber.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierBankBranch", SqlDbType.NVarChar);
                p1.Value = txtBankBranch.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierIFSC", SqlDbType.NVarChar);
                p1.Value = txtIFSC.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierBankCity", SqlDbType.NVarChar);
                p1.Value = txtBankCity.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierPaymentMethod", SqlDbType.NVarChar);
                p1.Value = payment;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierTransactionId", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);


                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    clear();

                    //frmPurchaseEntry obj = new frmPurchaseEntry();
                    //obj.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
