namespace Examination_PRL.Forms.Staff
{
    partial class StudentsList
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
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            radLblSumStudents = new Telerik.WinControls.UI.RadLabel();
            radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radGroupBox1.HeaderText = "radGroupBox1";
            radGroupBox1.Location = new Point(552, 12);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(234, 516);
            radGroupBox1.TabIndex = 1;
            radGroupBox1.Text = "radGroupBox1";
            radGroupBox1.ThemeName = "MaterialTeal";
            // 
            // radLblSumStudents
            // 
            radLblSumStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radLblSumStudents.AutoSize = false;
            radLblSumStudents.Location = new Point(12, 12);
            radLblSumStudents.Name = "radLblSumStudents";
            radLblSumStudents.Size = new Size(208, 36);
            radLblSumStudents.TabIndex = 2;
            radLblSumStudents.Text = "radLabel1";
            radLblSumStudents.ThemeName = "MaterialTeal";
            // 
            // radTextBoxControl1
            // 
            radTextBoxControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radTextBoxControl1.Location = new Point(226, 12);
            radTextBoxControl1.Name = "radTextBoxControl1";
            radTextBoxControl1.Size = new Size(320, 36);
            radTextBoxControl1.TabIndex = 3;
            radTextBoxControl1.ThemeName = "MaterialTeal";
            // 
            // radGridView1
            // 
            radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radGridView1.Location = new Point(12, 62);
            // 
            // 
            // 
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.Size = new Size(534, 466);
            radGridView1.TabIndex = 4;
            radGridView1.ThemeName = "MaterialTeal";
            // 
            // StudentsList
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 543);
            Controls.Add(radGridView1);
            Controls.Add(radTextBoxControl1);
            Controls.Add(radLblSumStudents);
            Controls.Add(radGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsList";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "StudentsList";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblSumStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLblSumStudents;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
