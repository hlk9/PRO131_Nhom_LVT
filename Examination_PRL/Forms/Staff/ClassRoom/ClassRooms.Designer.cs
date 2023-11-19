namespace Examination_PRL.Forms.Staff.ClassRoom
{
    partial class ClassRooms
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
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            ClassRoomExamGridView = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radBtnUpdate = new Telerik.WinControls.UI.RadButton();
            radBtnAdd = new Telerik.WinControls.UI.RadButton();
            radTxtName = new Telerik.WinControls.UI.RadTextBox();
            radTxId = new Telerik.WinControls.UI.RadTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassRoomExamGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassRoomExamGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow1;
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
            radDock1.Size = new Size(951, 567);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(ClassRoomExamGridView);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(543, 559);
            toolWindow1.Text = "toolWindow2";
            // 
            // ClassRoomExamGridView
            // 
            ClassRoomExamGridView.Dock = DockStyle.Fill;
            ClassRoomExamGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            ClassRoomExamGridView.MasterTemplate.AllowAddNewRow = false;
            ClassRoomExamGridView.MasterTemplate.AllowSearchRow = true;
            ClassRoomExamGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            ClassRoomExamGridView.MasterTemplate.EnablePaging = true;
            ClassRoomExamGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            ClassRoomExamGridView.Name = "ClassRoomExamGridView";
            ClassRoomExamGridView.ReadOnly = true;
            ClassRoomExamGridView.Size = new Size(543, 559);
            ClassRoomExamGridView.TabIndex = 0;
            ClassRoomExamGridView.ThemeName = "MaterialTeal";
            ClassRoomExamGridView.CellClick += ClassRoomExamGridView_CellClick;
            ClassRoomExamGridView.ContextMenuOpening += ClassRoomExamGridView_ContextMenuOpening;
            // 
            // documentContainer1
            // 
            documentContainer1.Controls.Add(documentTabStrip1);
            documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(531, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-192, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
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
            documentTabStrip1.Size = new Size(551, 567);
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
            toolTabStrip1.Location = new Point(559, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(392, 567);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(392, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(192, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radBtnUpdate);
            toolWindow2.Controls.Add(radBtnAdd);
            toolWindow2.Controls.Add(radTxtName);
            toolWindow2.Controls.Add(radTxId);
            toolWindow2.Controls.Add(radLabel2);
            toolWindow2.Controls.Add(radLabel1);
            toolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(384, 511);
            toolWindow2.Text = "Thông Tin Chi Tiết";
            toolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radBtnUpdate
            // 
            radBtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnUpdate.BackColor = Color.Teal;
            radBtnUpdate.ForeColor = Color.White;
            radBtnUpdate.Location = new Point(3, 440);
            radBtnUpdate.Name = "radBtnUpdate";
            radBtnUpdate.Size = new Size(378, 58);
            radBtnUpdate.TabIndex = 5;
            radBtnUpdate.Text = "Sửa";
            radBtnUpdate.ThemeName = "MaterialTeal";
            radBtnUpdate.Click += radBtnUpdate_Click;
            // 
            // radBtnAdd
            // 
            radBtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnAdd.BackColor = Color.Teal;
            radBtnAdd.ForeColor = Color.White;
            radBtnAdd.Location = new Point(3, 376);
            radBtnAdd.Name = "radBtnAdd";
            radBtnAdd.Size = new Size(378, 58);
            radBtnAdd.TabIndex = 4;
            radBtnAdd.Text = "Thêm";
            radBtnAdd.ThemeName = "MaterialTeal";
            radBtnAdd.Click += radBtnAdd_Click;
            // 
            // radTxtName
            // 
            radTxtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtName.Location = new Point(3, 100);
            radTxtName.Name = "radTxtName";
            radTxtName.Size = new Size(378, 37);
            radTxtName.TabIndex = 3;
            radTxtName.ThemeName = "MaterialTeal";
            // 
            // radTxId
            // 
            radTxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxId.Location = new Point(3, 30);
            radTxId.Name = "radTxId";
            radTxId.Size = new Size(378, 37);
            radTxId.TabIndex = 1;
            radTxId.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.Location = new Point(3, 73);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(60, 21);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "Tên Lớp";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.Location = new Point(3, 3);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(55, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Mã Lớp";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // ClassRooms
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 567);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassRooms";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ClassRoom";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClassRoomExamGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassRoomExamGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxId).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadGridView ClassRoomExamGridView;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.RadButton radBtnUpdate;
        private Telerik.WinControls.UI.RadButton radBtnAdd;
        private Telerik.WinControls.UI.RadTextBox radTxtName;
        private Telerik.WinControls.UI.RadTextBox radTxId;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
