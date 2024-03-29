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
            LoadData();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            int stt = 1;
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "stt"; dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].Name = "IDsubject"; dtg_Show.Columns[1].HeaderText = "ID Môn Học";
            dtg_Show.Columns[2].Name = "subjetc"; dtg_Show.Columns[2].HeaderText = "Môn Học";
            dtg_Show.Columns[3].Name = "status"; dtg_Show.Columns[3].HeaderText = "Trạng Thái";
            foreach (var item in _ser.GetSubjects())
            {
                dtg_Show.Rows.Add(stt++, item.Id, item.Name, item.Status == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void dtg_Show_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedID = dtg_Show.Rows[index];
            tbt_Subject.Text = selectedID.Cells[2].Value.ToString();
            tbt_IDSubject.Text = selectedID.Cells[1].Value.ToString();
            if (selectedID.Cells[3].Value.ToString() == "Hoạt động")
            {
                rb_Onl.IsChecked = true; rb_Off.IsChecked = false;
            }
            else
            {
                rb_Off.IsChecked = true; rb_Onl.IsChecked = false;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tbt_Subject.Text;
            string ID = tbt_IDSubject.Text;
           
            byte trangthai = 1;
            if (rb_Off.IsChecked)
            {
                trangthai = 0;
            }
            bool add = _ser.AddSub(name, ID, trangthai);
            if (add) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = tbt_Subject.Text;
            string ID = tbt_IDSubject.Text;
            byte trangthai = 0;
            if (rb_Onl.IsChecked)
            {
                trangthai = 1;
            }
            bool update = _ser.EditSub(ID, name, trangthai);
            if (update) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
        }

        private void rb_Off_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
