namespace CEPOS.UI
{
    partial class SalesManagement
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
            this.ScanProduct = new System.Windows.Forms.Label();
            this.txtSalesProductScan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSalesProduct = new System.Windows.Forms.DataGridView();
            this.Tax = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesProduct)).BeginInit();
            this.grpTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanProduct
            // 
            this.ScanProduct.AutoSize = true;
            this.ScanProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanProduct.ForeColor = System.Drawing.Color.White;
            this.ScanProduct.Location = new System.Drawing.Point(61, 39);
            this.ScanProduct.Name = "ScanProduct";
            this.ScanProduct.Size = new System.Drawing.Size(123, 25);
            this.ScanProduct.TabIndex = 18;
            this.ScanProduct.Text = "Scan Product";
            // 
            // txtSalesProductScan
            // 
            this.txtSalesProductScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSalesProductScan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesProductScan.Location = new System.Drawing.Point(190, 36);
            this.txtSalesProductScan.Multiline = true;
            this.txtSalesProductScan.Name = "txtSalesProductScan";
            this.txtSalesProductScan.Size = new System.Drawing.Size(358, 35);
            this.txtSalesProductScan.TabIndex = 17;
            this.txtSalesProductScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalesProductScan_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalesProductScan);
            this.groupBox1.Controls.Add(this.ScanProduct);
            this.groupBox1.Location = new System.Drawing.Point(37, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSalesProduct);
            this.groupBox2.Location = new System.Drawing.Point(37, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 450);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Invoice";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvSalesProduct
            // 
            this.dgvSalesProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesProduct.Location = new System.Drawing.Point(7, 20);
            this.dgvSalesProduct.Name = "dgvSalesProduct";
            this.dgvSalesProduct.Size = new System.Drawing.Size(601, 424);
            this.dgvSalesProduct.TabIndex = 0;
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.ForeColor = System.Drawing.Color.White;
            this.Tax.Location = new System.Drawing.Point(2, 153);
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
            this.lblNetAmount.Location = new System.Drawing.Point(3, 227);
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
            this.lblDiscountAmount.Location = new System.Drawing.Point(3, 82);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(132, 20);
            this.lblDiscountAmount.TabIndex = 22;
            this.lblDiscountAmount.Text = "Discount Amount";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtTax.Location = new System.Drawing.Point(6, 176);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(340, 43);
            this.txtTax.TabIndex = 16;
            this.txtTax.Text = "0";
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(4, 12);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(119, 20);
            this.lblInvoiceAmount.TabIndex = 21;
            this.lblInvoiceAmount.Text = "Invoice Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNetAmount.Location = new System.Drawing.Point(7, 250);
            this.txtNetAmount.Multiline = true;
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(339, 43);
            this.txtNetAmount.TabIndex = 17;
            this.txtNetAmount.Text = "0";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDiscount.Location = new System.Drawing.Point(6, 105);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(340, 43);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.Text = "0";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Enabled = false;
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtInvoiceAmount.Location = new System.Drawing.Point(7, 36);
            this.txtInvoiceAmount.Multiline = true;
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(339, 43);
            this.txtInvoiceAmount.TabIndex = 14;
            this.txtInvoiceAmount.Text = "0";
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.button1);
            this.grpTotals.Controls.Add(this.Tax);
            this.grpTotals.Controls.Add(this.lblNetAmount);
            this.grpTotals.Controls.Add(this.lblDiscountAmount);
            this.grpTotals.Controls.Add(this.txtTax);
            this.grpTotals.Controls.Add(this.lblInvoiceAmount);
            this.grpTotals.Controls.Add(this.txtNetAmount);
            this.grpTotals.Controls.Add(this.txtDiscount);
            this.grpTotals.Controls.Add(this.txtInvoiceAmount);
            this.grpTotals.ForeColor = System.Drawing.Color.White;
            this.grpTotals.Location = new System.Drawing.Point(676, 166);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Size = new System.Drawing.Size(352, 450);
            this.grpTotals.TabIndex = 21;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Calculations";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 144);
            this.button1.TabIndex = 26;
            this.button1.Text = "Print Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1040, 651);
            this.Controls.Add(this.grpTotals);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesProduct)).EndInit();
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ScanProduct;
        private System.Windows.Forms.TextBox txtSalesProductScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSalesProduct;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.Button button1;
    }
}