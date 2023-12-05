namespace Examination_PRL.Forms.Staff.FullStaff
{
    partial class CrudTK
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
            radView_Staff = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow4 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radCmbQuyen = new Telerik.WinControls.UI.RadDropDownList();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radTextId = new Telerik.WinControls.UI.RadTextBox();
            radTextUserName = new Telerik.WinControls.UI.RadTextBox();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radTxtPassWord = new Telerik.WinControls.UI.RadTextBox();
            radBtnReset = new Telerik.WinControls.UI.RadButton();
            radButnXoa = new Telerik.WinControls.UI.RadButton();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radButnThem = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radView_Staff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radView_Staff.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip2).BeginInit();
            toolTabStrip2.SuspendLayout();
            toolWindow4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radCmbQuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButnXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButnThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow1;
            radDock1.CausesValidation = false;
            radDock1.Controls.Add(documentContainer1);
            radDock1.Controls.Add(toolTabStrip2);
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
            radDock1.Size = new Size(1297, 644);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radView_Staff);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 4);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(931, 636);
            toolWindow1.Text = "toolWindow2";
            // 
            // radView_Staff
            // 
            radView_Staff.Dock = DockStyle.Fill;
            radView_Staff.Location = new Point(0, 0);
            // 
            // 
            // 
            radView_Staff.MasterTemplate.AllowAddNewRow = false;
            radView_Staff.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radView_Staff.MasterTemplate.EnablePaging = true;
            radView_Staff.MasterTemplate.ViewDefinition = tableViewDefinition2;
            radView_Staff.Name = "radView_Staff";
            radView_Staff.Size = new Size(931, 636);
            radView_Staff.TabIndex = 0;
            radView_Staff.ThemeName = "MaterialTeal";
            radView_Staff.CellClick += radView_Staff_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(931, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-234, 0);
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
            documentTabStrip1.Size = new Size(939, 644);
            documentTabStrip1.SizeInfo.AutoSizeScale = new SizeF(0.00241547823F, 0F);
            documentTabStrip1.SizeInfo.SplitterCorrection = new Size(-1, 0);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip2
            // 
            toolTabStrip2.CanUpdateChildIndex = true;
            toolTabStrip2.Controls.Add(toolWindow4);
            toolTabStrip2.Location = new Point(947, 0);
            toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            toolTabStrip2.RootElement.MinSize = new Size(25, 25);
            toolTabStrip2.SelectedIndex = 0;
            toolTabStrip2.Size = new Size(350, 644);
            toolTabStrip2.SizeInfo.AbsoluteSize = new Size(350, 200);
            toolTabStrip2.SizeInfo.SplitterCorrection = new Size(150, 0);
            toolTabStrip2.TabIndex = 3;
            toolTabStrip2.TabStop = false;
            toolTabStrip2.ThemeName = "MaterialTeal";
            // 
            // toolWindow4
            // 
            toolWindow4.Caption = null;
            toolWindow4.Controls.Add(radCmbQuyen);
            toolWindow4.Controls.Add(radLabel4);
            toolWindow4.Controls.Add(radTextId);
            toolWindow4.Controls.Add(radTextUserName);
            toolWindow4.Controls.Add(radLabel1);
            toolWindow4.Controls.Add(radLabel2);
            toolWindow4.Controls.Add(radTxtPassWord);
            toolWindow4.Controls.Add(radBtnReset);
            toolWindow4.Controls.Add(radButnXoa);
            toolWindow4.Controls.Add(radLabel3);
            toolWindow4.Controls.Add(radButnThem);
            toolWindow4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow4.Location = new Point(4, 52);
            toolWindow4.Name = "toolWindow4";
            toolWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow4.Size = new Size(342, 588);
            toolWindow4.Text = "Thông Tin Chi Tiết";
            toolWindow4.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radCmbQuyen
            // 
            radCmbQuyen.DropDownAnimationEnabled = true;
            radCmbQuyen.Location = new Point(114, 132);
            radCmbQuyen.Name = "radCmbQuyen";
            radCmbQuyen.Size = new Size(224, 37);
            radCmbQuyen.TabIndex = 7;
            radCmbQuyen.Text = "radDropDownList1";
            radCmbQuyen.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Location = new Point(8, 148);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(52, 21);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "Quyền:";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radTextId
            // 
            radTextId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTextId.Location = new Point(114, 3);
            radTextId.Name = "radTextId";
            radTextId.Size = new Size(224, 37);
            radTextId.TabIndex = 3;
            radTextId.ThemeName = "MaterialTeal";
            // 
            // radTextUserName
            // 
            radTextUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTextUserName.Location = new Point(114, 46);
            radTextUserName.Name = "radTextUserName";
            radTextUserName.Size = new Size(224, 37);
            radTextUserName.TabIndex = 4;
            radTextUserName.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(8, 19);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(100, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Mã Tài Khoản:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(8, 62);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(79, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "UserName:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radTxtPassWord
            // 
            radTxtPassWord.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTxtPassWord.Location = new Point(115, 89);
            radTxtPassWord.Name = "radTxtPassWord";
            radTxtPassWord.Size = new Size(224, 37);
            radTxtPassWord.TabIndex = 5;
            radTxtPassWord.ThemeName = "MaterialTeal";
            // 
            // radBtnReset
            // 
            radBtnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnReset.BackColor = Color.Teal;
            radBtnReset.ForeColor = Color.White;
            radBtnReset.Location = new Point(3, 530);
            radBtnReset.Name = "radBtnReset";
            radBtnReset.Size = new Size(333, 45);
            radBtnReset.TabIndex = 5;
            radBtnReset.Text = "Reset Mật Khẩu";
            radBtnReset.ThemeName = "MaterialTeal";
            // 
            // radButnXoa
            // 
            radButnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radButnXoa.BackColor = Color.Teal;
            radButnXoa.ForeColor = Color.White;
            radButnXoa.Location = new Point(3, 479);
            radButnXoa.Name = "radButnXoa";
            radButnXoa.Size = new Size(333, 45);
            radButnXoa.TabIndex = 4;
            radButnXoa.Text = "Xóa Tài Khoản";
            radButnXoa.ThemeName = "MaterialTeal";
            radButnXoa.Click += radButnXoa_Click;
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(8, 105);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(77, 21);
            radLabel3.TabIndex = 2;
            radLabel3.Text = "PassWord:";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radButnThem
            // 
            radButnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radButnThem.BackColor = Color.Teal;
            radButnThem.ForeColor = Color.White;
            radButnThem.Location = new Point(3, 428);
            radButnThem.Name = "radButnThem";
            radButnThem.Size = new Size(333, 45);
            radButnThem.TabIndex = 3;
            radButnThem.Text = "Thêm Tài Khoản";
            radButnThem.ThemeName = "MaterialTeal";
            radButnThem.Click += radButnThem_Click;
            // 
            // CrudTK
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 644);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrudTK";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "CrudTK";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radView_Staff.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radView_Staff).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip2).EndInit();
            toolTabStrip2.ResumeLayout(false);
            toolWindow4.ResumeLayout(false);
            toolWindow4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radCmbQuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextId).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtPassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButnXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButnThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadButton radButnXoa;
        private Telerik.WinControls.UI.RadButton radButnThem;
        private Telerik.WinControls.UI.RadButton radBtnReset;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadGridView radView_Staff;
        private Telerik.WinControls.UI.RadGridView radGridView3;
        private Telerik.WinControls.UI.RadTextBox radTextId;
        private Telerik.WinControls.UI.RadTextBox radTextUserName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTxtPassWord;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList radCmbQuyen;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radbtnSua;
    }
}
