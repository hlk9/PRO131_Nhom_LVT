﻿namespace Examination_PRL.Forms.Staff
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
            ((System.ComponentModel.ISupportInitialize)btn_DeleteRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radLabel1.Location = new Point(12, 26);
            radLabel1.Margin = new Padding(3, 2, 3, 2);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(73, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Phòng thi:";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // tb_Room
            // 
            tb_Room.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Room.Location = new Point(12, 51);
            tb_Room.Margin = new Padding(3, 2, 3, 2);
            tb_Room.Name = "tb_Room";
            tb_Room.Size = new Size(716, 37);
            tb_Room.TabIndex = 1;
            tb_Room.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.Location = new Point(12, 109);
            radLabel2.Margin = new Padding(3, 2, 3, 2);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(90, 21);
            radLabel2.TabIndex = 0;
            radLabel2.Text = "ID Phòng thi:";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // tb_RoomID
            // 
            tb_RoomID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_RoomID.Location = new Point(12, 134);
            tb_RoomID.Margin = new Padding(3, 2, 3, 2);
            tb_RoomID.Name = "tb_RoomID";
            tb_RoomID.Size = new Size(716, 37);
            tb_RoomID.TabIndex = 1;
            tb_RoomID.ThemeName = "MaterialTeal";
            // 
            // btn_AddRoom
            // 
            btn_AddRoom.Anchor = AnchorStyles.Top;
            btn_AddRoom.Location = new Point(206, 196);
            btn_AddRoom.Margin = new Padding(3, 2, 3, 2);
            btn_AddRoom.Name = "btn_AddRoom";
            btn_AddRoom.Size = new Size(137, 36);
            btn_AddRoom.TabIndex = 2;
            btn_AddRoom.Text = "Thêm";
            btn_AddRoom.ThemeName = "MaterialTeal";
            // 
            // btn_Clear
            // 
            btn_Clear.Anchor = AnchorStyles.Top;
            btn_Clear.Location = new Point(586, 196);
            btn_Clear.Margin = new Padding(3, 2, 3, 2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(142, 36);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Clear";
            btn_Clear.ThemeName = "MaterialTeal";
            // 
            // btn_EditRoom
            // 
            btn_EditRoom.Anchor = AnchorStyles.Top;
            btn_EditRoom.Location = new Point(12, 196);
            btn_EditRoom.Margin = new Padding(3, 2, 3, 2);
            btn_EditRoom.Name = "btn_EditRoom";
            btn_EditRoom.Size = new Size(137, 36);
            btn_EditRoom.TabIndex = 2;
            btn_EditRoom.Text = "Sửa";
            btn_EditRoom.ThemeName = "MaterialTeal";
            // 
            // btn_DeleteRoom
            // 
            btn_DeleteRoom.Anchor = AnchorStyles.Top;
            btn_DeleteRoom.Location = new Point(395, 196);
            btn_DeleteRoom.Margin = new Padding(3, 2, 3, 2);
            btn_DeleteRoom.Name = "btn_DeleteRoom";
            btn_DeleteRoom.Size = new Size(137, 36);
            btn_DeleteRoom.TabIndex = 2;
            btn_DeleteRoom.Text = "Xóa";
            btn_DeleteRoom.ThemeName = "MaterialTeal";
            // 
            // dtg_Show
            // 
            dtg_Show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Show.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dtg_Show.Location = new Point(12, 266);
            dtg_Show.Margin = new Padding(3, 2, 3, 2);
            dtg_Show.Name = "dtg_Show";
            dtg_Show.RowHeadersWidth = 51;
            dtg_Show.RowTemplate.Height = 29;
            dtg_Show.Size = new Size(716, 202);
            dtg_Show.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Phòng thi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "ID Phòng thi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Room
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 479);
            Controls.Add(dtg_Show);
            Controls.Add(btn_DeleteRoom);
            Controls.Add(btn_EditRoom);
            Controls.Add(btn_Clear);
            Controls.Add(btn_AddRoom);
            Controls.Add(tb_RoomID);
            Controls.Add(tb_Room);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Telerik.WinControls.UI.RadButton btn_DeleteRoom;
        private DataGridView dtg_Show;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
