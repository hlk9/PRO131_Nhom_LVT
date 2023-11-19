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
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class RestoreExamRoom : Telerik.WinControls.UI.RadForm
    {
        ExamRoomServices _ser = new ExamRoomServices();
        string _idWhenClick;

        public RestoreExamRoom()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            examRoomGridView.Rows.Clear();

            int stt = 1;

            examRoomGridView.ColumnCount = 7;

            examRoomGridView.Columns[0].HeaderText = "STT";
            examRoomGridView.Columns[1].HeaderText = "Mã Phòng Thi";
            examRoomGridView.Columns[2].HeaderText = "Tên Phòng Thi";
            examRoomGridView.Columns[3].HeaderText = "Địa Chỉ";
            examRoomGridView.Columns[4].HeaderText = "Ghi Chú";
            examRoomGridView.Columns[5].HeaderText = "Sức Chứa";
            examRoomGridView.Columns[6].HeaderText = "Trạng Thái";

            foreach (var item in _ser.getAllRoomRemoves())
            {
                examRoomGridView.Rows.Add(stt++, item.Id, item.Name, item.Address, item.Note, item.Capacity, item.Status == true ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void examRoomGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            _idWhenClick = examRoomGridView.CurrentRow.Cells[1].Value.ToString();

            var obj = _ser.getAllRoomRemoves().Where(x => x.Id == _idWhenClick).FirstOrDefault();

            radLblShow.Text = $"Mã: {obj.Id} - Tên: {obj.Name}";
        }

        private void radBtnResstore_Click(object sender, EventArgs e)
        {
            if (_ser.deleteExamRoom(_idWhenClick, true))
            {
                MessageBox.Show("Khôi Phục Thành Công");
            }
            else
            {
                MessageBox.Show("Khôi Phục Thất Bại");
            }

            LoadData();
        }
    }
}
