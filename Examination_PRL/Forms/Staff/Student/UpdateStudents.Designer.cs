namespace Examination_PRL.Forms.Staff
{
    partial class UpdateStudents
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
            examGridView = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radDDClassId = new Telerik.WinControls.UI.RadDropDownList();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            radBNu = new Telerik.WinControls.UI.RadRadioButton();
            radBNam = new Telerik.WinControls.UI.RadRadioButton();
            radLabel8 = new Telerik.WinControls.UI.RadLabel();
            radDtpNS = new Telerik.WinControls.UI.RadDateTimePicker();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            radTxtAdress = new Telerik.WinControls.UI.RadTextBox();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            radTxtEmail = new Telerik.WinControls.UI.RadTextBox();
            radTxtPhone = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radTxtName = new Telerik.WinControls.UI.RadTextBox();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radDDClassId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBNu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDtpNS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAdress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
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
            radDock1.Size = new Size(800, 700);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(examGridView);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(352, 692);
            toolWindow1.Text = "toolWindow2";
            // 
            // examGridView
            // 
            examGridView.Dock = DockStyle.Fill;
            examGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowAddNewRow = false;
            examGridView.MasterTemplate.AllowSearchRow = true;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examGridView.Name = "examGridView";
            examGridView.ReadOnly = true;
            examGridView.Size = new Size(352, 692);
            examGridView.TabIndex = 0;
            examGridView.ThemeName = "MaterialTeal";
            examGridView.CellClick += examGridView_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(352, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-232, 0);
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
            documentTabStrip1.Size = new Size(360, 700);
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
            toolTabStrip1.Location = new Point(368, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(432, 700);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(432, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(232, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.AutoScroll = true;
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radDDClassId);
            toolWindow2.Controls.Add(radLabel5);
            toolWindow2.Controls.Add(radButton1);
            toolWindow2.Controls.Add(radBNu);
            toolWindow2.Controls.Add(radBNam);
            toolWindow2.Controls.Add(radLabel8);
            toolWindow2.Controls.Add(radDtpNS);
            toolWindow2.Controls.Add(radLabel7);
            toolWindow2.Controls.Add(radTxtAdress);
            toolWindow2.Controls.Add(radLabel6);
            toolWindow2.Controls.Add(radTxtEmail);
            toolWindow2.Controls.Add(radTxtPhone);
            toolWindow2.Controls.Add(radLabel4);
            toolWindow2.Controls.Add(radTxtName);
            toolWindow2.Controls.Add(radLabel3);
            toolWindow2.Controls.Add(radLabel2);
            toolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 52);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(424, 644);
            toolWindow2.Text = "Sửa Thí Sinh Chi Tiết";
            toolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radDDClassId
            // 
            radDDClassId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radDDClassId.DropDownAnimationEnabled = true;
            radDDClassId.Location = new Point(3, 434);
            radDDClassId.Name = "radDDClassId";
            radDDClassId.Size = new Size(418, 37);
            radDDClassId.TabIndex = 30;
            radDDClassId.Text = "radDropDownList1";
            radDDClassId.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel5.Location = new Point(3, 407);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(55, 21);
            radLabel5.TabIndex = 28;
            radLabel5.Text = "Mã Lớp";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radButton1
            // 
            radButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radButton1.BackColor = Color.Teal;
            radButton1.Location = new Point(3, 590);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(413, 46);
            radButton1.TabIndex = 8;
            radButton1.Text = "Sửa Thông Tin";
            radButton1.ThemeName = "MaterialTeal";
            radButton1.Click += radButton1_Click;
            // 
            // radBNu
            // 
            radBNu.Location = new Point(144, 379);
            radBNu.Name = "radBNu";
            radBNu.Size = new Size(45, 22);
            radBNu.TabIndex = 7;
            radBNu.Text = "Nữ";
            radBNu.ThemeName = "MaterialTeal";
            // 
            // radBNam
            // 
            radBNam.CheckState = CheckState.Checked;
            radBNam.Location = new Point(3, 379);
            radBNam.Name = "radBNam";
            radBNam.Size = new Size(57, 22);
            radBNam.TabIndex = 6;
            radBNam.Text = "Nam";
            radBNam.ThemeName = "MaterialTeal";
            radBNam.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel8
            // 
            radLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel8.ForeColor = Color.Teal;
            radLabel8.Location = new Point(3, 352);
            radLabel8.Name = "radLabel8";
            radLabel8.Size = new Size(65, 21);
            radLabel8.TabIndex = 5;
            radLabel8.Text = "Giới Tính";
            radLabel8.ThemeName = "MaterialTeal";
            // 
            // radDtpNS
            // 
            radDtpNS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radDtpNS.CalendarSize = new Size(290, 320);
            radDtpNS.Location = new Point(3, 310);
            radDtpNS.Name = "radDtpNS";
            radDtpNS.Size = new Size(418, 36);
            radDtpNS.TabIndex = 5;
            radDtpNS.TabStop = false;
            radDtpNS.Text = "Monday, November 13, 2023";
            radDtpNS.ThemeName = "MaterialTeal";
            radDtpNS.Value = new DateTime(2023, 11, 13, 22, 58, 8, 638);
            // 
            // radLabel7
            // 
            radLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel7.ForeColor = Color.Teal;
            radLabel7.Location = new Point(3, 283);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(72, 21);
            radLabel7.TabIndex = 4;
            radLabel7.Text = "Ngày Sinh";
            radLabel7.ThemeName = "MaterialTeal";
            // 
            // radTxtAdress
            // 
            radTxtAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtAdress.Location = new Point(3, 240);
            radTxtAdress.Name = "radTxtAdress";
            radTxtAdress.Size = new Size(418, 37);
            radTxtAdress.TabIndex = 4;
            radTxtAdress.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel6.ForeColor = Color.Teal;
            radLabel6.Location = new Point(3, 213);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(53, 21);
            radLabel6.TabIndex = 3;
            radLabel6.Text = "Địa Chỉ";
            radLabel6.ThemeName = "MaterialTeal";
            // 
            // radTxtEmail
            // 
            radTxtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtEmail.Location = new Point(3, 170);
            radTxtEmail.Name = "radTxtEmail";
            radTxtEmail.Size = new Size(418, 37);
            radTxtEmail.TabIndex = 4;
            radTxtEmail.ThemeName = "MaterialTeal";
            // 
            // radTxtPhone
            // 
            radTxtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtPhone.Location = new Point(3, 100);
            radTxtPhone.Name = "radTxtPhone";
            radTxtPhone.Size = new Size(418, 37);
            radTxtPhone.TabIndex = 4;
            radTxtPhone.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel4.ForeColor = Color.Teal;
            radLabel4.Location = new Point(3, 143);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(43, 21);
            radLabel4.TabIndex = 3;
            radLabel4.Text = "Email";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radTxtName
            // 
            radTxtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtName.Location = new Point(3, 30);
            radTxtName.Name = "radTxtName";
            radTxtName.Size = new Size(418, 37);
            radTxtName.TabIndex = 4;
            radTxtName.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.ForeColor = Color.Teal;
            radLabel3.Location = new Point(3, 73);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(97, 21);
            radLabel3.TabIndex = 3;
            radLabel3.Text = "Số Điện Thoại";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(3, 3);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(54, 21);
            radLabel2.TabIndex = 3;
            radLabel2.Text = "Họ Tên";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // UpdateStudents
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStudents";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "UpdateStudents";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radDDClassId).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBNu).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).EndInit();
            ((System.ComponentModel.ISupportInitialize)radDtpNS).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtAdress).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadGridView examGridView;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadDateTimePicker radDtpNS;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox radTxtAdress;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox radTxtEmail;
        private Telerik.WinControls.UI.RadTextBox radTxtPhone;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTxtName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadRadioButton radBNu;
        private Telerik.WinControls.UI.RadRadioButton radBNam;
        private Telerik.WinControls.UI.RadDropDownList radDDClassId;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}
