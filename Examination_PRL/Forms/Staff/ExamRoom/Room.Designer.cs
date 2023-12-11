namespace Examination_PRL.Forms.Staff
{
    partial class Room
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
            examRoomGridView = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radBtnFalse = new Telerik.WinControls.UI.RadRadioButton();
            radBtnTrue = new Telerik.WinControls.UI.RadRadioButton();
            radBtnAdd = new Telerik.WinControls.UI.RadButton();
            radBtnUpdate = new Telerik.WinControls.UI.RadButton();
            radTxtNote = new Telerik.WinControls.UI.RadTextBox();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radTxtCapacity = new Telerik.WinControls.UI.RadTextBox();
            radTxtAddress = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radTxtName = new Telerik.WinControls.UI.RadTextBox();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radTxtId = new Telerik.WinControls.UI.RadTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radBtnClear = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnFalse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnTrue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnClear).BeginInit();
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
            radDock1.Size = new Size(1057, 883);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(examRoomGridView);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(651, 875);
            toolWindow1.Text = "toolWindow2";
            // 
            // examRoomGridView
            // 
            examRoomGridView.Dock = DockStyle.Fill;
            examRoomGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            examRoomGridView.MasterTemplate.AllowSearchRow = true;
            examRoomGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examRoomGridView.MasterTemplate.EnablePaging = true;
            examRoomGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examRoomGridView.Name = "examRoomGridView";
            examRoomGridView.Size = new Size(651, 875);
            examRoomGridView.TabIndex = 0;
            examRoomGridView.ThemeName = "MaterialTeal";
            examRoomGridView.CellClick += dtg_Show_CellClick;
            examRoomGridView.ContextMenuOpening += dtg_Show_ContextMenuOpening;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(655, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-190, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.CausesValidation = false;
            documentTabStrip1.Controls.Add(documentWindow1);
            documentTabStrip1.Controls.Add(documentWindow2);
            documentTabStrip1.Controls.Add(toolWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 2;
            documentTabStrip1.Size = new Size(659, 883);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(643, 827);
            documentWindow1.Text = "documentWindow2";
            // 
            // documentWindow2
            // 
            documentWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow2.Location = new Point(4, 4);
            documentWindow2.Name = "documentWindow2";
            documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow2.Size = new Size(643, 827);
            documentWindow2.Text = "documentWindow1";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.CausesValidation = false;
            toolTabStrip1.Controls.Add(toolWindow2);
            toolTabStrip1.Location = new Point(667, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(390, 883);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(390, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(190, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radBtnClear);
            toolWindow2.Controls.Add(radBtnFalse);
            toolWindow2.Controls.Add(radBtnTrue);
            toolWindow2.Controls.Add(radBtnAdd);
            toolWindow2.Controls.Add(radBtnUpdate);
            toolWindow2.Controls.Add(radTxtNote);
            toolWindow2.Controls.Add(radLabel6);
            toolWindow2.Controls.Add(radLabel5);
            toolWindow2.Controls.Add(radTxtCapacity);
            toolWindow2.Controls.Add(radTxtAddress);
            toolWindow2.Controls.Add(radLabel4);
            toolWindow2.Controls.Add(radTxtName);
            toolWindow2.Controls.Add(radLabel3);
            toolWindow2.Controls.Add(radTxtId);
            toolWindow2.Controls.Add(radLabel2);
            toolWindow2.Controls.Add(radLabel1);
            toolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(382, 827);
            toolWindow2.Text = "Thông Tin Chi Tiết";
            toolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radBtnFalse
            // 
            radBtnFalse.Location = new Point(172, 380);
            radBtnFalse.Name = "radBtnFalse";
            radBtnFalse.Size = new Size(140, 22);
            radBtnFalse.TabIndex = 12;
            radBtnFalse.Text = "Không Hoạt Động";
            radBtnFalse.ThemeName = "MaterialTeal";
            // 
            // radBtnTrue
            // 
            radBtnTrue.Location = new Point(3, 380);
            radBtnTrue.Name = "radBtnTrue";
            radBtnTrue.Size = new Size(95, 22);
            radBtnTrue.TabIndex = 11;
            radBtnTrue.Text = "Hoạt Động";
            radBtnTrue.ThemeName = "MaterialTeal";
            // 
            // radBtnAdd
            // 
            radBtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnAdd.BackColor = Color.Teal;
            radBtnAdd.ForeColor = Color.White;
            radBtnAdd.Location = new Point(6, 650);
            radBtnAdd.Name = "radBtnAdd";
            radBtnAdd.Size = new Size(376, 54);
            radBtnAdd.TabIndex = 10;
            radBtnAdd.Text = "Thêm";
            radBtnAdd.ThemeName = "MaterialTeal";
            radBtnAdd.Click += radBtnAdd_Click;
            // 
            // radBtnUpdate
            // 
            radBtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnUpdate.BackColor = Color.Teal;
            radBtnUpdate.ForeColor = Color.White;
            radBtnUpdate.Location = new Point(6, 710);
            radBtnUpdate.Name = "radBtnUpdate";
            radBtnUpdate.Size = new Size(376, 54);
            radBtnUpdate.TabIndex = 9;
            radBtnUpdate.Text = "Sửa";
            radBtnUpdate.ThemeName = "MaterialTeal";
            radBtnUpdate.Click += radBtnUpdate_Click;
            // 
            // radTxtNote
            // 
            radTxtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtNote.Location = new Point(3, 310);
            radTxtNote.Name = "radTxtNote";
            radTxtNote.Size = new Size(376, 37);
            radTxtNote.TabIndex = 6;
            radTxtNote.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel6.Location = new Point(3, 353);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(77, 21);
            radLabel6.TabIndex = 7;
            radLabel6.Text = "Trạng Thái";
            radLabel6.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel5.Location = new Point(3, 283);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(58, 21);
            radLabel5.TabIndex = 5;
            radLabel5.Text = "Ghi Chú";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radTxtCapacity
            // 
            radTxtCapacity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtCapacity.Location = new Point(3, 240);
            radTxtCapacity.Name = "radTxtCapacity";
            radTxtCapacity.Size = new Size(376, 37);
            radTxtCapacity.TabIndex = 5;
            radTxtCapacity.ThemeName = "MaterialTeal";
            // 
            // radTxtAddress
            // 
            radTxtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtAddress.Location = new Point(3, 170);
            radTxtAddress.Name = "radTxtAddress";
            radTxtAddress.Size = new Size(376, 37);
            radTxtAddress.TabIndex = 5;
            radTxtAddress.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel4.Location = new Point(3, 213);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(70, 21);
            radLabel4.TabIndex = 4;
            radLabel4.Text = "Sức Chứa";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radTxtName
            // 
            radTxtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtName.Location = new Point(3, 100);
            radTxtName.Name = "radTxtName";
            radTxtName.Size = new Size(376, 37);
            radTxtName.TabIndex = 3;
            radTxtName.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.Location = new Point(3, 143);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(53, 21);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "Địa Chỉ";
            radLabel3.TextAlignment = ContentAlignment.TopLeft;
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radTxtId
            // 
            radTxtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtId.Location = new Point(3, 30);
            radTxtId.Name = "radTxtId";
            radTxtId.Size = new Size(376, 37);
            radTxtId.TabIndex = 1;
            radTxtId.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.Location = new Point(3, 73);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(101, 21);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "Tên Phòng Thi";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.Location = new Point(3, 3);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(97, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Mã Phòng Thi";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radBtnClear
            // 
            radBtnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnClear.BackColor = Color.Teal;
            radBtnClear.ForeColor = Color.White;
            radBtnClear.Location = new Point(6, 770);
            radBtnClear.Name = "radBtnClear";
            radBtnClear.Size = new Size(376, 54);
            radBtnClear.TabIndex = 10;
            radBtnClear.Text = "Clear";
            radBtnClear.ThemeName = "MaterialTeal";
            radBtnClear.Click += radBtnClear_Click;
            // 
            // Room
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 883);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Room";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Room";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examRoomGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnFalse).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnTrue).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnClear).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadGridView examRoomGridView;
        private Telerik.WinControls.UI.RadButton radBtnAdd;
        private Telerik.WinControls.UI.RadButton radBtnUpdate;
        private Telerik.WinControls.UI.RadTextBox radTxtNote;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox radTxtCapacity;
        private Telerik.WinControls.UI.RadTextBox radTxtAddress;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTxtName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox radTxtId;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadRadioButton radBtnFalse;
        private Telerik.WinControls.UI.RadRadioButton radBtnTrue;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadButton radBtnClear;
    }
}
