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
    public partial class frmNewProductInfo : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=MobileShop");
        SqlDataReader dr;

        void clear()
        {
            txtProductName.Text = "";
            txtProductMRP.Text = "";
            txtProductSAC.Text = "";
            txtProductDescription.Text = "";
            txtProductHSNCode.Text = "";
        }

        public frmNewProductInfo()
        {
            InitializeComponent();
            con.Open();
            fetchCompany();
            filldata();
        }

        private void frmNewProductInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Product name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Focus();
                }
                else
                {
                    txtProductName.Focus();
                }
            }
        }

        private void txtProductMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductMRP.Text.Trim() == "")
                {
                    MessageBox.Show("Enter MRP", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductMRP.Focus();
                }
                else
                {
                    txtProductSAC.Focus();
                }
            }
        }

        private void txtProductSAC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductSAC.Text.Trim() == "")
                {
                    MessageBox.Show("Enter SAC", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductSAC.Focus();
                }
                else
                {
                    txtProductDescription.Focus();
                }
            }
        }

        private void txtProductDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Description", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductDescription.Focus();
                }
                else
                {
                    txtProductHSNCode.Focus();
                }
            }
        }

        private void txtProductHSNCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductHSNCode.Text.Trim() == "")
                {
                    MessageBox.Show("Enter HSN", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductHSNCode.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
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
                clear();

            }
        }


        int i;
        void filldata()
        {
            try
            {
                dgvNewProduct.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from NewProduct", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvNewProduct.Rows.Add();
                    dgvNewProduct.Rows[i].Cells[0].Value = dr[0];
                    dgvNewProduct.Rows[i].Cells[1].Value = dr[1];
                    dgvNewProduct.Rows[i].Cells[2].Value = dr[2];
                    dgvNewProduct.Rows[i].Cells[3].Value = dr[3];
                    dgvNewProduct.Rows[i].Cells[4].Value = dr[4];
                    dgvNewProduct.Rows[i].Cells[5].Value = dr[5];
                    dgvNewProduct.Rows[i].Cells[6].Value = dr[6];
                    dgvNewProduct.Rows[i].Cells[7].Value = dr[7];

                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Pro_NewProductInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                p1.Value = txtProductName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
                p1.Value = cmbCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductMRP", SqlDbType.NVarChar);
                p1.Value = txtProductMRP.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductSAC", SqlDbType.NVarChar);
                p1.Value = txtProductSAC.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ModelName", SqlDbType.NVarChar);
                p1.Value = cmbModelName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductDescription", SqlDbType.NVarChar);
                p1.Value = txtProductDescription.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductHSNCode", SqlDbType.NVarChar);
                p1.Value = txtProductHSNCode.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductTransactionId", SqlDbType.Int);
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
                    filldata();
                    clear();

                    //frmSupplierRegistration obj = new frmSupplierRegistration();
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