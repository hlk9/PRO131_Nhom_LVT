using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examination_PRL.Forms.Staff.FullStaff
{
    public partial class CrudTK : Telerik.WinControls.UI.RadForm
    {
        StaffService _serStaff = new StaffService();
        AccountServices _serAcc = new AccountServices();
        UserPermissionServices _serPer = new UserPermissionServices();
        PermissionService _serPerAcc = new PermissionService();
        List<int> _lstQuyen = new List<int>();
        string _idWhenClick;
        string _idWhenAccount;

        public CrudTK()
        {
            InitializeComponent();
            LoadData_Staff();
            LoadCMB();
        }
        public void LoadCMB()
        {
            foreach (var item in _serPerAcc.GetAllPermission())
            {
                _lstQuyen.Add(item.Id);
                radCmbQuyen.Items.Add(item.Name);
            }
            radCmbQuyen.SelectedIndex = 0;
        }
        public void LoadData_Staff()
        {
            int stt = 1;

            radView_Staff.ColumnCount = 5;
            radView_Staff.Columns[0].HeaderText = "STT";
            radView_Staff.Columns[1].HeaderText = "Mã Nhân Viên";
            radView_Staff.Columns[2].HeaderText = "Tên Nhân Viên";
            radView_Staff.Columns[3].HeaderText = "Giới Tính";
            radView_Staff.Columns[4].HeaderText = "AccountId";
            radView_Staff.Columns[4].IsVisible = false;


            radView_Staff.Rows.Clear();

            foreach (var item in _serStaff.GetAll())
            {

                radView_Staff.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.AccountId);
            }
        }

        private void radView_Staff_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = radView_Staff.Rows[e.RowIndex].Cells[1].Value.ToString();

            var obj = _serStaff.GetAll().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            if (obj.AccountId != null)
            {
                _idWhenAccount = radView_Staff.Rows[e.RowIndex].Cells[4].Value.ToString();
                var account = _serAcc.GetAccountById(_idWhenAccount);


                radTxtPassWord.Text = account.Password;
                if (_serPer.GetUserPermissionByAccountId(obj.Id) != null)
                {
                    radCmbQuyen.SelectedIndex = _lstQuyen.FindIndex(x => x == _serPerAcc.GetById(_serPer.GetUserPermissionByAccountId(obj.Id).PermissionId).Id);
                }
                else
                {
                    radCmbQuyen.SelectedIndex = -1;
                }
            }
            else
            {
                radTextId.Text = null;
                radTextUserName.Text = null;
                radTxtPassWord.Text = null;
            }
            radTextId.Text = obj.Id;
            radTextUserName.Text = obj.Id;
        }

        private void radButnThem_Click(object sender, EventArgs e)
        {
            string id = radTextId.Text;
            string username = radTextUserName.Text;
            string password = radTxtPassWord.Text;
            byte permissionId = Convert.ToByte(_lstQuyen[radCmbQuyen.SelectedIndex]);
            var permis = new UserPermission()
            {
                AccountId = id,
                PermissionId = permissionId
            };

            if (_serAcc.AddAccount(id, username, password))
            {
                if (_serPer.AddUserPermission(permis))
                {
                    if (_serStaff.UpDateAccountStaff(_idWhenClick, id))
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            LoadData_Staff();
        }

        private void radButnXoa_Click(object sender, EventArgs e)
        {
            if (_serStaff.UpDateAccountStaff(_idWhenClick, null))
            {
                if (_serAcc.DeleteAccount(_idWhenClick))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
            LoadData_Staff();
        }

        private void radbtnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
