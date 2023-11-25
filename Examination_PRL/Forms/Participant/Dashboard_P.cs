using Examination_BUS.Services;
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

        public string userName = "";
        ScheduleDetailServices scheduleDetailServices = new ScheduleDetailServices();

        List<ScheduleWithExamInforViewModel> listData;

        public Dashboard_P(string urs)
        {
            InitializeComponent();
            _ser = new FeedbackServices();
            this.userName = urs;
            LoadExamSchedule();
        }




        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tbt_Content.Text = "";

            tbt_IDParticipant.Text = "";
            tbt_Name.Text = "";

            tbt_Title.Text = "";
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

            Feedback fb = new Feedback()
            {

                Title = tbt_Title.Text,
                Name = tbt_Name.Text,
                IdParticipant = tbt_IDParticipant.Text,
                Content = tbt_Content.Text,
                Status = true,


            };
            bool add = (_ser.Send(fb));
            if (add) MessageBox.Show("Gửi thành công!");
            else MessageBox.Show("Gửi thất bại!");




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
            { }


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
                        e.VisualItem = new ExamCustomVisualItem(item);
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
    }
}
