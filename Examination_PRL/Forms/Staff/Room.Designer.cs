namespace Examination_PRL.Forms.Staff
{
    partial class Room
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
            tb_Room = new Telerik.WinControls.UI.RadTextBox();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            tb_RoomID = new Telerik.WinControls.UI.RadTextBox();
            btn_AddRoom = new Telerik.WinControls.UI.RadButton();
            btn_Clear = new Telerik.WinControls.UI.RadButton();
            btn_EditRoom = new Telerik.WinControls.UI.RadButton();
            btn_ShowRoom = new Telerik.WinControls.UI.RadButton();
            btn_DeleteRoom = new Telerik.WinControls.UI.RadButton();
            dtg_Show = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_Room).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_RoomID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Clear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_EditRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ShowRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_DeleteRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(37, 41);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(73, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Phòng thi:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // tb_Room
            // 
            tb_Room.Location = new Point(37, 68);
            tb_Room.Name = "tb_Room";
            tb_Room.Size = new Size(213, 37);
            tb_Room.TabIndex = 1;
            tb_Room.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(37, 151);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(90, 21);
            radLabel2.TabIndex = 0;
            radLabel2.Text = "ID Phòng thi:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // tb_RoomID
            // 
            tb_RoomID.Location = new Point(37, 178);
            tb_RoomID.Name = "tb_RoomID";
            tb_RoomID.Size = new Size(213, 42);
            tb_RoomID.TabIndex = 1;
            tb_RoomID.ThemeName = "MaterialTeal";
            // 
            // btn_AddRoom
            // 
            btn_AddRoom.Location = new Point(535, 41);
            btn_AddRoom.Name = "btn_AddRoom";
            btn_AddRoom.Size = new Size(157, 38);
            btn_AddRoom.TabIndex = 2;
            btn_AddRoom.Text = "Thêm";
            btn_AddRoom.ThemeName = "MaterialTeal";
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(327, 108);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(162, 38);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Clear";
            btn_Clear.ThemeName = "MaterialTeal";
            // 
            // btn_EditRoom
            // 
            btn_EditRoom.Location = new Point(535, 108);
            btn_EditRoom.Name = "btn_EditRoom";
            btn_EditRoom.Size = new Size(157, 38);
            btn_EditRoom.TabIndex = 2;
            btn_EditRoom.Text = "Sửa";
            btn_EditRoom.ThemeName = "MaterialTeal";
            // 
            // btn_ShowRoom
            // 
            btn_ShowRoom.Location = new Point(327, 40);
            btn_ShowRoom.Name = "btn_ShowRoom";
            btn_ShowRoom.Size = new Size(162, 38);
            btn_ShowRoom.TabIndex = 2;
            btn_ShowRoom.Text = "Hiển thị";
            btn_ShowRoom.ThemeName = "MaterialTeal";
            // 
            // btn_DeleteRoom
            // 
            btn_DeleteRoom.Location = new Point(535, 178);
            btn_DeleteRoom.Name = "btn_DeleteRoom";
            btn_DeleteRoom.Size = new Size(157, 38);
            btn_DeleteRoom.TabIndex = 2;
            btn_DeleteRoom.Text = "Xóa";
            btn_DeleteRoom.ThemeName = "MaterialTeal";
            // 
            // dtg_Show
            // 
            dtg_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Show.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dtg_Show.Location = new Point(37, 250);
            dtg_Show.Name = "dtg_Show";
            dtg_Show.RowHeadersWidth = 51;
            dtg_Show.RowTemplate.Height = 29;
            dtg_Show.Size = new Size(429, 188);
            dtg_Show.TabIndex = 3;
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
            Column2.HeaderText = "Phòng thi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID Phòng thi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Room
            // 
            AutoScaleBaseSize = new Size(8, 20);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(dtg_Show);
            Controls.Add(btn_DeleteRoom);
            Controls.Add(btn_EditRoom);
            Controls.Add(btn_Clear);
            Controls.Add(btn_ShowRoom);
            Controls.Add(btn_AddRoom);
            Controls.Add(tb_RoomID);
            Controls.Add(tb_Room);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Name = "Room";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Room";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_Room).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_RoomID).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Clear).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_EditRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ShowRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_DeleteRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Show).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tb_Room;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox tb_RoomID;
        private Telerik.WinControls.UI.RadButton btn_AddRoom;
        private Telerik.WinControls.UI.RadButton btn_Clear;
        private Telerik.WinControls.UI.RadButton btn_EditRoom;
        private Telerik.WinControls.UI.RadButton btn_ShowRoom;
        private Telerik.WinControls.UI.RadButton btn_DeleteRoom;
        private DataGridView dtg_Show;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
