using Examination_BUS.Services;
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
            if (ValiDate())
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
            DialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Tài Khoản Này Không???", "Xác Nhận", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                if (_service.DeleteAccount(_idWhenClick))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Tiếp Tục Chương Trình");
            }
            LoadDataCrud();
        }

        private bool ValiDate()
        {
            var textBoxes = toolWindow1.Controls.OfType<TextBox>();
            var errorProvider = new ErrorProvider();
            var error = 0;

            foreach (var item in textBoxes)
            {
                if (item.Name == "radTxtName" && !Regex.IsMatch(item.Text, @"^[a-zA-Z]+PH\d{5}$"))
                {
                    errorProvider.SetError(item, "Tài Khoản Ko Hợp Lệ");
                    error++;
                }
                else
                {
                    errorProvider.SetError(item, "");
                }
            }

            if (error > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
