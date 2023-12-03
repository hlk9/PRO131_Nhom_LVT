namespace Examination_PRL.Forms.Staff.Exam
{
    partial class GetListQnA
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
            gridViewQ = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewQ.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // gridViewQ
            // 
            gridViewQ.Dock = DockStyle.Fill;
            gridViewQ.Location = new Point(0, 0);
            // 
            // 
            // 
            gridViewQ.MasterTemplate.ViewDefinition = tableViewDefinition2;
            gridViewQ.Name = "gridViewQ";
            gridViewQ.Size = new Size(1354, 633);
            gridViewQ.TabIndex = 0;
            gridViewQ.ThemeName = "MaterialTeal";
            // 
            // GetListQnA
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 633);
            Controls.Add(gridViewQ);
            Name = "GetListQnA";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "GetListQnA";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)gridViewQ.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView gridViewQ;
    }
}
