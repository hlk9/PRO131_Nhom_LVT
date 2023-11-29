namespace Examination_PRL.Forms.Staff
{
    partial class SubjectResult
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip2 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridView2 = new Telerik.WinControls.UI.RadGridView();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            documentTabStrip3 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolWindow4 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).BeginInit();
            documentTabStrip2.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView2.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip3).BeginInit();
            documentTabStrip3.SuspendLayout();
            toolWindow4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow2;
            radDock1.CausesValidation = false;
            radDock1.Controls.Add(documentContainer1);
            radDock1.Controls.Add(toolTabStrip1);
            radDock1.Dock = DockStyle.Fill;
            radDock1.DocumentTabsVisible = false;
            radDock1.IsCleanUpTarget = true;
            radDock1.Location = new Point(0, 0);
            radDock1.MainDocumentContainer = documentContainer1;
            radDock1.Name = "radDock1";
            radDock1.Padding = new Padding(0);
            // 
            // 
            // 
            radDock1.RootElement.MinSize = new Size(25, 25);
            radDock1.Size = new Size(1292, 586);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // documentContainer1
            // 
            documentContainer1.CausesValidation = false;
            documentContainer1.Controls.Add(documentTabStrip2);
            documentContainer1.Controls.Add(documentTabStrip3);
            documentContainer1.Name = "documentContainer1";
            documentContainer1.Orientation = Orientation.Horizontal;
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(948, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-126, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip2
            // 
            documentTabStrip2.CanUpdateChildIndex = true;
            documentTabStrip2.Controls.Add(toolWindow2);
            documentTabStrip2.Location = new Point(0, 0);
            documentTabStrip2.Name = "documentTabStrip2";
            // 
            // 
            // 
            documentTabStrip2.RootElement.MinSize = new Size(25, 25);
            documentTabStrip2.SelectedIndex = 0;
            documentTabStrip2.Size = new Size(958, 289);
            documentTabStrip2.SizeInfo.AutoSizeScale = new SizeF(0.0520169735F, 0F);
            documentTabStrip2.SizeInfo.SplitterCorrection = new Size(61, 0);
            documentTabStrip2.TabIndex = 0;
            documentTabStrip2.TabStop = false;
            documentTabStrip2.TabStripVisible = false;
            documentTabStrip2.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radGridView2);
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 4);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(950, 281);
            toolWindow2.Text = "toolWindow3";
            // 
            // radGridView2
            // 
            radGridView2.Dock = DockStyle.Fill;
            radGridView2.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridView2.MasterTemplate.AllowAddNewRow = false;
            radGridView2.MasterTemplate.AllowSearchRow = true;
            radGridView2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridView2.MasterTemplate.EnablePaging = true;
            radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView2.Name = "radGridView2";
            radGridView2.ReadOnly = true;
            radGridView2.Size = new Size(950, 281);
            radGridView2.TabIndex = 0;
            radGridView2.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow3);
            toolTabStrip1.Location = new Point(966, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(326, 586);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(326, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(126, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow3
            // 
            toolWindow3.Caption = null;
            toolWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow3.Location = new Point(4, 52);
            toolWindow3.Name = "toolWindow3";
            toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow3.Size = new Size(318, 530);
            toolWindow3.Text = "Thông Tin Chi Tiết";
            toolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // documentTabStrip3
            // 
            documentTabStrip3.CanUpdateChildIndex = true;
            documentTabStrip3.CausesValidation = false;
            documentTabStrip3.Controls.Add(toolWindow4);
            documentTabStrip3.Location = new Point(0, 297);
            documentTabStrip3.Name = "documentTabStrip3";
            // 
            // 
            // 
            documentTabStrip3.RootElement.MinSize = new Size(25, 25);
            documentTabStrip3.SelectedIndex = 0;
            documentTabStrip3.Size = new Size(958, 289);
            documentTabStrip3.TabIndex = 1;
            documentTabStrip3.TabStop = false;
            documentTabStrip3.TabStripVisible = false;
            documentTabStrip3.ThemeName = "MaterialTeal";
            // 
            // toolWindow4
            // 
            toolWindow4.Caption = null;
            toolWindow4.Controls.Add(radGridView1);
            toolWindow4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow4.Location = new Point(4, 4);
            toolWindow4.Name = "toolWindow4";
            toolWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Floating;
            toolWindow4.Size = new Size(950, 281);
            toolWindow4.Text = "toolWindow4";
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
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            radGridView1.Name = "radGridView1";
            radGridView1.ReadOnly = true;
            radGridView1.Size = new Size(950, 281);
            radGridView1.TabIndex = 0;
            radGridView1.ThemeName = "MaterialTeal";
            // 
            // SubjectResult
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 586);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubjectResult";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "SubjectResult";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).EndInit();
            documentTabStrip2.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridView2.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip3).EndInit();
            documentTabStrip3.ResumeLayout(false);
            toolWindow4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip3;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
