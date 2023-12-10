using Examination_BUS.Services;
using Examination_DAL.Models;
using Examination_PRL.Forms.Staff.Student;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Examination_PRL.Forms
{
    public partial class AddStudents : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _ser = new ParticipantService();
        ClassroomServices _serClass = new ClassroomServices();
        AccountServices _serAcc = new AccountServices();
        UserPermissionServices _serUserPer = new UserPermissionServices();

        List<string> _lstClass = new List<string>();

        string _idWhenClick;

        public AddStudents()
        {
            InitializeComponent();
            LoadData();
            loadCmb();
        }

        private void loadCmb()
        {
            foreach (var x in _serClass.GetClassrooms())
            {
                _lstClass.Add(x.Id);
                radDDClassId.Items.Add(x.Name);
            }

            radDDClassId.SelectedIndex = 0;
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
            examGridView.Columns[8].HeaderText = "Mã Lớp";
            examGridView.Columns[9].HeaderText = "Tên Đăng Nhập";
            examGridView.Columns[10].HeaderText = "Trạng Thái";
            examGridView.Rows.Clear();

            foreach (var x in _ser.getAllStudents())
            {
                string userName = "";
                try
                {
                    userName = _serAcc.GetAccountById(x.AccountId).UserName;
                }
                catch
                {

                }

                examGridView.Rows.Add(stt++, x.Id, x.FullName, (x.Gender == true ? "Nam" : "Nữ"), x.DateOfBirth, x.PhoneNumber, x.Email, x.Address, x.ClassroomId, userName, x.Status == 1 ? "Hoạt Động" : "Không Hoạt Động");

                foreach (GridViewRowInfo rowInfo in examGridView.Rows)
                {
                    if (rowInfo.Cells[9].Value == "Không Hoạt Động")
                    {
                        rowInfo.IsVisible = false;
                    }
                }
            }
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

        private void radBtnAdd_Click(object sender, EventArgs e)
        {
            string id = radTxtId.Text;
            string name = radTxtName.Text;
            string email = radTxtEmail.Text;
            string address = radTxtAddress.Text;
            string phone = radTxtPhoneNumber.Text;
            bool gender;
            if (radBtnBoy.IsChecked == true)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }

            byte status = 1;

            DateTime dateOfBirth = radDtpDateOfBirth.Value;
            string classRoomId = _lstClass[radDDClassId.SelectedIndex];

            string idAcc = radTxtId.Text;
            string userName = radTxtUserName.Text;
            string passWord = HashPassword("123456");

            string AccId = idAcc;

            var userPer = new UserPermission()
            {
                AccountId = idAcc,
                PermissionId = 4
            };

            if (_serAcc.AddAccount(idAcc, userName, passWord))
            {
                if (_serUserPer.AddUserPermission(userPer))
                {
                    if (_ser.createStudents(id, name, address, email, phone, gender, status, dateOfBirth, classRoomId, AccId))
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }

            }
            LoadData();
        }

        private void radBtnUpdate_Click(object sender, EventArgs e)
        {
            string id = _idWhenClick;
            string name = radTxtName.Text;
            string email = radTxtEmail.Text;
            string address = radTxtAddress.Text;
            string phone = radTxtPhoneNumber.Text;
            bool gender;
            if (radBtnBoy.IsChecked == true)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            byte status = Convert.ToByte(_ser.getAllStudents().Where(x => x.Id == _idWhenClick).Select(x => x.Status).FirstOrDefault());
            DateTime dateOfBirth = radDtpDateOfBirth.Value;
            string classRoomId = _lstClass[radDDClassId.SelectedIndex];

            if (_ser.updateStudents(id, name, address, email, phone, gender, status, dateOfBirth, classRoomId))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }

            LoadData();
        }

        private void radBtnClear_Click(object sender, EventArgs e)
        {
            radTxtName.Text = "";
            radTxtPhoneNumber.Text = "";
            radTxtEmail.Text = "";
            radTxtAddress.Text = "";
            radDtpDateOfBirth.Value = DateTime.Now;
            radBtnBoy.IsChecked = true;
            radDDClassId.SelectedIndex = 0;
            radTxtId.Text = "";
            radTxtUserName.Text = "";

            radTxtUserName.Enabled = true;
        }

        private void examGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = examGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            var obj = _ser.getAllStudents().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radTxtUserName.Enabled = false;

            if (obj != null)
            {
                radTxtId.Text = obj.Id;
                radTxtName.Text = obj.FullName;
                radTxtPhoneNumber.Text = obj.PhoneNumber;
                radTxtEmail.Text = obj.Email;
                radTxtAddress.Text = obj.Address;
                radDtpDateOfBirth.Value = obj.DateOfBirth;
                if (obj.Gender == true)
                {
                    radBtnBoy.IsChecked = true;
                }
                else
                {
                    radBtnGirl.IsChecked = true;
                }

                radDDClassId.SelectedIndex = _lstClass.FindIndex(x => x == obj.ClassroomId);
                if(obj.AccountId != null)
                {
                    radTxtUserName.Text = _serAcc.GetAccountById(obj.AccountId).UserName;
                }
                else
                {
                    radTxtUserName.Text = "";
                }
                
            }
        }

        private void examGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();

            RadMenuItem deleteItem = new RadMenuItem("Xoá thí sinh này");
            deleteItem.Click += DeleteItem_Click;
            e.ContextMenu.Items.Add(deleteItem);

            RadMenuItem restore = new RadMenuItem("Khôi phục thí sinh");
            restore.Click += Restore_Click;
            e.ContextMenu.Items.Add(restore);
        }

        private void Restore_Click(object? sender, EventArgs e)
        {
            RestoreStudents restore = new RestoreStudents();
            restore.ShowDialog();
        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            string id = examGridView.CurrentRow.Cells[1].Value.ToString();
            if (_ser.deleteStudents(id, 255))
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại");
            }
            LoadData();
        }

        private void radBtnExcel_Click(object sender, EventArgs e)
        {
            AddStudentExcel addStudentExcel = new AddStudentExcel();
            addStudentExcel.ShowDialog();
        }
    }
}
