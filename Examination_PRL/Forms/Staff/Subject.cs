using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Examination_BUS.Services;
using Telerik.WinForms.Documents.UI.Extensibility;

namespace Examination_PRL.Forms.Staff
{
    public partial class Subject : Telerik.WinControls.UI.RadForm
    {
        SubjectServices _ser = new SubjectServices();
        int selectedID = 0;
        public Subject()
        {
            InitializeComponent();
            _ser = new SubjectServices();
            LoadData(_ser.GetSubjects());
        }
        public void LoadData(dynamic data)
        {
            dtg_Show.Rows.Clear();
            int stt = 1;
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "stt"; dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].Name = "IDsubject"; dtg_Show.Columns[1].HeaderText = "ID Môn Học";
            dtg_Show.Columns[2].Name = "subjetc"; dtg_Show.Columns[2].HeaderText = "Môn Học";
            dtg_Show.Columns[3].Name = "status"; dtg_Show.Columns[3].HeaderText = "Trạng Thái";
            foreach (var item in data)
            {
                dtg_Show.Rows.Add(stt++, item.Id, item.Name, item.Status == 0 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void dtg_Show_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedID = dtg_Show.Rows[index];
            tbt_Subject.Text = selectedID.Cells[2].Value.ToString();
            tbt_IDSubject.Text = selectedID.Cells[1].Value.ToString();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tbt_Subject.Text;
            string ID = tbt_IDSubject.Text;
            byte trangthai = 0;

            bool add = _ser.AddSub(name, ID, trangthai);
            if (add) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadData(_ser.GetSubjects());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = tbt_Subject.Text;
            string ID = tbt_IDSubject.Text;
            byte status = 0;
            bool update = _ser.EditSub(name, ID, status);
            if (update) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
        }
    }
}
