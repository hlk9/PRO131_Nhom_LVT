using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL
{
    public partial class OverViewNhanVien : Telerik.WinControls.UI.RadForm
    {
        StaffService _services = new StaffService();
        public OverViewNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            radViewNV.ColumnCount = 8;
            radViewNV.Columns[0].Name = "ID";
            radViewNV.Columns[1].HeaderText = "STT";
            radViewNV.Columns[2].HeaderText = "Tên NV";
            radViewNV.Columns[3].HeaderText = "Giới Tính";
            radViewNV.Columns[4].HeaderText = "Ngày Sinh";
            radViewNV.Columns[5].HeaderText = "Email";
            radViewNV.Columns[6].HeaderText = "SĐT";
            radViewNV.Columns[7].HeaderText = "Địa chỉ";
            radViewNV.Columns[0].IsVisible = false;

            foreach (var item in _services.GetAll())
            {
                radViewNV.Rows.Add(item.Id, stt++, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address);
            }
        }
    }
}
