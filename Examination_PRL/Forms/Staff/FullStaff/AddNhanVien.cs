using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL
{
    public partial class AddNhanVien : Telerik.WinControls.UI.RadForm
    {
        StaffService _service = new StaffService();
        public AddNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;

            dtg_Staff.ColumnCount = 9;
            dtg_Staff.Columns[0].HeaderText = "STT";
            dtg_Staff.Columns[1].HeaderText = "ID";
            dtg_Staff.Columns[1].IsVisible = false;
            dtg_Staff.Columns[2].HeaderText = "Họ Tên";
            dtg_Staff.Columns[3].HeaderText = "Giới Tính";
            dtg_Staff.Columns[4].HeaderText = "Ngày Sinh";
            dtg_Staff.Columns[5].HeaderText = "Email";
            dtg_Staff.Columns[6].HeaderText = "SĐT";
            dtg_Staff.Columns[7].HeaderText = "Địa Chỉ";
            dtg_Staff.Columns[8].HeaderText = "Trạng Thái";

            foreach (var item in _service.GetAll())
            {
                dtg_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, item.Status);
            }
        }
    }
}
