using Examination_BUS.Services;
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

        public StudentsList()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            examGridView.ColumnCount = 7;
            examGridView.Columns[0].HeaderText = "Mã Thí Sinh";
            examGridView.Columns[1].HeaderText = "Tên Thí Sinh";
            examGridView.Columns[2].HeaderText = "Giới Tính";
            examGridView.Columns[3].HeaderText = "Ngày Sinh";
            examGridView.Columns[4].HeaderText = "Số Điện Thoại";
            examGridView.Columns[5].HeaderText = "Email";
            examGridView.Columns[6].HeaderText = "Địa Chỉ";

            foreach (var x in _ser.getAllStudents())
            {
                examGridView.Rows.Add(x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address);
            }
        }

        private void examGridView_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            string id=  examGridView.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("Ping"+id);
            //get id current cell
            

        }
    }
}
