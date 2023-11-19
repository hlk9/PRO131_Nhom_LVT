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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Telerik.WinForms.Documents.Model.Notes;

namespace Examination_PRL.Forms.Staff
{
    public partial class Room : Telerik.WinControls.UI.RadForm
    {
        ExamRoomServices _ser = new ExamRoomServices();
        string _idWhenClick;

        public Room()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            examRoomGridView.Rows.Clear();

            int stt = 1;

            examRoomGridView.ColumnCount = 7;

            examRoomGridView.Columns[0].HeaderText = "STT";
            examRoomGridView.Columns[1].HeaderText = "Mã Phòng Thi";
            examRoomGridView.Columns[2].HeaderText = "Tên Phòng Thi";
            examRoomGridView.Columns[3].HeaderText = "Địa Chỉ";
            examRoomGridView.Columns[4].HeaderText = "Ghi Chú";
            examRoomGridView.Columns[5].HeaderText = "Sức Chứa";
            examRoomGridView.Columns[6].HeaderText = "Trạng Thái";

            foreach (var item in _ser.getAllRooms())
            {
                examRoomGridView.Rows.Add(stt++, item.Id, item.Name, item.Address, item.Note, item.Capacity, item.Status == true ? "Hoạt Động" : "Không Hoạt Động");

                foreach (GridViewRowInfo row in examRoomGridView.Rows)
                {
                    if (row.Cells[6].Value == "Không Hoạt Động")
                    {
                        row.IsVisible = false;
                    }
                }
            }
        }

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            string id = radTxtId.Text;
            string name = radTxtName.Text;
            string address = radTxtAddress.Text;
            string note = radTxtNote.Text;
            int capacity = int.Parse(radTxtCapacity.Text);
            bool status;

            if (radBtnTrue.IsChecked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (_ser.createExamRoom(id, name, address, note, capacity, status))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }

            LoadData();
        }

        private void radBtnUpdate_Click(object sender, EventArgs e)
        {
            string id = _idWhenClick;
            string name = radTxtName.Text;
            string address = radTxtAddress.Text;
            string note = radTxtNote.Text;
            int capacity = int.Parse(radTxtCapacity.Text);
            bool status;

            if (radBtnTrue.IsChecked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (_ser.updateExamRoom(id, name, address, note, capacity, status))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, GridViewCellEventArgs e)
        {
            _idWhenClick = examRoomGridView.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.getAllRooms().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radTxtId.Text = obj.Id;
            radTxtName.Text = obj.Name;
            radTxtAddress.Text = obj.Address;
            radTxtNote.Text = obj.Note;
            radTxtCapacity.Text = obj.Capacity.ToString();
            if (obj.Status == true)
            {
                radBtnTrue.IsChecked = true;
            }
            else
            {
                radBtnFalse.IsChecked = true;
            }
        }

        private void dtg_Show_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            RadMenuItem deleteExamRoom = new RadMenuItem("Xoá phòng thi này");
            deleteExamRoom.Click += DeleteItem_Click; 
            e.ContextMenu.Items.Add(deleteExamRoom);

            RadMenuItem restoreExamRoom = new RadMenuItem("Khôi phục phòng thi");
            restoreExamRoom.Click += Restore_Click;
            e.ContextMenu.Items.Add(restoreExamRoom);
        }

        private void Restore_Click(object? sender, EventArgs e)
        {
            RestoreExamRoom room = new RestoreExamRoom();
            room.ShowDialog();

            LoadData();
        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult == DialogResult.Yes)
            {
                if (_ser.deleteExamRoom(_idWhenClick, false))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }

                LoadData();
            }
        }
    }
}
