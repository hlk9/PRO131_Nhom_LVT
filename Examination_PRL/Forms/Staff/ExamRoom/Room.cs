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
            ConditionalFormattingObject formattingObject = new ConditionalFormattingObject("StatusFalse", ConditionTypes.Equal, "Không Hoạt Động", "", true);
            formattingObject.RowBackColor = Color.MistyRose;

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
            }

            this.examRoomGridView.Columns[6].ConditionalFormattingObjectList.Add(formattingObject);
        }

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(radTxtId.Text) || string.IsNullOrWhiteSpace(radTxtName.Text) || string.IsNullOrWhiteSpace(radTxtCapacity.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu quan trọng");
                return;
            }

            string id = radTxtId.Text;

            try
            {
                if (_ser.GetExamRoomById(id).Id != null)
                {
                    MessageBox.Show("Đã có mã phòng thi này", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {

            }
            

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
            if (string.IsNullOrWhiteSpace(radTxtId.Text) || string.IsNullOrWhiteSpace(radTxtName.Text) || string.IsNullOrWhiteSpace(radTxtCapacity.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu quan trọng");
                return;
            }

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

            radTxtId.Enabled = false;
        }

        private void dtg_Show_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            RadMenuItem deleteExamRoom = new RadMenuItem("Vô hiệu hóa thi này");
            deleteExamRoom.Click += DeleteItem_Click;
            e.ContextMenu.Items.Add(deleteExamRoom);
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

        private void radBtnClear_Click(object sender, EventArgs e)
        {
            radTxtId.Text = "";
            radTxtCapacity.Text = "";
            radTxtAddress.Text = "";
            radTxtNote.Text = "";
            radTxtName.Text = "";
            radTxtId.Enabled = true;
        }
    }
}
