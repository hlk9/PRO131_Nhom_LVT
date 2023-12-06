using Examination_BUS.Services;
using Examination_BUS.ViewModel;
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

namespace Examination_PRL.Forms.Participant
{
    public partial class ReViewExam : Telerik.WinControls.UI.RadForm
    {


        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        ExamServices examServices = new ExamServices();
        QuestionServices questionServices = new QuestionServices();
        AnswerServices answerServices = new AnswerServices();
        QuestionLevelService questionLevelService = new QuestionLevelService();
        ExamDetailServices examDetailServices = new ExamDetailServices();
        ExamQuestionServices examQuestionServices = new ExamQuestionServices();
        ExamResponseServices examResponseServices = new ExamResponseServices();
        AnswerResponseServices answerResponseServices = new AnswerResponseServices();
        public string examCode;

        int currentGenerateQuestion = 1;
        int pageViewWidth = -1;
        int pageViewHeight = -1;
        List<int> QuestionList = new List<int>();
        int CurrentQuestionCount = 0;
        int QuestionLimit = -1;

        List<AnswerResponse> listAnswered = new List<AnswerResponse>();

        public ReViewExam(int examResponseID)
        {
            InitializeComponent();
            var response = examResponseServices.GetExamResponseById(examResponseID);
            this.examCode = examDetailServices.GetById(response.ExamDetailId).ExamDetailCode;
            GetListAnsweredQuestion(examResponseID);
            FillAllQuestion(this.examCode);

            lblTotalScore.Text = response.Score.ToString() + "/" + examDetailServices.GetByExamDetailCode(this.examCode).MaxiumMark;

        }


        void GetListAnsweredQuestion(int responseID)
        {

            var listAnswerResponse = answerResponseServices.GetAllAnswerResponses().Where(x => x.ExamResponseId == responseID).ToList();
            this.listAnswered = listAnswerResponse;

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
                    radRadioButton.ReadOnly = true;
                    radRadioButton.ThemeName = "MaterialTeal";
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    flowPanel.Controls.Add(radRadioButton);
                    if (item.IsCorrect == true)
                    {
                        radRadioButton.ForeColor = Color.Green;
                        radRadioButton.Font = new Font(radRadioButton.Font, FontStyle.Bold);
                    }

                    if (listAnswered.Where(x => x.AnswerId == item.Id).ToList().Count > 0)
                    {
                        radRadioButton.IsChecked = true;
                        if (item.IsCorrect == true)
                        {
                            radRadioButton.ForeColor = Color.Green;
                            radRadioButton.Font = new Font(radRadioButton.Font, FontStyle.Bold);
                        }
                        else
                        {
                            radRadioButton.ForeColor = Color.Red;
                        }
                    }

                }
                else if (question.QuestionType == 2)
                {
                    //panelTypeAnswer.Text = "Chọn các đáp án đúng";
                    RadCheckBox radCheckBox = new RadCheckBox();
                    radCheckBox.ReadOnly = true;
                    radCheckBox.Name = item.Id.ToString();
                    radCheckBox.Text = item.Content;
                    radCheckBox.ThemeName = "MaterialTeal";
                    flowPanel.Controls.Add(radCheckBox);
                    if (item.IsCorrect == true)
                    {
                        radCheckBox.ForeColor = Color.Green;
                        radCheckBox.Font = new Font(radCheckBox.Font, FontStyle.Bold);
                    }
                    if (listAnswered.Where(x => x.AnswerId == item.Id).ToList().Count > 0)
                    {
                        radCheckBox.IsChecked = true;
                        if (item.IsCorrect == true)
                        {
                            radCheckBox.ForeColor = Color.Green;
                            radCheckBox.Font = new Font(radCheckBox.Font, FontStyle.Bold);
                        }
                        else
                        {
                            radCheckBox.ForeColor = Color.Red;
                        }
                    }
                }
                else if (question.QuestionType == 3)
                {
                    //panelTypeAnswer.Text = "Chọn Đúng/Sai ";
                    RadRadioButton radRadioButton = new RadRadioButton();
                    radRadioButton.ReadOnly = true;
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    radRadioButton.ThemeName = "MaterialTeal";
                    flowPanel.Controls.Add(radRadioButton);
                    if (item.IsCorrect == true)
                    {
                        radRadioButton.ForeColor = Color.Green;
                    }
                    if (listAnswered.Where(x => x.AnswerId == item.Id).ToList().Count > 0)
                    {
                        radRadioButton.IsChecked = true;
                        if (item.IsCorrect == true)
                        {
                            radRadioButton.ForeColor = Color.Green;
                            radRadioButton.Font = new Font(radRadioButton.Font, FontStyle.Bold);
                        }
                        else
                        {
                            radRadioButton.ForeColor = Color.Red;
                        }
                    }

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

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
