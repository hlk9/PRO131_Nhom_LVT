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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            dockParent = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            scheduleGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dockParent).BeginInit();
            dockParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView.MasterTemplate).BeginInit();
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
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(417, 672);
            toolWindow2.Text = "Thông tin và Thao tác";
            // 
            // scheduleGridView
            // 
            scheduleGridView.Dock = DockStyle.Fill;
            scheduleGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            scheduleGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.Size = new Size(1325, 720);
            scheduleGridView.TabIndex = 0;
            scheduleGridView.ThemeName = "MaterialTeal";
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
            ((System.ComponentModel.ISupportInitialize)dockParent).EndInit();
            dockParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
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
    }
}
