namespace Examination_PRL.Forms
{
    partial class EditExams
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
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            radGrid_ExamEdit = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radCMB = new Telerik.WinControls.UI.RadDropDownList();
            radxtID = new Telerik.WinControls.UI.RadTextBox();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radBtnSua = new Telerik.WinControls.UI.RadButton();
            radBtnThem = new Telerik.WinControls.UI.RadButton();
            radTxtTenBaiThi = new Telerik.WinControls.UI.RadTextBox();
            radTxtIdBaiThi = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGrid_ExamEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGrid_ExamEdit.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radCMB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radxtID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtTenBaiThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtIdBaiThi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = documentWindow1;
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
            radDock1.Size = new Size(912, 575);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(radGrid_ExamEdit);
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(632, 567);
            documentWindow1.Text = "documentWindow1";
            // 
            // radGrid_ExamEdit
            // 
            radGrid_ExamEdit.Dock = DockStyle.Fill;
            radGrid_ExamEdit.Location = new Point(0, 0);
            // 
            // 
            // 
            radGrid_ExamEdit.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGrid_ExamEdit.MasterTemplate.EnablePaging = true;
            radGrid_ExamEdit.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGrid_ExamEdit.Name = "radGrid_ExamEdit";
            radGrid_ExamEdit.Size = new Size(632, 567);
            radGrid_ExamEdit.TabIndex = 0;
            radGrid_ExamEdit.ThemeName = "MaterialTeal";
            radGrid_ExamEdit.CellClick += radGrid_ExamEdit_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(630, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-271, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.CausesValidation = false;
            documentTabStrip1.Controls.Add(documentWindow2);
            documentTabStrip1.Controls.Add(documentWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 1;
            documentTabStrip1.Size = new Size(640, 575);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // documentWindow2
            // 
            documentWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow2.Location = new Point(4, 4);
            documentWindow2.Name = "documentWindow2";
            documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow2.Size = new Size(622, 482);
            documentWindow2.Text = "documentWindow2";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow1);
            toolTabStrip1.Location = new Point(648, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(264, 575);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(264, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(64, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radCMB);
            toolWindow1.Controls.Add(radxtID);
            toolWindow1.Controls.Add(radLabel5);
            toolWindow1.Controls.Add(radBtnSua);
            toolWindow1.Controls.Add(radBtnThem);
            toolWindow1.Controls.Add(radTxtTenBaiThi);
            toolWindow1.Controls.Add(radTxtIdBaiThi);
            toolWindow1.Controls.Add(radLabel4);
            toolWindow1.Controls.Add(radLabel3);
            toolWindow1.Controls.Add(radLabel2);
            toolWindow1.Controls.Add(radLabel1);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(256, 519);
            toolWindow1.Text = "Nhân Viên Chi Tiết";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radCMB
            // 
            radCMB.DropDownAnimationEnabled = true;
            radCMB.Location = new Point(93, 89);
            radCMB.Name = "radCMB";
            radCMB.Size = new Size(160, 37);
            radCMB.TabIndex = 14;
            radCMB.Text = "radDropDownList1";
            radCMB.ThemeName = "MaterialTeal";
            radCMB.SelectedIndexChanged += radCMB_SelectedIndexChanged;
            // 
            // radxtID
            // 
            radxtID.Location = new Point(93, 3);
            radxtID.Name = "radxtID";
            radxtID.Size = new Size(160, 37);
            radxtID.TabIndex = 10;
            radxtID.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Location = new Point(3, 19);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(24, 21);
            radLabel5.TabIndex = 9;
            radLabel5.Text = "ID:";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radBtnSua
            // 
            radBtnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnSua.BackColor = Color.Teal;
            radBtnSua.ForeColor = Color.White;
            radBtnSua.Location = new Point(3, 466);
            radBtnSua.Name = "radBtnSua";
            radBtnSua.Size = new Size(250, 45);
            radBtnSua.TabIndex = 8;
            radBtnSua.Text = "Sửa Đề Thi";
            radBtnSua.ThemeName = "MaterialTeal";
            radBtnSua.Click += radBtnSua_Click;
            // 
            // radBtnThem
            // 
            radBtnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnThem.BackColor = Color.Teal;
            radBtnThem.ForeColor = Color.White;
            radBtnThem.Location = new Point(3, 415);
            radBtnThem.Name = "radBtnThem";
            radBtnThem.Size = new Size(250, 45);
            radBtnThem.TabIndex = 7;
            radBtnThem.Text = "Thêm Bài Thi";
            radBtnThem.ThemeName = "MaterialTeal";
            radBtnThem.Click += radBtnThem_Click;
            // 
            // radTxtTenBaiThi
            // 
            radTxtTenBaiThi.Location = new Point(97, 132);
            radTxtTenBaiThi.Name = "radTxtTenBaiThi";
            radTxtTenBaiThi.Size = new Size(160, 37);
            radTxtTenBaiThi.TabIndex = 5;
            radTxtTenBaiThi.ThemeName = "MaterialTeal";
            // 
            // radTxtIdBaiThi
            // 
            radTxtIdBaiThi.Location = new Point(93, 46);
            radTxtIdBaiThi.Name = "radTxtIdBaiThi";
            radTxtIdBaiThi.Size = new Size(160, 37);
            radTxtIdBaiThi.TabIndex = 4;
            radTxtIdBaiThi.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Location = new Point(3, 105);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(64, 21);
            radLabel4.TabIndex = 3;
            radLabel4.Text = "Mã Môn:";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(38, 110);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(2, 2);
            radLabel3.TabIndex = 2;
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(3, 148);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(84, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Tên Bài Thi:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(3, 62);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(80, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Mã Bài Thi:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // EditExams
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 575);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditExams";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "EditExams";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGrid_ExamEdit.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGrid_ExamEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radCMB).EndInit();
            ((System.ComponentModel.ISupportInitialize)radxtID).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtTenBaiThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtIdBaiThi).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadGridView radGrid_ExamEdit;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTxtTenBaiThi;
        private Telerik.WinControls.UI.RadTextBox radTxtIdBaiThi;
        private Telerik.WinControls.UI.RadButton radBtnSua;
        private Telerik.WinControls.UI.RadButton radBtnThem;
        private Telerik.WinControls.UI.RadTextBox radxtID;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadDropDownList radCMB;
    }
}
