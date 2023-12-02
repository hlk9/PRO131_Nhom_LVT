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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            radView_Crud = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radBtnThem = new Telerik.WinControls.UI.RadButton();
            radBtnSua = new Telerik.WinControls.UI.RadButton();
            radBtnXoa = new Telerik.WinControls.UI.RadButton();
            radTextMK = new Telerik.WinControls.UI.RadTextBox();
            radTxtName = new Telerik.WinControls.UI.RadTextBox();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radTxtID = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radView_Crud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radView_Crud.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTxtID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
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
            radDock1.Size = new Size(876, 516);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(radView_Crud);
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(595, 508);
            documentWindow1.Text = "documentWindow1";
            // 
            // radView_Crud
            // 
            radView_Crud.Dock = DockStyle.Fill;
            radView_Crud.Location = new Point(0, 0);
            // 
            // 
            // 
            radView_Crud.MasterTemplate.AllowAddNewRow = false;
            radView_Crud.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radView_Crud.MasterTemplate.EnablePaging = true;
            radView_Crud.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radView_Crud.Name = "radView_Crud";
            radView_Crud.Size = new Size(595, 508);
            radView_Crud.TabIndex = 0;
            radView_Crud.ThemeName = "MaterialTeal";
            radView_Crud.CellClick += radView_Crud_CellClick;
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
            documentContainer1.SizeInfo.AbsoluteSize = new Size(585, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-65, 0);
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
            documentTabStrip1.Size = new Size(603, 516);
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
            toolTabStrip1.Location = new Point(611, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(265, 516);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(265, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(65, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radLabel4);
            toolWindow1.Controls.Add(radTxtID);
            toolWindow1.Controls.Add(radBtnThem);
            toolWindow1.Controls.Add(radBtnSua);
            toolWindow1.Controls.Add(radBtnXoa);
            toolWindow1.Controls.Add(radTextMK);
            toolWindow1.Controls.Add(radTxtName);
            toolWindow1.Controls.Add(radLabel3);
            toolWindow1.Controls.Add(radLabel2);
            toolWindow1.Controls.Add(radLabel1);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(257, 460);
            toolWindow1.Text = "Thông TinTài Khoản";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radBtnThem
            // 
            radBtnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnThem.BackColor = Color.Teal;
            radBtnThem.Location = new Point(3, 278);
            radBtnThem.Name = "radBtnThem";
            radBtnThem.Size = new Size(251, 54);
            radBtnThem.TabIndex = 7;
            radBtnThem.Text = " Thêm";
            radBtnThem.ThemeName = "MaterialTeal";
            radBtnThem.Click += radBtnThem_Click;
            // 
            // radBtnSua
            // 
            radBtnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnSua.BackColor = Color.Teal;
            radBtnSua.Location = new Point(3, 338);
            radBtnSua.Name = "radBtnSua";
            radBtnSua.Size = new Size(251, 54);
            radBtnSua.TabIndex = 6;
            radBtnSua.Text = " Sửa";
            radBtnSua.ThemeName = "MaterialTeal";
            radBtnSua.Click += radBtnSua_Click;
            // 
            // radBtnXoa
            // 
            radBtnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radBtnXoa.BackColor = Color.Teal;
            radBtnXoa.Location = new Point(3, 398);
            radBtnXoa.Name = "radBtnXoa";
            radBtnXoa.Size = new Size(251, 54);
            radBtnXoa.TabIndex = 5;
            radBtnXoa.Text = "Xóa";
            radBtnXoa.ThemeName = "MaterialTeal";
            radBtnXoa.Click += radBtnXoa_Click;
            // 
            // radTextMK
            // 
            radTextMK.Location = new Point(116, 89);
            radTextMK.Name = "radTextMK";
            radTextMK.Size = new Size(141, 37);
            radTextMK.TabIndex = 4;
            radTextMK.ThemeName = "MaterialTeal";
            // 
            // radTxtName
            // 
            radTxtName.Location = new Point(117, 46);
            radTxtName.Name = "radTxtName";
            radTxtName.Size = new Size(141, 37);
            radTxtName.TabIndex = 3;
            radTxtName.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(12, 95);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(2, 2);
            radLabel3.TabIndex = 2;
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(3, 105);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(73, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Mật Khẩu:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(3, 62);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(104, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Tên Tài Khoản:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radTxtID
            // 
            radTxtID.Location = new Point(117, 3);
            radTxtID.Name = "radTxtID";
            radTxtID.Size = new Size(141, 37);
            radTxtID.TabIndex = 4;
            radTxtID.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Location = new Point(3, 19);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(24, 21);
            radLabel4.TabIndex = 1;
            radLabel4.Text = "ID:";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // CrudTK
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 516);
            Controls.Add(radDock1);
            Name = "CrudTK";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "CrudTK";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radView_Crud.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radView_Crud).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radBtnThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTxtID).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadGridView radView_Crud;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadTextBox radTxtName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radTextMK;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radBtnThem;
        private Telerik.WinControls.UI.RadButton radBtnSua;
        private Telerik.WinControls.UI.RadButton radBtnXoa;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTxtID;
    }
}
