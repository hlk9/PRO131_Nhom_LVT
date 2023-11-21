namespace Examination_PRL.Forms
{
    partial class Login
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
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            txtUserName = new Telerik.WinControls.UI.RadTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new Telerik.WinControls.UI.RadTextBox();
            lblForgot = new Label();
            btnLogin = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)txtUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.BackColor = Color.WhiteSmoke;
            txtUserName.Location = new Point(277, 125);
            txtUserName.Name = "txtUserName";
            txtUserName.NullText = "Nhập tên tài khoản";
            txtUserName.Size = new Size(286, 37);
            txtUserName.TabIndex = 1;
            txtUserName.ThemeName = "MaterialTeal";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(180, 136);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(119, 34);
            label2.Name = "label2";
            label2.Size = new Size(523, 31);
            label2.TabIndex = 3;
            label2.Text = "Chào mừng tới hệ thống thi trắc nghiệm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(180, 233);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(277, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.NullText = "Nhập mật khẩu";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(286, 37);
            txtPassword.TabIndex = 2;
            txtPassword.ThemeName = "MaterialTeal";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblForgot
            // 
            lblForgot.Anchor = AnchorStyles.None;
            lblForgot.AutoSize = true;
            lblForgot.ForeColor = Color.IndianRed;
            lblForgot.Location = new Point(453, 291);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(110, 17);
            lblForgot.TabIndex = 5;
            lblForgot.Text = "Quên mật khẩu?";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Teal;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(277, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 36);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.ThemeName = "MaterialTeal";
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyPress += btnLogin_KeyPress;
            // 
            // radButton2
            // 
            radButton2.Anchor = AnchorStyles.None;
            radButton2.BackColor = Color.IndianRed;
            radButton2.ForeColor = Color.White;
            radButton2.Location = new Point(443, 350);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(120, 36);
            radButton2.TabIndex = 7;
            radButton2.Text = "Thoát";
            radButton2.ThemeName = "MaterialTeal";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 459);
            Controls.Add(radButton2);
            Controls.Add(btnLogin);
            Controls.Add(lblForgot);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)txtUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Label lblForgot;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
