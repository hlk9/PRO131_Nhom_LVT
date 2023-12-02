namespace Examination_PRL.Forms.Staff.Schedule
{
    partial class CreateNew
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
            dateStart = new Telerik.WinControls.UI.RadDateTimePicker();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            txtName = new Telerik.WinControls.UI.RadTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            dropdownClass = new Telerik.WinControls.UI.RadDropDownList();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            dateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            txtSubject = new Telerik.WinControls.UI.RadTextBox();
            txtDes = new Telerik.WinControls.UI.RadTextBox();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            btnClose = new Telerik.WinControls.UI.RadButton();
            btnAdd = new Telerik.WinControls.UI.RadButton();
            txtExamID = new Telerik.WinControls.UI.RadTextBox();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)dateStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropdownClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExamID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dateStart
            // 
            dateStart.CalendarSize = new Size(290, 320);
            dateStart.Culture = new System.Globalization.CultureInfo("vi-VN");
            dateStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(157, 146);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(244, 36);
            dateStart.TabIndex = 0;
            dateStart.TabStop = false;
            dateStart.Text = "02/12/2023 11:55";
            dateStart.ThemeName = "MaterialTeal";
            dateStart.Value = new DateTime(2023, 12, 2, 11, 55, 26, 956);
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.Location = new Point(12, 43);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(79, 25);
            radLabel1.TabIndex = 1;
            radLabel1.Text = "Tên kỳ thi";
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 37);
            txtName.TabIndex = 2;
            txtName.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel2.Location = new Point(12, 102);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(107, 25);
            radLabel2.TabIndex = 3;
            radLabel2.Text = "Mã phòng thi";
            // 
            // dropdownClass
            // 
            dropdownClass.DropDownAnimationEnabled = true;
            dropdownClass.Location = new Point(157, 96);
            dropdownClass.Name = "dropdownClass";
            dropdownClass.NullText = "Chọn";
            dropdownClass.Size = new Size(244, 37);
            dropdownClass.TabIndex = 5;
            dropdownClass.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel3.Location = new Point(12, 153);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(136, 25);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "Thời gian bắt đầu";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel4.Location = new Point(12, 208);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(139, 25);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "Thời gian kết thúc";
            // 
            // dateEnd
            // 
            dateEnd.CalendarSize = new Size(290, 320);
            dateEnd.Culture = new System.Globalization.CultureInfo("vi-VN");
            dateEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(157, 201);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(244, 36);
            dateEnd.TabIndex = 5;
            dateEnd.TabStop = false;
            dateEnd.Text = "02/12/2023 11:55";
            dateEnd.ThemeName = "MaterialTeal";
            dateEnd.Value = new DateTime(2023, 12, 2, 11, 55, 26, 956);
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel5.Location = new Point(12, 251);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(42, 25);
            radLabel5.TabIndex = 5;
            radLabel5.Text = "Môn";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(157, 245);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(244, 37);
            txtSubject.TabIndex = 3;
            txtSubject.ThemeName = "MaterialTeal";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(157, 300);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(244, 37);
            txtDes.TabIndex = 6;
            txtDes.ThemeName = "MaterialTeal";
            // 
            // radLabel6
            // 
            radLabel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel6.Location = new Point(12, 306);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(51, 25);
            radLabel6.TabIndex = 7;
            radLabel6.Text = "Mô tả";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(281, 444);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 36);
            btnClose.TabIndex = 9;
            btnClose.Text = "Đóng";
            btnClose.ThemeName = "MaterialTeal";
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 444);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 36);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.ThemeName = "MaterialTeal";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtExamID
            // 
            txtExamID.Location = new Point(157, 356);
            txtExamID.Name = "txtExamID";
            txtExamID.Size = new Size(244, 37);
            txtExamID.TabIndex = 8;
            txtExamID.ThemeName = "MaterialTeal";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(12, 356);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(120, 36);
            radButton1.TabIndex = 9;
            radButton1.Text = "Chọn bài thi";
            radButton1.ThemeName = "MaterialTeal";
            radButton1.Click += radButton1_Click;
            // 
            // CreateNew
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 492);
            Controls.Add(radButton1);
            Controls.Add(txtExamID);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtDes);
            Controls.Add(txtSubject);
            Controls.Add(radLabel6);
            Controls.Add(radLabel5);
            Controls.Add(radLabel4);
            Controls.Add(radLabel3);
            Controls.Add(dateEnd);
            Controls.Add(dropdownClass);
            Controls.Add(radLabel2);
            Controls.Add(txtName);
            Controls.Add(radLabel1);
            Controls.Add(dateStart);
            Name = "CreateNew";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "CreateNew";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)dateStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropdownClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDes).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExamID).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadDateTimePicker dateStart;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList dropdownClass;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker dateEnd;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtSubject;
        private Telerik.WinControls.UI.RadTextBox txtDes;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadTextBox txtExamID;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
