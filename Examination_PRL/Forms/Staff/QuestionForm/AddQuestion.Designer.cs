namespace Examination_PRL.Forms.Staff.QuestionForm
{
    partial class AddQuestion
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
            btnImportExcel = new Telerik.WinControls.UI.RadButton();
            txtPath = new Telerik.WinControls.UI.RadTextBox();
            btnSelectFile = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)btnImportExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSelectFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // btnImportExcel
            // 
            btnImportExcel.Location = new Point(137, 206);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(120, 36);
            btnImportExcel.TabIndex = 0;
            btnImportExcel.Text = "Nhập";
            btnImportExcel.ThemeName = "MaterialTeal";
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 70);
            txtPath.Name = "txtPath";
            txtPath.NullText = "Đường dẫn file ";
            txtPath.ShowNullText = true;
            txtPath.Size = new Size(406, 37);
            txtPath.TabIndex = 1;
            txtPath.ThemeName = "MaterialTeal";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 28);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(120, 36);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Chọn File";
            btnSelectFile.ThemeName = "MaterialTeal";
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // AddQuestion
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 254);
            Controls.Add(btnSelectFile);
            Controls.Add(txtPath);
            Controls.Add(btnImportExcel);
            Name = "AddQuestion";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "AddQuestion";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)btnImportExcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPath).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSelectFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadButton btnImportExcel;
        private Telerik.WinControls.UI.RadTextBox txtPath;
        private Telerik.WinControls.UI.RadButton btnSelectFile;
    }
}
