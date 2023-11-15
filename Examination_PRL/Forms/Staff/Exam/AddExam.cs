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
        int currentGenerateQuestion = 1;

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

            RadPageViewPage page = new RadPageViewPage();

            page.Text = "Câu hỏi " + currentGenerateQuestion.ToString();
            page.BackColor = Color.Azure;
            RadPanel panel = new RadPanel();
            panel.Dock = DockStyle.Fill;


            RadPanel panelQuestion = new RadPanel();
            panelQuestion.Dock = DockStyle.Top;
            panelQuestion.Height = 100;
            panelQuestion.Width = 300;
            panelQuestion.BackColor = Color.AliceBlue;
            panelQuestion.Padding = new Padding(10, 10, 10, 10);
            panelQuestion.Margin = new Padding(10, 10, 10, 10);
            panelQuestion.AutoScroll = true;
            panelQuestion.Text = "Câu hỏi: " + question.Content;
            panelQuestion.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            panelQuestion.ForeColor = Color.Black;



            //RadPanel panelAnswer = new RadPanel();
            //panelAnswer.Dock = DockStyle.Bottom;
            //panelAnswer.Height = 100;
            //panelAnswer.Width = 300;
            //panelAnswer.BackColor = Color.Azure;
            //panelAnswer.Padding = new Padding(10, 10, 10, 10);
            //panelAnswer.Margin = new Padding(10, 10, 10, 10);
            //panelAnswer.AutoScroll = true;

            FlowLayoutPanel panelAnswer = new FlowLayoutPanel();
            int marginWidth = (this.Width - panelAnswer.Width) / 2;
            panelAnswer.Dock = DockStyle.Bottom;
            panelAnswer.Height = 100;
            panelAnswer.Width = 300;
            panelAnswer.Margin = new Padding(marginWidth, 0, marginWidth, 0);
            // panelAnswer.FlowDirection = FlowDirection.TopDown;

            int totalAnswer = question.Answers.Count;
            int index = 1;

            foreach (var item in question.Answers)
            {
                if (question.QuestionType == 1)
                {
                    RadRadioButton radRadioButton = new RadRadioButton();
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    panelAnswer.Controls.Add(radRadioButton);
                }
                else if (question.QuestionType == 2)
                {
                    RadCheckBox radCheckBox = new RadCheckBox();
                    radCheckBox.Name = item.Id.ToString();
                    radCheckBox.Text = item.Content;
                    panelAnswer.Controls.Add(radCheckBox);
                }
                else if (question.QuestionType == 3)
                {
                    RadRadioButton radRadioButton = new RadRadioButton();
                    radRadioButton.Name = item.Id.ToString();
                    radRadioButton.Text = item.Content;
                    panelAnswer.Controls.Add(radRadioButton);
                }
            }

            panel.Controls.Add(panelQuestion);
            panel.Controls.Add(panelAnswer);
            page.Controls.Add(panel);

            pageViewQuestion.Pages.Add(page);
            currentGenerateQuestion++;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SelectOrAddNewExam selectOrAddNewExam = new SelectOrAddNewExam();
            selectOrAddNewExam.ShowDialog();

        }
    }
}
