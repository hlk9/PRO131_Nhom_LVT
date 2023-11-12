using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL
{
    public partial class OverViewNhanVien : Telerik.WinControls.UI.RadForm
    {
        public OverViewNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dtgView.Rows.Clear();
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtgView.ColumnCount = 10;

            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "ID";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "Giới Tính";
            dtgView.Columns[4].Name = "Ngày Sinh";
            dtgView.Columns[5].Name = "Email";
            dtgView.Columns[6].Name = "SĐT";
            dtgView.Columns[7].Name = "Địa Chỉ";
            dtgView.Columns[8].Name = "Trạng Thái";
            dtgView.Columns[9].Name = "ID Tài Khoản";
        }
    }
}
