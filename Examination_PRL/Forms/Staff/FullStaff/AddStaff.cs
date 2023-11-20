using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_PRL
{
    public partial class AddNhanVien : Telerik.WinControls.UI.RadForm
    {
        StaffService _service = new StaffService();
        string _idWhenClick;
        public AddNhanVien()
        {
            InitializeComponent();
            LoadData();
            LoadDropDown();
        }

        public void LoadData()
        {
            int stt = 1;

            rad_Staff.ColumnCount = 9;
            rad_Staff.Columns[0].HeaderText = "STT";
            rad_Staff.Columns[1].HeaderText = "ID";
            rad_Staff.Columns[1].IsVisible = false;
            rad_Staff.Columns[2].HeaderText = "Họ Tên";
            rad_Staff.Columns[3].HeaderText = "Giới Tính";
            rad_Staff.Columns[4].HeaderText = "Ngày Sinh";
            rad_Staff.Columns[5].HeaderText = "Email";
            rad_Staff.Columns[6].HeaderText = "SĐT";
            rad_Staff.Columns[7].HeaderText = "Địa Chỉ";
            rad_Staff.Columns[8].HeaderText = "Trạng Thái";

            rad_Staff.Rows.Clear();

            foreach (var item in _service.GetAll())
            {
                rad_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, (item.Status == 0 ? "Vô Hiệu Hóa" : "Kích Hoạt"));
            }
        }

        private void rad_Staff_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = rad_Staff.Rows[e.RowIndex].Cells[1].Value.ToString();
            var obj = _service.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj != null)
            {
                radTxtFullName.Text = obj.FullName;
                radTxtPhone.Text = obj.PhoneNumber;
                radTxtEmail.Text = obj.Email;
                radTxtAdress.Text = obj.Address;
                radDTP.Value = obj.DateOfBirth;
                if (obj.Gender == true)
                {
                    radNam.IsChecked = true;
                }
                else
                {
                    radNu.IsChecked = true;
                }
                if (obj.Status == 0)
                {
                    radListStaff.SelectedIndex = 0;
                }
                else
                {
                    radListStaff.SelectedIndex = 1;
                }
            }
        }
        public void LoadDropDown()
        {
            radListStaff.Items.Add("Vô Hiệu Hóa");
            radListStaff.Items.Add("Kích Hoạt");
            radListStaff.SelectedIndex = 0;
        }

        private void radBtnAddStaff_Click(object sender, EventArgs e)
        {
            string id = radTxtID.Text;
            string name = radTxtFullName.Text;
            bool gender = radNam.IsChecked;
            DateTime date = Convert.ToDateTime(radDTP.Text);
            string email = radTxtEmail.Text;
            string phone = radTxtAdress.Text;
            string address = radTxtAdress.Text;
            byte statuss = 0;
            string selectedStatus = radListStaff.SelectedItem.Text;
            if (selectedStatus != null && selectedStatus.StartsWith("Kích Hoạt"))
            {
                statuss = 1;
            }
            if (_service.AddStaff(id, name, gender, date, email, phone, address, statuss))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            }
            LoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
