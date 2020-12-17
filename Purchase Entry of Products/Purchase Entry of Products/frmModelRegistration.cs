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


namespace Purchase_Entry_of_Products
{
    public partial class frmModelRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=MobileShop");
        SqlDataReader dr;

        void clear()
        {
            txtModelName.Text = "";
            txtDescription.Text = "";
        }
        public frmModelRegistration()
        {
            InitializeComponent();
            con.Open();
            fetchCompany();
        }

        void fetchCompany()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchCompany", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
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
            SqlCommand cmd = new SqlCommand("Pro_FetchCompanyID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@CompanyName", SqlDbType.VarChar);
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

        private void txtModelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtModelName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Company Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtModelName.Focus();
                }
                else
                {
                    txtDescription.Focus();
                }
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Company Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescription.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Pro_ModelInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
                p1.Value = cmbCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ModelName", SqlDbType.NVarChar);
                p1.Value = txtModelName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ModelDescription", SqlDbType.NVarChar);
                p1.Value = txtDescription.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ModelTransactionId", SqlDbType.Int);
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

                    //frmNewProductInfo obj = new frmNewProductInfo();
                    //obj.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int i;
        void filldata()
        {
            try
            {
                dgvModel.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Model", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvModel.Rows.Add();
                    dgvModel.Rows[i].Cells[0].Value = dr[0];
                    dgvModel.Rows[i].Cells[1].Value = dr[1];
                    dgvModel.Rows[i].Cells[2].Value = dr[2];
                    dgvModel.Rows[i].Cells[3].Value = dr[3];
                    
                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
