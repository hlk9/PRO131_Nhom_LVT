using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
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
        AccountServices _serAcc = new AccountServices();
        UserPermissionServices _serUser = new UserPermissionServices();
        PermissionService _serPer = new PermissionService();

        string _idWhenClick;

        string _accountIdWhenClick;

        List<byte> _lstIdPermisstion = new List<byte>();

        public AddNhanVien()
        {
            InitializeComponent();
            LoadData();
            LoadDropDown();
        }

        public void LoadData()
        {
            ConditionalFormattingObject formattingObject = new ConditionalFormattingObject("StatusFalse", ConditionTypes.Equal, "Vô Hiệu Hóa", "", true);
            formattingObject.RowBackColor = Color.MistyRose;

            int stt = 1;

            rad_Staff.ColumnCount = 12;
            rad_Staff.Columns[0].HeaderText = "STT";
            rad_Staff.Columns[1].HeaderText = "ID";
            rad_Staff.Columns[2].HeaderText = "Họ Tên";
            rad_Staff.Columns[3].HeaderText = "Giới Tính";
            rad_Staff.Columns[4].HeaderText = "Ngày Sinh";
            rad_Staff.Columns[5].HeaderText = "Email";
            rad_Staff.Columns[6].HeaderText = "SĐT";
            rad_Staff.Columns[7].HeaderText = "Địa Chỉ";
            rad_Staff.Columns[8].HeaderText = "Trạng Thái";
            rad_Staff.Columns[9].HeaderText = "Tên Đăng Nhập";
            rad_Staff.Columns[10].HeaderText = "Quyền";
            rad_Staff.Columns[11].HeaderText = "Mã TK";
            rad_Staff.Columns[11].IsVisible = false;

            rad_Staff.Rows.Clear();

            foreach (var item in _service.GetAll())
            {
                string userName = _serAcc.GetAccountById(item.Id).UserName;
                string permission = _serPer.GetById(Convert.ToByte(_serUser.GetUserPermissionByAccountID(item.AccountId).FirstOrDefault().PermissionId)).Name;
                rad_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.DateOfBirth, item.Email, item.PhoneNumber, item.Address, (item.Status == 1 ? "Kích Hoạt" : "Vô Hiệu Hóa"), userName, permission, item.AccountId);
            }

            this.rad_Staff.Columns[8].ConditionalFormattingObjectList.Add(formattingObject);
        }

        private void rad_Staff_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = rad_Staff.Rows[e.RowIndex].Cells[1].Value.ToString();
            _accountIdWhenClick = rad_Staff.CurrentRow.Cells[11].Value.ToString();
            var obj = _service.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj != null)
            {
                radTxtFullName.Text = obj.FullName;
                radTxtPhone.Text = obj.PhoneNumber;
                radTxtEmail.Text = obj.Email;
                radTxtAdress.Text = obj.Address;
                radDTP.Value = obj.DateOfBirth;
                radTxtID.Text = obj.Id;
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

                radTxtUserName.Text = _serAcc.GetAccountById(obj.AccountId).UserName;

                radCmbPermission.SelectedIndex = _lstIdPermisstion.FindIndex(x => x == _serPer.GetById(_serUser.GetUserPermissionByAccountId(obj.Id).PermissionId).Id);

                radTxtUserName.Enabled = false;
                radTxtID.Enabled = false;
            }
        }
        public void LoadDropDown()
        {
            radListStaff.Items.Add("Vô Hiệu Hóa");
            radListStaff.Items.Add("Kích Hoạt");
            radListStaff.SelectedIndex = 1;

            foreach (var x in _serPer.GetAllPermission())
            {
                if (x.Id == 4)
                {
                    continue;
                }
                _lstIdPermisstion.Add(x.Id);
                radCmbPermission.Items.Add(x.Name);
            }

            radCmbPermission.SelectedIndex = 0;
        }

        public string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            md5.Clear();
            return sb.ToString();

        }

        private void radBtnAddStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radTxtID.Text) || string.IsNullOrWhiteSpace(radTxtUserName.Text) || string.IsNullOrWhiteSpace(radTxtFullName.Text) || string.IsNullOrWhiteSpace(radTxtEmail.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu quan trọng");
                return;
            }
            string id = radTxtID.Text;

            try
            {
                if (_service.GetStaffById(id).Id != null)
                {
                    MessageBox.Show("Đã có mã nhân viên này", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch { }


            string name = radTxtFullName.Text;
            bool gender = radNam.IsChecked;
            DateTime date = Convert.ToDateTime(radDTP.Text);
            string email = radTxtEmail.Text;
            string phone = radTxtPhone.Text;
            string address = radTxtAdress.Text;
            byte statuss = 0;
            string selectedStatus = radListStaff.SelectedItem.Text;

            string idAcc = id;
            string userName = radTxtUserName.Text;
            string passWord = HashPassword("123456");

            var userPer = new UserPermission()
            {
                AccountId = idAcc,
                PermissionId = _lstIdPermisstion[radCmbPermission.SelectedIndex],
            };

            if (selectedStatus != null && selectedStatus.StartsWith("Kích Hoạt"))
            {
                statuss = 1;
            }

            if (_serAcc.AddAccount(idAcc, userName, passWord))
            {
                if (_serUser.AddUserPermission(userPer))
                {
                    if (_service.AddStaff(id, name, gender, date, email, phone, address, statuss, idAcc))
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên Thất Bại");
                    }
                }
            }
            LoadData();
        }

        private void radBtnUpDate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radTxtID.Text) || string.IsNullOrWhiteSpace(radTxtUserName.Text) || string.IsNullOrWhiteSpace(radTxtFullName.Text) || string.IsNullOrWhiteSpace(radTxtEmail.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu quan trọng");
                return;
            }

            string id = _idWhenClick;
            string name = radTxtFullName.Text;
            bool gender = radNam.IsChecked;
            DateTime date = Convert.ToDateTime(radDTP.Text);
            string email = radTxtEmail.Text;
            string phone = radTxtPhone.Text;
            string address = radTxtAdress.Text;
            byte statuss = 0;
            string selectedStatus = radListStaff.SelectedItem.Text;
            if (selectedStatus != null && selectedStatus.StartsWith("Kích Hoạt"))
            {
                statuss = 1;
            }

            byte permisstion = _lstIdPermisstion[radCmbPermission.SelectedIndex];

            UserPermission userPer = new UserPermission()
            {
                Id = _serUser.GetUserPermissionByAccountId(_idWhenClick).Id,
                PermissionId = permisstion
            };

            if (_serUser.UpdateUserPermission(userPer))
            {
                if (_service.UpDateStaff(id, name, gender, date, email, phone, address, statuss))
                {
                    MessageBox.Show("Sửa Nhân Viên Thành Công");
                }
                else
                {
                    MessageBox.Show("Sửa Nhân Viên Thất Bại");
                }
            }
            LoadData();
        }

        private void radBtnClear_Click(object sender, EventArgs e)
        {
            radTxtID.Text = "";
            radTxtFullName.Text = "";
            radTxtAdress.Text = "";
            radTxtEmail.Text = "";
            radTxtPhone.Text = "";
            radNam.IsChecked = true;
            radListStaff.SelectedIndex = 0;
            radTxtUserName.Enabled = true;
            radTxtUserName.Text = "";
            radTxtID.Enabled = true;
        }

        private void rad_Staff_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem dele = new RadMenuItem("Vô Hiệu Hóa Nhân Viên Này");
            dele.Click += Dele_Click;
            e.ContextMenu.Items.Add(dele);
        }

        private void Restore_FormClosing(object? sender, FormClosingEventArgs e)
        {
            LoadData();
        }

        private void Dele_Click(object? sender, EventArgs e)
        {
            string id = rad_Staff.CurrentRow.Cells[1].Value.ToString();
            if (_service.deleteStaff(id, 255))
            {
                MessageBox.Show("Vô Hiệu Hóa Thành Công");
            }
            else
            {
                MessageBox.Show("Vô Hiệu Hóa Thất Bại");
            }

            LoadData();
        }

        private void radTxtID_TextChanged(object sender, EventArgs e)
        {
            radTxtUserName.Text = radTxtID.Text;
        }
    }
}
