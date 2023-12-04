namespace Examination_PRL.Forms.Staff.Schedule
{
    partial class ParticipantInSchedule
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
            dockParent = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            gridViewParticipant = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            lblCurrentParti = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnRemove = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)dockParent).BeginInit();
            dockParent.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewParticipant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewParticipant.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblCurrentParti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dockParent
            // 
            dockParent.ActiveWindow = toolWindow1;
            dockParent.CausesValidation = false;
            dockParent.Controls.Add(documentContainer1);
            dockParent.Controls.Add(toolTabStrip1);
            dockParent.Dock = DockStyle.Fill;
            dockParent.IsCleanUpTarget = true;
            dockParent.Location = new Point(0, 0);
            dockParent.MainDocumentContainer = documentContainer1;
            dockParent.Name = "dockParent";
            dockParent.Padding = new Padding(0);
            // 
            // 
            // 
            dockParent.RootElement.MinSize = new Size(25, 25);
            dockParent.Size = new Size(1424, 659);
            dockParent.SplitterWidth = 8;
            dockParent.TabIndex = 0;
            dockParent.TabStop = false;
            dockParent.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(gridViewParticipant);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(1018, 651);
            toolWindow1.Text = "toolWindow1";
            // 
            // gridViewParticipant
            // 
            gridViewParticipant.Dock = DockStyle.Fill;
            gridViewParticipant.Location = new Point(0, 0);
            // 
            // 
            // 
            gridViewParticipant.MasterTemplate.AllowAddNewRow = false;
            gridViewParticipant.MasterTemplate.AllowCellContextMenu = false;
            gridViewParticipant.MasterTemplate.AllowDeleteRow = false;
            gridViewParticipant.MasterTemplate.AllowEditRow = false;
            gridViewParticipant.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewParticipant.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gridViewParticipant.Name = "gridViewParticipant";
            gridViewParticipant.Size = new Size(1018, 651);
            gridViewParticipant.TabIndex = 0;
            gridViewParticipant.ThemeName = "MaterialTeal";
            gridViewParticipant.CellClick += gridViewParticipant_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(1237, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-190, 0);
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
            documentTabStrip1.Size = new Size(1026, 659);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow2);
            toolTabStrip1.Location = new Point(1034, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(390, 659);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(390, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(190, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.TabStripVisible = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(lblCurrentParti);
            toolWindow2.Controls.Add(radLabel1);
            toolWindow2.Controls.Add(btnClose);
            toolWindow2.Controls.Add(btnRemove);
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(382, 603);
            toolWindow2.Text = "Thao tác";
            // 
            // lblCurrentParti
            // 
            lblCurrentParti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentParti.ForeColor = Color.Teal;
            lblCurrentParti.Location = new Point(193, 42);
            lblCurrentParti.Name = "lblCurrentParti";
            lblCurrentParti.Size = new Size(2, 2);
            lblCurrentParti.TabIndex = 3;
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.Location = new Point(53, 42);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(139, 24);
            radLabel1.TabIndex = 2;
            radLabel1.Text = "Đang chọn thí sinh:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(53, 552);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(279, 36);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.ThemeName = "MaterialTeal";
            btnClose.Click += btnClose_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(53, 464);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(279, 36);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Loại bỏ sinh viên khỏi đợt thi này";
            btnRemove.ThemeName = "MaterialTeal";
            btnRemove.Click += btnRemove_Click;
            // 
            // ParticipantInSchedule
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 659);
            Controls.Add(dockParent);
            Name = "ParticipantInSchedule";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ParticipantInSchedule";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)dockParent).EndInit();
            dockParent.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridViewParticipant.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewParticipant).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblCurrentParti).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock dockParent;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.RadGridView gridViewParticipant;
        private Telerik.WinControls.UI.RadButton btnRemove;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel lblCurrentParti;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}
