namespace Examination_PRL.Forms.Staff.Schedule
{
    partial class EditSchedule
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
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            txtName = new Telerik.WinControls.UI.RadTextBox();
            btnSelectExam = new Telerik.WinControls.UI.RadButton();
            txtExamID = new Telerik.WinControls.UI.RadTextBox();
            txtSubject = new Telerik.WinControls.UI.RadTextBox();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radLabel4 = new Telerik.WinControls.UI.RadLabel();
            dropDownExamRoom = new Telerik.WinControls.UI.RadDropDownList();
            radLabel5 = new Telerik.WinControls.UI.RadLabel();
            radLabel6 = new Telerik.WinControls.UI.RadLabel();
            dateStart = new Telerik.WinControls.UI.RadDateTimePicker();
            dateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            radLabel7 = new Telerik.WinControls.UI.RadLabel();
            txtNote = new Telerik.WinControls.UI.RadTextBox();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radLabel8 = new Telerik.WinControls.UI.RadLabel();
            txtDes = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSelectExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExamID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dropDownExamRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.Location = new Point(25, 110);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(92, 25);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Tên lịch thi ";
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Teal;
            radLabel2.Location = new Point(213, 12);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(118, 33);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "Sửa lịch thi";
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(379, 37);
            txtName.TabIndex = 2;
            txtName.ThemeName = "MaterialTeal";
            // 
            // btnSelectExam
            // 
            btnSelectExam.Location = new Point(25, 165);
            btnSelectExam.Name = "btnSelectExam";
            btnSelectExam.Size = new Size(116, 36);
            btnSelectExam.TabIndex = 3;
            btnSelectExam.Text = "Chọn bài thi";
            btnSelectExam.ThemeName = "MaterialTeal";
            btnSelectExam.Click += btnSelectExam_Click;
            // 
            // txtExamID
            // 
            txtExamID.Location = new Point(166, 165);
            txtExamID.Name = "txtExamID";
            txtExamID.ReadOnly = true;
            txtExamID.Size = new Size(379, 37);
            txtExamID.TabIndex = 4;
            txtExamID.ThemeName = "MaterialTeal";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(166, 225);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(379, 37);
            txtSubject.TabIndex = 5;
            txtSubject.ThemeName = "MaterialTeal";
            // 
            // radLabel3
            // 
            radLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel3.Location = new Point(25, 225);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(96, 25);
            radLabel3.TabIndex = 1;
            radLabel3.Text = "Tên môn thi";
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel4.Location = new Point(25, 285);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(78, 25);
            radLabel4.TabIndex = 2;
            radLabel4.Text = "Phòng thi";
            // 
            // dropDownExamRoom
            // 
            dropDownExamRoom.DropDownAnimationEnabled = true;
            dropDownExamRoom.Location = new Point(166, 283);
            dropDownExamRoom.Name = "dropDownExamRoom";
            dropDownExamRoom.Size = new Size(379, 37);
            dropDownExamRoom.TabIndex = 6;
            dropDownExamRoom.Text = "Không";
            dropDownExamRoom.ThemeName = "MaterialTeal";
            // 
            // radLabel5
            // 
            radLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel5.Location = new Point(25, 356);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(63, 25);
            radLabel5.TabIndex = 3;
            radLabel5.Text = "Bắt đầu";
            // 
            // radLabel6
            // 
            radLabel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel6.Location = new Point(25, 419);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(68, 25);
            radLabel6.TabIndex = 4;
            radLabel6.Text = "Kết thúc";
            // 
            // dateStart
            // 
            dateStart.CalendarSize = new Size(290, 320);
            dateStart.Culture = new System.Globalization.CultureInfo("vi-VN");
            dateStart.CustomFormat = "HH:mm dd/MM/yyyy";
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(166, 349);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(379, 36);
            dateStart.TabIndex = 7;
            dateStart.TabStop = false;
            dateStart.Text = "23:45 03/12/2023";
            dateStart.ThemeName = "MaterialTeal";
            dateStart.Value = new DateTime(2023, 12, 3, 23, 45, 11, 948);
            // 
            // dateEnd
            // 
            dateEnd.CalendarSize = new Size(290, 320);
            dateEnd.Culture = new System.Globalization.CultureInfo("vi-VN");
            dateEnd.CustomFormat = "HH:mm dd/MM/yyyy";
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(166, 415);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(379, 36);
            dateEnd.TabIndex = 8;
            dateEnd.TabStop = false;
            dateEnd.Text = "23:45 03/12/2023";
            dateEnd.ThemeName = "MaterialTeal";
            dateEnd.Value = new DateTime(2023, 12, 3, 23, 45, 11, 948);
            // 
            // radLabel7
            // 
            radLabel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel7.Location = new Point(25, 476);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(68, 25);
            radLabel7.TabIndex = 6;
            radLabel7.Text = "Ghi  chú";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(166, 476);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(379, 37);
            txtNote.TabIndex = 7;
            txtNote.ThemeName = "MaterialTeal";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(166, 634);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(116, 36);
            radButton1.TabIndex = 4;
            radButton1.Text = "Xác nhận";
            radButton1.ThemeName = "MaterialTeal";
            radButton1.Click += radButton1_Click;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(305, 634);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(116, 36);
            radButton2.TabIndex = 5;
            radButton2.Text = "Đóng";
            radButton2.ThemeName = "MaterialTeal";
            // 
            // radLabel8
            // 
            radLabel8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel8.Location = new Point(25, 547);
            radLabel8.Name = "radLabel8";
            radLabel8.Size = new Size(54, 25);
            radLabel8.TabIndex = 7;
            radLabel8.Text = "Mô Tả";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(166, 541);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(379, 37);
            txtDes.TabIndex = 8;
            txtDes.ThemeName = "MaterialTeal";
            // 
            // EditSchedule
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 682);
            Controls.Add(txtDes);
            Controls.Add(radLabel8);
            Controls.Add(radButton2);
            Controls.Add(radButton1);
            Controls.Add(radLabel7);
            Controls.Add(dateEnd);
            Controls.Add(txtNote);
            Controls.Add(dateStart);
            Controls.Add(radLabel6);
            Controls.Add(radLabel5);
            Controls.Add(dropDownExamRoom);
            Controls.Add(radLabel4);
            Controls.Add(radLabel3);
            Controls.Add(txtSubject);
            Controls.Add(txtExamID);
            Controls.Add(btnSelectExam);
            Controls.Add(txtName);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Name = "EditSchedule";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "EditSchedule";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSelectExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExamID).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dropDownExamRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel8).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDes).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadButton btnSelectExam;
        private Telerik.WinControls.UI.RadTextBox txtExamID;
        private Telerik.WinControls.UI.RadTextBox txtSubject;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList dropDownExamRoom;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDateTimePicker dateStart;
        private Telerik.WinControls.UI.RadDateTimePicker dateEnd;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtNote;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadTextBox txtDes;
    }
}
