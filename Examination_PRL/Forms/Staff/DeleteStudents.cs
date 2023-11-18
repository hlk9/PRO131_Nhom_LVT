using Examination_BUS.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_PRL.Forms.Staff
{
    public partial class DeleteStudents : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _ser = new ParticipantService();
        string curentExamCode = "";
        public DeleteStudents()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            examGridView.ColumnCount = 9;
            examGridView.Columns[0].HeaderText = "STT";
            examGridView.Columns[1].HeaderText = "Mã Thí Sinh";
            examGridView.Columns[2].HeaderText = "Tên Thí Sinh";
            examGridView.Columns[3].HeaderText = "Giới Tính";
            examGridView.Columns[4].HeaderText = "Ngày Sinh";
            examGridView.Columns[5].HeaderText = "Số Điện Thoại";
            examGridView.Columns[6].HeaderText = "Email";
            examGridView.Columns[7].HeaderText = "Địa Chỉ";
            examGridView.Columns[8].HeaderText = "Trạng Thái";
            examGridView.Columns[8].IsVisible = false;
            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllStudents())
            {
                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.Status);

                foreach (GridViewRowInfo row in examGridView.Rows)
                {
                    if (int.Parse(row.Cells[8].Value.ToString()) == 255)
                    {
                        row.IsVisible = false;
                    }
                }
            }
        }

        private void examGridView_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {

        }

        private void examGridView_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem currentExam = new RadMenuItem("Đang chọn: " + curentExamCode);
            currentExam.ForeColor = Color.Teal;
            e.ContextMenu.Items.Add(currentExam);

            RadMenuSeparatorItem separator = new RadMenuSeparatorItem();
            e.ContextMenu.Items.Add(separator);

            RadMenuItem editItem = new RadMenuItem("Sửa thí sinh này");
            editItem.Click += EditItem_Click; 
            e.ContextMenu.Items.Add(editItem);
            RadMenuItem deleteItem = new RadMenuItem("Xoá thí sinh này");
            deleteItem.Click += DeleteItem_Click;
            e.ContextMenu.Items.Add(deleteItem);

            RadMenuItem restoreItem = new RadMenuItem("Khôi phục thí sinh đã xõa");
            restoreItem.Click += RestoreItem_Click;
            e.ContextMenu.Items.Add(restoreItem);
        }

        private void RestoreItem_Click(object? sender, EventArgs e)
        {
            RestoreStudents res = new RestoreStudents();

            res.ShowDialog();
        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            if (examGridView.SelectedRows.Count > 0)
            {
                string id = examGridView.CurrentRow.Cells[1].Value.ToString();

                if (_ser.deleStudent(id, 255))
                {
                    MessageBox.Show("Xóa Thành Công!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
                examGridView.CurrentRow.Delete();
            }

        }

        private void EditItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
