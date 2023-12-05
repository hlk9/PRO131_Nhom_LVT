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
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff.Home
{
    public partial class Home : Telerik.WinControls.UI.RadForm
    {
        Account usrAccount;

        public Home(Account account)
        {
            this.usrAccount = account;
            InitializeComponent();
            LoadData();


        }
        public void LoadData()
        {
            StaffService staffService = new StaffService();
            ExamServices ExamServices = new ExamServices();
            ClassroomServices classroomServices = new ClassroomServices();
            ParticipantService participantService = new ParticipantService();
            ScheduleServices scheduleServices = new ScheduleServices();
            FeedbackServices feedbackServices = new FeedbackServices();

            panelTotalRoom.Text = classroomServices.GetClassrooms().Count.ToString();
            panelTotalExam.Text = ExamServices.GetAll().Count().ToString();
            lnlFullName.Text = "Chào mừng - " + staffService.GetStaffById(usrAccount.Id).FullName;
            panelTotalParti.Text = participantService.getAllStudents().Count().ToString();
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
            panelBlock3.RootElement.Shape = roundRectShape;
            panelBlock3.RootElement.ApplyShapeToControl = true;
            panelScheduleCurrent.RootElement.Shape = roundRectShape;
            panelScheduleCurrent.RootElement.ApplyShapeToControl = true;
            panelScheduleIncoming.RootElement.Shape = roundRectShape;
            panelScheduleIncoming.RootElement.ApplyShapeToControl = true;
            panelTotalParti.RootElement.Shape = roundRectShape;
            panelTotalParti.RootElement.ApplyShapeToControl = true;
            panelCurrentQnA.RootElement.Shape = roundRectShape;
            panelCurrentQnA.RootElement.ApplyShapeToControl = true;
            panelTotalQnA.RootElement.Shape = roundRectShape;
            panelTotalQnA.RootElement.ApplyShapeToControl = true;
            panelGoToSchedule.RootElement.Shape = roundRectShape;
            panelGoToSchedule.RootElement.ApplyShapeToControl = true;
            panelGoToExam.RootElement.Shape = roundRectShape;
            panelGoToExam.RootElement.ApplyShapeToControl = true;
            panelGoToFeedback.RootElement.Shape = roundRectShape;
            panelGoToFeedback.RootElement.ApplyShapeToControl = true;



            panelScheduleCurrent.Text = scheduleServices.GetAllSchedule().Where(x => x.StartTime <= DateTime.Now && x.EndTime >= DateTime.Now).Count().ToString();
            panelScheduleIncoming.Text = scheduleServices.GetAllSchedule().Where(x => x.StartTime >= DateTime.Now).Count().ToString();

            panelCurrentQnA.Text = feedbackServices.GetAll().Where(x => x.SubmitTime.Date >= DateTime.Now.Date).Count().ToString();
            panelTotalQnA.Text = feedbackServices.GetAll().Count().ToString();

            panelGoToSchedule.RootElement.Shape = roundRectShape;
            panelGoToSchedule.RootElement.ApplyShapeToControl = true;



        }



        private void panelGoToSchedule_Click(object sender, EventArgs e)
        {
            RadPageView pgView = this.ParentForm.Controls.Find("pvDashboard", true)[0] as RadPageView;
            pgView.SelectedPage = pgView.Pages[1];
        }

        private void panelGoToFeedback_Click(object sender, EventArgs e)
        {
            RadPageView pgView = this.ParentForm.Controls.Find("pvDashboard", true)[0] as RadPageView;
            pgView.SelectedPage = pgView.Pages[23];
        }

        private void panelGoToExam_Click(object sender, EventArgs e)
        {
            RadPageView pgView = this.ParentForm.Controls.Find("pvDashboard", true)[0] as RadPageView;
            pgView.SelectedPage = pgView.Pages[6];
        }
    }
}
