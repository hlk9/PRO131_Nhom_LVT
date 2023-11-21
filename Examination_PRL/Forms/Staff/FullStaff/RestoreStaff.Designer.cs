namespace Examination_PRL.Forms.Staff.FullStaff
{
    partial class RestoreStaff
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radLbl = new Telerik.WinControls.UI.RadLabel();
            radBtnRestore = new Telerik.WinControls.UI.RadButton();
            rad_Staff = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radLbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLbl
            // 
            radLbl.AutoSize = false;
            radLbl.Location = new Point(12, 12);
            radLbl.Name = "radLbl";
            radLbl.Size = new Size(893, 50);
            radLbl.TabIndex = 0;
            radLbl.Text = "0";
            radLbl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // radBtnRestore
            // 
            radBtnRestore.BackColor = Color.Teal;
            radBtnRestore.DialogResult = DialogResult.OK;
            radBtnRestore.ForeColor = Color.White;
            radBtnRestore.Location = new Point(911, 12);
            radBtnRestore.Name = "radBtnRestore";
            radBtnRestore.Size = new Size(305, 50);
            radBtnRestore.TabIndex = 1;
            radBtnRestore.Text = "Khôi Phục";
            radBtnRestore.ThemeName = "MaterialTeal";
            radBtnRestore.Click += radBtnRestore_Click;
            // 
            // rad_Staff
            // 
            rad_Staff.Location = new Point(12, 80);
            // 
            // 
            // 
            rad_Staff.MasterTemplate.AllowSearchRow = true;
            rad_Staff.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            rad_Staff.MasterTemplate.EnablePaging = true;
            rad_Staff.MasterTemplate.ViewDefinition = tableViewDefinition1;
            rad_Staff.Name = "rad_Staff";
            rad_Staff.Size = new Size(1204, 644);
            rad_Staff.TabIndex = 2;
            rad_Staff.ThemeName = "MaterialTeal";
            // 
            // RestoreStaff
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 736);
            Controls.Add(rad_Staff);
            Controls.Add(radBtnRestore);
            Controls.Add(radLbl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RestoreStaff";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "RestoreStaff";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLbl;
        private Telerik.WinControls.UI.RadButton radBtnRestore;
        private Telerik.WinControls.UI.RadGridView rad_Staff;
    }
}
