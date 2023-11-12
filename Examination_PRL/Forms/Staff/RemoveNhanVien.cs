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
    public partial class RemoveNhanVien : Telerik.WinControls.UI.RadForm
    {
        public RemoveNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dtgAddNhanVien.Rows.Clear();
            dtgAddNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtgAddNhanVien.ColumnCount = 10;

            dtgAddNhanVien.Columns[0].Name = "STT";
            dtgAddNhanVien.Columns[1].Name = "ID";
            dtgAddNhanVien.Columns[2].Name = "Tên";
            dtgAddNhanVien.Columns[3].Name = "Giới Tính";
            dtgAddNhanVien.Columns[4].Name = "Ngày Sinh";
            dtgAddNhanVien.Columns[5].Name = "Email";
            dtgAddNhanVien.Columns[6].Name = "SĐT";
            dtgAddNhanVien.Columns[7].Name = "Địa Chỉ";
            dtgAddNhanVien.Columns[8].Name = "Trạng Thái";
            dtgAddNhanVien.Columns[9].Name = "ID Tài Khoản";
        }

        private void radbtnClear_Click(object sender, EventArgs e)
        {
            radtxtID.Text = "";
            radtxtTen.Text = "";
            radSexNam.IsChecked = true;
            radtxtEmail.Text = "";
            radtxtSDT.Text = "";
            radtxtDiaChi.Text = "";
            radtxtTrangThai.Text = "";
        }
    }
}
