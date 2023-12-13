namespace Examination_PRL
{
    partial class ThoiGian
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
            components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(components);
            radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            radCalendar2 = new Telerik.WinControls.UI.RadCalendar();
            radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            scheduleNavigator = new Telerik.WinControls.UI.RadSchedulerNavigator();
            scheduleDetail = new Telerik.WinControls.UI.RadScheduler();
            documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            documentTabStrip2 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            ((System.ComponentModel.ISupportInitialize)radSchedulerNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radScheduler1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radDock1).BeginInit();
            radDock1.SuspendLayout();
            toolWindow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleNavigator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).BeginInit();
            documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).BeginInit();
            documentTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radSchedulerReminder1
            // 
            radSchedulerReminder1.AssociatedScheduler = null;
            radSchedulerReminder1.ThemeName = null;
            radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radSchedulerNavigator1
            // 
            radSchedulerNavigator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radSchedulerNavigator1.AssociatedScheduler = null;
            radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            radSchedulerNavigator1.Location = new Point(1071, 392);
            radSchedulerNavigator1.Margin = new Padding(0, 0, 10, 0);
            radSchedulerNavigator1.MaximumSize = new Size(1402, 100);
            radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            radSchedulerNavigator1.RootElement.MaxSize = new Size(1402, 100);
            radSchedulerNavigator1.RootElement.StretchVertically = false;
            radSchedulerNavigator1.Size = new Size(1402, 100);
            radSchedulerNavigator1.TabIndex = 0;
            radSchedulerNavigator1.ThemeName = "MaterialTeal";
            // 
            // radCalendar1
            // 
            radCalendar1.HeaderHeight = 32;
            radCalendar1.HeaderWidth = 32;
            radCalendar1.Location = new Point(860, 392);
            radCalendar1.Margin = new Padding(3, 2, 3, 2);
            radCalendar1.Name = "radCalendar1";
            radCalendar1.Size = new Size(208, 194);
            radCalendar1.TabIndex = 2;
            radCalendar1.ThemeName = "MaterialTeal";
            // 
            // radCalendar2
            // 
            radCalendar2.HeaderHeight = 32;
            radCalendar2.HeaderWidth = 32;
            radCalendar2.Location = new Point(860, 590);
            radCalendar2.Margin = new Padding(3, 2, 3, 2);
            radCalendar2.Name = "radCalendar2";
            radCalendar2.Size = new Size(208, 190);
            radCalendar2.TabIndex = 3;
            radCalendar2.ThemeName = "MaterialTeal";
            // 
            // radScheduler1
            // 
            radScheduler1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radScheduler1.Location = new Point(1071, 492);
            radScheduler1.Margin = new Padding(0, 0, 10, 0);
            radScheduler1.MaximumSize = new Size(1402, 820);
            radScheduler1.Name = "radScheduler1";
            radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            // 
            // 
            // 
            radScheduler1.RootElement.MaxSize = new Size(1402, 820);
            radScheduler1.Size = new Size(1402, 563);
            radScheduler1.TabIndex = 1;
            radScheduler1.ThemeName = "MaterialTeal";
            // 
            // radDock1
            // 
            radDock1.ActiveWindow = toolWindow2;
            radDock1.CausesValidation = false;
            radDock1.Controls.Add(documentContainer1);
            radDock1.Dock = DockStyle.Fill;
            radDock1.IsCleanUpTarget = true;
            radDock1.Location = new Point(0, 0);
            radDock1.MainDocumentContainer = documentContainer1;
            radDock1.Name = "radDock1";
            radDock1.Padding = new Padding(0);
            // 
            // 
            // 
            radDock1.RootElement.MinSize = new Size(25, 25);
            radDock1.Size = new Size(1729, 702);
            radDock1.SplitterWidth = 8;
            radDock1.TabIndex = 4;
            radDock1.TabStop = false;
            radDock1.ThemeName = "MaterialTeal";
            // 
            // toolWindow2
            // 
            toolWindow2.Caption = null;
            toolWindow2.Controls.Add(scheduleNavigator);
            toolWindow2.Controls.Add(scheduleDetail);
            toolWindow2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolWindow2.Location = new Point(4, 4);
            toolWindow2.Name = "toolWindow2";
            toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Floating;
            toolWindow2.Size = new Size(1721, 694);
            toolWindow2.Text = "toolWindow3";
            // 
            // scheduleNavigator
            // 
            scheduleNavigator.AssociatedScheduler = scheduleDetail;
            scheduleNavigator.DateFormat = "yyyy/MM/dd";
            scheduleNavigator.Dock = DockStyle.Top;
            scheduleNavigator.Location = new Point(0, 0);
            scheduleNavigator.Name = "scheduleNavigator";
            scheduleNavigator.NavigationStep = 7;
            scheduleNavigator.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            scheduleNavigator.RootElement.StretchVertically = false;
            scheduleNavigator.Size = new Size(1721, 118);
            scheduleNavigator.TabIndex = 1;
            scheduleNavigator.ThemeName = "MaterialTeal";
            // 
            // scheduleDetail
            // 
            scheduleDetail.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            scheduleDetail.AllowAppointmentCreateInline = false;
            scheduleDetail.AllowAppointmentMove = false;
            scheduleDetail.AllowAppointmentResize = false;
            scheduleDetail.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow;
            scheduleDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scheduleDetail.AutoScroll = true;
            scheduleDetail.Culture = new System.Globalization.CultureInfo("vi-VN");
            scheduleDetail.Location = new Point(0, 124);
            scheduleDetail.Name = "scheduleDetail";
            scheduleDetail.PrintStyle = schedulerDailyPrintStyle2;
            scheduleDetail.ReadOnly = true;
            scheduleDetail.Size = new Size(1721, 570);
            scheduleDetail.TabIndex = 0;
            scheduleDetail.ThemeName = "MaterialTeal";
            // 
            // documentContainer1
            // 
            documentContainer1.CausesValidation = false;
            documentContainer1.Controls.Add(documentTabStrip2);
            documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            documentContainer1.RootElement.MinSize = new Size(25, 25);
            documentContainer1.SizeInfo.AbsoluteSize = new Size(710, 200);
            documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainer1.SizeInfo.SplitterCorrection = new Size(-74, 0);
            documentContainer1.SplitterWidth = 8;
            documentContainer1.TabIndex = 2;
            documentContainer1.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip2
            // 
            documentTabStrip2.CanUpdateChildIndex = true;
            documentTabStrip2.CausesValidation = false;
            documentTabStrip2.Controls.Add(toolWindow2);
            documentTabStrip2.Location = new Point(0, 0);
            documentTabStrip2.Name = "documentTabStrip2";
            // 
            // 
            // 
            documentTabStrip2.RootElement.MinSize = new Size(25, 25);
            documentTabStrip2.SelectedIndex = 0;
            documentTabStrip2.Size = new Size(1729, 702);
            documentTabStrip2.TabIndex = 0;
            documentTabStrip2.TabStop = false;
            documentTabStrip2.TabStripVisible = false;
            documentTabStrip2.ThemeName = "MaterialTeal";
            // 
            // ThoiGian
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1729, 702);
            Controls.Add(radDock1);
            Controls.Add(radScheduler1);
            Controls.Add(radSchedulerNavigator1);
            Controls.Add(radCalendar1);
            Controls.Add(radCalendar2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThoiGian";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "RadForm1";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radSchedulerNavigator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radScheduler1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radDock1).EndInit();
            radDock1.ResumeLayout(false);
            toolWindow2.ResumeLayout(false);
            toolWindow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleNavigator).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentContainer1).EndInit();
            documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)documentTabStrip2).EndInit();
            documentTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadCalendar radCalendar2;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.RadSchedulerNavigator scheduleNavigator;
        private Telerik.WinControls.UI.RadScheduler scheduleDetail;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip2;
    }
}
