using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.FullStaff
{
    public partial class RestoreStaff : Telerik.WinControls.UI.RadForm
    {
        StaffService _service = new StaffService();
        string _idWhenClick;

        public RestoreStaff()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            rad_Staff.ColumnCount = 9;
            rad_Staff.Columns[0].HeaderText = "STT";
            rad_Staff.Columns[1].HeaderText = "ID";
            rad_Staff.Columns[2].HeaderText = "Họ Tên";
            rad_Staff.Columns[3].HeaderText = "Giới Tính";
            rad_Staff.Columns[4].HeaderText = "Ngày Sinh";
            rad_Staff.Columns[5].HeaderText = "Email";
            rad_Staff.Columns[6].HeaderText = "SĐT";
            rad_Staff.Columns[7].HeaderText = "Địa Chỉ";
            rad_Staff.Columns[8].HeaderText = "Trạng Thái";

            rad_Staff.Rows.Clear();

            foreach (var item in _service.getStaffAllRemove())
            {
                rad_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, (item.Status == 0 ? "Vô Hiệu Hóa" : "Kích Hoạt"));
            }
        }

        private void radBtnRestore_Click(object sender, EventArgs e)
        {
            string id = rad_Staff.CurrentRow.Cells[1].Value.ToString();

            if (_service.deleteStaff(id, 1))
            {
                MessageBox.Show("Khôi Phục Thành Công");
            }
            else
            {
                MessageBox.Show("Khôi Phục Thất Bại");
            }

            LoadData();
        }
    }
}
