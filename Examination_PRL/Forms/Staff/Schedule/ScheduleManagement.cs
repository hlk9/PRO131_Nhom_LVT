using Examination_BUS.Services;
using Examination_DAL.Models;
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
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff.Schedule
{
    public partial class ScheduleManagement : Telerik.WinControls.UI.RadForm
    {
        ScheduleServices scheduleServices;// = new ScheduleServices();
        ScheduleDetailServices scheduleDetailServices = new ScheduleDetailServices();
        string _idSchedule;
        Account usrAccount;
        public ScheduleManagement(Account account)
        {
            this.usrAccount = account;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            scheduleServices = new ScheduleServices();
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



            var list = scheduleServices.GetAllScheduleActive();
            int stt = 1;
            int notStart = 0;
            int inProgress = 0;
            int finished = 0;
            foreach (var item in list)
            {
                if (item.StartTime > DateTime.Now)
                {

                    notStart++;
                }
                else if (item.StartTime <= DateTime.Now && item.EndTime >= DateTime.Now)
                {

                    inProgress++;
                }
                else
                {

                    finished++;
                }
                scheduleGridView.Rows.Add(stt++, item.Name, item.ExamRoomId, item.StartTime, item.EndTime, item.Subject, item.Description, item.Status, item.CreatedBy, scheduleDetailServices.GetAllScheduleDetails().Where(x => x.ExamScheduleId == item.Id).ToList().DistinctBy(x => x.ParticipantId).Count(), item.ExamId, item.Id);

            }
            lblEnd.Text = finished.ToString();
            lblIncoming.Text = notStart.ToString();
            lblCurrent.Text = inProgress.ToString();
            lblTotal.Text = list.Count.ToString();



        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (_idSchedule != null)
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
                lblCurrentID.Text = _idSchedule;
            }
            catch (Exception)
            {

                _idSchedule = null;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNew createNewSchedule = new CreateNew(usrAccount);
            createNewSchedule.DataAdded += CreateNewSchedule_DataAdded;
            createNewSchedule.ShowDialog();
        }

        private void CreateNewSchedule_DataAdded(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            EditSchedule editSchedule = new EditSchedule(int.Parse(_idSchedule));
            editSchedule.DataAdded += EditSchedule_DataAdded;
            editSchedule.ShowDialog();

        }

        private void EditSchedule_DataAdded(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch thi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                scheduleServices = new ScheduleServices();
                var schedule = scheduleServices.GetScheduleById(int.Parse(_idSchedule));
                schedule.Status = false;
                scheduleServices.UpdateSchedule(schedule);
                LoadData();
            }
        }

        private void scheduleGridView_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem menuItem = new RadMenuItem("Xem chi tiết");
            menuItem.Click += MenuItem_Click;
            e.ContextMenu.Items.Add(menuItem);

        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            ParticipantInSchedule participantInSchedule = new ParticipantInSchedule(int.Parse(_idSchedule));
            participantInSchedule.DataAdded += ParticipantInSchedule_DataAdded;
            participantInSchedule.ShowDialog();


        }

        private void ParticipantInSchedule_DataAdded(object? sender, EventArgs e)
        {
            LoadData();
        }
    }
}
