namespace Examination_PRL.Forms.Staff
{
    partial class SubjectResult
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridViewSubject = new Telerik.WinControls.UI.RadGridView();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip2 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            documentTabStrip3 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolWindow4 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radGridViewExamSubject = new Telerik.WinControls.UI.RadGridView();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radLblSumExamFailed = new Telerik.WinControls.UI.RadLabel();
            radLblSumStudent = new Telerik.WinControls.UI.RadLabel();
            radLblSumExam = new Telerik.WinControls.UI.RadLabel();
            radLblSumExamPass = new Telerik.WinControls.UI.RadLabel();
            radLblSumScore = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridViewSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewSubject.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).BeginInit();
            documentTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip3).BeginInit();
            documentTabStrip3.SuspendLayout();
            toolWindow4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGridViewExamSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExamSubject.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExamFailed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExamPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow2;
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
            radDock1.Size = new Size(1292, 586);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 0;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(radGridViewSubject);
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 4);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow2.Size = new Size(950, 281);
            toolWindow2.Text = "toolWindow3";
            // 
            // radGridViewSubject
            // 
            radGridViewSubject.Dock = DockStyle.Fill;
            radGridViewSubject.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridViewSubject.MasterTemplate.AllowAddNewRow = false;
            radGridViewSubject.MasterTemplate.AllowSearchRow = true;
            radGridViewSubject.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridViewSubject.MasterTemplate.EnablePaging = true;
            radGridViewSubject.MasterTemplate.ViewDefinition = tableViewDefinition3;
            radGridViewSubject.Name = "radGridViewSubject";
            radGridViewSubject.ReadOnly = true;
            radGridViewSubject.Size = new Size(950, 281);
            radGridViewSubject.TabIndex = 0;
            radGridViewSubject.ThemeName = "MaterialTeal";
            radGridViewSubject.CellClick += radGridViewSubject_CellClick;
            // 
            // documentContainer1
            // 
            documentContainer1.CausesValidation = false;
            documentContainer1.Controls.Add(documentTabStrip2);
            documentContainer1.Controls.Add(documentTabStrip3);
            documentContainer1.Name = "documentContainer1";
            documentContainer1.Orientation = Orientation.Horizontal;
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(948, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-126, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip2
            // 
            documentTabStrip2.CanUpdateChildIndex = true;
            documentTabStrip2.Controls.Add(toolWindow2);
            documentTabStrip2.Location = new Point(0, 0);
            documentTabStrip2.Name = "documentTabStrip2";
            // 
            // 
            // 
            documentTabStrip2.RootElement.MinSize = new Size(25, 25);
            documentTabStrip2.SelectedIndex = 0;
            documentTabStrip2.Size = new Size(958, 289);
            documentTabStrip2.SizeInfo.AutoSizeScale = new SizeF(0.0520169735F, 0F);
            documentTabStrip2.SizeInfo.SplitterCorrection = new Size(61, 0);
            documentTabStrip2.TabIndex = 0;
            documentTabStrip2.TabStop = false;
            documentTabStrip2.TabStripVisible = false;
            documentTabStrip2.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip3
            // 
            documentTabStrip3.CanUpdateChildIndex = true;
            documentTabStrip3.CausesValidation = false;
            documentTabStrip3.Controls.Add(toolWindow4);
            documentTabStrip3.Location = new Point(0, 297);
            documentTabStrip3.Name = "documentTabStrip3";
            // 
            // 
            // 
            documentTabStrip3.RootElement.MinSize = new Size(25, 25);
            documentTabStrip3.SelectedIndex = 0;
            documentTabStrip3.Size = new Size(958, 289);
            documentTabStrip3.TabIndex = 1;
            documentTabStrip3.TabStop = false;
            documentTabStrip3.TabStripVisible = false;
            documentTabStrip3.ThemeName = "MaterialTeal";
            // 
            // toolWindow4
            // 
            toolWindow4.Caption = null;
            toolWindow4.Controls.Add(radGridViewExamSubject);
            toolWindow4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow4.Location = new Point(4, 4);
            toolWindow4.Name = "toolWindow4";
            toolWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Floating;
            toolWindow4.Size = new Size(950, 281);
            toolWindow4.Text = "toolWindow4";
            // 
            // radGridViewExamSubject
            // 
            radGridViewExamSubject.Dock = DockStyle.Fill;
            radGridViewExamSubject.Location = new Point(0, 0);
            // 
            // 
            // 
            radGridViewExamSubject.MasterTemplate.AllowAddNewRow = false;
            radGridViewExamSubject.MasterTemplate.AllowSearchRow = true;
            radGridViewExamSubject.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridViewExamSubject.MasterTemplate.EnablePaging = true;
            radGridViewExamSubject.MasterTemplate.ViewDefinition = tableViewDefinition4;
            radGridViewExamSubject.Name = "radGridViewExamSubject";
            radGridViewExamSubject.ReadOnly = true;
            radGridViewExamSubject.Size = new Size(950, 281);
            radGridViewExamSubject.TabIndex = 0;
            radGridViewExamSubject.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow3);
            toolTabStrip1.Location = new Point(966, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(326, 586);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(326, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(126, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow3
            // 
            toolWindow3.Caption = null;
            toolWindow3.Controls.Add(radLblSumScore);
            toolWindow3.Controls.Add(radLblSumExamPass);
            toolWindow3.Controls.Add(radLblSumExam);
            toolWindow3.Controls.Add(radLblSumStudent);
            toolWindow3.Controls.Add(radLblSumExamFailed);
            toolWindow3.Controls.Add(radLabel5);
            toolWindow3.Controls.Add(radLabel4);
            toolWindow3.Controls.Add(radLabel3);
            toolWindow3.Controls.Add(radLabel2);
            toolWindow3.Controls.Add(radLabel1);
            toolWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            toolWindow3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow3.Location = new Point(4, 52);
            toolWindow3.Name = "toolWindow3";
            toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow3.Size = new Size(318, 530);
            toolWindow3.Text = "Thông Tin Chi Tiết";
            toolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radLabel1
            // 
            radLabel1.BackColor = Color.Transparent;
            radLabel1.ForeColor = Color.Teal;
            radLabel1.Location = new Point(3, 3);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(100, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Tổng Thí Sinh:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.BackColor = Color.Transparent;
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(3, 54);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(92, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Tổng Bài Thi:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.BackColor = Color.Transparent;
            radLabel3.ForeColor = Color.Teal;
            radLabel3.Location = new Point(3, 107);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(118, 21);
            radLabel3.TabIndex = 1;
            radLabel3.Text = "Tổng Bài Thi Đạt:";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.BackColor = Color.Transparent;
            radLabel4.ForeColor = Color.Teal;
            radLabel4.Location = new Point(3, 157);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(132, 21);
            radLabel4.TabIndex = 1;
            radLabel4.Text = "Tổng Bài Thi Trượt:";
            radLabel4.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.BackColor = Color.Transparent;
            radLabel5.ForeColor = Color.Teal;
            radLabel5.Location = new Point(3, 212);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(81, 21);
            radLabel5.TabIndex = 1;
            radLabel5.Text = "Tổng Điểm:";
            radLabel5.ThemeName = "MaterialTeal";
            // 
            // radLblSumExamFailed
            // 
            radLblSumExamFailed.BackColor = Color.Transparent;
            radLblSumExamFailed.ForeColor = Color.MediumSlateBlue;
            radLblSumExamFailed.Location = new Point(141, 157);
            radLblSumExamFailed.Name = "radLblSumExamFailed";
            radLblSumExamFailed.Size = new Size(15, 21);
            radLblSumExamFailed.TabIndex = 1;
            radLblSumExamFailed.Text = "0";
            radLblSumExamFailed.ThemeName = "MaterialTeal";
            // 
            // radLblSumStudent
            // 
            radLblSumStudent.BackColor = Color.Transparent;
            radLblSumStudent.ForeColor = Color.MediumSlateBlue;
            radLblSumStudent.Location = new Point(141, 3);
            radLblSumStudent.Name = "radLblSumStudent";
            radLblSumStudent.Size = new Size(15, 21);
            radLblSumStudent.TabIndex = 2;
            radLblSumStudent.Text = "0";
            radLblSumStudent.ThemeName = "MaterialTeal";
            // 
            // radLblSumExam
            // 
            radLblSumExam.BackColor = Color.Transparent;
            radLblSumExam.ForeColor = Color.MediumSlateBlue;
            radLblSumExam.Location = new Point(141, 54);
            radLblSumExam.Name = "radLblSumExam";
            radLblSumExam.Size = new Size(15, 21);
            radLblSumExam.TabIndex = 2;
            radLblSumExam.Text = "0";
            radLblSumExam.ThemeName = "MaterialTeal";
            // 
            // radLblSumExamPass
            // 
            radLblSumExamPass.BackColor = Color.Transparent;
            radLblSumExamPass.ForeColor = Color.MediumSlateBlue;
            radLblSumExamPass.Location = new Point(141, 107);
            radLblSumExamPass.Name = "radLblSumExamPass";
            radLblSumExamPass.Size = new Size(15, 21);
            radLblSumExamPass.TabIndex = 2;
            radLblSumExamPass.Text = "0";
            radLblSumExamPass.ThemeName = "MaterialTeal";
            // 
            // radLblSumScore
            // 
            radLblSumScore.BackColor = Color.Transparent;
            radLblSumScore.ForeColor = Color.MediumSlateBlue;
            radLblSumScore.Location = new Point(141, 212);
            radLblSumScore.Name = "radLblSumScore";
            radLblSumScore.Size = new Size(15, 21);
            radLblSumScore.TabIndex = 2;
            radLblSumScore.Text = "0";
            radLblSumScore.ThemeName = "MaterialTeal";
            // 
            // SubjectResult
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 586);
            Controls.Add(radDock1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubjectResult";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "SubjectResult";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridViewSubject.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).EndInit();
            documentTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip3).EndInit();
            documentTabStrip3.ResumeLayout(false);
            toolWindow4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGridViewExamSubject.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExamSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow3.ResumeLayout(false);
            toolWindow3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExamFailed).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumExamPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadGridView radGridViewSubject;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip3;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadGridView radGridViewExamSubject;
        private Telerik.WinControls.UI.RadLabel radLblSumScore;
        private Telerik.WinControls.UI.RadLabel radLblSumExamPass;
        private Telerik.WinControls.UI.RadLabel radLblSumExam;
        private Telerik.WinControls.UI.RadLabel radLblSumStudent;
        private Telerik.WinControls.UI.RadLabel radLblSumExamFailed;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
