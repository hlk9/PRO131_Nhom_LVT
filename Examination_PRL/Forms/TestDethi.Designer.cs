namespace Examination_PRL.Forms
{
    partial class TestDethi
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
            radLayoutControl1 = new Telerik.WinControls.UI.RadLayoutControl();
            radPanel2 = new Telerik.WinControls.UI.RadPanel();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            layoutControlTabbedGroup1 = new Telerik.WinControls.UI.LayoutControlTabbedGroup();
            layoutControlLabelItem1 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            layoutControlSplitterItem1 = new Telerik.WinControls.UI.LayoutControlSplitterItem();
            layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            layoutControlItem1 = new Telerik.WinControls.UI.LayoutControlItem();
            layoutControlItem2 = new Telerik.WinControls.UI.LayoutControlItem();
            layoutControlSplitterItem2 = new Telerik.WinControls.UI.LayoutControlSplitterItem();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)radLayoutControl1).BeginInit();
            radLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radPanel2).BeginInit();
            radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLayoutControl1
            // 
            radLayoutControl1.Controls.Add(radPanel2);
            radLayoutControl1.Controls.Add(radPanel1);
            radLayoutControl1.Dock = DockStyle.Fill;
            radLayoutControl1.HiddenItems.AddRange(new Telerik.WinControls.RadItem[] { layoutControlTabbedGroup1, layoutControlLabelItem1, layoutControlSplitterItem1, layoutControlLabelItem2 });
            radLayoutControl1.Items.AddRange(new Telerik.WinControls.RadItem[] { layoutControlItem1, layoutControlItem2, layoutControlSplitterItem2 });
            radLayoutControl1.Location = new Point(0, 0);
            radLayoutControl1.Name = "radLayoutControl1";
            radLayoutControl1.Size = new Size(983, 581);
            radLayoutControl1.TabIndex = 0;
            radLayoutControl1.ThemeName = "MaterialTeal";
            // 
            // radPanel2
            // 
            radPanel2.BackColor = Color.Linen;
            radPanel2.Controls.Add(radLabel2);
            radPanel2.Location = new Point(732, 4);
            radPanel2.Name = "radPanel2";
            radPanel2.Size = new Size(247, 573);
            radPanel2.TabIndex = 3;
            radPanel2.ThemeName = "MaterialTeal";
            // 
            // radPanel1
            // 
            radPanel1.BackColor = Color.Beige;
            radPanel1.Controls.Add(radLabel1);
            radPanel1.Location = new Point(4, 4);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(718, 573);
            radPanel1.TabIndex = 2;
            radPanel1.ThemeName = "MaterialTeal";
            // 
            // layoutControlTabbedGroup1
            // 
            layoutControlTabbedGroup1.Bounds = new Rectangle(0, 0, 981, 579);
            layoutControlTabbedGroup1.Name = "layoutControlTabbedGroup1";
            // 
            // layoutControlLabelItem1
            // 
            layoutControlLabelItem1.Bounds = new Rectangle(468, 0, 194, 579);
            layoutControlLabelItem1.DrawText = false;
            layoutControlLabelItem1.Name = "layoutControlLabelItem1";
            // 
            // layoutControlSplitterItem1
            // 
            layoutControlSplitterItem1.Bounds = new Rectangle(662, 0, 4, 579);
            layoutControlSplitterItem1.Name = "layoutControlSplitterItem1";
            // 
            // layoutControlLabelItem2
            // 
            layoutControlLabelItem2.Bounds = new Rectangle(662, 0, 319, 579);
            layoutControlLabelItem2.DrawText = false;
            layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AssociatedControl = radPanel1;
            layoutControlItem1.Bounds = new Rectangle(0, 0, 724, 579);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Text = "radPanel1";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AssociatedControl = radPanel2;
            layoutControlItem2.Bounds = new Rectangle(728, 0, 253, 579);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Text = "radPanel2";
            // 
            // layoutControlSplitterItem2
            // 
            layoutControlSplitterItem2.Bounds = new Rectangle(724, 0, 4, 579);
            layoutControlSplitterItem2.Name = "layoutControlSplitterItem2";
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.Location = new Point(275, 109);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(89, 18);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Danh sách ở đây";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.Location = new Point(76, 273);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(91, 18);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Thông tin chi tiết";
            // 
            // TestDethi
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 581);
            Controls.Add(radLayoutControl1);
            Name = "TestDethi";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "TestDethi";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLayoutControl1).EndInit();
            radLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radPanel2).EndInit();
            radPanel2.ResumeLayout(false);
            radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLayoutControl radLayoutControl1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.LayoutControlTabbedGroup layoutControlTabbedGroup1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
        private Telerik.WinControls.UI.LayoutControlSplitterItem layoutControlSplitterItem1;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.LayoutControlSplitterItem layoutControlSplitterItem2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
