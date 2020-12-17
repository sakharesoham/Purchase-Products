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
    public partial class frmCompanyRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=MobileShop");
        SqlDataReader dr;

        public frmCompanyRegistration()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCompanyName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Company Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCompanyName.Focus();
                }
                else
                {
                    btnAdd.Focus();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {

                SqlCommand cmd = new SqlCommand("Pro_CompanyInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
                p1.Value = txtCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CompanyTransactionId", SqlDbType.Int);
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
                   //frmModelRegistration obj = new frmModelRegistration();
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
                dgvCompany.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Company", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvCompany.Rows.Add();
                    dgvCompany.Rows[i].Cells[0].Value = dr[0];
                    dgvCompany.Rows[i].Cells[1].Value = dr[1];
                    

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
