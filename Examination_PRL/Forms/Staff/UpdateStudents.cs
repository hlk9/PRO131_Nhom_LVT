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

namespace Examination_PRL.Forms.Staff
{
    public partial class UpdateStudents : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _ser = new ParticipantService();

        public UpdateStudents()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            examGridView.ColumnCount = 8;
            examGridView.Columns[0].HeaderText = "STT";
            examGridView.Columns[1].HeaderText = "Mã Thí Sinh";
            examGridView.Columns[2].HeaderText = "Tên Thí Sinh";
            examGridView.Columns[3].HeaderText = "Giới Tính";
            examGridView.Columns[4].HeaderText = "Ngày Sinh";
            examGridView.Columns[5].HeaderText = "Số Điện Thoại";
            examGridView.Columns[6].HeaderText = "Email";
            examGridView.Columns[7].HeaderText = "Địa Chỉ";

            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllStudents())
            {
                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address);
            }
        }

        private void examGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index == 0 || index == _ser.getAllStudents().Count) return;


        }
    }
}
