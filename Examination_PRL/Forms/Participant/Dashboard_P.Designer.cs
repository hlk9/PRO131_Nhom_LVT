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
            radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            btn_Send = new Telerik.WinControls.UI.RadButton();
            btn_Reset = new Telerik.WinControls.UI.RadButton();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            tbt_Content = new Telerik.WinControls.UI.RadRichTextEditor();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            tbt_IDParticipant = new Telerik.WinControls.UI.RadTextBox();
            tbt_Name = new Telerik.WinControls.UI.RadTextBox();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            tbt_Title = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)radPageView1).BeginInit();
            radPageView1.SuspendLayout();
            radPageViewPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Send).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Reset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Content).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbt_IDParticipant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Title).BeginInit();
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
            radPageView1.SelectedPage = radPageViewPage4;
            radPageView1.Size = new Size(1277, 706);
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
            // 
            // 
            radPageViewPage2.ItemSize = new SizeF(80F, 49F);
            radPageViewPage2.Location = new Point(6, 55);
            radPageViewPage2.Name = "radPageViewPage2";
            radPageViewPage2.Size = new Size(1265, 645);
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
            radPageViewPage4.Controls.Add(btn_Send);
            radPageViewPage4.Controls.Add(btn_Reset);
            radPageViewPage4.Controls.Add(radLabel7);
            radPageViewPage4.Controls.Add(radLabel1);
            radPageViewPage4.Controls.Add(tbt_Content);
            radPageViewPage4.Controls.Add(radLabel2);
            radPageViewPage4.Controls.Add(radLabel3);
            radPageViewPage4.Controls.Add(tbt_IDParticipant);
            radPageViewPage4.Controls.Add(tbt_Name);
            radPageViewPage4.Controls.Add(radLabel6);
            radPageViewPage4.Controls.Add(tbt_Title);
            radPageViewPage4.ItemSize = new SizeF(84F, 49F);
            radPageViewPage4.Location = new Point(6, 55);
            radPageViewPage4.Name = "radPageViewPage4";
            radPageViewPage4.Size = new Size(1265, 645);
            radPageViewPage4.Text = "Trợ Giúp";
            // 
            // btn_Send
            // 
            btn_Send.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Send.BackColor = Color.Teal;
            btn_Send.ForeColor = Color.White;
            btn_Send.Location = new Point(432, 518);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(120, 36);
            btn_Send.TabIndex = 19;
            btn_Send.Text = "Gửi phản hồi";
            btn_Send.ThemeName = "MaterialTeal";
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Reset.BackColor = Color.Teal;
            btn_Reset.ForeColor = Color.White;
            btn_Reset.Location = new Point(706, 518);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(120, 36);
            btn_Reset.TabIndex = 18;
            btn_Reset.Text = "Làm mới";
            btn_Reset.ThemeName = "MaterialTeal";
            btn_Reset.Click += btn_Reset_Click;
            // 
            // radLabel7
            // 
            radLabel7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel7.Location = new Point(525, 20);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(208, 36);
            radLabel7.TabIndex = 20;
            radLabel7.Text = "GỬI PHẢN HỒI";
            radLabel7.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.Location = new Point(314, 96);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(55, 21);
            radLabel1.TabIndex = 11;
            radLabel1.Text = "Tiêu đề";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // tbt_Content
            // 
            tbt_Content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbt_Content.BorderColor = Color.FromArgb(224, 224, 224);
            tbt_Content.Location = new Point(432, 331);
            tbt_Content.Name = "tbt_Content";
            tbt_Content.SelectionFill = Color.FromArgb(128, 128, 203, 196);
            tbt_Content.SelectionStroke = Color.FromArgb(128, 203, 196);
            tbt_Content.Size = new Size(394, 170);
            tbt_Content.TabIndex = 17;
            tbt_Content.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.Location = new Point(314, 173);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(68, 21);
            radLabel2.TabIndex = 10;
            radLabel2.Text = "Họ và tên";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.Location = new Point(314, 250);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(49, 21);
            radLabel3.TabIndex = 9;
            radLabel3.Text = "Mã SV";
            radLabel3.ThemeName = "MaterialTeal";
            // 
            // tbt_IDParticipant
            // 
            tbt_IDParticipant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbt_IDParticipant.Location = new Point(432, 234);
            tbt_IDParticipant.Name = "tbt_IDParticipant";
            tbt_IDParticipant.Size = new Size(394, 37);
            tbt_IDParticipant.TabIndex = 14;
            tbt_IDParticipant.ThemeName = "MaterialTeal";
            // 
            // tbt_Name
            // 
            tbt_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbt_Name.Location = new Point(432, 157);
            tbt_Name.Name = "tbt_Name";
            tbt_Name.Size = new Size(394, 37);
            tbt_Name.TabIndex = 15;
            tbt_Name.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel6.Location = new Point(314, 331);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(65, 21);
            radLabel6.TabIndex = 6;
            radLabel6.Text = "Nội dụng";
            radLabel6.ThemeName = "MaterialTeal";
            // 
            // tbt_Title
            // 
            tbt_Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbt_Title.Location = new Point(432, 80);
            tbt_Title.Name = "tbt_Title";
            tbt_Title.Size = new Size(394, 37);
            tbt_Title.TabIndex = 16;
            tbt_Title.ThemeName = "MaterialTeal";
            // 
            // Dashboard_P
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 706);
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
            radPageViewPage4.ResumeLayout(false);
            radPageViewPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Send).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Reset).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Content).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbt_IDParticipant).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Name).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbt_Title).EndInit();
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
        private Telerik.WinControls.UI.RadButton btn_Send;
        private Telerik.WinControls.UI.RadButton btn_Reset;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadRichTextEditor tbt_Content;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox tbt_IDParticipant;
        private Telerik.WinControls.UI.RadTextBox tbt_Name;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox tbt_Title;
    }
}
