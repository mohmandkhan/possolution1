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
    public partial class PeopleManagement : Form
    {
        public PeopleManagement()
        {
            InitializeComponent();
            getAllSuppliers();
            getAllRoles();
            getComboListRoles();
            getAllPrivileges();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Insert Supplier Procedure
        private void btnInsertSupplier_Click(object sender, EventArgs e)
        {
            string suppliername = txtSupplierName.Text;
            string company = txtSupplierCompany.Text;
            string phone = txtSupplierPhone.Text;
            string email = txtSupplierEmail.Text;
            string address = txtSupplierAddress.Text;

            if (suppliername != "" && company != "" && phone != "" && email != "" && address != "") {

                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO suppliers(suppliername,company,phone,email,address) VALUES(@suppliername,@company,@phone,@email,@address)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@suppliername", suppliername);
                    cmd.Parameters.AddWithValue("@company", company);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Supplier Inserted Successfully");
                        resetSupplierForm();
                        //txtSupplierName.Focus();
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

                MessageBox.Show("All fields required");
            }
        }
        #endregion
        #region Reset Supplier Form Method
        private void resetSupplierForm() {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierCompany.Text = "";
            txtSupplierPhone.Text = "";
            txtSupplierEmail.Text = "";
            txtSupplierAddress.Text = "";
            this.btnInsertSupplier.Enabled = true;
            this.btnDeleteSupplier.Enabled = false;
            this.btnUpdateSupplier.Enabled = false;
            txtSupplierName.Focus();
            getAllSuppliers();
        }

        #endregion
        #region Reset Supplier Form Button
        private void btnResetSupplier_Click(object sender, EventArgs e)
        {
            resetSupplierForm();
        }
        #endregion
        #region Get All Suppliers
        private void getAllSuppliers()
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT supplierid AS ID, suppliername AS Name, company AS Company, phone AS Phone, email AS Email, address AS Address  FROM suppliers";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvSuppliers.DataSource = dt;

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
        #region Suppliers Row Header Mouse Click
        private void dgvSuppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtSupplierID.Text = dgvSuppliers.Rows[rowIndex].Cells[0].Value.ToString();
            txtSupplierName.Text = dgvSuppliers.Rows[rowIndex].Cells[1].Value.ToString();
            txtSupplierCompany.Text = dgvSuppliers.Rows[rowIndex].Cells[2].Value.ToString();
            txtSupplierPhone.Text = dgvSuppliers.Rows[rowIndex].Cells[3].Value.ToString();
            txtSupplierEmail.Text = dgvSuppliers.Rows[rowIndex].Cells[4].Value.ToString();
            txtSupplierAddress.Text = dgvSuppliers.Rows[rowIndex].Cells[5].Value.ToString();
            this.btnInsertSupplier.Enabled = false;
            this.btnDeleteSupplier.Enabled = true;
            this.btnUpdateSupplier.Enabled = true;
        }
        #endregion
        #region Roles Row Header Mouse Click
        private void dgvAllRoles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtRoleID.Text = dgvAllRoles.Rows[rowIndex].Cells[0].Value.ToString();
            txtRoleName.Text = dgvAllRoles.Rows[rowIndex].Cells[1].Value.ToString();
            this.btnInsertRole.Enabled = false;
            this.btnDeleteRole.Enabled = true;
            this.btnUpdateRole.Enabled = true;
        }
        #endregion
        #region Delete Supplier
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            string supplierid = txtSupplierID.Text;
            string suppliername = txtSupplierName.Text;

            if (supplierid != "" && suppliername != "")
            {
                DialogResult confirm = MessageBox.Show("Are you sure?","Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(myconnstring);

                    try
                    {
                        string sql = "DELETE FROM suppliers where supplierid=@supplierid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@supplierid", supplierid);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Supplier Delete Successfully");
                            resetSupplierForm();
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
                MessageBox.Show("Supplier Name field is required","Error",MessageBoxButtons.OK);
            }
        }
        #endregion
        private void grpbxAllRoles_Enter(object sender, EventArgs e)
        {
        }
        #region Insert Roles
        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            string rolename = txtRoleName.Text;
            if (rolename != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO roles(rolename) VALUES(@rolename)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@rolename",rolename);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Role Inserted Successfully");
                        resetRoleForm();
                        getAllRoles();
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
                MessageBox.Show("Role name cannot be empty","Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Reset Role Form
        private void resetRoleForm()
        {
            txtRoleID.Text = "";
            txtRoleName.Text = "";
            txtRoleName.Focus();
            getAllRoles();
            getComboListRoles();
            this.btnInsertRole.Enabled = true;
            this.btnDeleteRole.Enabled = false;
            this.btnUpdateRole.Enabled = false;
        }
        #endregion
        #region Get All Roles
        private void getAllRoles()
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT roleid AS ID, rolename AS RoleName from roles";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvAllRoles.DataSource = dt;

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
        #region Reset Role Form
        private void btnResetRole_Click(object sender, EventArgs e)
        {
            resetRoleForm();
        }
        #endregion
        #region Delete Role
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            string roleid = txtRoleID.Text;
            string rolename = txtRoleName.Text;
            if (roleid != "" && rolename != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "DELETE FROM roles WHERE roleid=@roleid";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@roleid",roleid);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Role Deleted Successfully");
                        resetRoleForm();
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
                MessageBox.Show("Role ID and Name cannot be empty","Error",MessageBoxButtons.OK);
            }         
        }
        #endregion
        #region Update Role Name
        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            string roleid = txtRoleID.Text;
            string rolename = txtRoleName.Text;
            if (roleid != "" && rolename != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "UPDATE roles SET rolename=@rolename WHERE roleid=@roleid";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@roleid", roleid);
                    cmd.Parameters.AddWithValue("@rolename", rolename);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Role Updated Successfully");
                        resetRoleForm();
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
                MessageBox.Show("Role ID and Name cannot be empty", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Get All Roles Combo Box
        private void getComboListRoles() {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM roles";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                cmbAllRoles.DataSource = dt;
                cmbAllRoles.DisplayMember = "rolename";
                cmbAllRoles.ValueMember = "roleid";
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
        }
        #endregion
        #region Insert Privilege
        private void btnInsertPrivilege_Click(object sender, EventArgs e)
        {
            string privilegename = txtPrivilegeName.Text;
            string roleid = cmbAllRoles.SelectedValue.ToString();
            if (privilegename != "" && roleid != "")
            {
                SqlConnection con = new SqlConnection(myconnstring);
                try
                {
                    string sql = "INSERT INTO privileges(privilegename, roleid) VALUES(@privilegename, @roleid)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@privilegename", privilegename);
                    cmd.Parameters.AddWithValue("@roleid", roleid);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) {

                        MessageBox.Show("Privilege Insert Successfully");
                        resetPrivilegeForm();

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
            else
            {
                MessageBox.Show("Privilege Name and Role cannot be empty","Error", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Reset Privilege Form
        private void resetPrivilegeForm()
        {
            txtPrivilegeID.Text = "";
            txtPrivilegeName.Text = "";
            txtPrivilegeName.Focus();
            getAllPrivileges();
            this.btnDeletePrivilege.Enabled = false;
            this.btnUpdatePrivilege.Enabled = false;
            this.btnInsertPrivilege.Enabled = true;
        }
        #endregion
        #region Get All Privileges
        private void getAllPrivileges() {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT privileges.privilegeid AS PrivilegeID, privileges.privilegename AS Privilege, roles.roleid AS RoleID, roles.rolename AS Role from privileges, roles WHERE privileges.roleid = roles.roleid";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                dgvAllPrivileges.DataSource = dt;
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
        #region Privileges Row Header Mouse
        private void dgvAllPrivileges_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPrivilegeID.Text = dgvAllPrivileges.Rows[rowIndex].Cells[0].Value.ToString();
            txtPrivilegeName.Text = dgvAllPrivileges.Rows[rowIndex].Cells[1].Value.ToString();
            cmbAllRoles.SelectedValue = dgvAllPrivileges.Rows[rowIndex].Cells[2].Value.ToString();
            this.btnDeletePrivilege.Enabled = true;
            this.btnUpdatePrivilege.Enabled = true;
            this.btnInsertPrivilege.Enabled = false;
        }
        #endregion
        #region Reset Privileges Button
        private void btnResetPrivilege_Click(object sender, EventArgs e)
        {
            resetPrivilegeForm();
        }
        #endregion
        #region Delete Privilege
        private void btnDeletePrivilege_Click(object sender, EventArgs e)
        {
            string privilegeid = txtPrivilegeID.Text;
            string privilegename = txtPrivilegeName.Text;
            if (privilegeid != "" && privilegename != "")
            {
                DialogResult confirm = MessageBox.Show("Are you sure?","Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(myconnstring);
                    try
                    {
                        string sql = "DELETE FROM privileges WHERE privilegeid=@privilegeid";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@privilegeid", privilegeid);
                        con.Open();

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Privilege Deleted");
                            resetPrivilegeForm();
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
                MessageBox.Show("Privilege ID and Name cannot be empty","Error",MessageBoxButtons.OK);
            }

        }
        #endregion
    }
}
