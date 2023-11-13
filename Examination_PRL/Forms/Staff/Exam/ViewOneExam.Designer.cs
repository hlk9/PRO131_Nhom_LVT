namespace Examination_PRL.Forms.Staff.Exam
{
    partial class ViewOneExam
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
            examDockParent = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindowDetail = new Telerik.WinControls.UI.Docking.ToolWindow();
            gridAnswer = new Telerik.WinControls.UI.RadGridView();
            dockContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            examGridView = new Telerik.WinControls.UI.RadGridView();
            tabStripDetail = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            ((System.ComponentModel.ISupportInitialize)examDockParent).BeginInit();
            examDockParent.SuspendLayout();
            toolWindowDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridAnswer.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockContainer).BeginInit();
            dockContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabStripDetail).BeginInit();
            tabStripDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // examDockParent
            // 
            examDockParent.ActiveWindow = toolWindowDetail;
            examDockParent.CausesValidation = false;
            examDockParent.Controls.Add(dockContainer);
            examDockParent.Controls.Add(tabStripDetail);
            examDockParent.Dock = DockStyle.Fill;
            examDockParent.IsCleanUpTarget = true;
            examDockParent.Location = new Point(0, 0);
            examDockParent.MainDocumentContainer = dockContainer;
            examDockParent.Name = "examDockParent";
            examDockParent.Padding = new Padding(0);
            // 
            // 
            // 
            examDockParent.RootElement.MinSize = new Size(25, 25);
            examDockParent.Size = new Size(1125, 620);
            examDockParent.SplitterWidth = 8;
            examDockParent.TabIndex = 1;
            examDockParent.TabStop = false;
            examDockParent.ThemeName = "MaterialTeal";
            // 
            // toolWindowDetail
            // 
            toolWindowDetail.Caption = null;
            toolWindowDetail.Controls.Add(gridAnswer);
            toolWindowDetail.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindowDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindowDetail.Location = new Point(4, 52);
            toolWindowDetail.Name = "toolWindowDetail";
            toolWindowDetail.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindowDetail.Size = new Size(477, 564);
            toolWindowDetail.Text = "Các đáp án";
            toolWindowDetail.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // gridAnswer
            // 
            gridAnswer.Dock = DockStyle.Fill;
            gridAnswer.Location = new Point(0, 0);
            // 
            // 
            // 
            gridAnswer.MasterTemplate.AllowAddNewRow = false;
            gridAnswer.MasterTemplate.AllowCellContextMenu = false;
            gridAnswer.MasterTemplate.AllowColumnHeaderContextMenu = false;
            gridAnswer.MasterTemplate.AllowDeleteRow = false;
            gridAnswer.MasterTemplate.AllowDragToGroup = false;
            gridAnswer.MasterTemplate.AllowEditRow = false;
            gridAnswer.MasterTemplate.AllowRowHeaderContextMenu = false;
            gridAnswer.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridAnswer.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gridAnswer.Name = "gridAnswer";
            gridAnswer.ShowGroupPanel = false;
            gridAnswer.Size = new Size(477, 564);
            gridAnswer.TabIndex = 0;
            gridAnswer.ThemeName = "MaterialTeal";
            // 
            // dockContainer
            // 
            dockContainer.Controls.Add(documentTabStrip1);
            dockContainer.Name = "dockContainer";
            // 
            // 
            // 
            dockContainer.RootElement.MinSize = new Size(25, 25);
            dockContainer.SizeInfo.AbsoluteSize = new Size(632, 200);
            dockContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            dockContainer.SizeInfo.SplitterCorrection = new Size(-285, 0);
            dockContainer.SplitterWidth = 8;
            dockContainer.TabIndex = 2;
            dockContainer.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.Controls.Add(documentWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 0;
            documentTabStrip1.Size = new Size(632, 620);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(examGridView);
            documentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(624, 612);
            documentWindow1.Text = "Danh sách bài thi ";
            documentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // examGridView
            // 
            examGridView.Dock = DockStyle.Fill;
            examGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowAddNewRow = false;
            examGridView.MasterTemplate.AllowCellContextMenu = false;
            examGridView.MasterTemplate.AllowDeleteRow = false;
            examGridView.MasterTemplate.AllowEditRow = false;
            examGridView.MasterTemplate.AllowRowHeaderContextMenu = false;
            examGridView.MasterTemplate.AllowSearchRow = true;
            examGridView.MasterTemplate.AutoExpandGroups = true;
            examGridView.MasterTemplate.AutoGenerateColumns = false;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            examGridView.Name = "examGridView";
            examGridView.Size = new Size(624, 612);
            examGridView.TabIndex = 0;
            examGridView.ThemeName = "MaterialTeal";
            examGridView.CellClick += examGridView_CellClick;
            // 
            // tabStripDetail
            // 
            tabStripDetail.CanUpdateChildIndex = true;
            tabStripDetail.CausesValidation = false;
            tabStripDetail.Controls.Add(toolWindowDetail);
            tabStripDetail.Location = new Point(640, 0);
            tabStripDetail.Name = "tabStripDetail";
            // 
            // 
            // 
            tabStripDetail.RootElement.MinSize = new Size(25, 25);
            tabStripDetail.SelectedIndex = 0;
            tabStripDetail.Size = new Size(485, 620);
            tabStripDetail.SizeInfo.AbsoluteSize = new Size(485, 200);
            tabStripDetail.SizeInfo.SplitterCorrection = new Size(285, 0);
            tabStripDetail.TabIndex = 3;
            tabStripDetail.TabStop = false;
            tabStripDetail.ThemeName = "MaterialTeal";
            // 
            // ViewOneExam
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 620);
            Controls.Add(examDockParent);
            Name = "ViewOneExam";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ViewOneExam";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)examDockParent).EndInit();
            examDockParent.ResumeLayout(false);
            toolWindowDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAnswer.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockContainer).EndInit();
            dockContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabStripDetail).EndInit();
            tabStripDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock examDockParent;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindowDetail;
        private Telerik.WinControls.UI.Docking.DocumentContainer dockContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadGridView examGridView;
        private Telerik.WinControls.UI.Docking.ToolTabStrip tabStripDetail;
        private Telerik.WinControls.UI.RadGridView gridAnswer;
    }
}
