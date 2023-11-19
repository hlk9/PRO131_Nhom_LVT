namespace Examination_PRL.Forms.Staff
{
    partial class RestoreExamRoom
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
            examRoomGridView = new Telerik.WinControls.UI.RadGridView();
            radLblShow = new Telerik.WinControls.UI.RadLabel();
            radBtnResstore = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLblShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radBtnResstore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // examRoomGridView
            // 
            examRoomGridView.Location = new Point(12, 116);
            // 
            // 
            // 
            examRoomGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examRoomGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examRoomGridView.Name = "examRoomGridView";
            examRoomGridView.Size = new Size(631, 357);
            examRoomGridView.TabIndex = 0;
            examRoomGridView.ThemeName = "MaterialTeal";
            examRoomGridView.CellClick += examRoomGridView_CellClick;
            // 
            // radLblShow
            // 
            radLblShow.AutoSize = false;
            radLblShow.Location = new Point(12, 12);
            radLblShow.Name = "radLblShow";
            radLblShow.Size = new Size(631, 18);
            radLblShow.TabIndex = 1;
            radLblShow.TextAlignment = ContentAlignment.MiddleCenter;
            radLblShow.ThemeName = "MaterialTeal";
            // 
            // radBtnResstore
            // 
            radBtnResstore.BackColor = Color.Teal;
            radBtnResstore.ForeColor = Color.White;
            radBtnResstore.Location = new Point(12, 52);
            radBtnResstore.Name = "radBtnResstore";
            radBtnResstore.Size = new Size(631, 36);
            radBtnResstore.TabIndex = 2;
            radBtnResstore.Text = "Khôi Phục";
            radBtnResstore.ThemeName = "MaterialTeal";
            radBtnResstore.Click += radBtnResstore_Click;
            // 
            // RestoreExamRoom
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 485);
            Controls.Add(radBtnResstore);
            Controls.Add(radLblShow);
            Controls.Add(examRoomGridView);
            Name = "RestoreExamRoom";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "RestoreExamRoom";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)examRoomGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examRoomGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLblShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)radBtnResstore).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView examRoomGridView;
        private Telerik.WinControls.UI.RadLabel radLblShow;
        private Telerik.WinControls.UI.RadButton radBtnResstore;
    }
}
