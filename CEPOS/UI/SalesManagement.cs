using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPOS.UI
{
    public partial class SalesManagement : Form
    {
        public SalesManagement()
        {
            InitializeComponent();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSalesProductScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string keyword = txtSalesProductScan.Text;
                if (keyword != "")
                {

                    SqlConnection con = new SqlConnection(myconnstring);
                    DataTable dt = new DataTable();
                    try
                    {
                        //MessageBox.Show(keyword);
                        string sql = "SELECT * FROM products WHERE barcode= '" + keyword + "' OR name= '" + keyword + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                        con.Open();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dgvSalesProduct.DataSource = dt;
                            txtSalesProductScan.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Search field is empty!");
                    txtSalesProductScan.Text = "";
                }
            }
        }
    }
}
