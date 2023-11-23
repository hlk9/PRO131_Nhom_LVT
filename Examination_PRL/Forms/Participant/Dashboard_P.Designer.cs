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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Column 1");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("ListViewGroup 1");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup2 = new Telerik.WinControls.UI.ListViewDataItemGroup("ListViewGroup 2");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup3 = new Telerik.WinControls.UI.ListViewDataItemGroup("ListViewGroup 3");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 2");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 3");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 4");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 5");
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radPageView1 = new Telerik.WinControls.UI.RadPageView();
            radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            listViewParent = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)radPageView1).BeginInit();
            radPageView1.SuspendLayout();
            radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listViewParent).BeginInit();
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
            radPageView1.SelectedPage = radPageViewPage1;
            radPageView1.Size = new Size(1279, 561);
            radPageView1.TabIndex = 0;
            radPageView1.ThemeName = "MaterialTeal";
            ((Telerik.WinControls.UI.RadPageViewStripElement)radPageView1.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
            // 
            // radPageViewPage1
            // 
            radPageViewPage1.Controls.Add(listViewParent);
            radPageViewPage1.ItemSize = new SizeF(78F, 49F);
            radPageViewPage1.Location = new Point(6, 55);
            radPageViewPage1.Name = "radPageViewPage1";
            radPageViewPage1.Size = new Size(1267, 500);
            radPageViewPage1.Text = "Vào Thi";
            // 
            // radPageViewPage2
            // 
            radPageViewPage2.ItemSize = new SizeF(80F, 49F);
            radPageViewPage2.Location = new Point(6, 55);
            radPageViewPage2.Name = "radPageViewPage2";
            radPageViewPage2.Size = new Size(1267, 500);
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
            radPageViewPage4.ItemSize = new SizeF(84F, 49F);
            radPageViewPage4.Location = new Point(6, 55);
            radPageViewPage4.Name = "radPageViewPage4";
            radPageViewPage4.Size = new Size(1267, 500);
            radPageViewPage4.Text = "Trợ Giúp";
            // 
            // listViewParent
            // 
            listViewDetailColumn1.HeaderText = "Column 0";
            listViewDetailColumn2.HeaderText = "Column 1";
            listViewParent.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] { listViewDetailColumn1, listViewDetailColumn2 });
            listViewParent.Dock = DockStyle.Fill;
            listViewParent.FullRowSelect = false;
            listViewParent.GroupItemSize = new Size(200, 36);
            listViewDataItemGroup1.Text = "ListViewGroup 1";
            listViewDataItemGroup2.Text = "ListViewGroup 2";
            listViewDataItemGroup3.Text = "ListViewGroup 3";
            listViewParent.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] { listViewDataItemGroup1, listViewDataItemGroup2, listViewDataItemGroup3 });
            listViewDataItem1.Text = "ListViewItem 1";
            listViewDataItem2.Text = "ListViewItem 2";
            listViewDataItem3.Text = "ListViewItem 3";
            listViewDataItem4.Text = "ListViewItem 4";
            listViewDataItem5.Text = "ListViewItem 5";
            listViewParent.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] { listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4, listViewDataItem5 });
            listViewParent.ItemSize = new Size(144, 60);
            listViewParent.Location = new Point(0, 0);
            listViewParent.Name = "listViewParent";
            listViewParent.Size = new Size(1267, 500);
            listViewParent.TabIndex = 0;
            listViewParent.ThemeName = "MaterialTeal";
            listViewParent.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            // 
            // Dashboard_P
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 561);
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
            radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listViewParent).EndInit();
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
        private Telerik.WinControls.UI.RadListView listViewParent;
    }
}
