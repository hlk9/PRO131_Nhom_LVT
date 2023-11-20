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

namespace Examination_PRL.Forms.Staff.Student
{
    public partial class RestoreStudents : Telerik.WinControls.UI.RadForm
    {

        ParticipantService _ser = new ParticipantService();

        string _idWhenClick;

        public RestoreStudents()
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
            examGridView.Columns[8].HeaderText = "Mã Lớp";
            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllRemove())
            {
                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.ClassroomId);
            }
        }

        private void examGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            _idWhenClick = examGridView.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.getAllStudents().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radLabel1.Text = $"Họ Tên: {obj.FullName}";
        }

        private void radBtnRestore_Click(object sender, EventArgs e)
        {
            string id = examGridView.CurrentRow.Cells[1].Value.ToString();

            if (_ser.deleteStudents(id, 1))
            {
                MessageBox.Show("Khôi Phục Thành Công");
            }
            else
            {
                MessageBox.Show("Khôi Phực Thất Bại");
            }
            LoadData();

            AddStudents add = new AddStudents();
            add.Refresh();
        }
    }
}
