namespace CEPOS.UI
{
    partial class PurchaseManagement
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpAllInvoices = new System.Windows.Forms.GroupBox();
            this.dgvAllInvoices = new System.Windows.Forms.DataGridView();
            this.searchGrpBx = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpInvoiceToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.btnSearchSupplierAndDates = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtSearchInvoice = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.Tax = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchInvoiceNumber = new System.Windows.Forms.TextBox();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnSuspendInvoice = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.lblCurrentBill = new System.Windows.Forms.GroupBox();
            this.dgvPinvoiceProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetInvoice = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.btnDeleteFromInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBarcode = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnAddToInvoice = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblSupplierCompany = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.lblSearchBarcode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.grpAllInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).BeginInit();
            this.searchGrpBx.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpTotals.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.lblCurrentBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPinvoiceProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.grpAllInvoices);
            this.tabPage2.Controls.Add(this.searchGrpBx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purchase History";
            // 
            // grpAllInvoices
            // 
            this.grpAllInvoices.Controls.Add(this.dgvAllInvoices);
            this.grpAllInvoices.Location = new System.Drawing.Point(8, 116);
            this.grpAllInvoices.Name = "grpAllInvoices";
            this.grpAllInvoices.Size = new System.Drawing.Size(1148, 557);
            this.grpAllInvoices.TabIndex = 1;
            this.grpAllInvoices.TabStop = false;
            this.grpAllInvoices.Text = "Invoices";
            // 
            // dgvAllInvoices
            // 
            this.dgvAllInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInvoices.Location = new System.Drawing.Point(7, 20);
            this.dgvAllInvoices.Name = "dgvAllInvoices";
            this.dgvAllInvoices.Size = new System.Drawing.Size(1135, 531);
            this.dgvAllInvoices.TabIndex = 0;
            // 
            // searchGrpBx
            // 
            this.searchGrpBx.Controls.Add(this.lblTo);
            this.searchGrpBx.Controls.Add(this.lblFrom);
            this.searchGrpBx.Controls.Add(this.dtpInvoiceToDate);
            this.searchGrpBx.Controls.Add(this.dtpInvoiceFromDate);
            this.searchGrpBx.Controls.Add(this.cmbSupplierName);
            this.searchGrpBx.Controls.Add(this.btnSearchSupplierAndDates);
            this.searchGrpBx.Controls.Add(this.lblSupplier);
            this.searchGrpBx.Controls.Add(this.btnSearchInvoice);
            this.searchGrpBx.Controls.Add(this.lblInvoiceNo);
            this.searchGrpBx.Controls.Add(this.txtSearchInvoice);
            this.searchGrpBx.Location = new System.Drawing.Point(8, 8);
            this.searchGrpBx.Name = "searchGrpBx";
            this.searchGrpBx.Size = new System.Drawing.Size(1148, 101);
            this.searchGrpBx.TabIndex = 0;
            this.searchGrpBx.TabStop = false;
            this.searchGrpBx.Text = "Search";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(784, 55);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 20);
            this.lblTo.TabIndex = 25;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(784, 23);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 20);
            this.lblFrom.TabIndex = 24;
            this.lblFrom.Text = "From";
            // 
            // dtpInvoiceToDate
            // 
            this.dtpInvoiceToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpInvoiceToDate.Location = new System.Drawing.Point(836, 53);
            this.dtpInvoiceToDate.Name = "dtpInvoiceToDate";
            this.dtpInvoiceToDate.Size = new System.Drawing.Size(306, 32);
            this.dtpInvoiceToDate.TabIndex = 23;
            // 
            // dtpInvoiceFromDate
            // 
            this.dtpInvoiceFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpInvoiceFromDate.Location = new System.Drawing.Point(836, 17);
            this.dtpInvoiceFromDate.Name = "dtpInvoiceFromDate";
            this.dtpInvoiceFromDate.Size = new System.Drawing.Size(306, 32);
            this.dtpInvoiceFromDate.TabIndex = 22;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(476, 17);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(298, 32);
            this.cmbSupplierName.TabIndex = 21;
            this.cmbSupplierName.Text = "Search By Supplier";
            // 
            // btnSearchSupplierAndDates
            // 
            this.btnSearchSupplierAndDates.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSearchSupplierAndDates.FlatAppearance.BorderSize = 10;
            this.btnSearchSupplierAndDates.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchSupplierAndDates.ForeColor = System.Drawing.Color.Crimson;
            this.btnSearchSupplierAndDates.Location = new System.Drawing.Point(476, 54);
            this.btnSearchSupplierAndDates.Name = "btnSearchSupplierAndDates";
            this.btnSearchSupplierAndDates.Size = new System.Drawing.Size(298, 31);
            this.btnSearchSupplierAndDates.TabIndex = 20;
            this.btnSearchSupplierAndDates.Text = "Search Invoice";
            this.btnSearchSupplierAndDates.UseVisualStyleBackColor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(368, 21);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(109, 20);
            this.lblSupplier.TabIndex = 19;
            this.lblSupplier.Text = "SupplierName";
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSearchInvoice.FlatAppearance.BorderSize = 10;
            this.btnSearchInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnSearchInvoice.Location = new System.Drawing.Point(96, 55);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(246, 30);
            this.btnSearchInvoice.TabIndex = 17;
            this.btnSearchInvoice.Text = "Search Invoice";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceNo.Location = new System.Drawing.Point(6, 21);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(83, 20);
            this.lblInvoiceNo.TabIndex = 16;
            this.lblInvoiceNo.Text = "Invoice.No";
            // 
            // txtSearchInvoice
            // 
            this.txtSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchInvoice.Location = new System.Drawing.Point(96, 18);
            this.txtSearchInvoice.Multiline = true;
            this.txtSearchInvoice.Name = "txtSearchInvoice";
            this.txtSearchInvoice.Size = new System.Drawing.Size(246, 31);
            this.txtSearchInvoice.TabIndex = 15;
            this.txtSearchInvoice.Text = "Search Invoice";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.grpTotals);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lblCurrentBill);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Purchase Entry";
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.Tax);
            this.grpTotals.Controls.Add(this.lblNetAmount);
            this.grpTotals.Controls.Add(this.lblDiscountAmount);
            this.grpTotals.Controls.Add(this.txtTax);
            this.grpTotals.Controls.Add(this.lblInvoiceAmount);
            this.grpTotals.Controls.Add(this.txtNetAmount);
            this.grpTotals.Controls.Add(this.txtDiscount);
            this.grpTotals.Controls.Add(this.txtInvoiceAmount);
            this.grpTotals.ForeColor = System.Drawing.Color.White;
            this.grpTotals.Location = new System.Drawing.Point(898, 370);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(259, 305);
            this.grpTotals.TabIndex = 6;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Calculations";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.ForeColor = System.Drawing.Color.White;
            this.Tax.Location = new System.Drawing.Point(2, 155);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(130, 20);
            this.Tax.TabIndex = 25;
            this.Tax.Text = "Tax (Percentage)";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.ForeColor = System.Drawing.Color.White;
            this.lblNetAmount.Location = new System.Drawing.Point(3, 229);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(94, 20);
            this.lblNetAmount.TabIndex = 23;
            this.lblNetAmount.Text = "Net Amount";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.ForeColor = System.Drawing.Color.White;
            this.lblDiscountAmount.Location = new System.Drawing.Point(3, 84);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(132, 20);
            this.lblDiscountAmount.TabIndex = 22;
            this.lblDiscountAmount.Text = "Discount Amount";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTax.Location = new System.Drawing.Point(6, 178);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(246, 43);
            this.txtTax.TabIndex = 16;
            this.txtTax.Text = "0";
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(4, 14);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(119, 20);
            this.lblInvoiceAmount.TabIndex = 21;
            this.lblInvoiceAmount.Text = "Invoice Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNetAmount.Location = new System.Drawing.Point(7, 252);
            this.txtNetAmount.Multiline = true;
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(246, 43);
            this.txtNetAmount.TabIndex = 17;
            this.txtNetAmount.Text = "0";
            this.txtNetAmount.Enter += new System.EventHandler(this.txtNetAmount_Enter);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDiscount.Location = new System.Drawing.Point(6, 107);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(246, 43);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.Text = "0";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Enabled = false;
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtInvoiceAmount.Location = new System.Drawing.Point(7, 38);
            this.txtInvoiceAmount.Multiline = true;
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(246, 43);
            this.txtInvoiceAmount.TabIndex = 14;
            this.txtInvoiceAmount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearchInvoiceNumber);
            this.groupBox3.Controls.Add(this.btnCreateInvoice);
            this.groupBox3.Controls.Add(this.txtInvoiceNumber);
            this.groupBox3.Controls.Add(this.btnDeleteInvoice);
            this.groupBox3.Controls.Add(this.btnSuspendInvoice);
            this.groupBox3.Controls.Add(this.btnSaveInvoice);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(898, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 357);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // txtSearchInvoiceNumber
            // 
            this.txtSearchInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchInvoiceNumber.Location = new System.Drawing.Point(6, 18);
            this.txtSearchInvoiceNumber.Multiline = true;
            this.txtSearchInvoiceNumber.Name = "txtSearchInvoiceNumber";
            this.txtSearchInvoiceNumber.Size = new System.Drawing.Size(246, 31);
            this.txtSearchInvoiceNumber.TabIndex = 14;
            this.txtSearchInvoiceNumber.Text = "Search Invoice";
            this.txtSearchInvoiceNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchInvoiceNumber_KeyDown);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCreateInvoice.FlatAppearance.BorderSize = 10;
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnCreateInvoice.Location = new System.Drawing.Point(6, 84);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(246, 64);
            this.btnCreateInvoice.TabIndex = 13;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Enabled = false;
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInvoiceNumber.Location = new System.Drawing.Point(6, 51);
            this.txtInvoiceNumber.Multiline = true;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(246, 31);
            this.txtInvoiceNumber.TabIndex = 12;
            this.txtInvoiceNumber.Text = "Invoice#";
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteInvoice.FlatAppearance.BorderSize = 10;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(6, 282);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(246, 64);
            this.btnDeleteInvoice.TabIndex = 20;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnSuspendInvoice
            // 
            this.btnSuspendInvoice.Enabled = false;
            this.btnSuspendInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSuspendInvoice.FlatAppearance.BorderSize = 10;
            this.btnSuspendInvoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspendInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnSuspendInvoice.Location = new System.Drawing.Point(6, 216);
            this.btnSuspendInvoice.Name = "btnSuspendInvoice";
            this.btnSuspendInvoice.Size = new System.Drawing.Size(246, 64);
            this.btnSuspendInvoice.TabIndex = 19;
            this.btnSuspendInvoice.Text = "Suspend Invoice";
            this.btnSuspendInvoice.UseVisualStyleBackColor = true;
            this.btnSuspendInvoice.Click += new System.EventHandler(this.btnSuspendInvoice_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Enabled = false;
            this.btnSaveInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 10;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnSaveInvoice.Location = new System.Drawing.Point(6, 150);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(246, 64);
            this.btnSaveInvoice.TabIndex = 18;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // lblCurrentBill
            // 
            this.lblCurrentBill.Controls.Add(this.dgvPinvoiceProducts);
            this.lblCurrentBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentBill.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentBill.Location = new System.Drawing.Point(5, 318);
            this.lblCurrentBill.Name = "lblCurrentBill";
            this.lblCurrentBill.Size = new System.Drawing.Size(886, 357);
            this.lblCurrentBill.TabIndex = 4;
            this.lblCurrentBill.TabStop = false;
            this.lblCurrentBill.Text = "Current Bill";
            // 
            // dgvPinvoiceProducts
            // 
            this.dgvPinvoiceProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPinvoiceProducts.Location = new System.Drawing.Point(4, 16);
            this.dgvPinvoiceProducts.Name = "dgvPinvoiceProducts";
            this.dgvPinvoiceProducts.Size = new System.Drawing.Size(876, 336);
            this.dgvPinvoiceProducts.TabIndex = 0;
            this.dgvPinvoiceProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPinvoiceProducts_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetInvoice);
            this.groupBox2.Controls.Add(this.lblProductID);
            this.groupBox2.Controls.Add(this.txtProductID);
            this.groupBox2.Controls.Add(this.btnUpdateInvoice);
            this.groupBox2.Controls.Add(this.btnDeleteFromInvoice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearchBarcode);
            this.groupBox2.Controls.Add(this.lblExpiry);
            this.groupBox2.Controls.Add(this.dtpExpiry);
            this.groupBox2.Controls.Add(this.btnAddToInvoice);
            this.groupBox2.Controls.Add(this.lblTotalAmount);
            this.groupBox2.Controls.Add(this.txtTotalAmount);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lblSalePrice);
            this.groupBox2.Controls.Add(this.txtSalePrice);
            this.groupBox2.Controls.Add(this.lblCostPrice);
            this.groupBox2.Controls.Add(this.txtCostPrice);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(346, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Entry";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnResetInvoice
            // 
            this.btnResetInvoice.Enabled = false;
            this.btnResetInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnResetInvoice.FlatAppearance.BorderSize = 10;
            this.btnResetInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnResetInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetInvoice.Location = new System.Drawing.Point(158, 274);
            this.btnResetInvoice.Name = "btnResetInvoice";
            this.btnResetInvoice.Size = new System.Drawing.Size(378, 30);
            this.btnResetInvoice.TabIndex = 21;
            this.btnResetInvoice.Text = "Reset Invoice";
            this.btnResetInvoice.UseVisualStyleBackColor = true;
            this.btnResetInvoice.Click += new System.EventHandler(this.btnResetInvoice_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(26, 220);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(26, 20);
            this.lblProductID.TabIndex = 20;
            this.lblProductID.Text = "ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtProductID.Location = new System.Drawing.Point(30, 243);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(114, 60);
            this.txtProductID.TabIndex = 19;
            this.txtProductID.Text = "ID";
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Enabled = false;
            this.btnUpdateInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUpdateInvoice.FlatAppearance.BorderSize = 10;
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdateInvoice.Location = new System.Drawing.Point(158, 242);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(378, 30);
            this.btnUpdateInvoice.TabIndex = 18;
            this.btnUpdateInvoice.Text = "Update To Invoice";
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
            // 
            // btnDeleteFromInvoice
            // 
            this.btnDeleteFromInvoice.Enabled = false;
            this.btnDeleteFromInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteFromInvoice.FlatAppearance.BorderSize = 10;
            this.btnDeleteFromInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteFromInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteFromInvoice.Location = new System.Drawing.Point(158, 210);
            this.btnDeleteFromInvoice.Name = "btnDeleteFromInvoice";
            this.btnDeleteFromInvoice.Size = new System.Drawing.Size(378, 30);
            this.btnDeleteFromInvoice.TabIndex = 17;
            this.btnDeleteFromInvoice.Text = "Delete From Invoice";
            this.btnDeleteFromInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteFromInvoice.Click += new System.EventHandler(this.btnDeleteFromInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Barcode";
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchBarcode.Location = new System.Drawing.Point(158, 20);
            this.txtSearchBarcode.Multiline = true;
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.Size = new System.Drawing.Size(378, 30);
            this.txtSearchBarcode.TabIndex = 1;
            this.txtSearchBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBarcode_KeyDown);
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiry.ForeColor = System.Drawing.Color.White;
            this.lblExpiry.Location = new System.Drawing.Point(26, 156);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(90, 20);
            this.lblExpiry.TabIndex = 14;
            this.lblExpiry.Text = "Expiry Date";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Enabled = false;
            this.dtpExpiry.Location = new System.Drawing.Point(158, 152);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(378, 23);
            this.dtpExpiry.TabIndex = 7;
            // 
            // btnAddToInvoice
            // 
            this.btnAddToInvoice.Enabled = false;
            this.btnAddToInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAddToInvoice.FlatAppearance.BorderSize = 10;
            this.btnAddToInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddToInvoice.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddToInvoice.Location = new System.Drawing.Point(158, 178);
            this.btnAddToInvoice.Name = "btnAddToInvoice";
            this.btnAddToInvoice.Size = new System.Drawing.Size(378, 30);
            this.btnAddToInvoice.TabIndex = 8;
            this.btnAddToInvoice.Text = "Add To Invoice";
            this.btnAddToInvoice.UseVisualStyleBackColor = true;
            this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(326, 124);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(96, 20);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Tot. Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalAmount.Location = new System.Drawing.Point(422, 119);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(114, 30);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(26, 123);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(158, 119);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(114, 30);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.Text = "0";
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblSalePrice.Location = new System.Drawing.Point(326, 95);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(80, 20);
            this.lblSalePrice.TabIndex = 7;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Enabled = false;
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSalePrice.Location = new System.Drawing.Point(422, 86);
            this.txtSalePrice.Multiline = true;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(114, 30);
            this.txtSalePrice.TabIndex = 4;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.ForeColor = System.Drawing.Color.White;
            this.lblCostPrice.Location = new System.Drawing.Point(26, 90);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(81, 20);
            this.lblCostPrice.TabIndex = 5;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Enabled = false;
            this.txtCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCostPrice.Location = new System.Drawing.Point(158, 86);
            this.txtCostPrice.Multiline = true;
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(114, 30);
            this.txtCostPrice.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(26, 57);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 20);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProductName.Location = new System.Drawing.Point(158, 53);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(378, 30);
            this.txtProductName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSupplierID);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.lblSupplierCompany);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.lblSupplierName);
            this.groupBox1.Controls.Add(this.txtSearchSupplier);
            this.groupBox1.Controls.Add(this.lblSearchBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Information";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.White;
            this.lblSupplierID.Location = new System.Drawing.Point(5, 227);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(21, 17);
            this.lblSupplierID.TabIndex = 13;
            this.lblSupplierID.Text = "ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSupplierID.Location = new System.Drawing.Point(7, 255);
            this.txtSupplierID.Multiline = true;
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(109, 48);
            this.txtSupplierID.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(122, 189);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 114);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(4, 193);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(122, 155);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 28);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(4, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone.Location = new System.Drawing.Point(122, 121);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 28);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(4, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone";
            // 
            // txtCompany
            // 
            this.txtCompany.Enabled = false;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCompany.Location = new System.Drawing.Point(122, 87);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(208, 28);
            this.txtCompany.TabIndex = 4;
            // 
            // lblSupplierCompany
            // 
            this.lblSupplierCompany.AutoSize = true;
            this.lblSupplierCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierCompany.ForeColor = System.Drawing.Color.White;
            this.lblSupplierCompany.Location = new System.Drawing.Point(4, 91);
            this.lblSupplierCompany.Name = "lblSupplierCompany";
            this.lblSupplierCompany.Size = new System.Drawing.Size(67, 17);
            this.lblSupplierCompany.TabIndex = 5;
            this.lblSupplierCompany.Text = "Company";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSupplierName.Location = new System.Drawing.Point(122, 53);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(208, 28);
            this.txtSupplierName.TabIndex = 2;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplierName.ForeColor = System.Drawing.Color.White;
            this.lblSupplierName.Location = new System.Drawing.Point(4, 57);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(101, 17);
            this.lblSupplierName.TabIndex = 3;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchSupplier.Location = new System.Drawing.Point(122, 19);
            this.txtSearchSupplier.Multiline = true;
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(208, 28);
            this.txtSearchSupplier.TabIndex = 0;
            this.txtSearchSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSupplier_KeyDown);
            // 
            // lblSearchBarcode
            // 
            this.lblSearchBarcode.AutoSize = true;
            this.lblSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchBarcode.ForeColor = System.Drawing.Color.White;
            this.lblSearchBarcode.Location = new System.Drawing.Point(4, 23);
            this.lblSearchBarcode.Name = "lblSearchBarcode";
            this.lblSearchBarcode.Size = new System.Drawing.Size(109, 17);
            this.lblSearchBarcode.TabIndex = 1;
            this.lblSearchBarcode.Text = "Search Supplier";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 705);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1162, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            // 
            // PurchaseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1173, 712);
            this.Controls.Add(this.tabControl1);
            this.Name = "PurchaseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseManagement";
            this.tabPage2.ResumeLayout(false);
            this.grpAllInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).EndInit();
            this.searchGrpBx.ResumeLayout(false);
            this.searchGrpBx.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.lblCurrentBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPinvoiceProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblSearchBarcode;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddToInvoice;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblSupplierCompany;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.GroupBox lblCurrentBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBarcode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView dgvPinvoiceProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteFromInvoice;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnSuspendInvoice;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.Button btnResetInvoice;
        private System.Windows.Forms.TextBox txtSearchInvoiceNumber;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.GroupBox searchGrpBx;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpInvoiceToDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceFromDate;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.Button btnSearchSupplierAndDates;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtSearchInvoice;
        private System.Windows.Forms.GroupBox grpAllInvoices;
        private System.Windows.Forms.DataGridView dgvAllInvoices;
    }
}