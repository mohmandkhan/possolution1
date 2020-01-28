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
    public partial class PurchaseManagement : Form
    {
        public PurchaseManagement()
        {
            InitializeComponent();
            getAllInvoices();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        #region Create Purchase Invoice
        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            string supplierid = txtSupplierID.Text;
            if (supplierid != "")
            {
                string invoicenumber = "37" + DateTime.Now.ToLocalTime(); // 37 is the ID of the User Logged in which is hardcoded
                string invoicedate = DateTime.Now.ToString();
                string invoiceuser = "37";        // 37 is the ID of the User Logged in which is hardcoded
                string invoicesupplier = txtSupplierID.Text;
                //string invoicesupplier = 
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO purchaseinvoices(invoicenumber,invoicedate,invoiceuser,invoicesupplier) VALUES(@invoicenumber,@invoicedate,@invoiceuser,@invoicesupplier)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                    cmd.Parameters.AddWithValue("@invoicedate", invoicedate);
                    cmd.Parameters.AddWithValue("@invoiceuser", invoiceuser);
                    cmd.Parameters.AddWithValue("@invoicesupplier", invoicesupplier);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        //MessageBox.Show("Purchase Invoice Created! Add Products Now.");
                        /***************INVOICE MAIN BUTTONS CONFIGURATIONS********************/
                        txtInvoiceNumber.Text = invoicenumber;
                        this.btnCreateInvoice.Enabled = false;
                        this.btnDeleteInvoice.Enabled = true;
                        this.btnSuspendInvoice.Enabled = true;
                        this.btnSaveInvoice.Enabled = true;
                        txtSearchBarcode.Focus();
                        /****************INVOICE MAIN BUTTONS CONFIGURATIONS******************/

                        /********************PRODUCT FORM CONFIGURATION**********************/
                        this.txtProductName.Enabled = true;
                        this.txtCostPrice.Enabled = true;
                        this.txtSalePrice.Enabled = true;
                        this.txtQuantity.Enabled = true;
                        this.txtTotalAmount.Enabled = true;
                        this.dtpExpiry.Enabled = true;
                        this.btnAddToInvoice.Enabled = true;
                        //this.btnDeleteFromInvoice.Enabled = true;
                        //this.btnUpdateInvoice.Enabled = true;
                        /********************PRODUCT FORM CONFIGURATION**********************/

                    }
                    else
                    {
                        /*Please add up the body OR remove the else block from here.*/
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
                MessageBox.Show("Supplier must be selected first", "Select Supplier", MessageBoxButtons.OK);
            }
            
        }
        #endregion
        #region Add Product to P Invoice
        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            string invoicenumber = txtInvoiceNumber.Text;
            string productid = txtProductID.Text;
            string costprice = txtCostPrice.Text;
            string saleprice = txtSalePrice.Text;
            string quantity = txtQuantity.Text;
            string totalamount = txtTotalAmount.Text;
            string expiry = dtpExpiry.Text;

            if (invoicenumber != "" && productid != "" && costprice != "" && saleprice != "" && quantity != "" && totalamount != "" && expiry !="")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO pinvoiceproducts(invoicenumber,productid,costprice,saleprice,quantity,totalamount,expiry) VALUES(@invoicenumber,@productid,@costprice,@saleprice,@quantity,@totalamount,@expiry)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                    cmd.Parameters.AddWithValue("@productid", productid);
                    cmd.Parameters.AddWithValue("@costprice", costprice);
                    cmd.Parameters.AddWithValue("@saleprice", saleprice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@totalamount", totalamount);
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        //MessageBox.Show("Product Added to Bill");
                        getAllPinvoiceProducts(invoicenumber);
                        calculation();
                        txtProductName.Text = "";
                        txtCostPrice.Text = "";
                        txtSalePrice.Text = "";
                        txtQuantity.Text = "";
                        txtTotalAmount.Text = "";
                        txtSearchBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error");
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
                MessageBox.Show("One or more fields empty","Error",MessageBoxButtons.OK);
            }

        }
        #endregion
        #region Get All P Invoice Products
        private void getAllPinvoiceProducts(string invoicenumber)
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT products.id AS ID, products.barcode AS Barcode, products.name AS ProductName, pinvoiceproducts.costprice AS CostPrice, pinvoiceproducts.saleprice AS SalePrice, pinvoiceproducts.quantity AS Quantity, pinvoiceproducts.totalamount AS TotalAmount, pinvoiceproducts.expiry AS Expiry from products, pinvoiceproducts WHERE pinvoiceproducts.productid = products.id AND pinvoiceproducts.invoicenumber = @invoicenumber";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    dgvPinvoiceProducts.DataSource = dt;
                    getSupplierInformation(invoicenumber);
                    txtSearchInvoiceNumber.Text = "";
                    this.txtSearchSupplier.Enabled = false;
                    txtInvoiceNumber.Text = invoicenumber;
                    this.btnCreateInvoice.Enabled = false;
                    this.btnSaveInvoice.Enabled = true;
                    this.btnSuspendInvoice.Enabled = true;
                    this.btnDeleteInvoice.Enabled = true;
                    this.txtProductName.Enabled = true;
                    this.txtCostPrice.Enabled = true;
                    this.txtSalePrice.Enabled = true;
                    this.txtQuantity.Enabled = true;
                    this.txtTotalAmount.Enabled = true;
                    this.dtpExpiry.Enabled = true;
                    this.btnAddToInvoice.Enabled = true;
                    int sum = 0;
                    for (int i=0; i < dgvPinvoiceProducts.Rows.Count; i++)
                    {
                        sum += Convert.ToInt32(dgvPinvoiceProducts.Rows[i].Cells[6].Value);
                    }
                    txtInvoiceAmount.Text = sum.ToString();
                }
                else
                {
                    txtSearchInvoiceNumber.Text = "";
                    dgvPinvoiceProducts.DataSource = dt;
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
        #endregion

        #region Get Supplier Information
        private void getSupplierInformation(string invoicenumber)
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                string sql = "SELECT * FROM purchaseinvoices WHERE invoicenumber=@invoicenumber";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    //MessageBox.Show(invoicenumber + " OUTER LOOP");
                    string supplierid = dt1.Rows[0]["invoicesupplier"].ToString();
                    string sqlSupplierInformation = "SELECT * FROM suppliers WHERE supplierid=@supplierid";
                    SqlCommand cmdSupplierInformation = new SqlCommand(sqlSupplierInformation, con);
                    cmdSupplierInformation.Parameters.AddWithValue("@supplierid", supplierid);
                    SqlDataAdapter adapterSupplierInformation = new SqlDataAdapter(cmdSupplierInformation);
                    //con.Open();
                    adapterSupplierInformation.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        // MessageBox.Show(invoicenumber + " INSIDE LOOP");
                        txtSupplierName.Text = dt2.Rows[0]["suppliername"].ToString();
                        txtCompany.Text = dt2.Rows[0]["company"].ToString();
                        txtPhone.Text = dt2.Rows[0]["phone"].ToString();
                        txtEmail.Text = dt2.Rows[0]["email"].ToString();
                        txtAddress.Text = dt2.Rows[0]["address"].ToString();
                        txtSupplierID.Text = dt2.Rows[0]["supplierid"].ToString();
                    }
                    else
                    {
                        /*Please add the body here OR Remove the else block from here.*/
                    }
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
        #endregion
        #region Search Barcode
        private void txtSearchBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            string searchbarcode = txtSearchBarcode.Text;
            if (e.KeyCode == Keys.Return)
            {             
                if (searchbarcode != "")
                {
                    SqlConnection con = new SqlConnection(myconnstring);
                    DataTable dt = new DataTable();
                    try
                    {
                        string sql = "SELECT * FROM products where barcode=@keyword OR name=@keyword";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@keyword",searchbarcode);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        con.Open();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            txtQuantity.Focus();
                            txtSearchBarcode.Text = "";                           
                            txtProductID.Text = dt.Rows[0]["id"].ToString();
                            txtProductName.Text = dt.Rows[0]["name"].ToString();
                            txtCostPrice.Text = dt.Rows[0]["costprice"].ToString();
                            txtSalePrice.Text = dt.Rows[0]["saleprice"].ToString();
                            txtQuantity.Text = dt.Rows[0]["quantity"].ToString();                                                    

                        }
                        else
                        {
                            //MessageBox.Show("No Record Found","Information",MessageBoxButtons.OK);
                            txtSearchBarcode.Text = "";
                            txtQuantity.Focus();
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
                    MessageBox.Show("Barcode cannot be empty","Error",MessageBoxButtons.OK);

                }
            }
        }
        #endregion
        #region Multiplication of Cost and Quantity
        private void txtQuantity_Leave(object sender, EventArgs e)
        {

            Int32 costprice = Convert.ToInt32(txtCostPrice.Text);
            Int32 quantity = Convert.ToInt32(txtQuantity.Text);
            Int32 totalamount = costprice * quantity;
            txtTotalAmount.Text = Convert.ToString(totalamount);
        }
        #endregion
        #region Row Header Mouse Click Get All P Invoice Products
        private void dgvPinvoiceProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtProductID.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtProductName.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtCostPrice.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtSalePrice.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[4].Value.ToString();
            txtQuantity.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[5].Value.ToString();
            txtTotalAmount.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[6].Value.ToString();
            dtpExpiry.Text = dgvPinvoiceProducts.Rows[rowIndex].Cells[7].Value.ToString();

            this.btnAddToInvoice.Enabled = false;
            this.btnDeleteFromInvoice.Enabled = true;
            this.btnUpdateInvoice.Enabled = true;
            this.btnResetInvoice.Enabled = true;

        }
        #endregion
        #region Reset P Invoice Product Form
        private void btnResetInvoice_Click(object sender, EventArgs e)
        {
            resetPinvoiceProductForm();
        }
        #endregion
        #region Reset P invoice Product Form
        private void resetPinvoiceProductForm()
        {
            this.btnAddToInvoice.Enabled = true;
            this.btnDeleteFromInvoice.Enabled = false;
            this.btnUpdateInvoice.Enabled = false;
            this.btnResetInvoice.Enabled = false;
            txtSearchBarcode.Text = "";
            txtSearchBarcode.Focus();
            txtProductName.Text = "";
            txtProductID.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtQuantity.Text = "";
            txtTotalAmount.Text = "";
        }
        #endregion
        #region Delete Product From Pinvoice
        private void btnDeleteFromInvoice_Click(object sender, EventArgs e)
        {
            string productid = txtProductID.Text;
            string invoicenumber = txtInvoiceNumber.Text;
            if (productid != "" && invoicenumber != "")
            {
                DialogResult confirm = MessageBox.Show("Are you sure?","Delete Confirmation",MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(myconnstring);
                    try
                    {
                        string sql = "DELETE FROM pinvoiceproducts WHERE invoicenumber=@invoicenumber AND productid=@productid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                        cmd.Parameters.AddWithValue("@productid", productid);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            resetPinvoiceProductForm();
                            getAllPinvoiceProducts(invoicenumber);
                            calculation();
                            txtSearchBarcode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error");
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
            }
            else
            {
                MessageBox.Show("Invoice number and product id cannot be empty","Error",MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Update P Invoice Product
        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            string invoicenumber = txtInvoiceNumber.Text;
            string productid = txtProductID.Text;
            string costprice = txtCostPrice.Text;
            string saleprice = txtSalePrice.Text;
            string quantity = txtQuantity.Text;
            string totalamount = txtTotalAmount.Text;
            string expiry = dtpExpiry.Text;

            if (invoicenumber != "" && productid != "" && costprice != "" && saleprice != "" && quantity != "" && totalamount != "" && expiry != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "UPDATE pinvoiceproducts SET costprice = @costprice , saleprice=@saleprice , quantity = @quantity , totalamount = @totalamount , expiry = @expiry  WHERE invoicenumber = @invoicenumber AND productid = @productid";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                    cmd.Parameters.AddWithValue("@productid", productid);
                    cmd.Parameters.AddWithValue("@costprice", costprice);
                    cmd.Parameters.AddWithValue("@saleprice", saleprice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@totalamount", totalamount);
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        //MessageBox.Show("Product Added to Bill");
                        getAllPinvoiceProducts(invoicenumber);
                        calculation();
                        txtProductName.Text = "";
                        txtCostPrice.Text = "";
                        txtSalePrice.Text = "";
                        txtQuantity.Text = "";
                        txtTotalAmount.Text = "";
                        txtSearchBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error");
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
                MessageBox.Show("One or more fields empty", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Search Invoice
        private void txtSearchInvoiceNumber_KeyDown(object sender, KeyEventArgs e)
        {
            string invoicenumber = txtSearchInvoiceNumber.Text;

            if (e.KeyCode == Keys.Return)
            {
                if (invoicenumber != "")
                {
                    getAllPinvoiceProducts(invoicenumber);
                }
            }
        }
        #endregion
        #region Delete P Invoice Method
        private void deleteInvoice(string invoicenumber)
        {
            SqlConnection con = new SqlConnection(myconnstring);
            try
            {
                string sqlforDeleteInvoice = "DELETE FROM purchaseinvoices WHERE invoicenumber=@invoicenumber";
                string sqlforDeleteInvoiceProducts = "DELETE FROM pinvoiceproducts WHERE invoicenumber=@invoicenumber";
                SqlCommand cmd = new SqlCommand(sqlforDeleteInvoice, con);
                SqlCommand cmd2 = new SqlCommand(sqlforDeleteInvoiceProducts, con);
                cmd.Parameters.AddWithValue("@invoicenumber",invoicenumber);
                cmd2.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                con.Open();

                int rows1 = cmd.ExecuteNonQuery();
                int rows2 = cmd2.ExecuteNonQuery();
                if (rows1 > 0 && rows2 > 0)
                {
                    getAllPinvoiceProducts(invoicenumber);
                    //MessageBox.Show("Invoice Deleted");
                    //MessageBox.Show("Purchase Invoice Created! Add Products Now.");
                    /***************INVOICE MAIN BUTTONS CONFIGURATIONS********************/
                    txtInvoiceNumber.Text = "";
                    this.btnCreateInvoice.Enabled = true;
                    this.btnDeleteInvoice.Enabled = false;
                    this.btnSuspendInvoice.Enabled = false;
                    this.btnSaveInvoice.Enabled = false;
                    txtSearchBarcode.Focus();
                    /****************INVOICE MAIN BUTTONS CONFIGURATIONS******************/

                    /********************PRODUCT FORM CONFIGURATION**********************/
                    this.txtProductName.Enabled = false;
                    this.txtCostPrice.Enabled = false;
                    this.txtSalePrice.Enabled = false;
                    this.txtQuantity.Enabled = false;
                    this.txtTotalAmount.Enabled = false;
                    this.dtpExpiry.Enabled = false;
                    this.btnAddToInvoice.Enabled = false;
                    //this.btnDeleteFromInvoice.Enabled = true;
                    //this.btnUpdateInvoice.Enabled = true;
                    /********************PRODUCT FORM CONFIGURATION**********************/

                    /********************SUPPLIER FORM CONFIGURATION**********************/
                    txtSupplierName.Text = "";
                    txtCompany.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                    txtSupplierID.Text = "";
                    /********************SUPPLIER FORM CONFIGURATION**********************/
                }
                else
                {
                    MessageBox.Show("Error");
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
        #endregion
        #region Delete P Invoice Click
        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string invoicenumber = txtInvoiceNumber.Text;
            DialogResult confirm = MessageBox.Show("Are you sure?","Delete Confirmation",MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (invoicenumber != "")
                {
                    deleteInvoice(invoicenumber);
                }
                else
                {
                    MessageBox.Show("Invoice Number Cannot be empty","Error",MessageBoxButtons.OK);
                }
            }
            
        }
        #endregion

        #region Save Invoice
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
                string invoicenumber = txtInvoiceNumber.Text;
                string action = "save";
                string invoiceAmount = txtInvoiceAmount.Text;
                string discount = txtDiscount.Text;
                string tax = txtTax.Text;
                string netAmount = txtNetAmount.Text;
                saveSuspendInvoice(invoicenumber, action, invoicenumber, discount, tax, netAmount);
      
            
        }
        #endregion

        private void btnSuspendInvoice_Click(object sender, EventArgs e)
        {
            string invoicenumber = txtInvoiceNumber.Text;
            string action = "suspend";
            string invoiceAmount = txtInvoiceAmount.Text;
            string discount = txtDiscount.Text;
            string tax = txtTax.Text;
            string netAmount = txtNetAmount.Text;
            saveSuspendInvoice(invoicenumber, action, invoicenumber, discount, tax, netAmount);
        }

        #region Save / Suspend Invoice
        private void saveSuspendInvoice(string invoicenumber, string action, string invoiceAmount, string discount, string tax, string netAmount)
        {
            SqlConnection con = new SqlConnection(myconnstring);
            if (invoicenumber != "" && action == "save")
            {
                try
                {
                    string sql = "UPDATE purchaseinvoices SET saved=1, suspended=0, invoiceamount=@invoiceAmount, discount=@discount, tax=@tax, netamount=@netAmount WHERE invoicenumber=@invoicenumber";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                    cmd.Parameters.AddWithValue("@invoiceAmount", invoiceAmount);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@tax", tax);
                    cmd.Parameters.AddWithValue("@netAmount", netAmount);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        getAllPinvoiceProducts("");
                        getAllInvoices();
                        //MessageBox.Show("Invoice Deleted");
                        //MessageBox.Show("Purchase Invoice Created! Add Products Now.");
                        /***************INVOICE MAIN BUTTONS CONFIGURATIONS********************/
                        txtInvoiceNumber.Text = "";
                        this.btnCreateInvoice.Enabled = true;
                        this.btnDeleteInvoice.Enabled = false;
                        this.btnSuspendInvoice.Enabled = false;
                        this.btnSaveInvoice.Enabled = false;
                        txtSearchBarcode.Focus();
                        /****************INVOICE MAIN BUTTONS CONFIGURATIONS******************/

                        /********************PRODUCT FORM CONFIGURATION**********************/
                        this.txtProductName.Enabled = false;
                        this.txtCostPrice.Enabled = false;
                        this.txtSalePrice.Enabled = false;
                        this.txtQuantity.Enabled = false;
                        this.txtTotalAmount.Enabled = false;
                        this.dtpExpiry.Enabled = false;
                        this.btnAddToInvoice.Enabled = false;
                        //this.btnDeleteFromInvoice.Enabled = true;
                        //this.btnUpdateInvoice.Enabled = true;
                        /********************PRODUCT FORM CONFIGURATION**********************/

                        /********************SUPPLIER FORM CONFIGURATION**********************/
                        txtSupplierName.Text = "";
                        txtCompany.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtAddress.Text = "";
                        txtSupplierID.Text = "";
                        /********************SUPPLIER FORM CONFIGURATION**********************/

                        /********************CALCULATION FORM CONFIGURATION**********************/
                        txtInvoiceAmount.Text = "0";
                        txtDiscount.Text = "0";
                        txtTax.Text = "0";
                        txtNetAmount.Text = "0";
                        /********************CALCULATION FORM CONFIGURATION**********************/
                    }
                    else
                    {
                        MessageBox.Show("Error");

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
            else if (invoicenumber != "" && action == "suspend")
            {
                try
                {
                    string sql = "UPDATE purchaseinvoices SET saved=0, suspended=1, invoiceamount=@invoiceAmount, discount=@discount, tax=@tax, netamount=@netAmount WHERE invoicenumber=@invoicenumber";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@invoicenumber", invoicenumber);
                    cmd.Parameters.AddWithValue("@invoiceAmount", invoiceAmount);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@tax", tax);
                    cmd.Parameters.AddWithValue("@netAmount", netAmount);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        getAllPinvoiceProducts("");
                        getAllInvoices();
                        //MessageBox.Show("Invoice Deleted");
                        //MessageBox.Show("Purchase Invoice Created! Add Products Now.");
                        /***************INVOICE MAIN BUTTONS CONFIGURATIONS********************/
                        txtInvoiceNumber.Text = "";
                        this.btnCreateInvoice.Enabled = true;
                        this.btnDeleteInvoice.Enabled = false;
                        this.btnSuspendInvoice.Enabled = false;
                        this.btnSaveInvoice.Enabled = false;
                        txtSearchBarcode.Focus();
                        /****************INVOICE MAIN BUTTONS CONFIGURATIONS******************/

                        /********************PRODUCT FORM CONFIGURATION**********************/
                        this.txtProductName.Enabled = false;
                        this.txtCostPrice.Enabled = false;
                        this.txtSalePrice.Enabled = false;
                        this.txtQuantity.Enabled = false;
                        this.txtTotalAmount.Enabled = false;
                        this.dtpExpiry.Enabled = false;
                        this.btnAddToInvoice.Enabled = false;
                        //this.btnDeleteFromInvoice.Enabled = true;
                        //this.btnUpdateInvoice.Enabled = true;
                        /********************PRODUCT FORM CONFIGURATION**********************/

                        /********************SUPPLIER FORM CONFIGURATION**********************/
                        txtSupplierName.Text = "";
                        txtCompany.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtAddress.Text = "";
                        txtSupplierID.Text = "";
                        /********************SUPPLIER FORM CONFIGURATION**********************/

                        /********************CALCULATION FORM CONFIGURATION**********************/
                        txtInvoiceAmount.Text = "0";
                        txtDiscount.Text = "0";
                        txtTax.Text = "0";
                        txtNetAmount.Text = "0";
                        /********************CALCULATION FORM CONFIGURATION**********************/
                    }
                    else
                    {
                        MessageBox.Show("Error");

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
                MessageBox.Show("Something went wrong");
            }
        }
        #endregion

        private void txtSearchSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                string keyword = txtSearchSupplier.Text;
                if (keyword != "")
                {
                    SqlConnection con = new SqlConnection(myconnstring);
                    DataTable dt = new DataTable();
                    try
                    {
                        string sql = "SELECT * FROM suppliers where suppliername = @keyword OR phone=@keyword";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@keyword", keyword);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        con.Open();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            txtSupplierName.Text = dt.Rows[0]["suppliername"].ToString();
                            txtCompany.Text = dt.Rows[0]["company"].ToString();
                            txtPhone.Text = dt.Rows[0]["phone"].ToString();
                            txtEmail.Text = dt.Rows[0]["email"].ToString();
                            txtAddress.Text = dt.Rows[0]["address"].ToString();
                            txtSupplierID.Text = dt.Rows[0]["supplierid"].ToString();
                            txtSearchSupplier.Text = "";
                            txtSearchSupplier.Focus();

                        }
                        else
                        {

                            txtSearchSupplier.Text = "Sorry! No record found";
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
                    MessageBox.Show("Supplier Name or Phone number cannot be empty", "Error", MessageBoxButtons.OK);
                }
            }
            
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtNetAmount_Enter(object sender, EventArgs e)
        {
            int tax = Convert.ToInt32(txtTax.Text);
            //MessageBox.Show(tax.ToString());
            int invoiceAmount = Convert.ToInt32(txtInvoiceAmount.Text);
            //MessageBox.Show(invoiceAmount.ToString());
            decimal percentage = ((decimal)invoiceAmount / 100) * tax;
            //MessageBox.Show(percentage.ToString());
            decimal remainingInvoiceAmount = invoiceAmount - percentage;
            //MessageBox.Show(netAmount.ToString());
            int discount = Convert.ToInt32(txtDiscount.Text);
            decimal netAmount = remainingInvoiceAmount - discount;

            txtNetAmount.Text = netAmount.ToString();
            
        }

        private void calculation() {

            int tax = Convert.ToInt32(txtTax.Text);
            //MessageBox.Show(tax.ToString());
            int invoiceAmount = Convert.ToInt32(txtInvoiceAmount.Text);
            //MessageBox.Show(invoiceAmount.ToString());
            decimal percentage = ((decimal)invoiceAmount / 100) * tax;
            //MessageBox.Show(percentage.ToString());
            decimal remainingInvoiceAmount = invoiceAmount - percentage;
            //MessageBox.Show(netAmount.ToString());
            int discount = Convert.ToInt32(txtDiscount.Text);
            decimal netAmount = remainingInvoiceAmount - discount;
            txtNetAmount.Text = netAmount.ToString();
        }

        private void getAllInvoices()
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT purchaseinvoices.invoiceid AS ID, purchaseinvoices.invoicenumber AS InvoiceNumber, purchaseinvoices.invoicedate AS Date, purchaseinvoices.invoiceuser AS MadeBy, suppliers.suppliername AS Supplier, purchaseinvoices.invoiceamount AS InvoiceAmount, purchaseinvoices.discount AS Discount, purchaseinvoices.tax as TaxDeduction, purchaseinvoices.netamount as NetAmount FROM purchaseinvoices, suppliers WHERE purchaseinvoices.invoicesupplier = suppliers.supplierid";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvAllInvoices.DataSource = dt;
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
    }
}
