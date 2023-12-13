using Examination_BUS.Services;
using Examination_DAL.Models;
using Examination_PRL.Forms.Staff.Exam;
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
    public partial class EditSchedule : Telerik.WinControls.UI.RadForm
    {
        ExamServices examServices = new ExamServices();
        SubjectServices SubjectServices = new SubjectServices();
        ExamRoomServices examRoomServices = new ExamRoomServices();
        ScheduleServices scheduleServices = new ScheduleServices();
        int scheduleId;

        public event EventHandler DataAdded;

        public EditSchedule(int scheduleId)
        {
            this.scheduleId = scheduleId;
            InitializeComponent();
            LoadData();
        }

        private void btnSelectExam_Click(object sender, EventArgs e)
        {
            SelectOrAddNewExam selectOrAddNewExam = new SelectOrAddNewExam();
            selectOrAddNewExam.ShowDialog();
            MessageBox.Show("Select: " + selectOrAddNewExam.curentExamID);
            txtExamID.Text = selectOrAddNewExam.curentExamID.ToString();
            txtSubject.Text = SubjectServices.GetOneWithID(examServices.GetById(selectOrAddNewExam.curentExamID).SubjectId).Name;
        }
        public void LoadData()
        {
            dropDownExamRoom.Items.Clear();

            foreach (var item in examRoomServices.getAllRooms())
            {
                dropDownExamRoom.Items.Add(item.Id);
            }

            var schedule = scheduleServices.GetScheduleById(scheduleId);
            txtExamID.Text = schedule.ExamId.ToString();
            dropDownExamRoom.SelectedValue = schedule.ExamRoomId;
            txtName.Text = schedule.Name;
            txtDes.Text = schedule.Description;
            txtSubject.Text = schedule.Subject;
            dateStart.Value = schedule.StartTime;
            dateEnd.Value = schedule.EndTime;
            dropDownExamRoom.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;

        }
        protected virtual void OnDataAdded(EventArgs e)
        {
            // Gọi sự kiện DataAdded để thông báo rằng dữ liệu đã được thêm
            DataAdded?.Invoke(this, e);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Tên lịch thi không được để trống");
                return;
            }


            if (txtSubject.Text == "")
            {
                MessageBox.Show("Tên môn học không được để trống");
                return;
            }


            if (txtSubject.Text == "")
            {
                MessageBox.Show("Tên môn học không được để trống");
                return;
            }
            if (txtExamID.Text == "")
            {
                MessageBox.Show("Hãy chọn bài thi");
                return;
            }




            if (dateStart.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày hiện tại");
                dateStart.Value = DateTime.Now;
                return;
            }

            if (dateStart.Value > dateEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                dateStart.Value = DateTime.Now;
                return;
            }


            if (dateEnd.Value < dateStart.Value)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                return;
            }


            if (txtExamID.Text == null)
            {
                MessageBox.Show("Hãy chọn bài thi");
                return;
            }




            ExamSchedule examSchedule = new ExamSchedule();
            examSchedule.Id = scheduleId;
            examSchedule.StartTime = Convert.ToDateTime(dateStart.Value);
            examSchedule.EndTime = Convert.ToDateTime(dateEnd.Value);
            examSchedule.Name = txtName.Text;
            examSchedule.Description = txtDes.Text;
            examSchedule.ExamRoomId = dropDownExamRoom.SelectedItem.Text;
            examSchedule.Status = true;
            examSchedule.ExamId = Convert.ToInt32(txtExamID.Text);
            examSchedule.Subject = txtSubject.Text;


            if (ScheduleExist(examSchedule) == false)
            {
                if (scheduleServices.UpdateSchedule(examSchedule) == true)
                {
                    MessageBox.Show("Sửa thành công");

                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            else
            {
                MessageBox.Show("Phòng thi đã có lịch thi\nThời gian không hợp lệ");
            }


            OnDataAdded(EventArgs.Empty);
        }
        bool ScheduleExist(ExamSchedule examSchedule)
        {
            var list = scheduleServices.GetAllSchedule().Where(x => x.EndTime >= DateTime.Now).ToList();
            foreach (var item in list)
            {
                if (item.ExamRoomId == examSchedule.ExamRoomId)
                {
                    if (item.StartTime <= examSchedule.StartTime && item.EndTime >= examSchedule.StartTime)
                    {
                        return true;
                    }
                    if (item.StartTime <= examSchedule.EndTime && item.EndTime >= examSchedule.EndTime)
                    {
                        return true;
                    }
                    if (item.StartTime >= examSchedule.StartTime && item.EndTime <= examSchedule.EndTime)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
