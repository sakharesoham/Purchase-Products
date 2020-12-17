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
    public partial class frmPurchaseEntry : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=MobileShop");
        SqlDataReader dr;
        public frmPurchaseEntry()
        {
            InitializeComponent();
            con.Open();
            fetchSupplierName();
            fetchProductName();
            fetchCompany();
        }

        private void frmPurchaseEntry_Load(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInvoiceNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInvoiceNumber.Focus();
                }
                else
                {
                    txtQuantity.Focus();
                }
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Quantity", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantity.Focus();
                }
                else
                {
                    txtRate.Focus();
                }
            }
        }

        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRate.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRate.Focus();
                }
                else
                {
                    txtAmount.Focus();
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Amount", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }

        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTotalAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Total Amount", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotalAmount.Focus();
                }
                else
                {
                    txtGST.Focus();
                }
            }
        }

        private void txtGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGST.Text.Trim() == "")
                {
                    MessageBox.Show("Enter GST", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGST.Focus();
                }
                else
                {
                    txtNetAmount.Focus();
                }
            }
        }

        private void txtNetAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNetAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Net Amount", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNetAmount.Focus();
                }
                else
                {
                    txtPaidAmount.Focus();
                }
            }
        }

        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPaidAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Amount Paid", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaidAmount.Focus();
                }
                else
                {
                    txtRemainingAmount.Focus();
                }
            }
        }

        private void txtRemainingAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRemainingAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Remaining Amount", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemainingAmount.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        void fetchSupplierName()
        {
            SqlCommand cmd = new SqlCommand("Pro_SupplierName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSupplierName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string SupplyId;

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("select SupplierMobileNumber from Supplier where SupplierName='" + cmbSupplierName.Text + "'", con);
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                txtContactNumber.Text=dr1[0].ToString(); 
            }
            dr1.Close();

            SqlCommand cmd = new SqlCommand("Pro_FetchSupplierID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@SupplierName", SqlDbType.NVarChar);
            p1.Value = cmbCompanyName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                SupplyId = dr[0].ToString();

            }
            dr.Close();
            //clear();

        }

        void fetchProductName()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchProductName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProductName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string ProductId;

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("select ProductHSNCode from NewProduct where ProductName='" + cmbProductName.Text + "'", con);
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                txtHSNCode.Text = dr1[0].ToString(); 
            }
            dr1.Close();
            

            SqlCommand cmd = new SqlCommand("Pro_FetchCompanyID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            p1.Value = cmbCompanyName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                ProductId = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchCompany()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchCompany", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCompanyName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string CompanyId;

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select ModelName from Model where CompanyName='" + cmbCompanyName.Text + "'", con);
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                cmbModelName.Items.Add(dr1[0].ToString());
            }
            dr1.Close();


            SqlCommand cmd = new SqlCommand("Pro_FetchCompanyID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            p1.Value = cmbCompanyName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                CompanyId = dr[0].ToString();

            }
            dr.Close();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text.Trim() == "")
            {
            }
            else
            {
                txtAmount.Text = (float.Parse(txtQuantity.Text) * float.Parse(txtRate.Text)).ToString();
            }
        }
        
        
        private void txtGST_TextChanged(object sender, EventArgs e)
        {

            if (txtGST.Text.Trim() == "")
            {
            }
            else
            {
                txtNetAmount.Text = (float.Parse(txtTotalAmount.Text) + float.Parse(txtGST.Text)).ToString();

            }
                        
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text.Trim() == "")
            {
            }
            else
            {
                txtRemainingAmount.Text = (float.Parse(txtPaidAmount.Text) - float.Parse(txtNetAmount.Text)).ToString();
            }
        }


        int i;
        void filldata()
        {
            try
            {

                dgvReciept.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Reciept", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvReciept.Rows.Add();
                    dgvReciept.Rows[i].Cells[0].Value = dr[0];
                    dgvReciept.Rows[i].Cells[1].Value = dr[1];
                    dgvReciept.Rows[i].Cells[2].Value = dr[2];
                    dgvReciept.Rows[i].Cells[3].Value = dr[3];
                    dgvReciept.Rows[i].Cells[4].Value = dr[4];
                    dgvReciept.Rows[i].Cells[5].Value = dr[5];
                    dgvReciept.Rows[i].Cells[6].Value = dr[6];
                    dgvReciept.Rows[i].Cells[7].Value = dr[7];
                    dgvReciept.Rows[i].Cells[8].Value = dr[8];
                    dgvReciept.Rows[i].Cells[9].Value = dr[9];

                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int Gst = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Gst = (int.Parse(txtAmount.Text) * int.Parse(txtGSTRate.Text)) / 100; //GST calculation formula to be displayed in grid view 

            dgvReciept.Rows.Add();

            dgvReciept.Rows[i].Cells[0].Value = cmbProductName.Text;
            dgvReciept.Rows[i].Cells[1].Value = cmbCompanyName.Text;
            dgvReciept.Rows[i].Cells[2].Value = cmbModelName.Text;
            dgvReciept.Rows[i].Cells[3].Value = txtHSNCode.Text;
            dgvReciept.Rows[i].Cells[4].Value = txtQuantity.Text;
            dgvReciept.Rows[i].Cells[5].Value = txtRate.Text;
            dgvReciept.Rows[i].Cells[6].Value = txtGSTRate.Text;
            dgvReciept.Rows[i].Cells[7].Value = Gst;                             //assign variable to cell 
            dgvReciept.Rows[i].Cells[8].Value = txtAmount.Text;


            //cmbProductName.Text = "";
            //cmbCompanyName.Text = "";
            //cmbModelName.Text = "";
            //txtHSNCode.Text = "";
            //txtQuantity.Text = "";
            //txtRate.Text = "";
            //txtGSTRate.Text = "";
            //txtAmount.Text = "";
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Pro_RecieptInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@DateandTime", SqlDbType.NVarChar);
                p1.Value = dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar);
                p1.Value = txtInvoiceNumber.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierName", SqlDbType.NVarChar);
                p1.Value = cmbSupplierName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Product", SqlDbType.NVarChar);
                p1.Value = cmbProductName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Company", SqlDbType.NVarChar);
                p1.Value = cmbCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Model", SqlDbType.NVarChar);
                p1.Value = cmbModelName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@HSNCode", SqlDbType.NVarChar);
                p1.Value = txtHSNCode.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Quantity", SqlDbType.NVarChar);
                p1.Value = txtQuantity.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Rate", SqlDbType.NVarChar);
                p1.Value = txtRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTRate", SqlDbType.NVarChar);
                p1.Value = txtGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTAmount", SqlDbType.NVarChar);
                p1.Value = txtGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.NVarChar);
                p1.Value = txtAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PaidAmount", SqlDbType.NVarChar);
                p1.Value = txtPaidAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RemainingAmount", SqlDbType.NVarChar);
                p1.Value = txtRemainingAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RecieptTransactionId", SqlDbType.Int);
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
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReciept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


