using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff.ClassRoom
{
    public partial class ClassRooms : Telerik.WinControls.UI.RadForm
    {
        ClassroomServices _ser = new ClassroomServices();

        string _idWhenClick;

        public ClassRooms()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ClassRoomExamGridView.Rows.Clear();

            int stt = 1;

            ClassRoomExamGridView.ColumnCount = 3;

            ClassRoomExamGridView.Columns[0].HeaderText = "STT";
            ClassRoomExamGridView.Columns[1].HeaderText = "Mã Lớp";
            ClassRoomExamGridView.Columns[2].HeaderText = "Tên Lớp";

            foreach (var x in _ser.GetClassrooms())
            {
                ClassRoomExamGridView.Rows.Add(stt++, x.Id, x.Name);
            }
        }

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            string id = radTxId.Text;
            string name = radTxtName.Text;

            if (_ser.AddNewClass(id, name))
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
            string id = radTxId.Text;
            string name = radTxtName.Text;

            if (_ser.UpdateClass(id, name))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }
            LoadData();
        }

        private void ClassRoomExamGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = ClassRoomExamGridView.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.GetClassrooms().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radTxtName.Text = obj.Name;
            radTxId.Text = obj.Id;
        }

        private void ClassRoomExamGridView_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            RadMenuItem deleteClassRoom = new RadMenuItem("Xóa Lớp Này");
            deleteClassRoom.Click += DeleteClassRoom_Click;
            e.ContextMenu.Items.Add(deleteClassRoom);
        }

        private void DeleteClassRoom_Click(object? sender, EventArgs e)
        {
            if(_ser.RemoveClass(_idWhenClick))
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
