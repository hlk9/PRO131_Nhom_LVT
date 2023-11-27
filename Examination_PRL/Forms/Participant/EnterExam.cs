﻿using Examination_BUS.Services;
using Examination_BUS.ViewModel;
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
    public partial class EnterExam : Telerik.WinControls.UI.RadForm
    {
        public string examCode;
        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        ExamServices examServices = new ExamServices();
        QuestionServices questionServices = new QuestionServices();
        AnswerServices answerServices = new AnswerServices();
        QuestionLevelService questionLevelService = new QuestionLevelService();
        ExamDetailServices examDetailServices = new ExamDetailServices();

        ExamQuestionServices examQuestionServices = new ExamQuestionServices();


        int currentGenerateQuestion = 1;
        int pageViewWidth = -1;
        int pageViewHeight = -1;
        List<int> QuestionList = new List<int>();
        int CurrentQuestionCount = 0;
        int QuestionLimit = -1;

        public EnterExam(string examCode)
        {
            InitializeComponent();
            this.examCode = examCode;
            if (this.examCode != null)
            {
                FillAllQuestion(this.examCode);
            }
            else
            {
                MessageBox.Show("Không có bài thi nào");
            }


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
            pageQuestion.Text = "Câu hỏi " + currentGenerateQuestion.ToString();
            pageQuestion.BackColor = Color.Azure;
            RadPanel panelTopMost = new RadPanel();
            panelTopMost.Dock = DockStyle.Fill;
            panelTopMost.Height = pageViewHeight;
            panelTopMost.Width = pageViewWidth;
            panelTopMost.Name = "panelTopMost" + currentGenerateQuestion.ToString();
            panelTopMost.Padding = new Padding(10);

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

            RadPanel panelAnswer = new RadPanel();
            panelAnswer.Padding = new Padding(10);
            panelAnswer.Dock = DockStyle.Bottom;
            panelAnswer.Height = pageViewHeight / 2;
            panelAnswer.Width = pageWith;
            panelAnswer.BackColor = Color.Azure;
            panelTopMost.Controls.Add(panelAnswer);
            panelQuestion.Text = questionTypeServices.GetQuestionTypeNameById(Convert.ToByte(question.QuestionType)) + "\n" + question.Content;
            panelAnswer.ThemeName = "MaterialTeal";
            panelAnswer.Padding = new Padding(10);
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
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
    }
}
