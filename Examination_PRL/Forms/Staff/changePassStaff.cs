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

namespace Examination_PRL.Forms.Staff
{
    public partial class changePassStaff : Telerik.WinControls.UI.RadForm
    {
        AccountServices _serAcc = new AccountServices();
        Account Account;

        public changePassStaff(Account acc)
        {
            this.Account = acc;
            InitializeComponent();
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

        private void radBtnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radTxtPassCu.Text) || string.IsNullOrWhiteSpace(radTxtPassMoi.Text) || string.IsNullOrWhiteSpace(radTxtPassMoiNL.Text))
            {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }

            string passCu = HashPassword(radTxtPassCu.Text);

            if (_serAcc.GetAccountById(Account.Id).Password != passCu)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng! Mời kiểm tra lại.");
                return;
            }

            string passMoi = HashPassword(radTxtPassMoi.Text);
            string passMoiNL = HashPassword(radTxtPassMoiNL.Text);

            if (passMoi != passMoiNL)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu mới nhập lại không khớp! Mời kiểm tra lại");
                return;
            }

            if (passMoi == passCu || passMoiNL == passCu)
            {
                MessageBox.Show("Mật khẩu mới không được trong với mật khẩu cũ.");
                return;
            }

            DialogResult = MessageBox.Show("Bạn chắc chắn muốn đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult == DialogResult.Yes)
            {
                if (_serAcc.UpdatePassWord(Account.Id, passMoiNL))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
        }
    }
}
