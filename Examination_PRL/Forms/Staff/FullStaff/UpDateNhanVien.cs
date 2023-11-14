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

namespace Examination_PRL
{
    public partial class UpDateNhanVien : Telerik.WinControls.UI.RadForm
    {
        StaffService _service = new StaffService();
        string _idWhenClick;
        public UpDateNhanVien()
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
                string status = (item.Status == 0 ? "Kích Hoạt" : "Vô Hiệu Hóa");
                dtg_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, status);
            }
        }

        private void dtg_Staff_CellClick_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = dtg_Staff.Rows[e.RowIndex].Cells[1].Value.ToString();
            var obj = _service.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj != null)
            {
                radTxtTen.Text = obj.FullName;
                radTxtPhone.Text = obj.PhoneNumber;
                radTxtEmail.Text = obj.Email;
                radTxtAdress.Text = obj.Address;
                radDtpNS.Value = obj.DateOfBirth;
                if (obj.Gender == true)
                {
                    radBNam.IsChecked = true;
                }
                else
                {
                    radBNu.IsChecked = true;
                }
                if (obj.Status == 0)
                {
                    radDropDownList1.SelectedIndex = radDropDownList1.FindStringExact("Kích Hoạt");
                }
                else
                {
                    radDropDownList1.SelectedIndex = radDropDownList1.FindStringExact("Vô Hiệu Hóa");
                }
            }
        }

        private void radBtnUpDate_Click(object sender, EventArgs e)
        {
            string id = _idWhenClick;
            string name = radTxtTen.Text;
            bool sex = radBNam.IsChecked;
            DateTime ngaysinh = Convert.ToDateTime(radDtpNS.Text);
            string email = radTxtEmail.Text;
            string phone = radTxtPhone.Text;
            string address = radTxtAdress.Text;
            byte status = 0; // Default to inactive
            string selectedStatus = radDropDownList1.SelectedItem?.ToString();

            // Map status based on the selected item
            if (selectedStatus != null && selectedStatus.StartsWith("Active"))
            {
                status = 1; // Set to active
            }
            if (_service.UpDateStaff(id, name, sex, ngaysinh, email, phone, address, status))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }
            LoadData();
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            List<string> itemsToAdd = new List<string>
            {
                "Kích Hoạt",
                "Vô Hiệu Hóa",
                // Add more items as needed
            };

            // Clear existing items in the RadDropDownList (optional)
            radDropDownList1.Items.Clear();

            // Add the new items
            radDropDownList1.Items.AddRange(itemsToAdd.ToArray());

            // If you want to select the first item by default
            if (radDropDownList1.Items.Count > 0)
            {
                radDropDownList1.SelectedIndex = 0;
            }
        }
    }
}
