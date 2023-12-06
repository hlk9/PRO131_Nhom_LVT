namespace Examination_PRL
{
    partial class OverViewNhanVien
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
            radViewNV = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radLblDate = new Telerik.WinControls.UI.RadLabel();
            radLblStatus = new Telerik.WinControls.UI.RadLabel();
            radLblAdress = new Telerik.WinControls.UI.RadLabel();
            radLblSDT = new Telerik.WinControls.UI.RadLabel();
            radLblEmail = new Telerik.WinControls.UI.RadLabel();
            radLblGender = new Telerik.WinControls.UI.RadLabel();
            radLabel8 = new Telerik.WinControls.UI.RadLabel();
            radLblName = new Telerik.WinControls.UI.RadLabel();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radLblID = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            abc = new Telerik.WinControls.UI.RadLabel();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radViewNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radViewNV.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLblDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblAdress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSDT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)abc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
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
            radDock1.Size = new Size(807, 668);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(radViewNV);
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(501, 660);
            documentWindow1.Text = "documentWindow1";
            // 
            // radViewNV
            // 
            radViewNV.Dock = DockStyle.Fill;
            radViewNV.Location = new Point(0, 0);
            // 
            // 
            // 
            radViewNV.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radViewNV.MasterTemplate.EnablePaging = true;
            radViewNV.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radViewNV.Name = "radViewNV";
            radViewNV.Size = new Size(501, 660);
            radViewNV.TabIndex = 0;
            radViewNV.ThemeName = "MaterialTeal";
            radViewNV.CellClick += radViewNV_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(491, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-90, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            documentTabStrip1.CanUpdateChildIndex = true;
            documentTabStrip1.CausesValidation = false;
            documentTabStrip1.Controls.Add(documentWindow1);
            documentTabStrip1.Location = new Point(0, 0);
            documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            documentTabStrip1.RootElement.MinSize = new Size(25, 25);
            documentTabStrip1.SelectedIndex = 0;
            documentTabStrip1.Size = new Size(509, 668);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.CausesValidation = false;
            toolTabStrip1.Controls.Add(toolWindow1);
            toolTabStrip1.Location = new Point(517, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(290, 668);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(290, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(90, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radLblDate);
            toolWindow1.Controls.Add(radLblStatus);
            toolWindow1.Controls.Add(radLblAdress);
            toolWindow1.Controls.Add(radLblSDT);
            toolWindow1.Controls.Add(radLblEmail);
            toolWindow1.Controls.Add(radLblGender);
            toolWindow1.Controls.Add(radLabel8);
            toolWindow1.Controls.Add(radLblName);
            toolWindow1.Controls.Add(radLabel6);
            toolWindow1.Controls.Add(radLabel5);
            toolWindow1.Controls.Add(radLblID);
            toolWindow1.Controls.Add(radLabel3);
            toolWindow1.Controls.Add(radLabel2);
            toolWindow1.Controls.Add(abc);
            toolWindow1.Controls.Add(radLabel4);
            toolWindow1.Controls.Add(radLabel1);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(282, 612);
            toolWindow1.Text = "Thông Tin Chi Tiết";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radLblDate
            // 
            radLblDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblDate.ForeColor = Color.Teal;
            radLblDate.Location = new Point(109, 138);
            radLblDate.Name = "radLblDate";
            radLblDate.Size = new Size(15, 21);
            radLblDate.TabIndex = 5;
            radLblDate.Text = "0";
            radLblDate.ThemeName = "MaterialTeal";
            // 
            // radLblStatus
            // 
            radLblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblStatus.ForeColor = Color.Teal;
            radLblStatus.Location = new Point(109, 318);
            radLblStatus.Name = "radLblStatus";
            radLblStatus.Size = new Size(15, 21);
            radLblStatus.TabIndex = 10;
            radLblStatus.Text = "0";
            radLblStatus.ThemeName = "MaterialTeal";
            // 
            // radLblAdress
            // 
            radLblAdress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblAdress.ForeColor = Color.Teal;
            radLblAdress.Location = new Point(109, 273);
            radLblAdress.Name = "radLblAdress";
            radLblAdress.Size = new Size(15, 21);
            radLblAdress.TabIndex = 9;
            radLblAdress.Text = "0";
            radLblAdress.ThemeName = "MaterialTeal";
            // 
            // radLblSDT
            // 
            radLblSDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblSDT.ForeColor = Color.Teal;
            radLblSDT.Location = new Point(109, 228);
            radLblSDT.Name = "radLblSDT";
            radLblSDT.Size = new Size(15, 21);
            radLblSDT.TabIndex = 8;
            radLblSDT.Text = "0";
            radLblSDT.ThemeName = "MaterialTeal";
            // 
            // radLblEmail
            // 
            radLblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblEmail.ForeColor = Color.Teal;
            radLblEmail.Location = new Point(109, 183);
            radLblEmail.Name = "radLblEmail";
            radLblEmail.Size = new Size(15, 21);
            radLblEmail.TabIndex = 7;
            radLblEmail.Text = "0";
            radLblEmail.ThemeName = "MaterialTeal";
            // 
            // radLblGender
            // 
            radLblGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblGender.ForeColor = Color.Teal;
            radLblGender.Location = new Point(109, 93);
            radLblGender.Name = "radLblGender";
            radLblGender.Size = new Size(15, 21);
            radLblGender.TabIndex = 6;
            radLblGender.Text = "0";
            radLblGender.ThemeName = "MaterialTeal";
            // 
            // radLabel8
            // 
            radLabel8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel8.ForeColor = Color.Teal;
            radLabel8.Location = new Point(3, 138);
            radLabel8.Name = "radLabel8";
            radLabel8.Size = new Size(75, 21);
            radLabel8.TabIndex = 11;
            radLabel8.Text = "Ngày Sinh:";
            radLabel8.ThemeName = "MaterialTeal";
            // 
            // radLblName
            // 
            radLblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblName.ForeColor = Color.Teal;
            radLblName.Location = new Point(109, 48);
            radLblName.Name = "radLblName";
            radLblName.Size = new Size(15, 21);
            radLblName.TabIndex = 4;
            radLblName.Text = "0";
            radLblName.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel6.ForeColor = Color.Teal;
            radLabel6.Location = new Point(3, 318);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(79, 21);
            radLabel6.TabIndex = 5;
            radLabel6.Text = "Tình Trạng:";
            radLabel6.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel5.ForeColor = Color.Teal;
            radLabel5.Location = new Point(3, 273);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(55, 21);
            radLabel5.TabIndex = 4;
            radLabel5.Text = "Địa Chỉ:";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radLblID
            // 
            radLblID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLblID.ForeColor = Color.Teal;
            radLblID.Location = new Point(109, 3);
            radLblID.Name = "radLblID";
            radLblID.Size = new Size(15, 21);
            radLblID.TabIndex = 3;
            radLblID.Text = "0";
            radLblID.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel3.ForeColor = Color.Teal;
            radLabel3.Location = new Point(3, 228);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(36, 21);
            radLabel3.TabIndex = 3;
            radLabel3.Text = "SĐT:";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(3, 183);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(45, 21);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "Email:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // abc
            // 
            abc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            abc.ForeColor = Color.Teal;
            abc.Location = new Point(3, 48);
            abc.Name = "abc";
            abc.Size = new Size(103, 21);
            abc.TabIndex = 1;
            abc.Text = "Tên Nhân Viên:";
            abc.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel4.ForeColor = Color.Teal;
            radLabel4.Location = new Point(3, 93);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(68, 21);
            radLabel4.TabIndex = 1;
            radLabel4.Text = "Giới Tính:";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.ForeColor = Color.Teal;
            radLabel1.Location = new Point(3, 3);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(100, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Mã Nhân Viên:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // OverViewNhanVien
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 668);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OverViewNhanVien";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "OverViewNhanVien";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radViewNV.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radViewNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLblDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblAdress).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSDT).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblID).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)abc).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadGridView radViewNV;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLblID;
        private Telerik.WinControls.UI.RadLabel radLblName;
        private Telerik.WinControls.UI.RadLabel abc;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLblGender;
        private Telerik.WinControls.UI.RadLabel radLblDate;
        private Telerik.WinControls.UI.RadLabel radLblStatus;
        private Telerik.WinControls.UI.RadLabel radLblAdress;
        private Telerik.WinControls.UI.RadLabel radLblSDT;
        private Telerik.WinControls.UI.RadLabel radLblEmail;
        private Telerik.WinControls.UI.RadLabel radLabel8;
    }
}
