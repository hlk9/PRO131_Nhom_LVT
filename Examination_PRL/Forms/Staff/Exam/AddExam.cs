using Examination_BUS.Services;
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
using Telerik.WinForms.Documents.Model;

namespace Examination_PRL.Forms.Staff.Exam
{
    public partial class AddExam : Telerik.WinControls.UI.RadForm
    {

        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        ExamServices examServices = new ExamServices();
        QuestionServices questionServices = new QuestionServices();
        AnswerServices answerServices = new AnswerServices();

        QuestionLevelService questionLevelService = new QuestionLevelService();
        int currentGenerateQuestion = 1;

        int pageViewWidth = -1;
        int pageViewHeight = -1;

        List<int> CurrentQuestionList = new List<int>();

        public AddExam()
        {
            InitializeComponent();
            LoadForm();

        }

        private void btnSelectExam_Click(object sender, EventArgs e)
        {
            SelectOrAddNewExam selectOrAddNewExam = new SelectOrAddNewExam();
            selectOrAddNewExam.ShowDialog();
        }
        void LoadForm()
        {
            foreach (var item in questionTypeServices.GetAll())
            {
                dropDownQuestionType.Items.Add(item.Name);

            }

            foreach (var item in questionLevelService.GetAll())
            {
                dropDownQuestionLevel.Items.Add(item.Name);
            }
        }
        int questID = 1;
        private void radButton4_Click(object sender, EventArgs e)
        {
            AddQuestionToPage(questID);
            questID++;
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

            panelTopMost.Padding = new Padding(10);

            panelTopMost.BackColor = Color.Yellow;
            pageQuestion.Controls.Add(panelTopMost);
            int pageWith = panelTopMost.Width;
            int pageHeight = panelTopMost.Height;

            RadPanel panelQuestion = new RadPanel();
            panelQuestion.Dock = DockStyle.Top;
            panelQuestion.Height = pageHeight / 2;
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
            panelAnswer.BackColor = Color.Violet;
            panelTopMost.Controls.Add(panelAnswer);
            panelQuestion.Text = question.Content;
            panelAnswer.ThemeName = "MaterialTeal";
            panelAnswer.Padding = new Padding(10);

            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelAnswer.Controls.Add(flowPanel);
            flowPanel.Width = panelAnswer.Width;
            flowPanel.Height = panelAnswer.Height;

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
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SelectOrAddNewExam selectOrAddNewExam = new SelectOrAddNewExam();
            selectOrAddNewExam.ShowDialog();
            MessageBox.Show("Select: " + selectOrAddNewExam.curentExamCode);

        }

        private void pageViewQuestion_SizeChanged(object sender, EventArgs e)
        {
            var ojb = sender as RadPageView;
            pageViewHeight = ojb.Height;
            pageViewWidth = ojb.Width;


        }
        void ResizePageView(int width, int height)
        {

            pageViewQuestion.Height = height - 100;
            pageViewQuestion.Width = width - 100;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            byte questionType = Convert.ToByte(dropDownQuestionType.SelectedIndex + 1);
            byte questionLevel = Convert.ToByte(dropDownQuestionLevel.SelectedIndex + 1);
            int qNumber = Convert.ToInt32(txtCount.Text);



            List<QuestionWithAnswerViewModel> ListQuestionWithTypeAndLevel = questionServices.GetListQuestionWithTypeAndLevel(questionType, questionLevel);

            int offset = 1;

            for (int i = 0; i < qNumber; i++)
            {
                Random random = new Random();
                int count = random.Next(0, ListQuestionWithTypeAndLevel.Count);

                if (ListQuestionWithTypeAndLevel.Count == 0 || ListQuestionWithTypeAndLevel == null)
                {
                    MessageBox.Show("Không đủ câu hỏi để tạo đề thi");
                    return;
                }

                if (CurrentQuestionList.Contains(ListQuestionWithTypeAndLevel[count].Id))
                {
                    i--;
                    offset++;
                    if (offset >= ListQuestionWithTypeAndLevel.Count)
                        return;
                    continue;
                }

                CurrentQuestionList.Add(ListQuestionWithTypeAndLevel[count].Id);
                //if (CurrentQuestionList.Contains(ListQuestionWithTypeAndLevel[i].Id))
                //{
                //    i--;
                //    continue;
                //}

                AddQuestionToPage(ListQuestionWithTypeAndLevel[count].Id);



            }




        }
    }
}
