namespace Examination_PRL.Forms.Staff.Schedule
{
    partial class ScheduleManagement
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
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            scheduleGridView = new Telerik.WinControls.UI.RadGridView();
            dockParent = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            btnViewDetail = new Telerik.WinControls.UI.RadButton();
            lblEnd = new Telerik.WinControls.UI.RadLabel();
            lblCurrent = new Telerik.WinControls.UI.RadLabel();
            lblIncoming = new Telerik.WinControls.UI.RadLabel();
            lblTotal = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            btnNew = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockParent).BeginInit();
            dockParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnViewDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow1;
            radDock1.CausesValidation = false;
            radDock1.Controls.Add(dockParent);
            radDock1.Controls.Add(toolTabStrip1);
            radDock1.Dock = DockStyle.Fill;
            radDock1.IsCleanUpTarget = true;
            radDock1.Location = new Point(0, 0);
            radDock1.MainDocumentContainer = dockParent;
            radDock1.Name = "radDock1";
            radDock1.Padding = new Padding(0);
            // 
            // 
            // 
            radDock1.RootElement.MinSize = new Size(25, 25);
            radDock1.Size = new Size(1766, 728);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(scheduleGridView);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(1325, 720);
            toolWindow1.Text = "toolWindow1";
            // 
            // scheduleGridView
            // 
            scheduleGridView.Dock = DockStyle.Fill;
            scheduleGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            scheduleGridView.MasterTemplate.AllowAddNewRow = false;
            scheduleGridView.MasterTemplate.AllowDeleteRow = false;
            scheduleGridView.MasterTemplate.AllowEditRow = false;
            scheduleGridView.MasterTemplate.AllowSearchRow = true;
            scheduleGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            scheduleGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.Size = new Size(1325, 720);
            scheduleGridView.TabIndex = 0;
            scheduleGridView.ThemeName = "MaterialTeal";
            scheduleGridView.CellClick += scheduleGridView_CellClick;
            // 
            // dockParent
            // 
            dockParent.Controls.Add(documentTabStrip1);
            dockParent.Name = "dockParent";
            // 
            // 
            // 
            dockParent.RootElement.MinSize = new Size(25, 25);
            dockParent.SizeInfo.AbsoluteSize = new Size(1212, 200);
            dockParent.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            dockParent.SizeInfo.SplitterCorrection = new Size(-225, 0);
            dockParent.SplitterWidth = 8;
            dockParent.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.Controls.Add(toolWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 0;
            documentTabStrip1.Size = new Size(1333, 728);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.CausesValidation = false;
            toolTabStrip1.Controls.Add(toolWindow2);
            toolTabStrip1.Location = new Point(1341, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(425, 728);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(425, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(225, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(btnNew);
            toolWindow2.Controls.Add(btnViewDetail);
            toolWindow2.Controls.Add(lblEnd);
            toolWindow2.Controls.Add(lblCurrent);
            toolWindow2.Controls.Add(lblIncoming);
            toolWindow2.Controls.Add(lblTotal);
            toolWindow2.Controls.Add(radLabel5);
            toolWindow2.Controls.Add(radLabel4);
            toolWindow2.Controls.Add(radLabel3);
            toolWindow2.Controls.Add(radLabel2);
            toolWindow2.Controls.Add(radLabel1);
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(417, 672);
            toolWindow2.Text = "Thông tin và Thao tác";
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(24, 617);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(367, 44);
            btnViewDetail.TabIndex = 7;
            btnViewDetail.Text = "Xếp lịch tới các lớp/Sinh viên";
            btnViewDetail.ThemeName = "MaterialTeal";
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // lblEnd
            // 
            lblEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnd.ForeColor = Color.DarkOrchid;
            lblEnd.Location = new Point(133, 245);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(17, 25);
            lblEnd.TabIndex = 6;
            lblEnd.Text = "0";
            // 
            // lblCurrent
            // 
            lblCurrent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrent.ForeColor = Color.DarkOrchid;
            lblCurrent.Location = new Point(145, 199);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(17, 25);
            lblCurrent.TabIndex = 6;
            lblCurrent.Text = "0";
            // 
            // lblIncoming
            // 
            lblIncoming.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIncoming.ForeColor = Color.DarkOrchid;
            lblIncoming.Location = new Point(131, 147);
            lblIncoming.Name = "lblIncoming";
            lblIncoming.Size = new Size(17, 25);
            lblIncoming.TabIndex = 6;
            lblIncoming.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.DarkOrchid;
            lblTotal.Location = new Point(119, 101);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0";
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel5.ForeColor = Color.Teal;
            radLabel5.Location = new Point(24, 245);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(95, 25);
            radLabel5.TabIndex = 4;
            radLabel5.Text = "Đã kết thúc:";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel4.ForeColor = Color.Teal;
            radLabel4.Location = new Point(24, 199);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(105, 25);
            radLabel4.TabIndex = 3;
            radLabel4.Text = "Đang diễn ra:";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel3.ForeColor = Color.Teal;
            radLabel3.Location = new Point(24, 147);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(93, 25);
            radLabel3.TabIndex = 2;
            radLabel3.Text = "Sắp diễn ra:";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(24, 101);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(77, 25);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Số lượng:";
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top;
            radLabel1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.ForeColor = Color.Teal;
            radLabel1.Location = new Point(108, 23);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(220, 41);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Thông tin chung";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(24, 567);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(367, 44);
            btnNew.TabIndex = 8;
            btnNew.Text = "Tạo lịch mới";
            btnNew.ThemeName = "MaterialTeal";
            btnNew.Click += btnNew_Click;
            // 
            // ScheduleManagement
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1766, 728);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleManagement";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ScheduleManagement";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockParent).EndInit();
            dockParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnViewDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer dockParent;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.RadGridView scheduleGridView;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lblEnd;
        private Telerik.WinControls.UI.RadLabel lblCurrent;
        private Telerik.WinControls.UI.RadLabel lblIncoming;
        private Telerik.WinControls.UI.RadLabel lblTotal;
        private Telerik.WinControls.UI.RadButton btnViewDetail;
        private Telerik.WinControls.UI.RadButton btnNew;
    }
}
