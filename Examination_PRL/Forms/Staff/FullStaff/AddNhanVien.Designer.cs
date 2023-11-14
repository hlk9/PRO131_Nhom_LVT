namespace Examination_PRL
{
    partial class AddNhanVien
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
            dtg_Staff = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Staff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Staff.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dtg_Staff
            // 
            dtg_Staff.Dock = DockStyle.Fill;
            dtg_Staff.Location = new Point(0, 0);
            // 
            // 
            // 
            dtg_Staff.MasterTemplate.AllowSearchRow = true;
            dtg_Staff.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            dtg_Staff.MasterTemplate.EnablePaging = true;
            dtg_Staff.MasterTemplate.ViewDefinition = tableViewDefinition1;
            dtg_Staff.Name = "dtg_Staff";
            dtg_Staff.Size = new Size(778, 501);
            dtg_Staff.TabIndex = 0;
            dtg_Staff.ThemeName = "MaterialTeal";
            // 
            // AddNhanVien
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 501);
            Controls.Add(dtg_Staff);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddNhanVien";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "AddNhanVien";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)dtg_Staff.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Staff).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView dtg_Staff;
    }
}
