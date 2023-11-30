using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Examination_DAL.Models;
using Telerik.Pivot.Core.Groups;
using Examination_BUS.Services;

namespace Examination_PRL.Forms.Staff
{
    public partial class ListQA : Telerik.WinControls.UI.RadForm
    {
        FeedbackServices _ser = new FeedbackServices();
        public ListQA()
        {
            InitializeComponent();
            _ser = new FeedbackServices();
            LoadData(_ser.GetAll());

        }
        public void LoadData(dynamic data)
        {
            radGridView1.Rows.Clear();
            int stt = 1;
            radGridView1.ColumnCount = 8;
            radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridView1.Columns[0].HeaderText = "Số thứ tự";
            radGridView1.Columns[1].HeaderText = "ID";
            radGridView1.Columns[2].HeaderText = "Tiêu đề";
            radGridView1.Columns[3].HeaderText = "Tên";
            radGridView1.Columns[4].HeaderText = "ID Thí sinh";
            radGridView1.Columns[5].HeaderText = "Nội dung";
            radGridView1.Columns[6].HeaderText = "Ngày đăng";
            radGridView1.Columns[7].IsVisible = false;
            
          

            foreach(var item in data)
            {
                radGridView1.Rows.Add(stt++, item.Id, item.Title, item.Name, item.IdParticipant, item.Content,item.SubmitTime);
            }
           
        }
    }
}
