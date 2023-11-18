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
        ExamroomServices _ser = new ExamroomServices();
        string _idWhenClick;

        public Room()
        {
            InitializeComponent();
            _ser = new ExamroomServices();
            LoadData();
        }

        public void LoadData()
        {
            dtg_Show.Rows.Clear();

            int stt = 1;

            dtg_Show.ColumnCount = 7;
            dtg_Show.Columns[0].HeaderText = "Số Thứ Tự";
            dtg_Show.Columns[1].HeaderText = "Mã Phòng Thi";
            dtg_Show.Columns[2].HeaderText = "Phòng Thi";
            dtg_Show.Columns[3].HeaderText = "Địa Chỉ";
            dtg_Show.Columns[4].HeaderText = "Sức Chứa";
            dtg_Show.Columns[5].HeaderText = "Ghi Chú";
            dtg_Show.Columns[6].HeaderText = "Trạng Thái";

            foreach (var item in _ser.GetExamRooms())
            {
                dtg_Show.Rows.Add(stt++, item.Id, item.Name, item.Address, item.Capacity, item.Note, (item.Status == true ? "Hoạt Động" : "Không Hoạt Động"));

                foreach (GridViewRowInfo row in dtg_Show.Rows)
                {
                    if (row.Cells[6].Value == "Không Hoạt Động")
                    {
                        row.IsVisible = false;
                    }
                }
            }
        }

        private void radBtnThem_Click(object sender, EventArgs e)
        {
            string id = radTxtId.Text;
            string name = radTxtName.Text;
            string address = radTxtAddress.Text;
            string note = radRTxtNote.Text;
            int capacity = int.Parse(radTxtCapacity.Text);
            bool status;
            if (radBtnTrue.IsChecked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (_ser.AddExamRoom(id, name, address, note, capacity, status))
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
            string note = radRTxtNote.Text;
            int capacity = int.Parse(radTxtCapacity.Text);
            bool status;
            if (radBtnTrue.IsChecked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (_ser.UpdateExamRoom(id, name, address, note, capacity, status))
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
            _idWhenClick = dtg_Show.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.GetExamRooms().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radTxtId.Text = obj.Id;
            radTxtName.Text = obj.Name;
            radTxtAddress.Text = obj.Address;
            radRTxtNote.Text = obj.Note;
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
            e.ContextMenu.Items.Clear();

            RadMenuItem deleteItem = new RadMenuItem("Xoá thí sinh này");
            deleteItem.Click += DeleteItem_Click; 
            e.ContextMenu.Items.Add(deleteItem);

            RadMenuItem restoreItem = new RadMenuItem("Khôi phục thí sinh đã xõa");
            restoreItem.Click += RestoreItem_Click; 
            e.ContextMenu.Items.Add(restoreItem);
        }

        private void RestoreItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            if(_ser.RemoveExamRoom(_idWhenClick, false))
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
