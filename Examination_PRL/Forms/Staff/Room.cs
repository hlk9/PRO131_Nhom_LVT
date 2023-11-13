using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Examination_BUS.Services;
using Examination_DAL.Models;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class Room : Telerik.WinControls.UI.RadForm
    {
        ClassroomServices _ser = new ClassroomServices();
        int _idWhenClick;

        public Room()
        {
            InitializeComponent();
            _ser = new ClassroomServices();
        }

        public void LoadData(dynamic data)
        {
            dtg_Show.Rows.Clear();
            int stt = 1;
            dtg_Show.ColumnCount = 3;
            dtg_Show.Columns[0].Name = "stt"; dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].Name = "nameclass"; dtg_Show.Columns[1].HeaderText = "Phòng thi";
            dtg_Show.Columns[2].Name = "Idclass"; dtg_Show.Columns[2].HeaderText = "ID Phòng thi";
            foreach (var item in data)
            {
                dtg_Show.Rows.Add(stt++, item.Name, item.Id);
            }
        }


        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            string name = tb_Room.Text;
            string ID = tb_RoomID.Text;
            bool add = _ser.AddNewClass(name, ID);
            if (add) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadData(_ser.GetClassrooms());
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadData(_ser.GetClassrooms());
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var selectedClass = dtg_Show.Rows[rowIndex];
            tb_Room.Text = selectedClass.Cells[1].Value.ToString();
            tb_RoomID.Text = selectedClass.Cells[2].Value.ToString();
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {

            var DialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Classroom room = new Classroom();
                string name = tb_Room.Text;
                string ID = tb_RoomID.Text;
                _idWhenClick = Convert.ToInt32(room.Id);
                bool delete = _ser.RemoveClass(ID);
                if (delete) MessageBox.Show("Xóa thành công!");
                else MessageBox.Show("Xóa thất bại!");
                LoadData(_ser.GetClassrooms());

            }
            else
            {
                return;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Room.Text = "";
            tb_RoomID.Text = "";
        }

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            Classroom room = new Classroom();
            string name = tb_Room.Text;
            string ID = tb_RoomID.Text;

            bool update = _ser.UpdateClass(ID, name);
            if (update) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadData(_ser.GetClassrooms());
        }
    }
}
