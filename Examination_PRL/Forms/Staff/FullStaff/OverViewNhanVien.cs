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
using Telerik.WinControls.UI;

namespace Examination_PRL
{
    public partial class OverViewNhanVien : Telerik.WinControls.UI.RadForm
    {
        StaffService _services = new StaffService();
        string _idWhenClick;
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
            radViewNV.Columns[0].IsVisible = false;
            radViewNV.Columns[1].HeaderText = "STT";
            radViewNV.Columns[2].HeaderText = "Tên NV";
            radViewNV.Columns[3].HeaderText = "Giới Tính";
            radViewNV.Columns[4].HeaderText = "Ngày Sinh";
            radViewNV.Columns[5].HeaderText = "Email";
            radViewNV.Columns[6].HeaderText = "SĐT";
            radViewNV.Columns[7].HeaderText = "Địa chỉ";
            radViewNV.Columns[8].HeaderText = "Trạng Thái";

            foreach (var item in _services.GetAll())
            {
                radViewNV.Rows.Add(item.Id, stt++, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, (item.Status == 0 ? "Vô Hiệu Hóa" : "Kích Hoạt"));
            }
        }

        private void radViewNV_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = radViewNV.CurrentRow.Cells[1].Value.ToString();
            var obj = _services.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj != null)
            {
                radLblName.Text = obj.FullName;
                radLblSDT.Text = obj.PhoneNumber;
                radLblEmail.Text = obj.Email;
                radLblAdress.Text = obj.Address;
                radLblDate.Text = obj.DateOfBirth.ToString();
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
            }
        }
    }
}
