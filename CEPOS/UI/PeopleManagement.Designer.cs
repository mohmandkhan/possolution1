namespace CEPOS.UI
{
    partial class PeopleManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSuppliers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.SupplierFormActions = new System.Windows.Forms.GroupBox();
            this.btnResetSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnInsertSupplier = new System.Windows.Forms.Button();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.lblSupplierCompanyName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierCompany = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvAllPrivileges = new System.Windows.Forms.DataGridView();
            this.grpbxAllRoles = new System.Windows.Forms.GroupBox();
            this.dgvAllRoles = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrivilegeID = new System.Windows.Forms.TextBox();
            this.btnResetPrivilege = new System.Windows.Forms.Button();
            this.btnUpdatePrivilege = new System.Windows.Forms.Button();
            this.btnDeletePrivilege = new System.Windows.Forms.Button();
            this.btnInsertPrivilege = new System.Windows.Forms.Button();
            this.cmbAllRoles = new System.Windows.Forms.ComboBox();
            this.txtPrivilegeName = new System.Windows.Forms.TextBox();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblRoleID = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.btnResetRole = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnInsertRole = new System.Windows.Forms.Button();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabSuppliers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SupplierFormActions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPrivileges)).BeginInit();
            this.grpbxAllRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRoles)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.tabPage1);
            this.tabSuppliers.Controls.Add(this.tabPage2);
            this.tabSuppliers.Controls.Add(this.tabPage3);
            this.tabSuppliers.Controls.Add(this.tabPage4);
            this.tabSuppliers.Location = new System.Drawing.Point(39, 37);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.SelectedIndex = 0;
            this.tabSuppliers.Size = new System.Drawing.Size(941, 543);
            this.tabSuppliers.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(121)))), ((int)(((byte)(199)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Suppliers";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(121)))), ((int)(((byte)(199)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSuppliers);
            this.groupBox3.Location = new System.Drawing.Point(466, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 485);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Suppliers";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(7, 19);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(440, 460);
            this.dgvSuppliers.TabIndex = 0;
            this.dgvSuppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliers_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 485);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entry and Search";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblSupplierID);
            this.groupBox5.Controls.Add(this.txtSupplierID);
            this.groupBox5.Controls.Add(this.SupplierFormActions);
            this.groupBox5.Controls.Add(this.lblSupplierAddress);
            this.groupBox5.Controls.Add(this.lblSupplierEmail);
            this.groupBox5.Controls.Add(this.lblSupplierPhone);
            this.groupBox5.Controls.Add(this.lblSupplierCompanyName);
            this.groupBox5.Controls.Add(this.lblSupplierName);
            this.groupBox5.Controls.Add(this.txtSupplierAddress);
            this.groupBox5.Controls.Add(this.txtSupplierEmail);
            this.groupBox5.Controls.Add(this.txtSupplierPhone);
            this.groupBox5.Controls.Add(this.txtSupplierCompany);
            this.groupBox5.Controls.Add(this.txtSupplierName);
            this.groupBox5.Location = new System.Drawing.Point(7, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 396);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.White;
            this.lblSupplierID.Location = new System.Drawing.Point(9, 26);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(78, 19);
            this.lblSupplierID.TabIndex = 33;
            this.lblSupplierID.Text = "ID (Locked)";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierID.Location = new System.Drawing.Point(119, 23);
            this.txtSupplierID.Multiline = true;
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(312, 28);
            this.txtSupplierID.TabIndex = 32;
            // 
            // SupplierFormActions
            // 
            this.SupplierFormActions.Controls.Add(this.btnResetSupplier);
            this.SupplierFormActions.Controls.Add(this.btnDeleteSupplier);
            this.SupplierFormActions.Controls.Add(this.btnUpdateSupplier);
            this.SupplierFormActions.Controls.Add(this.btnInsertSupplier);
            this.SupplierFormActions.Location = new System.Drawing.Point(13, 332);
            this.SupplierFormActions.Name = "SupplierFormActions";
            this.SupplierFormActions.Size = new System.Drawing.Size(418, 51);
            this.SupplierFormActions.TabIndex = 31;
            this.SupplierFormActions.TabStop = false;
            this.SupplierFormActions.Text = "Actions";
            // 
            // btnResetSupplier
            // 
            this.btnResetSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnResetSupplier.FlatAppearance.BorderSize = 10;
            this.btnResetSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResetSupplier.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetSupplier.Location = new System.Drawing.Point(313, 15);
            this.btnResetSupplier.Name = "btnResetSupplier";
            this.btnResetSupplier.Size = new System.Drawing.Size(95, 28);
            this.btnResetSupplier.TabIndex = 23;
            this.btnResetSupplier.Text = "Reset";
            this.btnResetSupplier.UseVisualStyleBackColor = true;
            this.btnResetSupplier.Click += new System.EventHandler(this.btnResetSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Enabled = false;
            this.btnDeleteSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteSupplier.FlatAppearance.BorderSize = 10;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteSupplier.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(212, 15);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(95, 28);
            this.btnDeleteSupplier.TabIndex = 22;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Enabled = false;
            this.btnUpdateSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUpdateSupplier.FlatAppearance.BorderSize = 10;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateSupplier.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(111, 15);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(95, 28);
            this.btnUpdateSupplier.TabIndex = 21;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnInsertSupplier
            // 
            this.btnInsertSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInsertSupplier.FlatAppearance.BorderSize = 10;
            this.btnInsertSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsertSupplier.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsertSupplier.Location = new System.Drawing.Point(10, 15);
            this.btnInsertSupplier.Name = "btnInsertSupplier";
            this.btnInsertSupplier.Size = new System.Drawing.Size(95, 28);
            this.btnInsertSupplier.TabIndex = 20;
            this.btnInsertSupplier.Text = "Insert";
            this.btnInsertSupplier.UseVisualStyleBackColor = true;
            this.btnInsertSupplier.Click += new System.EventHandler(this.btnInsertSupplier_Click);
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierAddress.ForeColor = System.Drawing.Color.White;
            this.lblSupplierAddress.Location = new System.Drawing.Point(11, 197);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(58, 19);
            this.lblSupplierAddress.TabIndex = 30;
            this.lblSupplierAddress.Text = "Address";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierEmail.ForeColor = System.Drawing.Color.White;
            this.lblSupplierEmail.Location = new System.Drawing.Point(10, 162);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(94, 19);
            this.lblSupplierEmail.TabIndex = 29;
            this.lblSupplierEmail.Text = "Email Address";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierPhone.ForeColor = System.Drawing.Color.White;
            this.lblSupplierPhone.Location = new System.Drawing.Point(10, 129);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(48, 19);
            this.lblSupplierPhone.TabIndex = 28;
            this.lblSupplierPhone.Text = "Phone";
            // 
            // lblSupplierCompanyName
            // 
            this.lblSupplierCompanyName.AutoSize = true;
            this.lblSupplierCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblSupplierCompanyName.Location = new System.Drawing.Point(9, 94);
            this.lblSupplierCompanyName.Name = "lblSupplierCompanyName";
            this.lblSupplierCompanyName.Size = new System.Drawing.Size(108, 19);
            this.lblSupplierCompanyName.TabIndex = 27;
            this.lblSupplierCompanyName.Text = "Company Name";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierName.ForeColor = System.Drawing.Color.White;
            this.lblSupplierName.Location = new System.Drawing.Point(9, 60);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(98, 19);
            this.lblSupplierName.TabIndex = 26;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierAddress.Location = new System.Drawing.Point(119, 193);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(312, 101);
            this.txtSupplierAddress.TabIndex = 24;
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierEmail.Location = new System.Drawing.Point(119, 159);
            this.txtSupplierEmail.Multiline = true;
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(312, 28);
            this.txtSupplierEmail.TabIndex = 23;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierPhone.Location = new System.Drawing.Point(119, 125);
            this.txtSupplierPhone.Multiline = true;
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(312, 28);
            this.txtSupplierPhone.TabIndex = 22;
            // 
            // txtSupplierCompany
            // 
            this.txtSupplierCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierCompany.Location = new System.Drawing.Point(119, 91);
            this.txtSupplierCompany.Multiline = true;
            this.txtSupplierCompany.Name = "txtSupplierCompany";
            this.txtSupplierCompany.Size = new System.Drawing.Size(312, 28);
            this.txtSupplierCompany.TabIndex = 21;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSupplierName.Location = new System.Drawing.Point(119, 57);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(312, 28);
            this.txtSupplierName.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchSupplier);
            this.groupBox4.Controls.Add(this.txtSearchSupplier);
            this.groupBox4.Location = new System.Drawing.Point(6, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 58);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Supplier";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSearchSupplier.FlatAppearance.BorderSize = 10;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.Crimson;
            this.btnSearchSupplier.Location = new System.Drawing.Point(333, 19);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(95, 28);
            this.btnSearchSupplier.TabIndex = 19;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtSearchSupplier.Location = new System.Drawing.Point(15, 19);
            this.txtSearchSupplier.Multiline = true;
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(312, 28);
            this.txtSearchSupplier.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(121)))), ((int)(((byte)(199)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(121)))), ((int)(((byte)(199)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "System Users";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(121)))), ((int)(((byte)(199)))));
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.grpbxAllRoles);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(933, 517);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Roles and Privilages";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvAllPrivileges);
            this.groupBox8.Location = new System.Drawing.Point(377, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(550, 357);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "All Privileges";
            // 
            // dgvAllPrivileges
            // 
            this.dgvAllPrivileges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPrivileges.Location = new System.Drawing.Point(6, 19);
            this.dgvAllPrivileges.Name = "dgvAllPrivileges";
            this.dgvAllPrivileges.Size = new System.Drawing.Size(537, 332);
            this.dgvAllPrivileges.TabIndex = 0;
            this.dgvAllPrivileges.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllPrivileges_RowHeaderMouseClick);
            // 
            // grpbxAllRoles
            // 
            this.grpbxAllRoles.Controls.Add(this.dgvAllRoles);
            this.grpbxAllRoles.Location = new System.Drawing.Point(7, 153);
            this.grpbxAllRoles.Name = "grpbxAllRoles";
            this.grpbxAllRoles.Size = new System.Drawing.Size(363, 357);
            this.grpbxAllRoles.TabIndex = 2;
            this.grpbxAllRoles.TabStop = false;
            this.grpbxAllRoles.Text = "All Roles";
            this.grpbxAllRoles.Enter += new System.EventHandler(this.grpbxAllRoles_Enter);
            // 
            // dgvAllRoles
            // 
            this.dgvAllRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRoles.Location = new System.Drawing.Point(7, 19);
            this.dgvAllRoles.Name = "dgvAllRoles";
            this.dgvAllRoles.Size = new System.Drawing.Size(350, 332);
            this.dgvAllRoles.TabIndex = 0;
            this.dgvAllRoles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllRoles_RowHeaderMouseClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtPrivilegeID);
            this.groupBox7.Controls.Add(this.btnResetPrivilege);
            this.groupBox7.Controls.Add(this.btnUpdatePrivilege);
            this.groupBox7.Controls.Add(this.btnDeletePrivilege);
            this.groupBox7.Controls.Add(this.btnInsertPrivilege);
            this.groupBox7.Controls.Add(this.cmbAllRoles);
            this.groupBox7.Controls.Add(this.txtPrivilegeName);
            this.groupBox7.Controls.Add(this.lblSelectRole);
            this.groupBox7.Controls.Add(this.lblPrivilege);
            this.groupBox7.Location = new System.Drawing.Point(376, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(551, 140);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Privilege";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID";
            // 
            // txtPrivilegeID
            // 
            this.txtPrivilegeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrivilegeID.Enabled = false;
            this.txtPrivilegeID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPrivilegeID.Location = new System.Drawing.Point(89, 22);
            this.txtPrivilegeID.Multiline = true;
            this.txtPrivilegeID.Name = "txtPrivilegeID";
            this.txtPrivilegeID.Size = new System.Drawing.Size(283, 28);
            this.txtPrivilegeID.TabIndex = 43;
            // 
            // btnResetPrivilege
            // 
            this.btnResetPrivilege.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnResetPrivilege.FlatAppearance.BorderSize = 10;
            this.btnResetPrivilege.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResetPrivilege.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetPrivilege.Location = new System.Drawing.Point(455, 89);
            this.btnResetPrivilege.Name = "btnResetPrivilege";
            this.btnResetPrivilege.Size = new System.Drawing.Size(72, 31);
            this.btnResetPrivilege.TabIndex = 40;
            this.btnResetPrivilege.Text = "Reset";
            this.btnResetPrivilege.UseVisualStyleBackColor = true;
            this.btnResetPrivilege.Click += new System.EventHandler(this.btnResetPrivilege_Click);
            // 
            // btnUpdatePrivilege
            // 
            this.btnUpdatePrivilege.Enabled = false;
            this.btnUpdatePrivilege.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUpdatePrivilege.FlatAppearance.BorderSize = 10;
            this.btnUpdatePrivilege.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdatePrivilege.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdatePrivilege.Location = new System.Drawing.Point(378, 89);
            this.btnUpdatePrivilege.Name = "btnUpdatePrivilege";
            this.btnUpdatePrivilege.Size = new System.Drawing.Size(72, 31);
            this.btnUpdatePrivilege.TabIndex = 40;
            this.btnUpdatePrivilege.Text = "Update";
            this.btnUpdatePrivilege.UseVisualStyleBackColor = true;
            // 
            // btnDeletePrivilege
            // 
            this.btnDeletePrivilege.Enabled = false;
            this.btnDeletePrivilege.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeletePrivilege.FlatAppearance.BorderSize = 10;
            this.btnDeletePrivilege.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeletePrivilege.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeletePrivilege.Location = new System.Drawing.Point(455, 54);
            this.btnDeletePrivilege.Name = "btnDeletePrivilege";
            this.btnDeletePrivilege.Size = new System.Drawing.Size(72, 31);
            this.btnDeletePrivilege.TabIndex = 40;
            this.btnDeletePrivilege.Text = "Delete";
            this.btnDeletePrivilege.UseVisualStyleBackColor = true;
            this.btnDeletePrivilege.Click += new System.EventHandler(this.btnDeletePrivilege_Click);
            // 
            // btnInsertPrivilege
            // 
            this.btnInsertPrivilege.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInsertPrivilege.FlatAppearance.BorderSize = 10;
            this.btnInsertPrivilege.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsertPrivilege.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsertPrivilege.Location = new System.Drawing.Point(378, 54);
            this.btnInsertPrivilege.Name = "btnInsertPrivilege";
            this.btnInsertPrivilege.Size = new System.Drawing.Size(72, 31);
            this.btnInsertPrivilege.TabIndex = 37;
            this.btnInsertPrivilege.Text = "Insert";
            this.btnInsertPrivilege.UseVisualStyleBackColor = true;
            this.btnInsertPrivilege.Click += new System.EventHandler(this.btnInsertPrivilege_Click);
            // 
            // cmbAllRoles
            // 
            this.cmbAllRoles.BackColor = System.Drawing.Color.White;
            this.cmbAllRoles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbAllRoles.ForeColor = System.Drawing.Color.Crimson;
            this.cmbAllRoles.FormattingEnabled = true;
            this.cmbAllRoles.ItemHeight = 21;
            this.cmbAllRoles.Location = new System.Drawing.Point(89, 90);
            this.cmbAllRoles.Name = "cmbAllRoles";
            this.cmbAllRoles.Size = new System.Drawing.Size(283, 29);
            this.cmbAllRoles.TabIndex = 42;
            this.cmbAllRoles.Text = "Select Role";
            // 
            // txtPrivilegeName
            // 
            this.txtPrivilegeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrivilegeName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPrivilegeName.Location = new System.Drawing.Point(89, 56);
            this.txtPrivilegeName.Multiline = true;
            this.txtPrivilegeName.Name = "txtPrivilegeName";
            this.txtPrivilegeName.Size = new System.Drawing.Size(283, 28);
            this.txtPrivilegeName.TabIndex = 40;
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectRole.ForeColor = System.Drawing.Color.White;
            this.lblSelectRole.Location = new System.Drawing.Point(23, 97);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(35, 19);
            this.lblSelectRole.TabIndex = 41;
            this.lblSelectRole.Text = "Role";
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrivilege.ForeColor = System.Drawing.Color.White;
            this.lblPrivilege.Location = new System.Drawing.Point(23, 61);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(60, 19);
            this.lblPrivilege.TabIndex = 40;
            this.lblPrivilege.Text = "Privilege";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblRoleID);
            this.groupBox6.Controls.Add(this.txtRoleID);
            this.groupBox6.Controls.Add(this.btnResetRole);
            this.groupBox6.Controls.Add(this.btnUpdateRole);
            this.groupBox6.Controls.Add(this.btnDeleteRole);
            this.groupBox6.Controls.Add(this.btnInsertRole);
            this.groupBox6.Controls.Add(this.txtRoleName);
            this.groupBox6.Controls.Add(this.lblRole);
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(363, 140);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Role";
            // 
            // lblRoleID
            // 
            this.lblRoleID.AutoSize = true;
            this.lblRoleID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoleID.ForeColor = System.Drawing.Color.White;
            this.lblRoleID.Location = new System.Drawing.Point(7, 31);
            this.lblRoleID.Name = "lblRoleID";
            this.lblRoleID.Size = new System.Drawing.Size(23, 19);
            this.lblRoleID.TabIndex = 41;
            this.lblRoleID.Text = "ID";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRoleID.Enabled = false;
            this.txtRoleID.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtRoleID.Location = new System.Drawing.Point(48, 24);
            this.txtRoleID.Multiline = true;
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(300, 28);
            this.txtRoleID.TabIndex = 40;
            // 
            // btnResetRole
            // 
            this.btnResetRole.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnResetRole.FlatAppearance.BorderSize = 10;
            this.btnResetRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResetRole.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetRole.Location = new System.Drawing.Point(276, 92);
            this.btnResetRole.Name = "btnResetRole";
            this.btnResetRole.Size = new System.Drawing.Size(72, 28);
            this.btnResetRole.TabIndex = 39;
            this.btnResetRole.Text = "Reset";
            this.btnResetRole.UseVisualStyleBackColor = true;
            this.btnResetRole.Click += new System.EventHandler(this.btnResetRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Enabled = false;
            this.btnUpdateRole.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUpdateRole.FlatAppearance.BorderSize = 10;
            this.btnUpdateRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateRole.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdateRole.Location = new System.Drawing.Point(201, 92);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(72, 28);
            this.btnUpdateRole.TabIndex = 38;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Enabled = false;
            this.btnDeleteRole.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteRole.FlatAppearance.BorderSize = 10;
            this.btnDeleteRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteRole.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteRole.Location = new System.Drawing.Point(123, 92);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(72, 28);
            this.btnDeleteRole.TabIndex = 37;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnInsertRole
            // 
            this.btnInsertRole.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInsertRole.FlatAppearance.BorderSize = 10;
            this.btnInsertRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsertRole.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsertRole.Location = new System.Drawing.Point(48, 92);
            this.btnInsertRole.Name = "btnInsertRole";
            this.btnInsertRole.Size = new System.Drawing.Size(72, 28);
            this.btnInsertRole.TabIndex = 36;
            this.btnInsertRole.Text = "Insert";
            this.btnInsertRole.UseVisualStyleBackColor = true;
            this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
            // 
            // txtRoleName
            // 
            this.txtRoleName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRoleName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtRoleName.Location = new System.Drawing.Point(48, 58);
            this.txtRoleName.Multiline = true;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(300, 28);
            this.txtRoleName.TabIndex = 35;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(7, 62);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 19);
            this.lblRole.TabIndex = 34;
            this.lblRole.Text = "Role";
            // 
            // PeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1024, 612);
            this.Controls.Add(this.tabSuppliers);
            this.Name = "PeopleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleManagement";
            this.tabSuppliers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.SupplierFormActions.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPrivileges)).EndInit();
            this.grpbxAllRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRoles)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabSuppliers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierCompany;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierCompanyName;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.GroupBox SupplierFormActions;
        private System.Windows.Forms.Button btnInsertSupplier;
        private System.Windows.Forms.Button btnResetSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnResetRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnInsertRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPrivilegeName;
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.GroupBox grpbxAllRoles;
        private System.Windows.Forms.Button btnResetPrivilege;
        private System.Windows.Forms.Button btnUpdatePrivilege;
        private System.Windows.Forms.Button btnDeletePrivilege;
        private System.Windows.Forms.Button btnInsertPrivilege;
        private System.Windows.Forms.ComboBox cmbAllRoles;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvAllPrivileges;
        private System.Windows.Forms.DataGridView dgvAllRoles;
        private System.Windows.Forms.TextBox txtPrivilegeID;
        private System.Windows.Forms.Label lblRoleID;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Label label1;
    }
}