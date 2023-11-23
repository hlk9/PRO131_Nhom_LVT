namespace Examination_PRL.Forms.Participant
{
    partial class Dashboard_P
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
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radPageView1 = new Telerik.WinControls.UI.RadPageView();
            radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)radPageView1).BeginInit();
            radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radScheduler1).BeginInit();
            radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radPageView1
            // 
            radPageView1.Controls.Add(radPageViewPage1);
            radPageView1.Controls.Add(radPageViewPage2);
            radPageView1.Controls.Add(radPageViewPage3);
            radPageView1.Controls.Add(radPageViewPage4);
            radPageView1.Dock = DockStyle.Fill;
            radPageView1.Location = new Point(0, 0);
            radPageView1.Name = "radPageView1";
            radPageView1.SelectedPage = radPageViewPage2;
            radPageView1.Size = new Size(1279, 561);
            radPageView1.TabIndex = 0;
            radPageView1.ThemeName = "MaterialTeal";
            ((Telerik.WinControls.UI.RadPageViewStripElement)radPageView1.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
            // 
            // radPageViewPage1
            // 
            radPageViewPage1.ItemSize = new SizeF(78F, 49F);
            radPageViewPage1.Location = new Point(6, 55);
            radPageViewPage1.Name = "radPageViewPage1";
            radPageViewPage1.Size = new Size(1267, 500);
            radPageViewPage1.Text = "Vào Thi";
            // 
            // radPageViewPage2
            // 
            // 
            // radScheduler1
            // 
            radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Agenda;
            radScheduler1.Dock = DockStyle.Fill;
            radScheduler1.Location = new Point(0, 0);
            radScheduler1.Name = "radScheduler1";
            radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            // 
            // 
            // 
            radScheduler1.RootElement.AutoSize = true;
            radScheduler1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            radScheduler1.Size = new Size(1267, 500);
            radScheduler1.TabIndex = 0;
            radScheduler1.ThemeName = "MaterialTeal";
            ((Telerik.WinControls.UI.RadSchedulerElement)radScheduler1.GetChildAt(0)).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            radPageViewPage2.Controls.Add(radScheduler1);
            radPageViewPage2.ItemSize = new SizeF(80F, 49F);
            radPageViewPage2.Location = new Point(6, 55);
            radPageViewPage2.Name = "radPageViewPage2";
            radPageViewPage2.Size = new Size(1267, 500);
            radPageViewPage2.Text = "Lịch Thi";
            // 
            // radPageViewPage3
            // 
            radPageViewPage3.ItemSize = new SizeF(80F, 49F);
            radPageViewPage3.Location = new Point(6, 55);
            radPageViewPage3.Name = "radPageViewPage3";
            radPageViewPage3.Size = new Size(1267, 500);
            radPageViewPage3.Text = "Kết Quả";
            // 
            // radPageViewPage4
            // 
            radPageViewPage4.ItemSize = new SizeF(84F, 49F);
            radPageViewPage4.Location = new Point(6, 55);
            radPageViewPage4.Name = "radPageViewPage4";
            radPageViewPage4.Size = new Size(1267, 500);
            radPageViewPage4.Text = "Trợ Giúp";
            // 
            // Dashboard_P
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 561);
            Controls.Add(radPageView1);
            Name = "Dashboard_P";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Dashboard";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radPageView1).EndInit();
            radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radScheduler1).EndInit();
            radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
    }
}
