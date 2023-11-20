namespace Examination_PRL.Forms.Staff.Student
{
    partial class RestoreStudents
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radBtnRestore = new Telerik.WinControls.UI.RadButtonTextBox();
            examGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.AutoSize = false;
            radLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(12, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(672, 37);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "0";
            radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // radBtnRestore
            // 
            radBtnRestore.BackColor = Color.Teal;
            radBtnRestore.ForeColor = Color.White;
            radBtnRestore.Location = new Point(693, 12);
            radBtnRestore.Name = "radBtnRestore";
            radBtnRestore.Size = new Size(233, 37);
            radBtnRestore.TabIndex = 1;
            radBtnRestore.Text = "Khôi phục";
            radBtnRestore.TextAlign = HorizontalAlignment.Center;
            radBtnRestore.ThemeName = "MaterialTeal";
            radBtnRestore.Click += radBtnRestore_Click;
            // 
            // examGridView
            // 
            examGridView.Location = new Point(12, 66);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowAddNewRow = false;
            examGridView.MasterTemplate.AllowSearchRow = true;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            examGridView.Name = "examGridView";
            examGridView.ReadOnly = true;
            examGridView.Size = new Size(914, 429);
            examGridView.TabIndex = 2;
            examGridView.ThemeName = "MaterialTeal";
            examGridView.CellClick += examGridView_CellClick;
            // 
            // RestoreStudents
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 507);
            Controls.Add(examGridView);
            Controls.Add(radBtnRestore);
            Controls.Add(radLabel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RestoreStudents";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "RestoreStudents";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButtonTextBox radBtnRestore;
        private Telerik.WinControls.UI.RadGridView examGridView;
    }
}
