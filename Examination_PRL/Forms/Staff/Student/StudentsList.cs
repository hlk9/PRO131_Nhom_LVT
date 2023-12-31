﻿using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff
{
    public partial class StudentsList : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _ser = new ParticipantService();

        string _idWhenClick;

        public StudentsList()
        {
            InitializeComponent();
            radLblSum.Text = _ser.getAllStudents().Count.ToString();
            radLblBoySum.Text = _ser.getAllStudents().Where(x => x.Gender == true).ToList().Count.ToString();
            radLblGirlSum.Text = _ser.getAllStudents().Where(x => x.Gender == false).ToList().Count.ToString();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            examGridView.ColumnCount = 10;

            examGridView.Columns[0].HeaderText = "STT";
            examGridView.Columns[1].HeaderText = "Mã Thí Sinh";
            examGridView.Columns[2].HeaderText = "Tên Thí Sinh";
            examGridView.Columns[3].HeaderText = "Giới Tính";
            examGridView.Columns[4].HeaderText = "Ngày Sinh";
            examGridView.Columns[5].HeaderText = "Số Điện Thoại";
            examGridView.Columns[6].HeaderText = "Email";
            examGridView.Columns[7].HeaderText = "Địa Chỉ";
            examGridView.Columns[8].HeaderText = "Mã Lớp";
            examGridView.Columns[9].HeaderText = "Trạng Thái";

            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllStudents())
            {
                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.ClassroomId, x.Status == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }

            for (int i = 0; i < examGridView.Columns.Count; i++)
            {
                examGridView.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

           try
            {
                examGridView.CurrentRow = examGridView.Rows[0];
            }
            catch
            {

            }

        }

        private void examGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = examGridView.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.getAllStudents().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radLblId.Text = obj.Id;
            radLblName.Text = obj.FullName;
            radLblPhone.Text = obj.PhoneNumber;
            radLblEmail.Text = obj.Email;
            radLblAddress.Text = obj.Address;
            radLblDateOfBirth.Text = obj.DateOfBirth.ToString();

            if (obj.Gender == true)
            {
                radLblGender.Text = "Nam";
            }
            else
            {
                radLblGender.Text = "Nữ";
            }

            if (obj.Status == 1)
            {
                radLblStatus.Text = "Hoạt Động";
            }
            else
            {
                radLblStatus.Text = "Không Hoạt Động";
            }

            radLblClassId.Text = obj.ClassroomId;
        }
    }
}
