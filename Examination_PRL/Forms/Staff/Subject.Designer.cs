namespace Examination_PRL.Forms.Staff
{
    partial class Subject
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
            tb_Subject = new Telerik.WinControls.UI.RadTextBox();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            tb_IDSubject = new Telerik.WinControls.UI.RadTextBox();
            btn_ShowSubject = new Telerik.WinControls.UI.RadButton();
            btn_Clear = new Telerik.WinControls.UI.RadButton();
            btn_AddSubject = new Telerik.WinControls.UI.RadButton();
            btn_EditSubject = new Telerik.WinControls.UI.RadButton();
            btn_DeleteSubject = new Telerik.WinControls.UI.RadButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tb_Subject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_IDSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ShowSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Clear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_EditSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_DeleteSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // tb_Subject
            // 
            tb_Subject.Location = new Point(45, 68);
            tb_Subject.Name = "tb_Subject";
            tb_Subject.Size = new Size(210, 37);
            tb_Subject.TabIndex = 0;
            tb_Subject.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(45, 41);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(67, 21);
            radLabel1.TabIndex = 1;
            radLabel1.Text = "Môn học:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(45, 144);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(84, 21);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "ID Môn học:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // tb_IDSubject
            // 
            tb_IDSubject.Location = new Point(45, 171);
            tb_IDSubject.Name = "tb_IDSubject";
            tb_IDSubject.Size = new Size(210, 42);
            tb_IDSubject.TabIndex = 0;
            tb_IDSubject.ThemeName = "MaterialTeal";
            // 
            // btn_ShowSubject
            // 
            btn_ShowSubject.Location = new Point(312, 41);
            btn_ShowSubject.Name = "btn_ShowSubject";
            btn_ShowSubject.Size = new Size(171, 38);
            btn_ShowSubject.TabIndex = 2;
            btn_ShowSubject.Text = "Hiển thị";
            btn_ShowSubject.ThemeName = "MaterialTeal";
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(312, 110);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(171, 38);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Clear";
            btn_Clear.ThemeName = "MaterialTeal";
            // 
            // btn_AddSubject
            // 
            btn_AddSubject.Location = new Point(524, 41);
            btn_AddSubject.Name = "btn_AddSubject";
            btn_AddSubject.Size = new Size(171, 38);
            btn_AddSubject.TabIndex = 2;
            btn_AddSubject.Text = "Thêm";
            btn_AddSubject.ThemeName = "MaterialTeal";
            // 
            // btn_EditSubject
            // 
            btn_EditSubject.Location = new Point(524, 110);
            btn_EditSubject.Name = "btn_EditSubject";
            btn_EditSubject.Size = new Size(171, 38);
            btn_EditSubject.TabIndex = 2;
            btn_EditSubject.Text = "Sửa";
            btn_EditSubject.ThemeName = "MaterialTeal";
            // 
            // btn_DeleteSubject
            // 
            btn_DeleteSubject.Location = new Point(524, 175);
            btn_DeleteSubject.Name = "btn_DeleteSubject";
            btn_DeleteSubject.Size = new Size(171, 38);
            btn_DeleteSubject.TabIndex = 2;
            btn_DeleteSubject.Text = "Xóa";
            btn_DeleteSubject.ThemeName = "MaterialTeal";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(45, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(424, 188);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Môn học";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID Môn học";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Subject
            // 
            AutoScaleBaseSize = new Size(8, 20);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 451);
            Controls.Add(dataGridView1);
            Controls.Add(btn_DeleteSubject);
            Controls.Add(btn_EditSubject);
            Controls.Add(btn_AddSubject);
            Controls.Add(btn_Clear);
            Controls.Add(btn_ShowSubject);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Controls.Add(tb_IDSubject);
            Controls.Add(tb_Subject);
            Name = "Subject";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Subject";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)tb_Subject).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_IDSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ShowSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Clear).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_EditSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_DeleteSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadTextBox tb_Subject;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox tb_IDSubject;
        private Telerik.WinControls.UI.RadButton btn_ShowSubject;
        private Telerik.WinControls.UI.RadButton btn_Clear;
        private Telerik.WinControls.UI.RadButton btn_AddSubject;
        private Telerik.WinControls.UI.RadButton btn_EditSubject;
        private Telerik.WinControls.UI.RadButton btn_DeleteSubject;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
