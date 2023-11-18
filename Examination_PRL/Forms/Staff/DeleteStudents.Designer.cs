namespace Examination_PRL.Forms.Staff
{
    partial class DeleteStudents
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
            examGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            SuspendLayout();
            // 
            // DeleteStudents
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            // 
            // examGridView
            // 
            examGridView.Dock = DockStyle.Fill;
            examGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowAddNewRow = false;
            examGridView.MasterTemplate.AllowSearchRow = true;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examGridView.Name = "examGridView";
            examGridView.ReadOnly = true;
            examGridView.Size = new Size(800, 500);
            examGridView.TabIndex = 0;
            examGridView.ThemeName = "MaterialTeal";
            examGridView.UserDeletingRow += examGridView_UserDeletingRow;
            examGridView.ContextMenuOpening += examGridView_ContextMenuOpening;
            Controls.Add(examGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteStudents";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "DeleteStudents";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView examGridView;
    }
}
