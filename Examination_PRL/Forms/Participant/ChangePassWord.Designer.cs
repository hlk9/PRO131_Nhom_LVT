﻿namespace Examination_PRL.Forms.Staff
{
    partial class ChangePassWord
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
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radTxtPassCu = new Telerik.WinControls.UI.RadTextBox();
            radTxtPassMoi = new Telerik.WinControls.UI.RadTextBox();
            radTxtPassMoiNL = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radBtnChange = new Telerik.WinControls.UI.RadButton();
            radBtnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassCu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassMoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassMoiNL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.AutoSize = false;
            radLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(12, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(346, 42);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Đổi Mật Khẩu";
            radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.AutoSize = false;
            radLabel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel2.Location = new Point(12, 77);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(346, 30);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Mật khẩu cũ:";
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.AutoSize = false;
            radLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel3.Location = new Point(12, 165);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(346, 30);
            radLabel3.TabIndex = 2;
            radLabel3.Text = "Mật khẩu mới:";
            // 
            // radTxtPassCu
            // 
            radTxtPassCu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtPassCu.Location = new Point(12, 113);
            radTxtPassCu.Name = "radTxtPassCu";
            radTxtPassCu.PasswordChar = '●';
            radTxtPassCu.Size = new Size(346, 37);
            radTxtPassCu.TabIndex = 3;
            radTxtPassCu.ThemeName = "MaterialTeal";
            radTxtPassCu.UseSystemPasswordChar = true;
            // 
            // radTxtPassMoi
            // 
            radTxtPassMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtPassMoi.Location = new Point(12, 201);
            radTxtPassMoi.Name = "radTxtPassMoi";
            radTxtPassMoi.PasswordChar = '●';
            radTxtPassMoi.Size = new Size(346, 37);
            radTxtPassMoi.TabIndex = 4;
            radTxtPassMoi.ThemeName = "MaterialTeal";
            radTxtPassMoi.UseSystemPasswordChar = true;
            // 
            // radTxtPassMoiNL
            // 
            radTxtPassMoiNL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtPassMoiNL.Location = new Point(12, 290);
            radTxtPassMoiNL.Name = "radTxtPassMoiNL";
            radTxtPassMoiNL.PasswordChar = '●';
            radTxtPassMoiNL.Size = new Size(346, 37);
            radTxtPassMoiNL.TabIndex = 4;
            radTxtPassMoiNL.ThemeName = "MaterialTeal";
            radTxtPassMoiNL.UseSystemPasswordChar = true;
            // 
            // radLabel4
            // 
            radLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel4.AutoSize = false;
            radLabel4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel4.Location = new Point(12, 254);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(346, 30);
            radLabel4.TabIndex = 3;
            radLabel4.Text = "Nhập lại mật khẩu mới:";
            // 
            // radBtnChange
            // 
            radBtnChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radBtnChange.BackColor = Color.Teal;
            radBtnChange.ForeColor = Color.White;
            radBtnChange.Location = new Point(108, 397);
            radBtnChange.Name = "radBtnChange";
            radBtnChange.Size = new Size(122, 42);
            radBtnChange.TabIndex = 5;
            radBtnChange.Text = "Lưu";
            radBtnChange.ThemeName = "MaterialTeal";
            radBtnChange.Click += radBtnChange_Click;
            // 
            // radBtnClose
            // 
            radBtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radBtnClose.BackColor = Color.Teal;
            radBtnClose.ForeColor = Color.White;
            radBtnClose.Location = new Point(236, 397);
            radBtnClose.Name = "radBtnClose";
            radBtnClose.Size = new Size(122, 42);
            radBtnClose.TabIndex = 6;
            radBtnClose.Text = "Thoát";
            radBtnClose.ThemeName = "MaterialTeal";
            radBtnClose.Click += radBtnClose_Click;
            // 
            // ChangePassWord
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 451);
            Controls.Add(radBtnClose);
            Controls.Add(radBtnChange);
            Controls.Add(radLabel4);
            Controls.Add(radTxtPassMoiNL);
            Controls.Add(radTxtPassMoi);
            Controls.Add(radTxtPassCu);
            Controls.Add(radLabel3);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ChangePassWord";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassWord";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassCu).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassMoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassMoiNL).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox radTxtPassCu;
        private Telerik.WinControls.UI.RadTextBox radTxtPassMoi;
        private Telerik.WinControls.UI.RadTextBox radTxtPassMoiNL;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton radBtnChange;
        private Telerik.WinControls.UI.RadButton radBtnClose;
    }
}
