namespace Examination_PRL.Forms
{
    partial class ForgotPassword
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
            txtEmail = new Telerik.WinControls.UI.RadTextBox();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            lblError = new Label();
            btnSubmit = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.NullText = "Nhập email";
            txtEmail.ShowNullText = true;
            txtEmail.Size = new Size(286, 37);
            txtEmail.TabIndex = 0;
            txtEmail.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(125, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(206, 33);
            radLabel1.TabIndex = 1;
            radLabel1.Text = "Khôi phục mật khẩu";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(35, 110);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(63, 18);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "Nhập Email";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(125, 138);
            lblError.Name = "lblError";
            lblError.Size = new Size(257, 34);
            lblError.TabIndex = 31;
            lblError.Text = "Nếu email được liên kết với tài khoản,\r\nhệ thống sẽ cấp mật khẩu mới qua email";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(35, 205);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 36);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.ThemeName = "MaterialTeal";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(291, 205);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(120, 36);
            radButton2.TabIndex = 33;
            radButton2.Text = "Thoát";
            radButton2.ThemeName = "MaterialTeal";
            radButton2.Click += radButton2_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 286);
            Controls.Add(radButton2);
            Controls.Add(btnSubmit);
            Controls.Add(lblError);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Controls.Add(txtEmail);
            Name = "ForgotPassword";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ForgotPassword";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmit).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Label lblError;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
