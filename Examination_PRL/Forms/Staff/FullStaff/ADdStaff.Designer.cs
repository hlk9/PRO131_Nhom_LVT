namespace Examination_PRL
{
    partial class AddNhanVien
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
            rad_Staff = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            label8 = new Label();
            radDTP = new Telerik.WinControls.UI.RadDateTimePicker();
            radBtnAddStaff = new Telerik.WinControls.UI.RadButton();
            radListStaff = new Telerik.WinControls.UI.RadDropDownList();
            radNu = new Telerik.WinControls.UI.RadRadioButton();
            radNam = new Telerik.WinControls.UI.RadRadioButton();
            radTxtAdress = new Telerik.WinControls.UI.RadTextBox();
            radTxtPhone = new Telerik.WinControls.UI.RadTextBox();
            radTxtEmail = new Telerik.WinControls.UI.RadTextBox();
            radTxtID = new Telerik.WinControls.UI.RadTextBox();
            radTxtFullName = new Telerik.WinControls.UI.RadTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rad_Staff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radDTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAddStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radListStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radNu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAdress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtFullName).BeginInit();
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
            radDock1.Size = new Size(917, 526);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(rad_Staff);
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(572, 518);
            documentWindow1.Text = "documentWindow1";
            // 
            // rad_Staff
            // 
            rad_Staff.Dock = DockStyle.Fill;
            rad_Staff.Location = new Point(0, 0);
            // 
            // 
            // 
            rad_Staff.MasterTemplate.AllowAddNewRow = false;
            rad_Staff.MasterTemplate.AllowSearchRow = true;
            rad_Staff.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            rad_Staff.MasterTemplate.EnablePaging = true;
            rad_Staff.MasterTemplate.ViewDefinition = tableViewDefinition1;
            rad_Staff.Name = "rad_Staff";
            rad_Staff.Size = new Size(572, 518);
            rad_Staff.TabIndex = 0;
            rad_Staff.ThemeName = "MaterialTeal";
            rad_Staff.CellClick += rad_Staff_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(572, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-129, 0);
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
            documentTabStrip1.Size = new Size(580, 526);
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
            toolTabStrip1.Location = new Point(588, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(329, 526);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(329, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(129, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(label8);
            toolWindow1.Controls.Add(radDTP);
            toolWindow1.Controls.Add(radBtnAddStaff);
            toolWindow1.Controls.Add(radListStaff);
            toolWindow1.Controls.Add(radNu);
            toolWindow1.Controls.Add(radNam);
            toolWindow1.Controls.Add(radTxtAdress);
            toolWindow1.Controls.Add(radTxtPhone);
            toolWindow1.Controls.Add(radTxtEmail);
            toolWindow1.Controls.Add(radTxtID);
            toolWindow1.Controls.Add(radTxtFullName);
            toolWindow1.Controls.Add(label7);
            toolWindow1.Controls.Add(label6);
            toolWindow1.Controls.Add(label5);
            toolWindow1.Controls.Add(label4);
            toolWindow1.Controls.Add(label3);
            toolWindow1.Controls.Add(label2);
            toolWindow1.Controls.Add(label1);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(321, 470);
            toolWindow1.Text = "Thông Tin Chi Tiết";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(-3, 141);
            label8.Name = "label8";
            label8.Size = new Size(75, 17);
            label8.TabIndex = 15;
            label8.Text = "Ngày Sinh:";
            // 
            // radDTP
            // 
            radDTP.CalendarSize = new Size(290, 320);
            radDTP.Location = new Point(78, 131);
            radDTP.Name = "radDTP";
            radDTP.Size = new Size(249, 36);
            radDTP.TabIndex = 14;
            radDTP.TabStop = false;
            radDTP.Text = "Monday, November 20, 2023";
            radDTP.ThemeName = "MaterialTeal";
            radDTP.Value = new DateTime(2023, 11, 20, 0, 29, 51, 457);
            // 
            // radBtnAddStaff
            // 
            radBtnAddStaff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnAddStaff.BackColor = Color.Teal;
            radBtnAddStaff.Location = new Point(3, 419);
            radBtnAddStaff.Name = "radBtnAddStaff";
            radBtnAddStaff.Size = new Size(310, 43);
            radBtnAddStaff.TabIndex = 13;
            radBtnAddStaff.Text = "Thêm Nhân Viên";
            radBtnAddStaff.ThemeName = "MaterialTeal";
            radBtnAddStaff.Click += radBtnAddStaff_Click;
            // 
            // radListStaff
            // 
            radListStaff.DropDownAnimationEnabled = true;
            radListStaff.Location = new Point(78, 316);
            radListStaff.Name = "radListStaff";
            radListStaff.Size = new Size(249, 37);
            radListStaff.TabIndex = 12;
            radListStaff.Text = "radDropDownList1";
            radListStaff.ThemeName = "MaterialTeal";
            // 
            // radNu
            // 
            radNu.Location = new Point(182, 103);
            radNu.Name = "radNu";
            radNu.Size = new Size(45, 22);
            radNu.TabIndex = 11;
            radNu.TabStop = false;
            radNu.Text = "Nữ";
            radNu.ThemeName = "MaterialTeal";
            // 
            // radNam
            // 
            radNam.CheckState = CheckState.Checked;
            radNam.Location = new Point(94, 103);
            radNam.Name = "radNam";
            radNam.Size = new Size(57, 22);
            radNam.TabIndex = 10;
            radNam.Text = "Nam";
            radNam.ThemeName = "MaterialTeal";
            radNam.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radTxtAdress
            // 
            radTxtAdress.Location = new Point(78, 259);
            radTxtAdress.Name = "radTxtAdress";
            radTxtAdress.Size = new Size(249, 37);
            radTxtAdress.TabIndex = 8;
            radTxtAdress.ThemeName = "MaterialTeal";
            // 
            // radTxtPhone
            // 
            radTxtPhone.Location = new Point(78, 216);
            radTxtPhone.Name = "radTxtPhone";
            radTxtPhone.Size = new Size(249, 37);
            radTxtPhone.TabIndex = 8;
            radTxtPhone.ThemeName = "MaterialTeal";
            // 
            // radTxtEmail
            // 
            radTxtEmail.Location = new Point(78, 173);
            radTxtEmail.Name = "radTxtEmail";
            radTxtEmail.Size = new Size(249, 37);
            radTxtEmail.TabIndex = 9;
            radTxtEmail.ThemeName = "MaterialTeal";
            // 
            // radTxtID
            // 
            radTxtID.Location = new Point(78, 3);
            radTxtID.Name = "radTxtID";
            radTxtID.Size = new Size(249, 37);
            radTxtID.TabIndex = 8;
            radTxtID.ThemeName = "MaterialTeal";
            // 
            // radTxtFullName
            // 
            radTxtFullName.Location = new Point(78, 46);
            radTxtFullName.Name = "radTxtFullName";
            radTxtFullName.Size = new Size(249, 37);
            radTxtFullName.TabIndex = 7;
            radTxtFullName.ThemeName = "MaterialTeal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 323);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 6;
            label7.Text = "Tình Trạng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 269);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 5;
            label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 226);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 4;
            label5.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 184);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 2;
            label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-1, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(26, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // AddNhanVien
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 526);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddNhanVien";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "AddNhanVien";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rad_Staff.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)rad_Staff).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radDTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnAddStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)radListStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)radNu).EndInit();
            ((System.ComponentModel.ISupportInitialize)radNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAdress).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtID).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtFullName).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadGridView rad_Staff;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Telerik.WinControls.UI.RadButton radBtnAddStaff;
        private Telerik.WinControls.UI.RadDropDownList radListStaff;
        private Telerik.WinControls.UI.RadRadioButton radNu;
        private Telerik.WinControls.UI.RadRadioButton radNam;
        private Telerik.WinControls.UI.RadTextBox radTxtAdress;
        private Telerik.WinControls.UI.RadTextBox radTxtPhone;
        private Telerik.WinControls.UI.RadTextBox radTxtEmail;
        private Telerik.WinControls.UI.RadTextBox radTxtID;
        private Telerik.WinControls.UI.RadTextBox radTxtFullName;
        private Label label8;
        private Telerik.WinControls.UI.RadDateTimePicker radDTP;
    }
}
