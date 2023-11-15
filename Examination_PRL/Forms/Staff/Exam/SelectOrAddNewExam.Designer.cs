namespace Examination_PRL.Forms.Staff.Exam
{
    partial class SelectOrAddNewExam
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
            components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            examGridView = new Telerik.WinControls.UI.RadGridView();
            gridContextMenu = new Telerik.WinControls.UI.RadContextMenu(components);
            radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // examGridView
            // 
            examGridView.Dock = DockStyle.Fill;
            examGridView.Location = new Point(0, 0);
            // 
            // 
            // 
            examGridView.MasterTemplate.AllowAddNewRow = false;
            examGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            examGridView.MasterTemplate.EnablePaging = true;
            examGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            examGridView.Name = "examGridView";
            examGridView.Size = new Size(1174, 574);
            examGridView.TabIndex = 0;
            examGridView.ThemeName = "MaterialTeal";
            examGridView.CellEndEdit += examGridView_CellEndEdit;
            examGridView.SelectionChanged += examGridView_SelectionChanged;
            examGridView.CellClick += examGridView_CellClick;
            // 
            // gridContextMenu
            // 
            gridContextMenu.Items.AddRange(new Telerik.WinControls.RadItem[] { radMenuItem1, radMenuItem2, radMenuItem3 });
            gridContextMenu.ThemeName = "MaterialTeal";
            // 
            // radMenuItem1
            // 
            radMenuItem1.Name = "radMenuItem1";
            radMenuItem1.Text = "radMenuItem1";
            // 
            // radMenuItem2
            // 
            radMenuItem2.Name = "radMenuItem2";
            radMenuItem2.Text = "radMenuItem2";
            // 
            // radMenuItem3
            // 
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "radMenuItem3";
            // 
            // SelectOrAddNewExam
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 574);
            Controls.Add(examGridView);
            Name = "SelectOrAddNewExam";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "SelectOrAddNewExam";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)examGridView.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView examGridView;
        private Telerik.WinControls.UI.RadContextMenu gridContextMenu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
    }
}
