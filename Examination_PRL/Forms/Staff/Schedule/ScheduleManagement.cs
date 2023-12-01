using Examination_BUS.Services;
using Examination_PRL.Forms.Participant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.WebSockets;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.Schedule
{
    public partial class ScheduleManagement : Telerik.WinControls.UI.RadForm
    {
        ScheduleServices scheduleServices = new ScheduleServices();
        ScheduleDetailServices scheduleDetailServices = new ScheduleDetailServices();
        string _idSchedule;
        public ScheduleManagement()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            scheduleGridView.Rows.Clear();
            scheduleGridView.ColumnCount = 12;
            scheduleGridView.Columns[0].HeaderText = "STT";
            scheduleGridView.Columns[1].HeaderText = "Tên lịch thi";
            scheduleGridView.Columns[2].HeaderText = "Phòng thi";
            scheduleGridView.Columns[3].HeaderText = "Thời gian bắt đầu";
            scheduleGridView.Columns[4].HeaderText = "Thời gian kết thúc";
            scheduleGridView.Columns[5].HeaderText = "Môn thi";
            scheduleGridView.Columns[6].HeaderText = "Mô tả";
            scheduleGridView.Columns[7].HeaderText = "Trạng thái";
            scheduleGridView.Columns[8].HeaderText = "Người tạo";
            scheduleGridView.Columns[9].HeaderText = "Số lượng thí sinh";
            scheduleGridView.Columns[10].HeaderText = "Mã Bài thi";
            scheduleGridView.Columns[11].HeaderText = "Id";
            scheduleGridView.Columns[11].IsVisible = false;
            scheduleGridView.Columns[7].IsVisible = false;
            scheduleGridView.Columns[8].IsVisible = false;



            var list = scheduleServices.GetAllSchedule();
            int stt = 1;
            foreach (var item in list)
            {
                scheduleGridView.Rows.Add(stt++, item.Name, item.ExamRoomId, item.StartTime, item.EndTime, item.Subject, item.Description, item.Status, item.CreatedBy, scheduleDetailServices.GetAllScheduleDetails().Where(x => x.ExamScheduleId == item.Id).Count(), item.ExamId, item.Id);

            }

            lblTotal.Text = list.Count.ToString();



        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
           if(_idSchedule != null)
            {
                AddScheduleTo addToClass = new AddScheduleTo(int.Parse(_idSchedule));
                addToClass.ShowDialog();
           
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch thi");
            }
        }

        private void scheduleGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                _idSchedule = scheduleGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            catch (Exception)
            {

                _idSchedule = null;
            }
        }
    }
}
