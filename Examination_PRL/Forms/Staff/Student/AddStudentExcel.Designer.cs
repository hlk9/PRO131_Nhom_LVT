namespace Examination_PRL.Forms.Staff.Student
{
    partial class AddStudentExcel
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
            radTxtFile = new Telerik.WinControls.UI.RadTextBox();
            radBtnSelectFile = new Telerik.WinControls.UI.RadButton();
            radBtnSave = new Telerik.WinControls.UI.RadButton();
            radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)radTxtFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSelectFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radTxtFile
            // 
            radTxtFile.Location = new Point(12, 12);
            radTxtFile.Name = "radTxtFile";
            radTxtFile.Size = new Size(523, 37);
            radTxtFile.TabIndex = 0;
            radTxtFile.ThemeName = "MaterialTeal";
            // 
            // radBtnSelectFile
            // 
            radBtnSelectFile.BackColor = Color.Teal;
            radBtnSelectFile.ForeColor = Color.White;
            radBtnSelectFile.Location = new Point(541, 12);
            radBtnSelectFile.Name = "radBtnSelectFile";
            radBtnSelectFile.Size = new Size(175, 36);
            radBtnSelectFile.TabIndex = 1;
            radBtnSelectFile.Text = "Select File";
            radBtnSelectFile.ThemeName = "MaterialTeal";
            radBtnSelectFile.Click += radBtnSelectFile_Click;
            // 
            // radBtnSave
            // 
            radBtnSave.Location = new Point(207, 67);
            radBtnSave.Name = "radBtnSave";
            radBtnSave.Size = new Size(266, 36);
            radBtnSave.TabIndex = 2;
            radBtnSave.Text = "Nhập";
            radBtnSave.ThemeName = "MaterialTeal";
            radBtnSave.Click += radBtnSave_Click;
            // 
            // AddStudentExcel
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 115);
            Controls.Add(radBtnSave);
            Controls.Add(radBtnSelectFile);
            Controls.Add(radTxtFile);
            Name = "AddStudentExcel";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radTxtFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSelectFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox radTxtFile;
        private Telerik.WinControls.UI.RadButton radBtnSelectFile;
        private Telerik.WinControls.UI.RadButton radBtnSave;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}
