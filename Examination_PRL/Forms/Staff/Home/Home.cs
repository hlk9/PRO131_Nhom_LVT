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

namespace Examination_PRL.Forms.Staff.Home
{
    public partial class Home : Telerik.WinControls.UI.RadForm
    {
        Account usrAccount;
        StaffService staffService = new StaffService();
        ExamServices ExamServices = new ExamServices();
        ClassroomServices classroomServices = new ClassroomServices();
        ParticipantService participantService = new ParticipantService();
        ScheduleServices scheduleServices = new ScheduleServices();
        public Home(Account account)
        {
            this.usrAccount = account;
            InitializeComponent();
            lblTotalClassRoom.Text = classroomServices.GetClassrooms().Count.ToString();
            lblTotalExam.Text = ExamServices.GetAll().Count().ToString();
            lnlFullName.Text = "Chào mừng - " + staffService.GetStaffById(usrAccount.Id).FullName;
            lblTotalParticipant.Text = participantService.getAllStudents().Count().ToString();
            RoundRectShape roundRectShape = new RoundRectShape();
            roundRectShape.Radius = 30;
            panelBlock1.RootElement.Shape = roundRectShape;
            panelBlock1.RootElement.ApplyShapeToControl = true;
            panelTotalExam.RootElement.Shape = roundRectShape;
            panelTotalExam.RootElement.ApplyShapeToControl = true;
            panelTotalRoom.RootElement.Shape = roundRectShape;
            panelTotalRoom.RootElement.ApplyShapeToControl = true;
            panelWelcome.RootElement.Shape = roundRectShape;
            panelWelcome.RootElement.ApplyShapeToControl = true;
            panelBlock2.RootElement.Shape = roundRectShape;
            panelBlock2.RootElement.ApplyShapeToControl = true;
            panelScheduleCurrent.RootElement.Shape = roundRectShape;
            panelScheduleCurrent.RootElement.ApplyShapeToControl = true;
            panelScheduleIncoming.RootElement.Shape = roundRectShape;
            panelScheduleIncoming.RootElement.ApplyShapeToControl = true;

            lblScheduleCurrent.Text = scheduleServices.GetAllSchedule().Where(x=>x.StartTime <= DateTime.Now && x.EndTime >= DateTime.Now).Count().ToString();
            lblScheduleIncoming.Text = scheduleServices.GetAllSchedule().Where(x => x.StartTime >= DateTime.Now).Count().ToString();





        }
    }
}
