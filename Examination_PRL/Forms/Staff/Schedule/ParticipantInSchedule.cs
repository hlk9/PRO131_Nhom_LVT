using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.Schedule
{
    public partial class ParticipantInSchedule : Telerik.WinControls.UI.RadForm
    {
        int scheduleID;
        string currentParticipantID = "";
        ScheduleDetailServices scheduleDetailServices = new ScheduleDetailServices();
        ParticipantService participantService = new ParticipantService();
        public event EventHandler DataAdded;
        public ParticipantInSchedule(int scheduleID)
        {
            this.scheduleID = scheduleID;

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var listParticipant = scheduleDetailServices.GetAllScheduleDetails().Where(x => x.ExamScheduleId == scheduleID).ToList();
            gridViewParticipant.ColumnCount = 5;
            int stt = 1;
            gridViewParticipant.Columns[0].HeaderText = "STT";
            gridViewParticipant.Columns[1].HeaderText = "Mã sinh viên";
            gridViewParticipant.Columns[2].HeaderText = "Họ tên";
            gridViewParticipant.Columns[3].HeaderText = "Ngày sinh";
            gridViewParticipant.Columns[4].HeaderText = "Giới tính";
            gridViewParticipant.Rows.Clear();
            foreach (var participant in listParticipant)
            {
                var parti = participantService.GetOneByID(participant.ParticipantId);
                gridViewParticipant.Rows.Add(stt++, parti.Id, parti.FullName, parti.DateOfBirth.ToString("dd/MM/yyyy"), parti.Gender == true ? "Nam" : "Nữ");

            }




        }

        private void gridViewParticipant_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                currentParticipantID = gridViewParticipant.CurrentRow.Cells[1].Value.ToString();
                lblCurrentParti.Text = currentParticipantID;
            }
            catch
            {
                lblCurrentParti.Text = "";
                currentParticipantID = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var edt = scheduleDetailServices.GetAllScheduleDetails().Where(x => x.ExamScheduleId == scheduleID && x.ParticipantId == currentParticipantID).FirstOrDefault();
            if (scheduleDetailServices.DeleteScheduleDetail(edt.Id) == true)
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
                OnDataAdded(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        protected virtual void OnDataAdded(EventArgs e)
        {
            // Gọi sự kiện DataAdded để thông báo rằng dữ liệu đã được thêm
            DataAdded?.Invoke(this, e);
        }
    }
}
