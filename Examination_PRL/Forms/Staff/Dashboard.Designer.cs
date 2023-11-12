namespace Examination_PRL.Forms.Staff
{
    partial class Dashboard
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
            visualStudio2022LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2022LightTheme();
            pvDashboard = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)pvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // pvDashboard
            // 
            pvDashboard.Dock = DockStyle.Fill;
            pvDashboard.Location = new Point(0, 0);
            pvDashboard.Name = "pvDashboard";
            pvDashboard.Padding = new Padding(0, 0, 15, 0);
            pvDashboard.Size = new Size(998, 663);
            pvDashboard.TabIndex = 0;
            pvDashboard.ThemeName = "MaterialTeal";
            pvDashboard.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            // 
            // Dashboard
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 663);
            Controls.Add(pvDashboard);
            Name = "Dashboard";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)pvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.VisualStudio2022LightTheme visualStudio2022LightTheme1;
        private Telerik.WinControls.UI.RadPageView pvDashboard;
    }
}
