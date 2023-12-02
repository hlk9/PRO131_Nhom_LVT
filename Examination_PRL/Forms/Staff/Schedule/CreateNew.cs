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
    public partial class CreateNew : Telerik.WinControls.UI.RadForm
    {
        ClassroomServices classroomServices = new ClassroomServices();
        ScheduleServices scheduleServices = new ScheduleServices();
        ExamRoomServices examRoomServices = new ExamRoomServices();
        Account usrAccount;
        public event EventHandler DataAdded;
        public CreateNew(Account account)
        {
            this.usrAccount = account;
            InitializeComponent();
            LoadData();
            dropdownClass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;

        }
        public void LoadData()
        {
            var list = examRoomServices.getAllRooms();
            foreach (var item in list)
            {
                dropdownClass.Items.Add(item.Id);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = Convert.ToDateTime(dateStart.Value);
            examSchedule.EndTime = Convert.ToDateTime(dateEnd.Value);
            examSchedule.Name = txtName.Text;
            examSchedule.Description = txtDes.Text;
            examSchedule.ExamRoomId = dropdownClass.SelectedItem.Text;
            examSchedule.Status = true;
            examSchedule.CreatedBy = usrAccount.Id;

            scheduleServices.AddSchedule(examSchedule);

            OnDataAdded(EventArgs.Empty);

        }


        protected virtual void OnDataAdded(EventArgs e)
        {
            // Gọi sự kiện DataAdded để thông báo rằng dữ liệu đã được thêm
            DataAdded?.Invoke(this, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnDataAdded(EventArgs.Empty);
        }
    }
}
