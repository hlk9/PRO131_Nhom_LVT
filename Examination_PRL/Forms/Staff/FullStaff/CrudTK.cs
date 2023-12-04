﻿using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.FullStaff
{
    public partial class CrudTK : Telerik.WinControls.UI.RadForm
    {
        AccountServices _service = new AccountServices();
        string _idWhenClick;
        public CrudTK()
        {
            InitializeComponent();
            LoadDataCrud();
        }

        public void LoadDataCrud()
        {
            int stt = 1;

            radView_Crud.ColumnCount = 4;

            radView_Crud.Columns[0].HeaderText = "STT";
            radView_Crud.Columns[1].HeaderText = "ID";
            radView_Crud.Columns[2].HeaderText = "TÊN TK";
            radView_Crud.Columns[3].HeaderText = "MẬT KHẨU";

            radView_Crud.Rows.Clear();

            foreach (var item in _service.GetAllAccounts())
            {
                radView_Crud.Rows.Add(stt++, item.Id, item.UserName, item.Password);
            }
        }

        private void radView_Crud_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = radView_Crud.Rows[e.RowIndex].Cells[1].Value.ToString();

            var obj = _service.GetAllAccounts().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            if (obj != null)
            {
                radTxtID.Text = obj.Id.ToString();
                radTxtName.Text = obj.UserName;
                radTextMK.Text = obj.Password;
            }
        }

        private void radBtnThem_Click(object sender, EventArgs e)
        {
                string id = radTxtID.Text;
                string name = radTxtName.Text;
                string passWord = radTextMK.Text;

                if (_service.AddAccount(id, name, passWord))
                {
                    MessageBox.Show("Thêm Tài Khoản Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Tài Khoản Thất Bại Kiểm Tra Lại Định Dạng");
                }
                LoadDataCrud();
        }

        private void radBtnSua_Click(object sender, EventArgs e)
        {
            string id = _idWhenClick.ToString();
            string name = radTxtName.Text;
            string passWord = radTextMK.Text;

            if (_service.UpdateAccount(id, name, passWord, null))
            {
                MessageBox.Show("Sửa Tài Khoản Thành Công");
            }
            else
            {
                MessageBox.Show("Sửa Tài Khoản Thất Bại");
            }
            LoadDataCrud();
        }

        private void radBtnXoa_Click(object sender, EventArgs e)
        {
         
        }
    }
}
