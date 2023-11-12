namespace Examination_PRL.Forms.Staff
{
    partial class Exam_Overview
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
            dockWindowPlaceholder1 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            layoutControlLabelItem1 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            layoutControlLabelItem3 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            examDockParent = new Telerik.WinControls.UI.Docking.RadDock();
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            examGridView = new Telerik.WinControls.UI.RadGridView();
            dockContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            tabStripDetail = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindowDetail = new Telerik.WinControls.UI.Docking.ToolWindow();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examDockParent).BeginInit();
            examDockParent.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockContainer).BeginInit();
            dockContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabStripDetail).BeginInit();
            tabStripDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dockWindowPlaceholder1
            // 
            dockWindowPlaceholder1.AutoHideSize = new Size(236, 293);
            dockWindowPlaceholder1.DockWindowName = "toolWindow1";
            dockWindowPlaceholder1.DockWindowText = "Thông tin chung";
            dockWindowPlaceholder1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dockWindowPlaceholder1.Location = new Point(0, 0);
            dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
            dockWindowPlaceholder1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            dockWindowPlaceholder1.Size = new Size(200, 200);
            dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
            // 
            // layoutControlLabelItem1
            // 
            layoutControlLabelItem1.Bounds = new Rectangle(1422, 0, 242, 726);
            layoutControlLabelItem1.DrawText = false;
            layoutControlLabelItem1.Name = "layoutControlLabelItem1";
            // 
            // layoutControlLabelItem2
            // 
            layoutControlLabelItem2.Bounds = new Rectangle(0, 0, 1664, 127);
            layoutControlLabelItem2.DrawText = false;
            layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // layoutControlLabelItem3
            // 
            layoutControlLabelItem3.Bounds = new Rectangle(0, 52, 1666, 60);
            layoutControlLabelItem3.DrawText = false;
            layoutControlLabelItem3.Name = "layoutControlLabelItem3";
            // 
            // radGridView1
            // 
            radGridView1.Location = new Point(541, 243);
            // 
            // 
            // 
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.Size = new Size(240, 150);
            radGridView1.TabIndex = 0;
            // 
            // radPanel1
            // 
            radPanel1.Location = new Point(370, 61);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(200, 100);
            radPanel1.TabIndex = 0;
            // 
            // examDockParent
            // 
            examDockParent.ActiveWindow = documentWindow1;
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
            examDockParent.Size = new Size(1326, 589);
            examDockParent.SplitterWidth = 8;
            examDockParent.TabIndex = 0;
            examDockParent.TabStop = false;
            examDockParent.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(examGridView);
            documentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(946, 581);
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
            examGridView.MasterTemplate.AllowSearchRow = true;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            examGridView.Name = "examGridView";
            examGridView.Size = new Size(946, 581);
            examGridView.TabIndex = 0;
            examGridView.ThemeName = "MaterialTeal";
            // 
            // dockContainer
            // 
            dockContainer.Controls.Add(documentTabStrip1);
            dockContainer.Name = "dockContainer";
            // 
            // 
            // 
            dockContainer.RootElement.MinSize = new Size(25, 25);
            dockContainer.SizeInfo.AbsoluteSize = new Size(1263, 200);
            dockContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            dockContainer.SizeInfo.SplitterCorrection = new Size(-164, 0);
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
            documentTabStrip1.Size = new Size(954, 589);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // tabStripDetail
            // 
            tabStripDetail.CanUpdateChildIndex = true;
            tabStripDetail.CausesValidation = false;
            tabStripDetail.Controls.Add(toolWindowDetail);
            tabStripDetail.Location = new Point(962, 0);
            tabStripDetail.Name = "tabStripDetail";
            // 
            // 
            // 
            tabStripDetail.RootElement.MinSize = new Size(25, 25);
            tabStripDetail.SelectedIndex = 0;
            tabStripDetail.Size = new Size(364, 589);
            tabStripDetail.SizeInfo.AbsoluteSize = new Size(364, 200);
            tabStripDetail.SizeInfo.SplitterCorrection = new Size(164, 0);
            tabStripDetail.TabIndex = 3;
            tabStripDetail.TabStop = false;
            tabStripDetail.ThemeName = "MaterialTeal";
            // 
            // toolWindowDetail
            // 
            toolWindowDetail.Caption = null;
            toolWindowDetail.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindowDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindowDetail.Location = new Point(4, 52);
            toolWindowDetail.Name = "toolWindowDetail";
            toolWindowDetail.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindowDetail.Size = new Size(356, 533);
            toolWindowDetail.Text = "Thông tin chi tiết";
            toolWindowDetail.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // Exam_Overview
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 589);
            Controls.Add(examDockParent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exam_Overview";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Exam_Overview";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)examDockParent).EndInit();
            examDockParent.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockContainer).EndInit();
            dockContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabStripDetail).EndInit();
            tabStripDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem3;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder1;
        private Telerik.WinControls.UI.Docking.RadDock examDockParent;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindowDetail;
        private Telerik.WinControls.UI.Docking.DocumentContainer dockContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip tabStripDetail;
        private Telerik.WinControls.UI.RadGridView examGridView;
    }
}
