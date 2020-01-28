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
    public partial class ProductsManagement : Form
    {
        public ProductsManagement()
        {
            InitializeComponent();
            getCategories();
            catListOfValues();
            getAllSubCategories();
            catListOfValuesProducts();
            getAllProducts();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region GET ALL CATEGORIES DATATABLE
        private void getCategories() {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT categoryid AS Identification,categoryname AS Category FROM categories";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvCategories.DataSource = dt;

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

        #region GET ALL SUB CATEGORIES DATATABLE
        public void getAllSubCategories()
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT subcategories.subcategoryid as Identification, subcategories.subcategoryname as SubCategory, categories.categoryname as Category from subcategories,categories WHERE subcategories.categoryid=categories.categoryid";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvSubCategories.DataSource = dt;

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

        #region Categories List of Values
        public void catListOfValues() {
            SqlConnection con = new SqlConnection(myconnstring);
            
            DataTable dt = new DataTable();
            try
            {           
                string sql = "SELECT * from categories";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                cmbAllCategories.DataSource = dt;
                cmbAllCategories.DisplayMember = "categoryname";
                cmbAllCategories.ValueMember = "categoryid";
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
        }
        #endregion

        #region INSERT CATEGORY PROCEDURE
        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnstring);
            string category = txtCategoryName.Text;

            if (category!="")
            {
                try
                {
                    string sql = "INSERT INTO categories(categoryname) VALUES(@categoryname)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@categoryname", category);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Category Inserted");
                        getCategories();
                        txtCategoryName.Text = "";
                        txtCategoryName.Focus();
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

            } else {

                MessageBox.Show("Category Name Cannot Be Empty","Empty Field Error",MessageBoxButtons.OK);
            }
          }
        #endregion

        private void products_Click(object sender, EventArgs e)
        {

        }

        #region CATEGORIES DATAGRID ROW SELECTION ROW HEADER
        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtCategoryName.Text = dgvCategories.Rows[rowIndex].Cells[1].Value.ToString();
            this.btnUpdateCategory.Enabled = true;
            this.btnInsertCategory.Enabled = false;
            this.btnDeleteCategory.Enabled = true;
        }
        #endregion

        #region DELETE CATEGORY PROCEDURE
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryname = txtCategoryName.Text;
            string categoryID = txtCategoryID.Text;
            if (categoryname!="") {

                DialogResult confirm = MessageBox.Show("Are You Sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {

                    
                    SqlConnection con = new SqlConnection(myconnstring);
                    try
                    {
                        string sql = "DELETE FROM categories WHERE categoryid=@categoryid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@categoryid", categoryID);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Category Deleted Successfully");
                            getCategories();
                            txtCategoryName.Text = "";
                            txtCategoryID.Text = "";
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
            else {

                MessageBox.Show("Category Name Cannot Be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region RESET CATEGORY FORM PROCEDURE
        private void btnResetCategory_Click(object sender, EventArgs e)
        {
            getCategories();
            txtCategoryName.Text = "";
            txtSearchCategory.Text = "";
            txtCategoryID.Text = "";
            this.btnUpdateCategory.Enabled = false;
            this.btnInsertCategory.Enabled = true;
            this.btnDeleteCategory.Enabled = false;
        }
        #endregion

        #region SEARCH CATEGORY PROCEDURE
        private void txtSearchCategory_Enter(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region SEARCH CATEGORY PROCEDURE CLICK
        private void btnCategorySearch_Click(object sender, EventArgs e)
        {
            string categoryname = txtSearchCategory.Text;
            if (categoryname != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                DataTable dt = new DataTable();
                try
                {
                    string sql = "SELECT categoryid as Identification,categoryname as Category from categories WHERE categoryname = @categoryname";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@categoryname", categoryname);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    dgvCategories.DataSource = dt;
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
                MessageBox.Show("Category Name Cannot be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region UPDATE CATEGORY PROCEDURE
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string categoryname = txtCategoryName.Text;
            string categoryID = txtCategoryID.Text;
            if (categoryname != "")
            {

               SqlConnection con = new SqlConnection(myconnstring);
                    try
                    {
                        string sql = "UPDATE categories SET categoryname=@categoryname WHERE categoryid=@categoryid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@categoryid", categoryID);
                        cmd.Parameters.AddWithValue("@categoryname", categoryname);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Category Updated Successfully");
                            getCategories();
                            txtCategoryName.Text = "";
                            txtCategoryID.Text = "";
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

                MessageBox.Show("Category Name Cannot Be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region INSERT SUB CATEGORY PROCEDURE
        private void btnInsertSubCategory_Click(object sender, EventArgs e)
        {
            string subcategoryname = txtSubCategoryName.Text;
            if (subcategoryname!="")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string categoryid = cmbAllCategories.SelectedValue.ToString();
                    string sql = "INSERT INTO subcategories(subcategoryname,categoryid) VALUES(@subcategoryname,@categoryid)";
                    SqlCommand cmd = new SqlCommand(sql,con);
                    cmd.Parameters.AddWithValue("@subcategoryname",subcategoryname);
                    cmd.Parameters.AddWithValue("@categoryid", categoryid);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows>0)
                    {
                        MessageBox.Show("Sub Category Added Successfully");
                        txtSubCategoryName.Text = "";
                        txtSubCategoryName.Focus();
                        getAllSubCategories();
                    }
                    else {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
            else {
                MessageBox.Show("Sub Category Name Cannot Be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region RESET SUB CATEGORY FORM PROCEDURE
        private void btnResetSubCategoryForm_Click(object sender, EventArgs e)
        {
            getAllSubCategories();
            txtSubCategoryName.Text = "";
            txtSubCategorySearch.Text = "";
            txtSubCatID.Text = "";
            this.btnUpdateSubCategory.Enabled = false;
            this.btnInsertSubCategory.Enabled = true;
            this.btnDeleteSubCategory.Enabled = false;
        }



        #endregion

        #region SUB CATEGORIES DATAGRID ROW SELECTION ROW HEADER
        private void dgvSubCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtSubCatID.Text = dgvSubCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtSubCategoryName.Text = dgvSubCategories.Rows[rowIndex].Cells[1].Value.ToString();
            this.btnUpdateSubCategory.Enabled = true;
            this.btnInsertSubCategory.Enabled = false;
            this.btnDeleteSubCategory.Enabled = true;
        }
        #endregion

        #region DELETE SUB CATEGORY PROCEDURE
        private void btnDeleteSubCategory_Click(object sender, EventArgs e)
        {
            string subcategoryname = txtSubCategoryName.Text;
            string subcategoryid = txtSubCatID.Text;
            if (subcategoryname != "")
            {

                DialogResult confirm = MessageBox.Show("Are You Sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {


                    SqlConnection con = new SqlConnection(myconnstring);
                    try
                    {
                        string sql = "DELETE FROM subcategories WHERE subcategoryid=@subcategoryid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@subcategoryid", subcategoryid);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Sub Category Deleted Successfully");
                            getAllSubCategories();
                            txtSubCategoryName.Text = "";
                            txtSubCatID.Text = "";
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

                MessageBox.Show(" Sub Category Name Cannot Be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }

        }
        #endregion

        #region UPDATE SUB CATEGORY PROCEDURE
        private void btnUpdateSubCategory_Click(object sender, EventArgs e)
        {
            string subcategoryname = txtSubCategoryName.Text;
            string subcategoryid = txtSubCatID.Text;
            string categoryid = cmbAllCategories.SelectedValue.ToString();
            if (subcategoryname != "")
            {

                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "UPDATE subcategories SET subcategoryname=@subcategoryname,categoryid=@categoryid WHERE subcategoryid=@subcategoryid";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@subcategoryname", subcategoryname);
                    cmd.Parameters.AddWithValue("@categoryid", categoryid);
                    cmd.Parameters.AddWithValue("@subcategoryid", subcategoryid);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Sub Category Updated Successfully");
                        getAllSubCategories();
                        txtSubCategoryName.Text = "";
                        txtSubCatID.Text = "";
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

                MessageBox.Show("Sub Category Name Cannot Be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region SEARCH SUB CATEGORY PROCEDURE
        private void btnSubCategorySearch_Click(object sender, EventArgs e)
        {
            string subcategoryname = txtSubCategorySearch.Text;
            if (subcategoryname != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                DataTable dt = new DataTable();
                try
                {
                    string sql = "SELECT subcategories.subcategoryid as Identification, subcategories.subcategoryname as SubCategory, categories.categoryname as Category from subcategories,categories WHERE subcategories.categoryid=categories.categoryid AND subcategoryname=@subcategoryname";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@subcategoryname", subcategoryname);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    dgvSubCategories.DataSource = dt;
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
                MessageBox.Show("Sub Category Name Cannot be Empty", "Empty Field Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region GET CATEGORIES FOR Products
        private void catListOfValuesProducts() {
            SqlConnection con = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM categories";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "categoryname";
                cmbCategory.ValueMember = "categoryid";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
        }
        #endregion

        #region Reset Products Form
        private void resetProductForm() {

            txtBarcode.Text = "";
            txtProductName.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtQuantity.Text = "";

        }
        #endregion

        #region GET ALL PRODUCTS
        private void getAllProducts() {

            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT products.barcode as Barcode, products.name as ProductName, products.costprice as CostPrice, products.saleprice as SalePrice, products.quantity as Quantity, categories.categoryname as CategoryName, subcategories.subcategoryname as SubCategoryName FROM products, categories, subcategories WHERE products.categoryid=categories.categoryid AND products.subcategoryid=subcategories.subcategoryid";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                dgvAllProducts.DataSource = dt;
               
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

        #region INSERT PRODUCT PROCEDURE
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            string name = txtProductName.Text;
            string costPrice = txtCostPrice.Text;
            string salePrice = txtSalePrice.Text;
            string quantity = txtQuantity.Text;
            string categoryID = cmbCategory.SelectedValue.ToString();
            string subcategoryID = cmbSubCategory.SelectedValue.ToString();

            if (barcode != "" && name != "" && costPrice != "" && salePrice != "" && quantity != "" && categoryID != "" && subcategoryID != "")
            {

                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO products(barcode,name,costprice,saleprice,quantity,categoryid,subcategoryid) VALUES(@barcode,@name,@costprice,@saleprice,@quantity,@categoryid,@subcategoryid)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@costprice", costPrice);
                    cmd.Parameters.AddWithValue("@saleprice", salePrice);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@categoryid", categoryID);
                    cmd.Parameters.AddWithValue("@subcategoryid", subcategoryID);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Product inserted Successfully!");
                        resetProductForm();
                        txtBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error!");

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
            else {

                MessageBox.Show("All fields are required!");
            }
            


        }
        #endregion

        #region Fetch SubCategories WHILE selecting Categories
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryID = cmbCategory.SelectedValue.ToString();
            //MessageBox.Show(categoryID);
            //if (categoryid!="") {
                SqlConnection con = new SqlConnection(myconnstring);
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM subcategories where categoryid="+categoryID;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    adapter.Fill(dt);
                    cmbSubCategory.DataSource = dt;
                    cmbSubCategory.DisplayMember = "subcategoryname";
                    cmbSubCategory.ValueMember = "subcategoryid";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            //}
          

        }

        #endregion

        private void txtSearch_Enter(object sender, EventArgs e)
        {
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string keyword = txtSearch.Text;
                if (keyword!="") {

                    SqlConnection con = new SqlConnection(myconnstring);
                    DataTable dt = new DataTable();
                    try
                    {
                        //MessageBox.Show(keyword);
                        string sql = "SELECT * FROM products WHERE barcode= '"+keyword+"' OR name= '"+keyword+"'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                        con.Open();
                        adapter.Fill(dt);
                        if (dt.Rows.Count>0) {
                            txtBarcode.Text = dt.Rows[0]["barcode"].ToString();
                            txtProductName.Text = dt.Rows[0]["name"].ToString();
                            txtCostPrice.Text = dt.Rows[0]["costprice"].ToString();
                            txtSalePrice.Text = dt.Rows[0]["saleprice"].ToString();
                            txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
                            cmbCategory.SelectedValue = dt.Rows[0]["categoryid"].ToString();
                            cmbSubCategory.SelectedValue = dt.Rows[0]["subcategoryid"].ToString();
                            txtSearch.Text = "";
                            this.btnInsert.Enabled = false;
                            this.btnUpdate.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnResetProduct.Enabled = true;
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
                else {
                    MessageBox.Show("Search field is empty!");
                    txtSearch.Text = "";
                }
            }
        }

        private void btnResetProduct_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            txtProductName.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtQuantity.Text = "";
            this.btnInsert.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnResetProduct.Enabled = false;
        }

        private void txtSearchProductsByType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string keyword = txtSearchProductsByType.Text;
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
                            dgvAllProducts.DataSource = dt;
                            txtSearchProductsByType.Text = "";
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
                    txtSearchProductsByType.Text = "";
                }
            }
        }
    }
}
