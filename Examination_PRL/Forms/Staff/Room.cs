using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Examination_BUS.Services;
using Examination_DAL.Models;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class Room : Telerik.WinControls.UI.RadForm
    {
        ClassroomServices _ser = new ClassroomServices();
        int _idWhenClick;

        public Room()
        {
            InitializeComponent();
            _ser = new ClassroomServices();
            LoadData(_ser.GetClassrooms());
        }

        public void LoadData(dynamic data)
        {
            dtg_Show.Rows.Clear();
            int stt = 1;
            dtg_Show.ColumnCount = 3;
            dtg_Show.Columns[0].Name = "stt"; dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].Name = "nameclass"; dtg_Show.Columns[1].HeaderText = "Phòng thi";
            dtg_Show.Columns[2].Name = "Idclass"; dtg_Show.Columns[2].HeaderText = "ID Phòng thi";
            foreach (var item in data)
            {
                dtg_Show.Rows.Add(stt++, item.Name, item.Id);
            }
        }





    }
}
