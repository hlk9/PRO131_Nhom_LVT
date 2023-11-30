﻿using Examination_BUS.Services;
using Examination_BUS.Utilities;
using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_PRL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Participant
{
    public partial class Dashboard_P : Telerik.WinControls.UI.RadForm
    {
        FeedbackServices _ser = new FeedbackServices();
        ScheduleServices scheduleServices = new ScheduleServices();
        public string userName = "";
        ScheduleDetailServices scheduleDetailServices = new ScheduleDetailServices();
        List<ScheduleWithExamInforViewModel> listData;
        ExamServices _serviceExam = new ExamServices();
        int _idExamClick;
        Account userAccount;

        public Dashboard_P(string urs, Account userAccount)
        {
            InitializeComponent();
            this.userAccount = userAccount;
            _ser = new FeedbackServices();
            this.userName = urs;
            LoadData();
            LoadExamSchedule();
            radlblSum.Text = _serviceExam.GetExamResponses().Where(x => x.ParticipantId == userAccount.Id).Count().ToString();  
            var obj = _serviceExam.GetExamResponses().Where(x => x.ParticipantId == userAccount.Id && x.IsPassed == true).ToList().Count.ToString();
            radlblDat.Text = obj;
            radlblChuaDat.Text = _serviceExam.GetExamResponses().Where(x => x.ParticipantId == userAccount.Id && x.IsPassed == false).ToList().Count.ToString();
            LoadDataExam();
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
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Subject";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.UniqueId = "Id";
            appointmentMappingInfo.Exceptions = "Exceptions";
            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            dataSource.EventProvider.DataSource = appointments;
            this.radViewScheduler.DataSource = dataSource;
            radViewScheduler.ThemeName = "MaterialTeal";
        }



        public void LoadExamSchedule()
        {
            listData = scheduleDetailServices.GetScheduleAndExamByParticipantID(userName);
            listViewExam.VisualItemCreating += ListViewExam_VisualItemCreating;
            listViewExam.VisualItemCreating += ListViewExam_VisualItemFormatting;
            this.listViewExam.ShowGroups = true;
            this.listViewExam.EnableGrouping = true;
            GroupDescriptor groupByValue = new GroupDescriptor(new SortDescriptor[]
            {
                new SortDescriptor("Type", ListSortDirection.Ascending)
            });
            this.listViewExam.GroupDescriptors.Add(groupByValue);
            this.listViewExam.ViewType = ListViewType.IconsView;
            this.listViewExam.ItemSize = new Size(300, 150);
            this.listViewExam.ItemSpacing = 10;
            this.listViewExam.AllowEdit = false;
            this.listViewExam.EnableFiltering = true;
            this.listViewExam.HotTracking = false;
            this.listViewExam.RootElement.BackColor = Color.Transparent;
            this.listViewExam.BackColor = Color.Transparent;
            this.listViewExam.ListViewElement.DrawFill = false;
            this.listViewExam.ListViewElement.ViewElement.BackColor = Color.Transparent;
            this.listViewExam.ListViewElement.Padding = new Padding(-9, 0, 0, 0);
            this.listViewExam.Margin = new Padding(20);
            this.listViewExam.RootElement.EnableElementShadow = false;
            this.listViewExam.GroupItemSize = new Size(0, 45);
            listViewExam.ItemSpacing = 40;
            foreach (var item in listData)
            {
                listViewExam.Items.Add(item);
            }
            try
            {
                listViewExam.Items[listViewExam.Items.Count - 1].Visible = false;
            }
            catch
            {

            }
        }

        private void ListViewExam_VisualItemFormatting(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            IconListViewGroupVisualItem groupItem = e.VisualItem as IconListViewGroupVisualItem;
            if (groupItem != null)
            {
                if (groupItem.HasVisibleItems())
                {
                    groupItem.Visibility = ElementVisibility.Visible;
                }
                else
                {
                    groupItem.Visibility = ElementVisibility.Collapsed;
                }
                e.VisualItem.CustomFontSize = 15;
                e.VisualItem.CustomFontStyle = FontStyle.Regular;
                groupItem.ToggleElement.Visibility = ElementVisibility.Collapsed;
                e.VisualItem.ShowHorizontalLine = false;
                e.VisualItem.Padding = new Padding(20, 0, 0, 0);
                e.VisualItem.TextAlignment = ContentAlignment.BottomLeft;
                e.VisualItem.EnableElementShadow = false;
            }
            else
            {
                e.VisualItem.EnableElementShadow = true;
                e.VisualItem.ShadowDepth = 1;
                e.VisualItem.Padding = new Padding(0);
                e.VisualItem.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void ListViewExam_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            //e.VisualItem = new ExamCustomVisualItem(null);

            if (this.listViewExam.ViewType == ListViewType.IconsView)
            {
                if (listData.Count > 0)
                {
                    foreach (var item in listData)
                    {
                        e.VisualItem = new ExamCustomVisualItem(item, userAccount);
                        listData.Remove(item);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        // radgridView Kết Quả
        public void LoadDataExam()
        {
            int stt = 1;
            radViewExam_Answers.ColumnCount = 6;
            radViewExam_Answers.Columns[0].HeaderText = "STT";
            radViewExam_Answers.Columns[1].HeaderText = "ID";
            radViewExam_Answers.Columns[1].IsVisible = false;
            radViewExam_Answers.Columns[2].HeaderText = "Mã Môn";
            radViewExam_Answers.Columns[3].HeaderText = "Tên Môn";
            radViewExam_Answers.Columns[4].HeaderText = "Điểm";
            radViewExam_Answers.Columns[5].HeaderText = "Ghi Chú";

            radViewExam_Answers.Rows.Clear();

            foreach (var item in _serviceExam.GetAnswer_ResponsesViewModels(userAccount.Id))
            {
                radViewExam_Answers.Rows.Add(stt++, item.Id, item.SubjectId , item.NameExam, item.Score, item.Note);
            }
        }

        private void radViewExam_Answers_CellClick(object sender, GridViewCellEventArgs e)
        {
            _idExamClick = Convert.ToInt32(radViewExam_Answers.Rows[e.RowIndex].Cells[1].Value);
            var obj = _serviceExam.GetAnswer_ResponsesViewModels(userAccount.Id).Where(x => x.Id == _idExamClick).FirstOrDefault();
            if (obj != null)
            {
                radLblIDDe.Text = obj.IdExam.ToString();
                radLblIdThiSinh.Text = obj.ParticipantId.ToString();
                radLblIdMon.Text = obj.Id.ToString();
                radLblName.Text = obj.NameExam.ToString();
                radLblTime.Text = obj.SubmitTime.ToString();
                radLablDiem.Text = obj.Score.ToString();
                radLblPass.Text = obj.IsPassed == true ? "Đạt" : "Chưa Đạt";
                radLblDung.Text = obj.QuestionCorrect.ToString();
                radLblSai.Text = obj.QuestionWrong.ToString();
                radLblChuaLam.Text = obj.QuestionNotAnswered.ToString();
                radLblTimeLamBai.Text = FormatTime(Convert.ToInt32(obj.FinishTime));
                radLblNote.Text = obj.Note;

            }
        }

        private string FormatTime(int seconds)
        {
            // Format the remaining time as mm:ss
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }

        private void btn_Send_Click_1(object sender, EventArgs e)
        {
            Feedback fb = new Feedback()
            {

                Title = tbt_Title.Text,
                Name = tbt_Name.Text,
                IdParticipant = tbt_IDParticipant.Text,
                Content = tbt_Content.Text,
                Status = true,
                SubmitTime = DateTime.Now,
            };
            bool add = (_ser.Send(fb));
            if (add) MessageBox.Show("Gửi thành công!");
            else MessageBox.Show("Gửi thất bại!");
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            tbt_Content.Text = "";
            tbt_IDParticipant.Text = "";
            tbt_Name.Text = "";
            tbt_Title.Text = "";
        }
    }
}
