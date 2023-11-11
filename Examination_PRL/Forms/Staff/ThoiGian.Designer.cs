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
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(components);
            radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            radCalendar2 = new Telerik.WinControls.UI.RadCalendar();
            ((System.ComponentModel.ISupportInitialize)radSchedulerNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radScheduler1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar2).BeginInit();
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
            radSchedulerNavigator1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radSchedulerNavigator1.AssociatedScheduler = null;
            radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            radSchedulerNavigator1.Location = new Point(217, 9);
            radSchedulerNavigator1.Margin = new Padding(3, 2, 3, 2);
            radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            radSchedulerNavigator1.RootElement.StretchVertically = false;
            radSchedulerNavigator1.Size = new Size(1491, 118);
            radSchedulerNavigator1.TabIndex = 0;
            radSchedulerNavigator1.ThemeName = "MaterialTeal";
            // 
            // radScheduler1
            // 
            radScheduler1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radScheduler1.Location = new Point(217, 102);
            radScheduler1.Margin = new Padding(3, 2, 3, 2);
            radScheduler1.Name = "radScheduler1";
            radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            radScheduler1.Size = new Size(1491, 953);
            radScheduler1.TabIndex = 1;
            radScheduler1.ThemeName = "MaterialTeal";
            // 
            // radCalendar1
            // 
            radCalendar1.HeaderHeight = 32;
            radCalendar1.HeaderWidth = 32;
            radCalendar1.Location = new Point(10, 9);
            radCalendar1.Margin = new Padding(3, 2, 3, 2);
            radCalendar1.Name = "radCalendar1";
            radCalendar1.Size = new Size(201, 194);
            radCalendar1.TabIndex = 2;
            radCalendar1.ThemeName = "MaterialTeal";
            // 
            // radCalendar2
            // 
            radCalendar2.HeaderHeight = 32;
            radCalendar2.HeaderWidth = 32;
            radCalendar2.Location = new Point(10, 230);
            radCalendar2.Margin = new Padding(3, 2, 3, 2);
            radCalendar2.Name = "radCalendar2";
            radCalendar2.Size = new Size(201, 189);
            radCalendar2.TabIndex = 3;
            radCalendar2.ThemeName = "MaterialTeal";
            // 
            // ThoiGian
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(989, 625);
            Controls.Add(radCalendar2);
            Controls.Add(radCalendar1);
            Controls.Add(radScheduler1);
            Controls.Add(radSchedulerNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)radScheduler1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radCalendar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadCalendar radCalendar2;
    }
}
