namespace Examination_PRL.Forms.Staff
{
    partial class Exam_Overview
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
            layoutControlLabelItem1 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            layoutControlLabelItem2 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            radLayoutControl1 = new Telerik.WinControls.UI.RadLayoutControl();
            panelHeader = new Telerik.WinControls.UI.RadPanel();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            lblTotalExam = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            panelDetail = new Telerik.WinControls.UI.RadPanel();
            radLabel9 = new Telerik.WinControls.UI.RadLabel();
            radLabel8 = new Telerik.WinControls.UI.RadLabel();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            examGridView = new Telerik.WinControls.UI.RadGridView();
            layoutControlItem1 = new Telerik.WinControls.UI.LayoutControlItem();
            layoutControlSplitterItem1 = new Telerik.WinControls.UI.LayoutControlSplitterItem();
            layoutControlItem2 = new Telerik.WinControls.UI.LayoutControlItem();
            layoutControlItem3 = new Telerik.WinControls.UI.LayoutControlItem();
            layoutControlLabelItem3 = new Telerik.WinControls.UI.LayoutControlLabelItem();
            ((System.ComponentModel.ISupportInitialize)radLayoutControl1).BeginInit();
            radLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelDetail).BeginInit();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // layoutControlLabelItem1
            // 
            layoutControlLabelItem1.Bounds = new Rectangle(1422, 0, 242, 726);
            layoutControlLabelItem1.DrawText = false;
            layoutControlLabelItem1.Name = "layoutControlLabelItem1";
            // 
            // layoutControlLabelItem2
            // 
            layoutControlLabelItem2.Bounds = new Rectangle(0, 0, 1664, 127);
            layoutControlLabelItem2.DrawText = false;
            layoutControlLabelItem2.Name = "layoutControlLabelItem2";
            // 
            // radLayoutControl1
            // 
            radLayoutControl1.Controls.Add(panelHeader);
            radLayoutControl1.Controls.Add(panelDetail);
            radLayoutControl1.Controls.Add(examGridView);
            radLayoutControl1.Dock = DockStyle.Fill;
            radLayoutControl1.Items.AddRange(new Telerik.WinControls.RadItem[] { layoutControlItem1, layoutControlSplitterItem1, layoutControlItem2, layoutControlItem3 });
            radLayoutControl1.Location = new Point(0, 0);
            radLayoutControl1.Name = "radLayoutControl1";
            radLayoutControl1.Size = new Size(1666, 728);
            radLayoutControl1.TabIndex = 0;
            radLayoutControl1.ThemeName = "MaterialTeal";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(227, 244, 244);
            panelHeader.Controls.Add(radLabel5);
            panelHeader.Controls.Add(radTextBox1);
            panelHeader.Controls.Add(radLabel4);
            panelHeader.Controls.Add(radLabel2);
            panelHeader.Controls.Add(lblTotalExam);
            panelHeader.Controls.Add(radLabel3);
            panelHeader.Controls.Add(radLabel1);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(4, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1658, 126);
            panelHeader.TabIndex = 1;
            panelHeader.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel5.Location = new Point(7, 93);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(170, 27);
            radLabel5.TabIndex = 4;
            radLabel5.Text = "Các bài thi hiện có";
            // 
            // radTextBox1
            // 
            radTextBox1.Location = new Point(941, 85);
            radTextBox1.Name = "radTextBox1";
            radTextBox1.NullText = "Nhập từ khoá ";
            radTextBox1.ShowNullText = true;
            radTextBox1.Size = new Size(350, 37);
            radTextBox1.TabIndex = 4;
            radTextBox1.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel4.Location = new Point(844, 89);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(91, 27);
            radLabel4.TabIndex = 3;
            radLabel4.Text = "Tìm kiếm";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(499, 7);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(20, 27);
            radLabel2.TabIndex = 3;
            radLabel2.Text = "0";
            // 
            // lblTotalExam
            // 
            lblTotalExam.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalExam.ForeColor = Color.Teal;
            lblTotalExam.Location = new Point(152, 7);
            lblTotalExam.Name = "lblTotalExam";
            lblTotalExam.Size = new Size(20, 27);
            lblTotalExam.TabIndex = 1;
            lblTotalExam.Text = "0";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel3.Location = new Point(341, 7);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(152, 27);
            radLabel3.TabIndex = 2;
            radLabel3.Text = "Tổng số môn thi";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(7, 7);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(139, 27);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Tổng số bài thi";
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(radLabel9);
            panelDetail.Controls.Add(radLabel8);
            panelDetail.Controls.Add(radLabel7);
            panelDetail.Controls.Add(radPanel1);
            panelDetail.Location = new Point(1277, 136);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(385, 588);
            panelDetail.TabIndex = 3;
            panelDetail.ThemeName = "MaterialTeal";
            // 
            // radLabel9
            // 
            radLabel9.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel9.ForeColor = Color.DarkCyan;
            radLabel9.Location = new Point(3, 243);
            radLabel9.Name = "radLabel9";
            radLabel9.Size = new Size(136, 23);
            radLabel9.TabIndex = 6;
            radLabel9.Text = "Tổng số lượng đề";
            // 
            // radLabel8
            // 
            radLabel8.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel8.ForeColor = Color.DarkCyan;
            radLabel8.Location = new Point(3, 200);
            radLabel8.Name = "radLabel8";
            radLabel8.Size = new Size(68, 23);
            radLabel8.TabIndex = 6;
            radLabel8.Text = "Mã môn";
            // 
            // radLabel7
            // 
            radLabel7.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel7.ForeColor = Color.DarkCyan;
            radLabel7.Location = new Point(3, 154);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(68, 23);
            radLabel7.TabIndex = 5;
            radLabel7.Text = "Môn Thi";
            // 
            // radPanel1
            // 
            radPanel1.Controls.Add(radLabel6);
            radPanel1.Location = new Point(3, 3);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(351, 93);
            radPanel1.TabIndex = 1;
            radPanel1.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel6.ForeColor = Color.DarkCyan;
            radLabel6.Location = new Point(102, 27);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(158, 27);
            radLabel6.TabIndex = 4;
            radLabel6.Text = "Thông tin chi tiết";
            // 
            // examGridView
            // 
            examGridView.AutoSize = true;
            examGridView.Dock = DockStyle.Fill;
            examGridView.Location = new Point(4, 429);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowDeleteRow = false;
            examGridView.MasterTemplate.AllowDragToGroup = false;
            examGridView.MasterTemplate.AllowRowResize = false;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examGridView.Name = "examGridView";
            examGridView.Size = new Size(2, 2);
            examGridView.TabIndex = 2;
            examGridView.ThemeName = "MaterialTeal";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AssociatedControl = examGridView;
            layoutControlItem1.Bounds = new Rectangle(0, 132, 1269, 594);
            layoutControlItem1.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Text = "";
            // 
            // layoutControlSplitterItem1
            // 
            layoutControlSplitterItem1.Bounds = new Rectangle(1269, 132, 4, 594);
            layoutControlSplitterItem1.Name = "layoutControlSplitterItem1";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AssociatedControl = panelDetail;
            layoutControlItem2.Bounds = new Rectangle(1273, 132, 391, 594);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Text = "radPanel1";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AssociatedControl = panelHeader;
            layoutControlItem3.Bounds = new Rectangle(0, 0, 1664, 132);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Text = "";
            // 
            // layoutControlLabelItem3
            // 
            layoutControlLabelItem3.Bounds = new Rectangle(0, 52, 1666, 60);
            layoutControlLabelItem3.DrawText = false;
            layoutControlLabelItem3.Name = "layoutControlLabelItem3";
            // 
            // Exam_Overview
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 728);
            Controls.Add(radLayoutControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exam_Overview";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Exam_Overview";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLayoutControl1).EndInit();
            radLayoutControl1.ResumeLayout(false);
            radLayoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTotalExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelDetail).EndInit();
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel9).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem1;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem2;
        private Telerik.WinControls.UI.RadLayoutControl radLayoutControl1;
        private Telerik.WinControls.UI.RadPanel panelHeader;
        private Telerik.WinControls.UI.RadPanel panelDetail;
        private Telerik.WinControls.UI.RadGridView examGridView;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem1;
        private Telerik.WinControls.UI.LayoutControlSplitterItem layoutControlSplitterItem1;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem2;
        private Telerik.WinControls.UI.LayoutControlItem layoutControlItem3;
        private Telerik.WinControls.UI.LayoutControlLabelItem layoutControlLabelItem3;
        private Telerik.WinControls.UI.RadLabel lblTotalExam;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel9;
    }
}
