namespace Examination_PRL.Forms.Staff.QuestionForm
{
    partial class EditQuestion
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
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            dropDownType = new Telerik.WinControls.UI.RadDropDownList();
            dropDownLevel = new Telerik.WinControls.UI.RadDropDownList();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            richContent = new Telerik.WinControls.UI.RadRichTextEditor();
            dropDownSubject = new Telerik.WinControls.UI.RadDropDownList();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropDownType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropDownLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)richContent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropDownSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.Location = new Point(29, 57);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(95, 25);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Loại câu hỏi";
            // 
            // dropDownType
            // 
            dropDownType.DropDownAnimationEnabled = true;
            dropDownType.Location = new Point(161, 55);
            dropDownType.Name = "dropDownType";
            dropDownType.Size = new Size(357, 37);
            dropDownType.TabIndex = 1;
            dropDownType.ThemeName = "MaterialTeal";
            // 
            // dropDownLevel
            // 
            dropDownLevel.DropDownAnimationEnabled = true;
            dropDownLevel.Location = new Point(161, 131);
            dropDownLevel.Name = "dropDownLevel";
            dropDownLevel.Size = new Size(357, 37);
            dropDownLevel.TabIndex = 3;
            dropDownLevel.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel2.Location = new Point(29, 133);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(64, 25);
            radLabel2.TabIndex = 2;
            radLabel2.Text = "Mức độ";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel3.Location = new Point(29, 277);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(76, 25);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "Nội dung";
            // 
            // richContent
            // 
            richContent.BorderColor = Color.FromArgb(224, 224, 224);
            richContent.Location = new Point(161, 277);
            richContent.Name = "richContent";
            richContent.SelectionFill = Color.FromArgb(128, 128, 203, 196);
            richContent.SelectionStroke = Color.FromArgb(128, 203, 196);
            richContent.Size = new Size(357, 180);
            richContent.TabIndex = 5;
            richContent.ThemeName = "MaterialTeal";
            // 
            // dropDownSubject
            // 
            dropDownSubject.DropDownAnimationEnabled = true;
            dropDownSubject.Location = new Point(161, 200);
            dropDownSubject.Name = "dropDownSubject";
            dropDownSubject.Size = new Size(357, 37);
            dropDownSubject.TabIndex = 7;
            dropDownSubject.ThemeName = "MaterialTeal";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel4.Location = new Point(29, 202);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(69, 25);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "Mã môn";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(29, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 36);
            btnClose.TabIndex = 8;
            btnClose.Text = "Đóng";
            btnClose.ThemeName = "MaterialTeal";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(454, 564);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.ThemeName = "MaterialTeal";
            btnSave.Click += btnSave_Click;
            // 
            // EditQuestion
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 612);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(dropDownSubject);
            Controls.Add(radLabel4);
            Controls.Add(richContent);
            Controls.Add(radLabel3);
            Controls.Add(dropDownLevel);
            Controls.Add(radLabel2);
            Controls.Add(dropDownType);
            Controls.Add(radLabel1);
            Name = "EditQuestion";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "EditQuestion";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropDownType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropDownLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)richContent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropDownSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList dropDownType;
        private Telerik.WinControls.UI.RadDropDownList dropDownLevel;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList dropDownSubject;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadRichTextEditor richContent;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
