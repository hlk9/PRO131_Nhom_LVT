namespace Examination_PRL.Forms.Staff
{
    partial class ListQA
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
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radGridView1
            // 
            radGridView1.Dock = DockStyle.Fill;
            radGridView1.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridView1.MasterTemplate.AllowAddNewRow = false;
            radGridView1.MasterTemplate.AllowSearchRow = true;
            radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridView1.MasterTemplate.EnablePaging = true;
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.ReadOnly = true;
            radGridView1.Size = new Size(1135, 659);
            radGridView1.TabIndex = 0;
            radGridView1.ThemeName = "MaterialTeal";
            // 
            // ListQA
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 659);
            Controls.Add(radGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListQA";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ListQA";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
