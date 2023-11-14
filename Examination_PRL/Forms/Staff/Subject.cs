using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Examination_BUS.Services;

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
            dtg_Show.Columns[1].Name = "subject"; dtg_Show.Columns[1].HeaderText = "Môn học";
            dtg_Show.Columns[2].Name = "IDsubjetc"; dtg_Show.Columns[2].HeaderText = "ID Môn học";
            dtg_Show.Columns[3].Name = "status"; dtg_Show.Columns[2].HeaderText = "Trạng thái";
            foreach (var item in data)
            {
                dtg_Show.Rows.Add(stt++, item.Name, item.Id, item.Status == 0);
            }
        }

        private void dtg_Show_Click(object sender, EventArgs e)
        {
           
        }
    }
}
