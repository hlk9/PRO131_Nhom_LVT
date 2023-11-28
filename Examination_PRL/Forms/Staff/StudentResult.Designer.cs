namespace Examination_PRL.Forms.Staff
{
    partial class StudentResult
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
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridViewStudent = new Telerik.WinControls.UI.RadGridView();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridViewExam = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radSplitContainer1).BeginInit();
            radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewStudent.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip2).BeginInit();
            toolTabStrip2.SuspendLayout();
            toolWindow3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow1;
            radDock1.CausesValidation = false;
            radDock1.Controls.Add(radSplitContainer1);
            radDock1.Controls.Add(toolTabStrip2);
            radDock1.Dock = DockStyle.Fill;
            radDock1.DocumentTabsVisible = false;
            radDock1.IsCleanUpTarget = true;
            radDock1.Location = new Point(0, 0);
            radDock1.MainDocumentContainer = documentContainer1;
            radDock1.Name = "radDock1";
            radDock1.Orientation = Orientation.Horizontal;
            radDock1.Padding = new Padding(0);
            // 
            // 
            // 
            radDock1.RootElement.MinSize = new Size(25, 25);
            radDock1.Size = new Size(1284, 1100);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(375, 626);
            toolWindow2.Text = "Thông Tin Chi Tiết";
            toolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radSplitContainer1
            // 
            radSplitContainer1.CausesValidation = false;
            radSplitContainer1.Controls.Add(documentContainer1);
            radSplitContainer1.Controls.Add(toolTabStrip1);
            radSplitContainer1.IsCleanUpTarget = true;
            radSplitContainer1.Location = new Point(0, 0);
            radSplitContainer1.Name = "radSplitContainer1";
            radSplitContainer1.Padding = new Padding(5);
            // 
            // 
            // 
            radSplitContainer1.RootElement.MinSize = new Size(25, 25);
            radSplitContainer1.Size = new Size(1284, 682);
            radSplitContainer1.SizeInfo.AbsoluteSize = new Size(200, 448);
            radSplitContainer1.SizeInfo.SplitterCorrection = new Size(0, -210);
            radSplitContainer1.SplitterWidth = 8;
            radSplitContainer1.TabIndex = 0;
            radSplitContainer1.TabStop = false;
            radSplitContainer1.ThemeName = "MaterialTeal";
            // 
            // documentContainer1
            // 
            documentContainer1.CausesValidation = false;
            documentContainer1.Controls.Add(documentTabStrip1);
            documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(885, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-183, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.CausesValidation = false;
            documentTabStrip1.Controls.Add(toolWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 0;
            documentTabStrip1.Size = new Size(893, 682);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radGridViewStudent);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(885, 674);
            toolWindow1.Text = "toolWindow2";
            // 
            // radGridViewStudent
            // 
            radGridViewStudent.Dock = DockStyle.Fill;
            radGridViewStudent.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridViewStudent.MasterTemplate.AllowAddNewRow = false;
            radGridViewStudent.MasterTemplate.AllowSearchRow = true;
            radGridViewStudent.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridViewStudent.MasterTemplate.EnablePaging = true;
            radGridViewStudent.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridViewStudent.Name = "radGridViewStudent";
            radGridViewStudent.ReadOnly = true;
            radGridViewStudent.Size = new Size(885, 674);
            radGridViewStudent.TabIndex = 0;
            radGridViewStudent.ThemeName = "MaterialTeal";
            radGridViewStudent.CellClick += radGridViewStudent_CellClick;
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow2);
            toolTabStrip1.Location = new Point(901, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(383, 682);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(383, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(183, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip2
            // 
            toolTabStrip2.CanUpdateChildIndex = true;
            toolTabStrip2.CausesValidation = false;
            toolTabStrip2.Controls.Add(toolWindow3);
            toolTabStrip2.Location = new Point(0, 690);
            toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            toolTabStrip2.RootElement.MinSize = new Size(25, 25);
            toolTabStrip2.SelectedIndex = 0;
            toolTabStrip2.Size = new Size(1284, 410);
            toolTabStrip2.SizeInfo.AbsoluteSize = new Size(200, 410);
            toolTabStrip2.SizeInfo.SplitterCorrection = new Size(0, 210);
            toolTabStrip2.TabIndex = 1;
            toolTabStrip2.TabStop = false;
            toolTabStrip2.ThemeName = "MaterialTeal";
            // 
            // toolWindow3
            // 
            toolWindow3.Caption = null;
            toolWindow3.Controls.Add(radGridViewExam);
            toolWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow3.Location = new Point(4, 52);
            toolWindow3.Name = "toolWindow3";
            toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow3.Size = new Size(1276, 354);
            toolWindow3.Text = "Danh Sách Bài Thi";
            toolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radGridViewExam
            // 
            radGridViewExam.Dock = DockStyle.Fill;
            radGridViewExam.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridViewExam.MasterTemplate.AllowAddNewRow = false;
            radGridViewExam.MasterTemplate.AllowSearchRow = true;
            radGridViewExam.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridViewExam.MasterTemplate.ViewDefinition = tableViewDefinition2;
            radGridViewExam.Name = "radGridViewExam";
            radGridViewExam.ReadOnly = true;
            radGridViewExam.Size = new Size(1276, 354);
            radGridViewExam.TabIndex = 0;
            radGridViewExam.ThemeName = "MaterialTeal";
            // 
            // StudentResult
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 1100);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentResult";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "StudentResult";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radSplitContainer1).EndInit();
            radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridViewStudent.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip2).EndInit();
            toolTabStrip2.ResumeLayout(false);
            toolWindow3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridViewExam.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.RadGridView radGridViewExam;
        private Telerik.WinControls.UI.RadGridView radGridViewStudent;
    }
}
