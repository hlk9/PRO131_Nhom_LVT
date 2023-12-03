using Examination_BUS.Services;
using Examination_BUS.ViewModel;
using Examination_DAL.IRepository;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Flow.Model.Fields;

namespace Examination_PRL.Forms.Participant
{
    public partial class EnterExam : Telerik.WinControls.UI.RadForm
    {
        private System.Windows.Forms.Timer countDownTimer = new System.Windows.Forms.Timer();
        public int timeLeft = 0;
        public int timeDoExam = 0;
        public string examCode;
        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        ExamServices examServices = new ExamServices();
        QuestionServices questionServices = new QuestionServices();
        AnswerServices answerServices = new AnswerServices();
        QuestionLevelService questionLevelService = new QuestionLevelService();
        ExamDetailServices examDetailServices = new ExamDetailServices();
        ExamQuestionServices examQuestionServices = new ExamQuestionServices();
        ExamResponseServices examResponseServices = new ExamResponseServices();
        AnswerResponseServices answerResponseServices = new AnswerResponseServices();

        Account userAccount = new Account();


        int currentGenerateQuestion = 1;
        int pageViewWidth = -1;
        int pageViewHeight = -1;
        List<int> QuestionList = new List<int>();
        int CurrentQuestionCount = 0;
        int QuestionLimit = -1;
        int scheduleId = -1;
        public EnterExam(string examCode,int scheduleId, Account account)
        {
            InitializeComponent();
            this.examCode = examCode;
            this.scheduleId = scheduleId;
            if (this.examCode != null)
            {
                FillAllQuestion(this.examCode);

                var exam = examDetailServices.GetByCode(examCode);
                this.timeLeft = exam.Duration * 60;
                countDownTimer.Interval = 1000;
                countDownTimer.Tick += CountDownTimer_Tick;
                countDownTimer.Start();
                this.userAccount = account;


            }
            else
            {
                MessageBox.Show("Không có bài thi nào");
            }


        }

        private void CountDownTimer_Tick(object? sender, EventArgs e)
        {
            timeLeft--;
            timeDoExam++;
            if (timeLeft > 0)
            {
                lblTime.Text = FormatTime(timeLeft);
            }
            else
            {
                pageViewQuestion.Enabled = false;
                countDownTimer.Stop();
                lblTime.Text = "Hết giờ";
                MessageBox.Show("Hết giờ làm bài");
            }
        }
        private string FormatTime(int seconds)
        {
            // Format the remaining time as mm:ss
            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            return $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
        }

        public void FillAllQuestion(string examCode)
        {

            var listQuestion = questionServices.GetQuestionsByExamCode(examCode);
            // int stt = 1;
            foreach (var question in listQuestion.Questions)
            {
                ListViewDataItem listViewDataItem = new ListViewDataItem();
                listViewDataItem.Text = "Câu " + currentGenerateQuestion.ToString();
                listViewDataItem.Value = "Câu " + currentGenerateQuestion.ToString();
                listViewDataItem.BackColor = Color.MintCream;
                listViewQuestion.Items.Add(listViewDataItem);
                AddQuestionToPage(question.Id);

            }
            listViewQuestion.SelectedIndex = 0;

        }
        public void AddQuestionToPage(int questionID)
        {
            QuestionWithAnswerViewModel question = questionServices.GetQuestionWithAnswer(questionID);
            RadPageViewPage pageQuestion = new RadPageViewPage();
            pageQuestion.Name = "pageQuestion" + currentGenerateQuestion.ToString();
            pageQuestion.Text = "Câu hỏi " + currentGenerateQuestion.ToString();
            pageQuestion.BackColor = Color.Azure;
            RadPanel panelTopMost = new RadPanel();
            panelTopMost.Dock = DockStyle.Fill;
            panelTopMost.Height = pageViewHeight;
            panelTopMost.Width = pageViewWidth;
            panelTopMost.Name = "panelTopMost";
            panelTopMost.Padding = new Padding(10);
            panelTopMost.ThemeName = "MaterialTeal";

            panelTopMost.BackColor = Color.White; ;
            pageQuestion.Controls.Add(panelTopMost);
            int pageWith = panelTopMost.Width;
            int pageHeight = panelTopMost.Height;

            RadPanel panelQuestion = new RadPanel();
            panelQuestion.Dock = DockStyle.Top;
            panelQuestion.Height = pageViewHeight / 2;
            panelQuestion.Width = pageWith;
            panelQuestion.BackColor = Color.White;
            panelTopMost.Controls.Add(panelQuestion);
            panelQuestion.ThemeName = "MaterialTeal";
            panelQuestion.TextAlignment = ContentAlignment.TopLeft;
            panelQuestion.Padding = new Padding(10);
            panelQuestion.Name = "panelQuestion" + question.Id;

            RadPanel panelAnswer = new RadPanel();
            panelAnswer.Padding = new Padding(10);
            panelAnswer.Dock = DockStyle.Bottom;
            panelAnswer.Height = pageViewHeight / 2;
            panelAnswer.Width = pageWith;
            panelAnswer.BackColor = Color.Azure;
            panelTopMost.Controls.Add(panelAnswer);
            panelAnswer.Name = "panelAnswer";
            panelQuestion.Text = questionTypeServices.GetQuestionTypeNameById(Convert.ToByte(question.QuestionType)) + "\n" + question.Content;
            panelAnswer.ThemeName = "MaterialTeal";
            panelAnswer.Padding = new Padding(10);
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Name = "flowPanel";
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelAnswer.Controls.Add(flowPanel);
            flowPanel.Width = panelAnswer.Width;
            flowPanel.Height = panelAnswer.Height;
            flowPanel.Location = new Point(30, 80);
            flowPanel.BringToFront();
            foreach (var item in question.Answers)
            {
                if (question.QuestionType == 1)
                {
                    //panelTypeAnswer.Text = "Chọn đáp án đúng nhất ";
                    RadRadioButton radRadioButton = new RadRadioButton();
                    radRadioButton.ThemeName = "MaterialTeal";
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    flowPanel.Controls.Add(radRadioButton);
                }
                else if (question.QuestionType == 2)
                {
                    //panelTypeAnswer.Text = "Chọn các đáp án đúng";
                    RadCheckBox radCheckBox = new RadCheckBox();
                    radCheckBox.Name = item.Id.ToString();
                    radCheckBox.Text = item.Content;
                    radCheckBox.ThemeName = "MaterialTeal";
                    flowPanel.Controls.Add(radCheckBox);
                }
                else if (question.QuestionType == 3)
                {
                    //panelTypeAnswer.Text = "Chọn Đúng/Sai ";
                    RadRadioButton radRadioButton = new RadRadioButton();
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    radRadioButton.ThemeName = "MaterialTeal";
                    flowPanel.Controls.Add(radRadioButton);
                }
            }
            pageViewQuestion.Controls.Add(pageQuestion);

            currentGenerateQuestion++;
            CurrentQuestionCount++;
        }
        private void pageViewQuestion_SizeChanged(object sender, EventArgs e)
        {
            var ojb = sender as RadPageView;
            pageViewHeight = ojb.Height - 50;
            pageViewWidth = ojb.Width;
        }

        private void listViewQuestion_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            pageViewQuestion.SelectedPage = pageViewQuestion.Pages[listViewQuestion.SelectedIndex];
        }

        private void pageViewQuestion_SelectedPageChanged(object sender, EventArgs e)
        {
            Thread threadHightlight = new Thread(HighlightQuestion);
            threadHightlight.Start();
            listViewQuestion.SelectedIndex = Convert.ToInt32(pageViewQuestion.SelectedPage.Text.Replace("Câu hỏi ", "")) - 1;
        }

        void HighlightQuestion()
        {

            if (listViewQuestion.InvokeRequired)
            {
                listViewQuestion.Invoke(new Action(HighlightQuestion));
                return;
            }


            try
            {

                for (int i = 0; i < pageViewQuestion.Pages.Count; i++)
                {
                    var panelTop = pageViewQuestion.Pages[i].Controls.Find("panelTopMost", true);
                    if (panelTop.Length > 0)
                    {
                        var panelAnswer = panelTop[0].Controls.Find("panelAnswer", true);

                        if (panelAnswer.Length > 0)
                        {
                            var flowPanel = panelAnswer[0].Controls.Find("flowPanel", true);
                            if (flowPanel.Length > 0)
                            {
                                var radRadioButton = flowPanel[0].Controls.OfType<RadRadioButton>();
                                if (radRadioButton.Count() > 0)
                                {
                                    int count = 0;
                                    foreach (var item in radRadioButton)
                                    {
                                        if (item.IsChecked == true)
                                        {
                                            count++;
                                        }
                                    }

                                    if (count > 0)
                                        listViewQuestion.Items[i].BackColor = Color.Moccasin;

                                    else
                                        listViewQuestion.Items[i].BackColor = Color.MintCream;
                                }
                                else
                                {
                                    var checkBox = flowPanel[0].Controls.OfType<RadCheckBox>();
                                    if (checkBox.Count() > 0)
                                    {
                                        int count = 0;
                                        foreach (var item in checkBox)
                                        {
                                            if (item.IsChecked == true)
                                            {
                                                count++;
                                            }
                                        }

                                        if (count > 0)
                                            listViewQuestion.Items[i].BackColor = Color.Moccasin;

                                        else
                                            listViewQuestion.Items[i].BackColor = Color.MintCream;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkBoxComplete.Checked == true)
            {

                //ExamResponse examResponse = new ExamResponse();
                //examResponse.ExamDetailId = 1;
                //examResponse.ParticipantId = "longhd";
                //examResponse.SubmitTime = DateTime.Now;
                //MessageBox.Show(examResponseServices.AddExamResponseAndGetId(examResponse).ToString());
                ScoreExam(ListAnsweredQuestion());
                //MessageBox.Show("Bạn đã hoàn thành bài thi");
                //return;
            }
            else
            {
                MessageBox.Show("Bạn chưa hoàn thành bài thi");
            }
        }

        public List<QuestionAndAnswerResponse> ListAnsweredQuestion()
        {

            List<QuestionAndAnswerResponse> listQnA = new List<QuestionAndAnswerResponse>();

            try
            {
                for (int i = 0; i < pageViewQuestion.Pages.Count; i++)
                {

                    QuestionAndAnswerResponse QnA = new QuestionAndAnswerResponse();
                    List<AnswerResponse> listA = new List<AnswerResponse>();

                    var panelParent = pageViewQuestion.Pages[i].Controls.Find("panelTopMost", true);
                    if (panelParent.Length > 0)
                    {
                        var panelQuestion = panelParent[0].Controls.OfType<RadPanel>().Where(x => x.Name.Contains("panelQuestion")).FirstOrDefault();
                        QnA.QuestionId = Convert.ToInt32(panelQuestion.Name.Replace("panelQuestion", ""));
                        var panelAnswer = panelParent[0].Controls.Find("panelAnswer", true);

                        if (panelAnswer.Length > 0)
                        {
                            var flowPanel = panelAnswer[0].Controls.Find("flowPanel", true);
                            if (flowPanel.Length > 0)
                            {
                                var radRadioButton = flowPanel[0].Controls.OfType<RadRadioButton>();
                                if (radRadioButton.Count() > 0)
                                {
                                    int count = 0;
                                    foreach (var item in radRadioButton)
                                    {
                                        AnswerResponse answerResponse = new AnswerResponse();
                                        try
                                        {
                                            if (item.IsChecked == true)
                                            {
                                                count++;
                                                answerResponse.QuestionId = Convert.ToInt32(panelQuestion.Name.Replace("panelQuestion", ""));
                                                answerResponse.AnswerId = Convert.ToInt32(item.Name);
                                                answerResponse.AnswerAt = DateTime.Now;


                                                if (answerServices.GetAnswerById(Convert.ToInt32(answerResponse.AnswerId)).IsCorrect == true)
                                                {
                                                    answerResponse.IsCorrect = true;
                                                }
                                                else
                                                {
                                                    answerResponse.IsCorrect = false;
                                                }
                                                listA.Add(answerResponse);
                                            }
                                        }
                                        catch
                                        {

                                        }
                                    }

                                }
                                else
                                {
                                    var checkBox = flowPanel[0].Controls.OfType<RadCheckBox>();
                                    if (checkBox.Count() > 0)
                                    {
                                        foreach (var item in checkBox)
                                        {
                                            AnswerResponse answerResponse = new AnswerResponse();
                                            try
                                            {
                                                if (item.IsChecked == true)
                                                {
                                                    answerResponse.QuestionId = Convert.ToInt32(panelQuestion.Name.Replace("panelQuestion", ""));
                                                    answerResponse.AnswerId = Convert.ToInt32(item.Name);
                                                    answerResponse.AnswerAt = DateTime.Now;


                                                    if (answerServices.GetAnswerById(Convert.ToInt32(answerResponse.AnswerId)).IsCorrect == true)
                                                    {
                                                        answerResponse.IsCorrect = true;
                                                    }
                                                    else
                                                    {
                                                        answerResponse.IsCorrect = false;
                                                    }

                                                    listA.Add(answerResponse);

                                                }
                                            }
                                            catch
                                            {

                                            }
                                        }
                                    }
                                }

                                QnA.AnswerResponses = listA;
                                listQnA.Add(QnA);

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            //foreach (var item in listQnA)
            //{
            //    try
            //    {

            //        if(item.AnswerResponses.Count == 0)
            //        {
            //            MessageBox.Show("Câu " + item.QuestionId + " " + "Chưa trả lời");
            //        }    

            //        foreach (var item2 in item.AnswerResponses)
            //        {
            //            MessageBox.Show("Câu " + item.QuestionId + " " + item2.AnswerId.ToString() + " " + item2.AnswerAt.ToString() + " " + item2.IsCorrect.ToString());
            //        }
            //    }
            //    catch
            //    {

            //    }

            //}


            return listQnA;

        }

        public void ScoreExam(List<QuestionAndAnswerResponse> listQnA)
        {

            try
            {
                btnSubmit.Enabled = false;
                countDownTimer.Stop();
                ExamResponse examResponse = new ExamResponse();
                ExamDetail exam = examDetailServices.GetByExamDetailCode(this.examCode);
                int qFalse = 0;
                int qTrue = 0;
                int qNotAnswer = 0;
                double score = 0;
                double totalScore = exam.MaxiumMark;
                score = totalScore;
                bool isPass = false;
                float secondTaken = timeDoExam;
                List<ExamQuestionWithPointViewModel> listQAnP = examQuestionServices.GetQuestionInExamWithPoint(this.examCode);
                foreach (var item in listQnA)
                {

                    QuestionWithAnswerViewModel listTrueAnswer = questionServices.GetQuestionWithTRUEAnswer(item.QuestionId);

                    if (item.AnswerResponses.Count == 0)
                    {
                        score -= listQAnP.Where(x => x.QuestionId == item.QuestionId).FirstOrDefault().Point;
                        qNotAnswer++;
                    }
                    else if (item.AnswerResponses.Count == 1)
                    {
                        foreach (var item2 in item.AnswerResponses)
                        {
                            if (item2.IsCorrect == true)
                            {
                                qTrue++;
                            }
                            else
                            {
                                score -= listQAnP.Where(x => x.QuestionId == item.QuestionId).FirstOrDefault().Point;
                                qFalse++;
                            }
                        }
                    }
                    else
                    {
                        bool allTrue = listTrueAnswer.Answers.Count == item.AnswerResponses.Where(x => x.IsCorrect == true).Count();

                        if (allTrue == true)
                        {
                            qTrue++;

                        }
                        else
                        {
                            score -= listQAnP.Where(x => x.QuestionId == item.QuestionId).FirstOrDefault().Point;
                            qFalse++;
                        }

                    }

                }


                if (score < exam.PassMark)
                {
                    isPass = false;
                }
                else
                {
                    isPass = true;
                }
                examResponse.ExamDetailId = exam.Id;
                examResponse.IsPassed = isPass;
                examResponse.Score = score;
                examResponse.FinishTime = secondTaken;
                examResponse.SubmitTime = DateTime.Now;
                examResponse.ParticipantId = userAccount.Id;
                examResponse.SubjectId = examServices.GetById(exam.ExamId).SubjectId;
                examResponse.Status = 1;
                examResponse.QuestionCorrect = qTrue;
                examResponse.QuestionWrong = qFalse;
                examResponse.QuestionNotAnswered = qNotAnswer;
                examResponse.ScoredMethod = true; //true is automatic , false is manual
                examResponse.Note = null;
                examResponse.ExamScheduleId = this.scheduleId;
                int idExResponse = examResponseServices.AddExamResponseAndGetId(examResponse);
                if (idExResponse != -1)
                {
                    foreach (var item in listQnA)
                    {
                        foreach (var item2 in item.AnswerResponses)
                        {
                            if (item2 != null)
                            {
                                AnswerResponse ar = new AnswerResponse();
                                ar.IsCorrect = item2.IsCorrect;
                                ar.AnswerAt = null;
                                ar.QuestionId = item.QuestionId;
                                ar.AnswerId = item2.AnswerId;
                                ar.ExamResponseId = idExResponse;
                                answerResponseServices.AddAnswerResponse(ar);
                            }

                        }
                    }
                }
                MessageBox.Show("Nộp bài thành công");
                MessageBox.Show("TEST\nSố câu đúng: " + qTrue.ToString() + "\n" + "Số câu sai: " + qFalse.ToString() + "\n" + "Số câu chưa trả lời: " + qNotAnswer.ToString() + "\n" + "Tổng điểm: " + totalScore.ToString() + "\n" + "Điểm của bạn: " + score.ToString());
                btnExit.Enabled = true;
                btnExit.Visible = true;
                //foreach(var page in pageViewQuestion.Pages)
                //{
                //    page.Enabled = false;
                //}    
                //convert second to minute ,
                //TimeSpan timeSpan = TimeSpan.FromSeconds(timeDoExam);

                //DateTime baseDate = new DateTime(1, 1, 1);
                //DateTime resultDateTime = baseDate.Add(timeSpan);

                //MessageBox.Show(resultDateTime.Minute.ToString()+":"+resultDateTime.Second.ToString());


            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi khi nộp bài, hãy thử lại");
                btnSubmit.Enabled = true;
                countDownTimer.Start();
                btnExit.Visible = false;
            }





        }



    }

    public class QuestionAndAnswerResponse
    {
        public int QuestionId { get; set; }
        public List<AnswerResponse> AnswerResponses { get; set; }

    }
}
