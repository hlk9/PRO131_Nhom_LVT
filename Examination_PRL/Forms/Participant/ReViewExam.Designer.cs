namespace Examination_PRL.Forms.Participant
{
    partial class ReViewExam
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
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            dockParent = new Telerik.WinControls.UI.Docking.RadDock();
            documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            pageViewQuestion = new Telerik.WinControls.UI.RadPageView();
            questionContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            btnEx = new Telerik.WinControls.UI.RadButton();
            listViewQuestion = new Telerik.WinControls.UI.RadListView();
            btnExit = new Telerik.WinControls.UI.RadButton();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            checkBoxComplete = new Telerik.WinControls.UI.RadCheckBox();
            btnSubmit = new Telerik.WinControls.UI.RadButton();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            lblTotalScore = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)dockParent).BeginInit();
            dockParent.SuspendLayout();
            documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pageViewQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionContainer).BeginInit();
            questionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).BeginInit();
            documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).BeginInit();
            toolTabStrip1.SuspendLayout();
            toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listViewQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkBoxComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dockParent
            // 
            dockParent.ActiveWindow = documentWindow1;
            dockParent.CausesValidation = false;
            dockParent.Controls.Add(questionContainer);
            dockParent.Controls.Add(toolTabStrip1);
            dockParent.Dock = DockStyle.Fill;
            dockParent.IsCleanUpTarget = true;
            dockParent.Location = new Point(0, 0);
            dockParent.MainDocumentContainer = questionContainer;
            dockParent.Name = "dockParent";
            dockParent.Padding = new Padding(0);
            // 
            // 
            // 
            dockParent.RootElement.MinSize = new Size(25, 25);
            dockParent.Size = new Size(1561, 689);
            dockParent.SplitterWidth = 8;
            dockParent.TabIndex = 1;
            dockParent.TabStop = false;
            dockParent.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            documentWindow1.Controls.Add(pageViewQuestion);
            documentWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            documentWindow1.Location = new Point(4, 4);
            documentWindow1.Name = "documentWindow1";
            documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            documentWindow1.Size = new Size(1261, 681);
            documentWindow1.Text = "documentWindow1";
            // 
            // pageViewQuestion
            // 
            pageViewQuestion.Dock = DockStyle.Fill;
            pageViewQuestion.Location = new Point(0, 0);
            pageViewQuestion.Name = "pageViewQuestion";
            pageViewQuestion.Size = new Size(1261, 681);
            pageViewQuestion.TabIndex = 0;
            pageViewQuestion.ThemeName = "MaterialTeal";
            pageViewQuestion.SelectedPageChanged += pageViewQuestion_SelectedPageChanged;
            pageViewQuestion.SizeChanged += pageViewQuestion_SizeChanged;
            ((Telerik.WinControls.UI.RadPageViewStripElement)pageViewQuestion.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.ItemList;
            // 
            // questionContainer
            // 
            questionContainer.CausesValidation = false;
            questionContainer.Controls.Add(documentTabStrip1);
            questionContainer.Name = "questionContainer";
            // 
            // 
            // 
            questionContainer.RootElement.MinSize = new Size(25, 25);
            questionContainer.SizeInfo.AbsoluteSize = new Size(1261, 200);
            questionContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            questionContainer.SizeInfo.SplitterCorrection = new Size(-84, 0);
            questionContainer.SplitterWidth = 8;
            questionContainer.ThemeName = "MaterialTeal";
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
            documentTabStrip1.Size = new Size(1269, 689);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow1);
            toolTabStrip1.Location = new Point(1277, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(284, 689);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(284, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(84, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(lblTotalScore);
            toolWindow1.Controls.Add(radLabel2);
            toolWindow1.Controls.Add(btnEx);
            toolWindow1.Controls.Add(listViewQuestion);
            toolWindow1.Controls.Add(btnExit);
            toolWindow1.Controls.Add(radLabel1);
            toolWindow1.Controls.Add(checkBoxComplete);
            toolWindow1.Controls.Add(btnSubmit);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(276, 633);
            toolWindow1.Text = "Chi tiết";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // btnEx
            // 
            btnEx.Anchor = AnchorStyles.Bottom;
            btnEx.BackColor = Color.Brown;
            btnEx.ForeColor = Color.White;
            btnEx.Location = new Point(3, 594);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(270, 36);
            btnEx.TabIndex = 5;
            btnEx.Text = "Thoát";
            btnEx.ThemeName = "MaterialTeal";
            btnEx.Visible = false;
            btnEx.Click += btnEx_Click;
            // 
            // listViewQuestion
            // 
            listViewQuestion.AllowEdit = false;
            listViewQuestion.AllowRemove = false;
            listViewQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewQuestion.AutoSizeColumnsMode = Telerik.WinControls.UI.ListViewAutoSizeColumnsMode.Fill;
            listViewQuestion.FullRowSelect = false;
            listViewQuestion.GroupItemSize = new Size(200, 36);
            listViewQuestion.ItemSize = new Size(60, 60);
            listViewQuestion.ItemSpacing = 10;
            listViewQuestion.Location = new Point(3, 202);
            listViewQuestion.Name = "listViewQuestion";
            listViewQuestion.Size = new Size(270, 336);
            listViewQuestion.TabIndex = 4;
            listViewQuestion.ThemeName = "MaterialTeal";
            listViewQuestion.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            listViewQuestion.ItemMouseClick += listViewQuestion_ItemMouseClick;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.BackColor = Color.Brown;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(174, 981);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(175, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.ThemeName = "MaterialTeal";
            btnExit.Visible = false;
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top;
            radLabel1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.ForeColor = Color.Teal;
            radLabel1.Location = new Point(50, 169);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(169, 27);
            radLabel1.TabIndex = 3;
            radLabel1.Text = "Danh sách câu hỏi";
            // 
            // checkBoxComplete
            // 
            checkBoxComplete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxComplete.Location = new Point(3, 988);
            checkBoxComplete.Name = "checkBoxComplete";
            checkBoxComplete.Size = new Size(162, 19);
            checkBoxComplete.TabIndex = 2;
            checkBoxComplete.Text = "Đã hoàn thành bài thi";
            checkBoxComplete.ThemeName = "MaterialTeal";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(3, 1026);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(346, 37);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Nộp bài";
            btnSubmit.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top;
            radLabel2.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(70, 3);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(129, 34);
            radLabel2.TabIndex = 4;
            radLabel2.Text = "Tổng điểm";
            // 
            // lblTotalScore
            // 
            lblTotalScore.Anchor = AnchorStyles.Top;
            lblTotalScore.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalScore.ForeColor = Color.Teal;
            lblTotalScore.Location = new Point(122, 43);
            lblTotalScore.Name = "lblTotalScore";
            lblTotalScore.Size = new Size(20, 27);
            lblTotalScore.TabIndex = 4;
            lblTotalScore.Text = "0";
            // 
            // ReViewExam
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 689);
            Controls.Add(dockParent);
            Name = "ReViewExam";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ReViewExam";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)dockParent).EndInit();
            dockParent.ResumeLayout(false);
            documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pageViewQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionContainer).EndInit();
            questionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip1).EndInit();
            documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolTabStrip1).EndInit();
            toolTabStrip1.ResumeLayout(false);
            toolWindow1.ResumeLayout(false);
            toolWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEx).EndInit();
            ((System.ComponentModel.ISupportInitialize)listViewQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkBoxComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSubmit).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock dockParent;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox checkBoxComplete;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.Docking.DocumentContainer questionContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadPageView pageViewQuestion;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.RadListView listViewQuestion;
        private Telerik.WinControls.UI.RadButton btnEx;
        private Telerik.WinControls.UI.RadLabel lblTotalScore;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
