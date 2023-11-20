﻿using Examination_BUS.Services;
using Examination_BUS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL
{
    public partial class ThoiGian : Telerik.WinControls.UI.RadForm
    {

        ScheduleServices scheduleServices = new ScheduleServices();

        public ThoiGian()
        {
            InitializeComponent();
            LoadData();
         
        }
        public void LoadData()
        {
            BindingList<CustomAppointment> appointments = new BindingList<CustomAppointment>();

            foreach (var item in scheduleServices.GetListSchedule())
            {
                CustomAppointment myAppointment =
                new CustomAppointment(
                item.StartTime,
                item.EndTime,
                item.Subject,
                item.Description,
                item.ExamRoomId);               
                appointments.Add(myAppointment);
            }

            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            // map the MyAppointment properties to the scheduler
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Subject";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.UniqueId = "Id";
            appointmentMappingInfo.Exceptions = "Exceptions";
            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            // assign the generic List of CustomAppointment as the EventProvider data source
            dataSource.EventProvider.DataSource = appointments;
            this.scheduleDetail.DataSource = dataSource;

        }
    }
}
