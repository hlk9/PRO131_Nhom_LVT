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

namespace Examination_PRL.Forms
{
    public partial class AddStudents : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _ser = new ParticipantService();

        public AddStudents()
        {
            InitializeComponent();
            LoadData();
        }

        private void loadCmb()
        {

        }

        public void LoadData()
        {
            int stt = 1;

            examGridView.ColumnCount = 11;
            examGridView.Columns[0].HeaderText = "STT";
            examGridView.Columns[1].HeaderText = "Mã Thí Sinh";
            examGridView.Columns[2].HeaderText = "Tên Thí Sinh";
            examGridView.Columns[3].HeaderText = "Giới Tính";
            examGridView.Columns[4].HeaderText = "Ngày Sinh";
            examGridView.Columns[5].HeaderText = "Số Điện Thoại";
            examGridView.Columns[6].HeaderText = "Email";
            examGridView.Columns[7].HeaderText = "Địa Chỉ";
            examGridView.Columns[8].HeaderText = "Id Lớp";
            examGridView.Columns[9].HeaderText = "Id Account";
            examGridView.Columns[10].HeaderText = "Trạng Thái";

            examGridView.Columns[8].IsVisible = false;
            examGridView.Columns[9].IsVisible = false;
            examGridView.Columns[10].IsVisible = false;
            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllStudents())
            {
                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.ClassroomId, x.AccountId, x.Status);

                foreach (GridViewRowInfo row in examGridView.Rows)
                {
                    if (int.Parse(row.Cells[10].Value.ToString()) == 255)
                    {
                        row.IsVisible = false;
                    }
                }
            }
        }

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            string id = radTxtMa.Text;
            string FullName = radTxtName.Text;
            string Email = radTxtEmail.Text;
            string Address = radTxtAddress.Text;
            string PhoneNumber = radTxtPhone.Text;
            bool Gender;
            if(radBtnMen.IsChecked)
            {
                Gender = true;
            }
            else
            {
                Gender = false;
            }
            byte status = byte.Parse(radCmbStatus.SelectedItem.ToString());
            DateTime DateOfBirth = radDtp.Value;

        }
    }
}
