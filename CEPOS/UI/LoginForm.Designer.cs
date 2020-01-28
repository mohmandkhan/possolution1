namespace CEPOS.UI
{
    partial class LoginForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpEnterCredentials = new System.Windows.Forms.GroupBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.grpSelectRole = new System.Windows.Forms.GroupBox();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.grpSelectServer = new System.Windows.Forms.GroupBox();
            this.lblSelectServer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpEnterCredentials.SuspendLayout();
            this.grpSelectRole.SuspendLayout();
            this.grpSelectServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(126, 31);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 30);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(14, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 30);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 30);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(126, 68);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // grpEnterCredentials
            // 
            this.grpEnterCredentials.Controls.Add(this.btnResetPassword);
            this.grpEnterCredentials.Controls.Add(this.btnLogin);
            this.grpEnterCredentials.Controls.Add(this.chkRememberMe);
            this.grpEnterCredentials.Controls.Add(this.txtUsername);
            this.grpEnterCredentials.Controls.Add(this.lblPassword);
            this.grpEnterCredentials.Controls.Add(this.lblUsername);
            this.grpEnterCredentials.Controls.Add(this.txtPassword);
            this.grpEnterCredentials.Location = new System.Drawing.Point(52, 149);
            this.grpEnterCredentials.Name = "grpEnterCredentials";
            this.grpEnterCredentials.Size = new System.Drawing.Size(363, 180);
            this.grpEnterCredentials.TabIndex = 4;
            this.grpEnterCredentials.TabStop = false;
            this.grpEnterCredentials.Text = "Enter Credentials";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(240, 129);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(106, 34);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset?";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(126, 105);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(95, 17);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // grpSelectRole
            // 
            this.grpSelectRole.Controls.Add(this.lblSelectRole);
            this.grpSelectRole.Controls.Add(this.cmbRole);
            this.grpSelectRole.Location = new System.Drawing.Point(52, 337);
            this.grpSelectRole.Name = "grpSelectRole";
            this.grpSelectRole.Size = new System.Drawing.Size(363, 65);
            this.grpSelectRole.TabIndex = 5;
            this.grpSelectRole.TabStop = false;
            this.grpSelectRole.Text = "Select Role";
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.AutoSize = true;
            this.lblSelectRole.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRole.Location = new System.Drawing.Point(14, 21);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(53, 30);
            this.lblSelectRole.TabIndex = 7;
            this.lblSelectRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 30;
            this.cmbRole.Location = new System.Drawing.Point(126, 17);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(220, 36);
            this.cmbRole.TabIndex = 0;
            // 
            // grpSelectServer
            // 
            this.grpSelectServer.Controls.Add(this.lblSelectServer);
            this.grpSelectServer.Controls.Add(this.comboBox1);
            this.grpSelectServer.Location = new System.Drawing.Point(52, 412);
            this.grpSelectServer.Name = "grpSelectServer";
            this.grpSelectServer.Size = new System.Drawing.Size(363, 65);
            this.grpSelectServer.TabIndex = 8;
            this.grpSelectServer.TabStop = false;
            this.grpSelectServer.Text = "Select Server";
            // 
            // lblSelectServer
            // 
            this.lblSelectServer.AutoSize = true;
            this.lblSelectServer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectServer.Location = new System.Drawing.Point(14, 21);
            this.lblSelectServer.Name = "lblSelectServer";
            this.lblSelectServer.Size = new System.Drawing.Size(70, 30);
            this.lblSelectServer.TabIndex = 7;
            this.lblSelectServer.Text = "Server";
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Location = new System.Drawing.Point(126, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 36);
            this.comboBox1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(151)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(456, 625);
            this.Controls.Add(this.grpSelectServer);
            this.Controls.Add(this.grpSelectRole);
            this.Controls.Add(this.grpEnterCredentials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.grpEnterCredentials.ResumeLayout(false);
            this.grpEnterCredentials.PerformLayout();
            this.grpSelectRole.ResumeLayout(false);
            this.grpSelectRole.PerformLayout();
            this.grpSelectServer.ResumeLayout(false);
            this.grpSelectServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpEnterCredentials;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpSelectRole;
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.GroupBox grpSelectServer;
        private System.Windows.Forms.Label lblSelectServer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}