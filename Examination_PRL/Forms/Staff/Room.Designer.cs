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
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            dtg_Show = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radTxtCapacity = new Telerik.WinControls.UI.RadTextBox();
            radBtnFalse = new Telerik.WinControls.UI.RadRadioButton();
            radBtnTrue = new Telerik.WinControls.UI.RadRadioButton();
            radRTxtNote = new Telerik.WinControls.UI.RadRichTextEditor();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radTxtAddress = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radBtnThem = new Telerik.WinControls.UI.RadButton();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radBtnUpdate = new Telerik.WinControls.UI.RadButton();
            radTxtName = new Telerik.WinControls.UI.RadTextBox();
            radTxtId = new Telerik.WinControls.UI.RadTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Show.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radTxtCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnFalse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnTrue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radRTxtNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtId).BeginInit();
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
            radDock1.Size = new Size(1057, 690);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(dtg_Show);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(684, 682);
            toolWindow1.Text = "toolWindow2";
            // 
            // dtg_Show
            // 
            dtg_Show.Dock = DockStyle.Fill;
            dtg_Show.Location = new Point(0, 0);
            // 
            // 
            // 
            dtg_Show.MasterTemplate.AllowAddNewRow = false;
            dtg_Show.MasterTemplate.AllowSearchRow = true;
            dtg_Show.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            dtg_Show.MasterTemplate.EnablePaging = true;
            dtg_Show.MasterTemplate.ViewDefinition = tableViewDefinition1;
            dtg_Show.Name = "dtg_Show";
            dtg_Show.ReadOnly = true;
            dtg_Show.Size = new Size(684, 682);
            dtg_Show.TabIndex = 0;
            dtg_Show.ThemeName = "MaterialTeal";
            dtg_Show.CellClick += dtg_Show_CellClick;
            dtg_Show.ContextMenuOpening += dtg_Show_ContextMenuOpening;
            // 
            // documentContainer1
            // 
            documentContainer1.Controls.Add(documentTabStrip1);
            documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(678, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-157, 0);
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
            documentTabStrip1.Size = new Size(692, 690);
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
            toolTabStrip1.Location = new Point(700, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(357, 690);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(357, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(157, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radTxtCapacity);
            toolWindow2.Controls.Add(radBtnFalse);
            toolWindow2.Controls.Add(radBtnTrue);
            toolWindow2.Controls.Add(radRTxtNote);
            toolWindow2.Controls.Add(radLabel6);
            toolWindow2.Controls.Add(radLabel5);
            toolWindow2.Controls.Add(radTxtAddress);
            toolWindow2.Controls.Add(radLabel4);
            toolWindow2.Controls.Add(radBtnThem);
            toolWindow2.Controls.Add(radLabel3);
            toolWindow2.Controls.Add(radBtnUpdate);
            toolWindow2.Controls.Add(radTxtName);
            toolWindow2.Controls.Add(radTxtId);
            toolWindow2.Controls.Add(radLabel2);
            toolWindow2.Controls.Add(radLabel1);
            toolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(349, 634);
            toolWindow2.Text = "Thông Tin Chi Tiết";
            toolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radTxtCapacity
            // 
            radTxtCapacity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtCapacity.Location = new Point(3, 240);
            radTxtCapacity.Name = "radTxtCapacity";
            radTxtCapacity.Size = new Size(338, 37);
            radTxtCapacity.TabIndex = 6;
            radTxtCapacity.ThemeName = "MaterialTeal";
            // 
            // radBtnFalse
            // 
            radBtnFalse.Location = new Point(153, 310);
            radBtnFalse.Name = "radBtnFalse";
            radBtnFalse.Size = new Size(142, 22);
            radBtnFalse.TabIndex = 11;
            radBtnFalse.Text = "Ngưng Hoạt Động";
            radBtnFalse.ThemeName = "MaterialTeal";
            // 
            // radBtnTrue
            // 
            radBtnTrue.Location = new Point(3, 310);
            radBtnTrue.Name = "radBtnTrue";
            radBtnTrue.Size = new Size(95, 22);
            radBtnTrue.TabIndex = 10;
            radBtnTrue.Text = "Hoạt Động";
            radBtnTrue.ThemeName = "MaterialTeal";
            // 
            // radRTxtNote
            // 
            radRTxtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radRTxtNote.BorderColor = Color.FromArgb(224, 224, 224);
            radRTxtNote.Location = new Point(3, 365);
            radRTxtNote.Name = "radRTxtNote";
            radRTxtNote.SelectionFill = Color.FromArgb(128, 128, 203, 196);
            radRTxtNote.SelectionStroke = Color.FromArgb(128, 203, 196);
            radRTxtNote.Size = new Size(338, 124);
            radRTxtNote.TabIndex = 9;
            radRTxtNote.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel6.Location = new Point(3, 338);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(58, 21);
            radLabel6.TabIndex = 8;
            radLabel6.Text = "Ghi Chú";
            radLabel6.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel5.Location = new Point(3, 283);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(77, 21);
            radLabel5.TabIndex = 7;
            radLabel5.Text = "Trạng Thái";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radTxtAddress
            // 
            radTxtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtAddress.Location = new Point(3, 170);
            radTxtAddress.Name = "radTxtAddress";
            radTxtAddress.Size = new Size(338, 37);
            radTxtAddress.TabIndex = 5;
            radTxtAddress.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel4.Location = new Point(3, 213);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(70, 21);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "Sức Chứa";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radBtnThem
            // 
            radBtnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnThem.BackColor = Color.Teal;
            radBtnThem.ForeColor = Color.White;
            radBtnThem.Location = new Point(3, 510);
            radBtnThem.Name = "radBtnThem";
            radBtnThem.Size = new Size(338, 55);
            radBtnThem.TabIndex = 5;
            radBtnThem.Text = "Thêm";
            radBtnThem.ThemeName = "MaterialTeal";
            radBtnThem.Click += radBtnThem_Click;
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.Location = new Point(3, 143);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(53, 21);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "Địa Chỉ";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radBtnUpdate
            // 
            radBtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnUpdate.BackColor = Color.Teal;
            radBtnUpdate.ForeColor = Color.White;
            radBtnUpdate.Location = new Point(3, 571);
            radBtnUpdate.Name = "radBtnUpdate";
            radBtnUpdate.Size = new Size(338, 55);
            radBtnUpdate.TabIndex = 4;
            radBtnUpdate.Text = "Sửa";
            radBtnUpdate.ThemeName = "MaterialTeal";
            radBtnUpdate.Click += radBtnUpdate_Click;
            // 
            // radTxtName
            // 
            radTxtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtName.Location = new Point(3, 100);
            radTxtName.Name = "radTxtName";
            radTxtName.Size = new Size(338, 37);
            radTxtName.TabIndex = 3;
            radTxtName.ThemeName = "MaterialTeal";
            // 
            // radTxtId
            // 
            radTxtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtId.Location = new Point(3, 30);
            radTxtId.Name = "radTxtId";
            radTxtId.Size = new Size(338, 37);
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
            // Room
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 690);
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
            ((System.ComponentModel.ISupportInitialize)dtg_Show.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Show).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radTxtCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnFalse).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnTrue).EndInit();
            ((System.ComponentModel.ISupportInitialize)radRTxtNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView dtg_Show;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radBtnUpdate;
        private Telerik.WinControls.UI.RadButton radBtnThem;
        private Telerik.WinControls.UI.RadTextBox radTxtName;
        private Telerik.WinControls.UI.RadTextBox radTxtId;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadRichTextEditor radRTxtNote;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox radTxtAddress;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadRadioButton radBtnFalse;
        private Telerik.WinControls.UI.RadRadioButton radBtnTrue;
        private Telerik.WinControls.UI.RadTextBox radTxtCapacity;
    }
}
