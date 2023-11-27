namespace Examination_PRL.Forms.Participant
{
    partial class EnterExam
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
            radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            listViewQuestion = new Telerik.WinControls.UI.RadListView();
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
            ((System.ComponentModel.ISupportInitialize)radScrollablePanel1).BeginInit();
            radScrollablePanel1.PanelContainer.SuspendLayout();
            radScrollablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listViewQuestion).BeginInit();
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
            dockParent.TabIndex = 0;
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
            documentWindow1.Size = new Size(1205, 681);
            documentWindow1.Text = "documentWindow1";
            // 
            // pageViewQuestion
            // 
            pageViewQuestion.Dock = DockStyle.Fill;
            pageViewQuestion.Location = new Point(0, 0);
            pageViewQuestion.Name = "pageViewQuestion";
            pageViewQuestion.Size = new Size(1205, 681);
            pageViewQuestion.TabIndex = 0;
            pageViewQuestion.ThemeName = "MaterialTeal";
            pageViewQuestion.SelectedPageChanged += pageViewQuestion_SelectedPageChanged;
            pageViewQuestion.SizeChanged += pageViewQuestion_SizeChanged;
            ((Telerik.WinControls.UI.RadPageViewStripElement)pageViewQuestion.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
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
            questionContainer.SizeInfo.AbsoluteSize = new Size(1297, 200);
            questionContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            questionContainer.SizeInfo.SplitterCorrection = new Size(-140, 0);
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
            documentTabStrip1.Size = new Size(1213, 689);
            documentTabStrip1.TabIndex = 0;
            documentTabStrip1.TabStop = false;
            documentTabStrip1.TabStripVisible = false;
            documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            toolTabStrip1.CanUpdateChildIndex = true;
            toolTabStrip1.Controls.Add(toolWindow1);
            toolTabStrip1.Location = new Point(1221, 0);
            toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            toolTabStrip1.RootElement.MinSize = new Size(25, 25);
            toolTabStrip1.SelectedIndex = 0;
            toolTabStrip1.Size = new Size(340, 689);
            toolTabStrip1.SizeInfo.AbsoluteSize = new Size(340, 200);
            toolTabStrip1.SizeInfo.SplitterCorrection = new Size(140, 0);
            toolTabStrip1.TabIndex = 1;
            toolTabStrip1.TabStop = false;
            toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolWindow1
            // 
            toolWindow1.Caption = null;
            toolWindow1.Controls.Add(radScrollablePanel1);
            toolWindow1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow1.Location = new Point(4, 52);
            toolWindow1.Name = "toolWindow1";
            toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            toolWindow1.Size = new Size(332, 633);
            toolWindow1.Text = "Chi tiết";
            toolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radScrollablePanel1
            // 
            radScrollablePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radScrollablePanel1.Location = new Point(3, 154);
            radScrollablePanel1.Name = "radScrollablePanel1";
            radScrollablePanel1.Padding = new Padding(0);
            // 
            // radScrollablePanel1.PanelContainer
            // 
            radScrollablePanel1.PanelContainer.Controls.Add(listViewQuestion);
            radScrollablePanel1.PanelContainer.Location = new Point(0, 0);
            radScrollablePanel1.PanelContainer.Size = new Size(326, 354);
            radScrollablePanel1.Size = new Size(326, 354);
            radScrollablePanel1.TabIndex = 0;
            radScrollablePanel1.ThemeName = "MaterialTeal";
            // 
            // listViewQuestion
            // 
            listViewQuestion.AllowEdit = false;
            listViewQuestion.AllowRemove = false;
            listViewQuestion.AutoSizeColumnsMode = Telerik.WinControls.UI.ListViewAutoSizeColumnsMode.Fill;
            listViewQuestion.Dock = DockStyle.Fill;
            listViewQuestion.FullRowSelect = false;
            listViewQuestion.GroupItemSize = new Size(200, 36);
            listViewQuestion.ItemSize = new Size(144, 60);
            listViewQuestion.ItemSpacing = 10;
            listViewQuestion.Location = new Point(0, 0);
            listViewQuestion.Name = "listViewQuestion";
            listViewQuestion.Size = new Size(326, 354);
            listViewQuestion.TabIndex = 0;
            listViewQuestion.ThemeName = "MaterialTeal";
            listViewQuestion.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            listViewQuestion.ItemMouseClick += listViewQuestion_ItemMouseClick;
            // 
            // EnterExam
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 689);
            Controls.Add(dockParent);
            Name = "EnterExam";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Vào thi";
            ThemeName = "MaterialTeal";
            WindowState = FormWindowState.Maximized;
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
            radScrollablePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radScrollablePanel1).EndInit();
            radScrollablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listViewQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.Docking.RadDock dockParent;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer questionContainer;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadPageView pageViewQuestion;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
        private Telerik.WinControls.UI.RadListView listViewQuestion;
    }
}
