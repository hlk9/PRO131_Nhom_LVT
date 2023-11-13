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

        string _idWhenClick;

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
            _idWhenClick = examGridView.Rows[e.RowIndex].Cells[1].Value.ToString();        
            var obj = _ser.getAllStudents().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj != null)
            {
                radTxtTen.Text = obj.FullName;
                radTxtPhone.Text = obj.PhoneNumber;
                radTxtEmail.Text = obj.Email;
                radTxtAdress.Text = obj.Address;
                radDtpNS.Value = obj.DateOfBirth;
                if(obj.Gender == true)
                {
                    radBNam.IsChecked = true;
                }
                else
                {
                    radBNu.IsChecked = true;
                }
            }
        }
    }
}
