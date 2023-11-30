using Telerik.WinControls;
using Telerik.WinControls.UI;
using Examination_BUS.ViewModel;
using Examination_PRL.Forms.Participant;
using Examination_DAL.Models;
using Examination_BUS.Services;

namespace Examination_PRL.Utilities
{


    class ExamCustomVisualItem : IconListViewVisualItem
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(IconListViewVisualItem);
            }
        }

        private LightVisualElement examRoomId = new LightVisualElement();
        private LightVisualElement examStatus = new LightVisualElement();
        private LightVisualElement examName = new LightVisualElement();
        private LightVisualElement examDuration = new LightVisualElement();
        private LightVisualElement houseKeepingInfo = new LightVisualElement();
        private LightVisualElement examReTest = new LightVisualElement();
        private StackLayoutElement verticalContainer = new StackLayoutElement();
        private StackLayoutElement roomHeaderContainer = new StackLayoutElement();
        private StackLayoutElement roomFooterContainer = new StackLayoutElement();
        private ScheduleWithExamInforViewModel dataItem;
        Account userAccount;

        bool isClicked = false;


        public ExamCustomVisualItem(ScheduleWithExamInforViewModel s,Account account )
        {
            this.dataItem = s;
            this.userAccount = account;
        }



        protected override void CreateChildElements()
        {

            this.Click += ExamCustomVisualItem_Click;

            base.CreateChildElements();

            verticalContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            verticalContainer.NotifyParentOnMouseInput = true;
            verticalContainer.ShouldHandleMouseInput = false;
            verticalContainer.StretchHorizontally = true;
            verticalContainer.StretchVertically = true;

            roomHeaderContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            roomHeaderContainer.NotifyParentOnMouseInput = true;
            roomHeaderContainer.ShouldHandleMouseInput = false;
            roomHeaderContainer.Children.Add(examRoomId);
            roomHeaderContainer.Children.Add(examStatus);
            roomHeaderContainer.StretchHorizontally = true;

            examRoomId.NotifyParentOnMouseInput = true;
            examRoomId.ShouldHandleMouseInput = false;
            examRoomId.StretchHorizontally = true;
            //roomId.CustomFont = Utils.MainFont;
            examRoomId.CustomFontSize = 9;
            examRoomId.CustomFontStyle = FontStyle.Bold;
            examRoomId.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
            examRoomId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;

            examStatus.NotifyParentOnMouseInput = true;
            examStatus.ShouldHandleMouseInput = false;
            examStatus.StretchHorizontally = false;
            //roomStatus.CustomFont = Utils.MainFont;
            examStatus.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            examStatus.CustomFontSize = 9;
            examStatus.CustomFontStyle = FontStyle.Regular;
            examStatus.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);

            roomFooterContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            roomFooterContainer.NotifyParentOnMouseInput = true;
            roomFooterContainer.ShouldHandleMouseInput = false;
            roomFooterContainer.StretchHorizontally = true;
            roomFooterContainer.DrawFill = true;
            roomFooterContainer.BackColor = Color.White;
            roomFooterContainer.GradientStyle = GradientStyles.Solid;
            roomFooterContainer.MinSize = new System.Drawing.Size(0, 30);

            examName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            examName.StretchHorizontally = false;
            examName.Layout.LeftPart.Padding = new System.Windows.Forms.Padding(24, 0, 8, 0);

            examName.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            examName.NotifyParentOnMouseInput = true;
            examName.ShouldHandleMouseInput = false;
            //bookingInfo.CustomFont = Utils.MainFont;
            examName.CustomFontSize = 12;
            examName.CustomFontStyle = FontStyle.Regular;

            examReTest.Text = "repair";
            examDuration.NotifyParentOnMouseInput = true;
            examDuration.ShouldHandleMouseInput = false;

            examDuration.StretchVertically = true;
            houseKeepingInfo.StretchVertically = true;
            examReTest.StretchVertically = true;
            roomFooterContainer.Children.Add(examDuration);
            roomFooterContainer.Children.Add(houseKeepingInfo);
            roomFooterContainer.Children.Add(examReTest);

            examReTest.NotifyParentOnMouseInput = true;
            examReTest.ShouldHandleMouseInput = false;
            examReTest.StretchHorizontally = false;
            examReTest.Alignment = ContentAlignment.MiddleRight;
            examReTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //needsRepair.CustomFont = Utils.MainFont;
            examReTest.CustomFontSize = 9;
            examReTest.CustomFontStyle = FontStyle.Regular;

            houseKeepingInfo.NotifyParentOnMouseInput = true;
            houseKeepingInfo.ShouldHandleMouseInput = false;
            houseKeepingInfo.StretchHorizontally = false;
            houseKeepingInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //houseKeepingInfo.CustomFont = Utils.MainFont;
            houseKeepingInfo.CustomFontSize = 9;
            houseKeepingInfo.CustomFontStyle = FontStyle.Regular;

            examDuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            //bookingDuration.CustomFont = Utils.MainFont;
            examDuration.CustomFontSize = 9;
            examDuration.CustomFontStyle = FontStyle.Regular;
            examDuration.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            examDuration.StretchHorizontally = false;

            roomHeaderContainer.BackColor = Color.White;

            verticalContainer.Children.Add(roomHeaderContainer);
            verticalContainer.Children.Add(examName);
            verticalContainer.Children.Add(roomFooterContainer);



            this.Children.Add(this.verticalContainer);
        }

        private void ExamCustomVisualItem_Click(object? sender, EventArgs e)
        {
            ExamDetailServices examDetailServices = new ExamDetailServices();
            var examDetail = examDetailServices.GetByExamDetailCode(dataItem.ExamDetailCode);
            ExamResponseServices examResponseServices = new ExamResponseServices();
            
            if(examResponseServices.GetAllExamResponse().Where(x=>x.ExamDetailId == examDetail.Id).ToList().Count>examDetail.ReTestNumber)
            {
                MessageBox.Show("Bạn đã hết số lần thi lại cho bài thi này!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }    

            EnterExam enterExam = new EnterExam(this.Name,userAccount);
            enterExam.ShowDialog();
        }

        protected override void SynchronizeProperties()
        {


            base.SynchronizeProperties();
            this.DrawText = false;
            //this.BackColor = Color.White;
            this.DrawFill = true;
            this.DrawBorder = false;
            examRoomId.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            examName.ImageLayout = System.Windows.Forms.ImageLayout.None;
            examName.Margin = new System.Windows.Forms.Padding(24, 0, 0, 0);

            examName.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            examName.StretchHorizontally = true;
            examName.ImageAlignment = ContentAlignment.MiddleLeft;
            examName.TextAlignment = ContentAlignment.MiddleLeft;

            examDuration.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);
            examDuration.ForeColor = Color.FromArgb(200, 0, 0, 0);
            houseKeepingInfo.ForeColor = Color.FromArgb(200, 0, 0, 0);
            houseKeepingInfo.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);
            examReTest.ForeColor = Color.FromArgb(200, 0, 0, 0);
            examReTest.Layout.LeftPart.Margin = new System.Windows.Forms.Padding(0, -3, 0, 0);

            //generate random data

            examRoomId.Text = dataItem.ExamRoomId.ToString();
            examRoomId.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            examRoomId.ForeColor = Color.White;


            if(DateTime.Now>dataItem.ExamStartTime && DateTime.Now < dataItem.ExamEndTime)
            {
                examStatus.Text = "Đang diễn ra";
            }    
            else if(DateTime.Now<dataItem.ExamStartTime)
            {
                examStatus.Text = "Sắp diễn ra";
            }    
            else
            {
                examStatus.Text = "Đã kết thúc";
            }

        
            examStatus.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            examStatus.ForeColor = Color.White;

            examName.Text = dataItem.ExamName;
            
            examName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            examName.ForeColor = Color.White;

            examDuration.Image = Properties.Resources.GlyphCalendar_small;
            examDuration.Text = dataItem.ExamStartTime.ToString("HH:mm") + " - " + dataItem.ExamEndTime.ToString("HH:mm") +"  "+ dataItem.ExamStartTime.ToString("dd/MM/yyyy");
            houseKeepingInfo.Text = "";
            examReTest.Text ="Lượt thi: "+dataItem.ExamRepeat.ToString();


            houseKeepingInfo.Visibility = Telerik.WinControls.ElementVisibility.Hidden;



            this.Name = dataItem.ExamDetailCode.ToString();
            //this.BackColor = Color.FromArgb(247, 247, 247);
            this.BackColor = Color.Teal;




            //roomStatus.ForeColor = Color.Black;
            //bookingInfo.ForeColor = Color.Black;
            //bookingInfo.BackColor = Color.Teal;



           

            examReTest.Visibility = Telerik.WinControls.ElementVisibility.Visible;


            //this.Click += ExamCustomVisualItem_Click;





        }

      
    }


}
