using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class QLTKStudent : Telerik.WinControls.UI.RadForm
    {
        ParticipantService _service = new ParticipantService();
        AccountServices _accountServices = new AccountServices();
        string _idWhenClick;
        string _accountId;
        public QLTKStudent()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            ConditionalFormattingObject formattingObject = new ConditionalFormattingObject("AccountID", ConditionTypes.Equal, "", "", true);
            formattingObject.RowBackColor = Color.LightPink;
            int stt = 1;
            radView_QLTKTS.ColumnCount = 6;

            radView_QLTKTS.Columns[0].HeaderText = "STT";
            radView_QLTKTS.Columns[1].HeaderText = "Mã Thí Sinh";
            radView_QLTKTS.Columns[2].HeaderText = "Tên Thí Sinh";
            radView_QLTKTS.Columns[3].HeaderText = "Giới Tính";
            radView_QLTKTS.Columns[4].HeaderText = "Email";
            radView_QLTKTS.Columns[5].HeaderText = "AccountID";
            radView_QLTKTS.Columns[5].IsVisible = false;


            radView_QLTKTS.Rows.Clear();

            foreach (var item in _service.getAllStudents())
            {
                radView_QLTKTS.Rows.Add(stt++, item.Id, item.FullName, (item.Gender == true ? "Nam" : "Nữ"), item.Email, item.AccountId == null ? "" : item.AccountId);
            }
            radView_QLTKTS.Columns[5].ConditionalFormattingObjectList.Add(formattingObject);
        }

        private void radView_QLTKTS_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = radView_QLTKTS.Rows[e.RowIndex].Cells[1].Value.ToString();
            _accountId = radView_QLTKTS.Rows[e.RowIndex].Cells[5].Value.ToString();
            var obj = _service.getAllStudents().Where(x => x.Id == _idWhenClick).FirstOrDefault();
            var account = _service.GetAccountById(_accountId).FirstOrDefault();

            if (obj != null)
            {
                radTxtIDTK.Text = obj.AccountId;
                radTxtIDThiSinh.Text = obj.Id;
                radTxtName.Text = obj.FullName;
                if (obj.Gender == true)
                {
                    radTxtGender.Text = "Nam";
                }
                else
                {
                    radTxtGender.Text = "Nữ";
                }

                radTxtEmail.Text = obj.Email;

            }
            radTxtIDThiSinh.Enabled = false;
            radTxtName.Enabled = false;
            radTxtGender.Enabled = false;
            radTxtEmail.Enabled = false;
            if (account == null)
            {
                radTxtUserName.Text = " ";
                radTxtPassWord.Text = " ";
            }
            else
            {
                radTxtUserName.Text = account.UserName;
                radTxtPassWord.Text = account.Password;
            }
        }

        private void radBtnTaoTK_Click(object sender, EventArgs e)
        {
            string userName = radTxtUserName.Text;
            string password = radTxtPassWord.Text;

            if (_accountServices.AddAccount(_idWhenClick, userName, password))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            _service.updateAccountId(_idWhenClick, _idWhenClick);
        }

        private void radBtnXoaTK_Click(object sender, EventArgs e)
        {
            if (_service.updateAccountId(_idWhenClick, null))
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
            _accountServices.DeleteAccount(_idWhenClick);
        }
    }
}
