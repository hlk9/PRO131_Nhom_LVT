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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            txtUserName = new Telerik.WinControls.UI.RadTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new Telerik.WinControls.UI.RadTextBox();
            lblForgot = new Label();
            btnLogin = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            radPictureBox2 = new Telerik.WinControls.UI.RadPictureBox();
            ((System.ComponentModel.ISupportInitialize)txtUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.BackColor = Color.WhiteSmoke;
            txtUserName.Location = new Point(371, 224);
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
            label1.Location = new Point(274, 235);
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
            label2.Location = new Point(260, 98);
            label2.Name = "label2";
            label2.Size = new Size(429, 31);
            label2.TabIndex = 3;
            label2.Text = "Hệ thống thi trắc nghiệm Testify";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(274, 332);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(371, 330);
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
            lblForgot.Location = new Point(547, 390);
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
            btnLogin.Location = new Point(371, 449);
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
            radButton2.Location = new Point(537, 449);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(120, 36);
            radButton2.TabIndex = 7;
            radButton2.Text = "Thoát";
            radButton2.ThemeName = "MaterialTeal";
            radButton2.Click += radButton2_Click;
            // 
            // radPictureBox1
            // 
            radPictureBox1.Image = Properties.Resources.question_and_answer;
            radPictureBox1.Location = new Point(12, 407);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(256, 220);
            radPictureBox1.TabIndex = 8;
            radPictureBox1.ThemeName = "MaterialTeal";
            // 
            // radPictureBox2
            // 
            radPictureBox2.Image = Properties.Resources.logoForTestify;
            radPictureBox2.Location = new Point(891, 12);
            radPictureBox2.Name = "radPictureBox2";
            radPictureBox2.Size = new Size(82, 73);
            radPictureBox2.TabIndex = 10;
            radPictureBox2.ThemeName = "MaterialTeal";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 639);
            Controls.Add(radPictureBox2);
            Controls.Add(radButton2);
            Controls.Add(btnLogin);
            Controls.Add(lblForgot);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(radPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPictureBox2).EndInit();
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
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox2;
    }
}
