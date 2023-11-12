namespace Examination_PRL
{
    partial class OverViewNhanVien
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
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Dock = DockStyle.Fill;
            dtgView.Location = new Point(0, 0);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(780, 468);
            dtgView.TabIndex = 0;
            // 
            // OverViewNhanVien
            // 
            AutoScaleBaseSize = new Size(8, 20);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 468);
            Controls.Add(dtgView);
            Name = "OverViewNhanVien";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "OverViewNhanVien";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private DataGridView dtgView;
    }
}
