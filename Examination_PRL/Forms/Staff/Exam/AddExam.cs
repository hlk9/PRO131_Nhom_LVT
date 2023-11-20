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
        ExamDetailServices examDetailServices = new ExamDetailServices();

        ExamQuestionServices examQuestionServices = new ExamQuestionServices();

        public event EventHandler UpdateDataEvent;

        int currentGenerateQuestion = 1;
        int pageViewWidth = -1;
        int pageViewHeight = -1;
        List<int> QuestionList = new List<int>();
        int CurrentQuestionCount = 0;
        int QuestionLimit = -1;

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

            if (CurrentQuestionCount >= QuestionLimit)
            {
                MessageBox.Show("Số lượng câu hỏi đã đạt giới hạn");
                return;
            }

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
            panelQuestion.Text = questionTypeServices.GetQuestionTypeNameById(Convert.ToByte(question.QuestionType))+"\n"+question.Content;
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
            MessageBox.Show(panelAnswer.Location.X.ToString() + "\n" + panelAnswer.Location.Y.ToString());
            MessageBox.Show(flowPanel.Location.X.ToString() + "\n" + flowPanel.Location.Y.ToString());




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

        private void radButton1_Click(object sender, EventArgs e)
        {
            SelectOrAddNewExam selectOrAddNewExam = new SelectOrAddNewExam();
            selectOrAddNewExam.ShowDialog();
            MessageBox.Show("Select: " + selectOrAddNewExam.curentExamID);
            lblExam.Text = selectOrAddNewExam.curentExamID.ToString();

        }

        private void pageViewQuestion_SizeChanged(object sender, EventArgs e)
        {
            var ojb = sender as RadPageView;
            pageViewHeight = ojb.Height - 50;
            pageViewWidth = ojb.Width;


        }


        private void radButton2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtQNumber.Text == "" || txtMaxScore.Text == "" || txtDuration.Text == "" || lblExam.Text == "")
                {
                    MessageBox.Show("Các trường yêu cầu không trống");
                    return;
                }
            }
            catch
            {

            }


            try
            {
                QuestionLimit = Convert.ToInt32(txtQNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng câu hỏi không hợp lệ");
                QuestionLimit = -1;
                return;
            }

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

                if (QuestionList.Contains(ListQuestionWithTypeAndLevel[count].Id))
                {
                    i--;
                    offset++;
                    if (offset >= ListQuestionWithTypeAndLevel.Count)
                        return;
                    continue;
                }

                QuestionList.Add(ListQuestionWithTypeAndLevel[count].Id);
                AddQuestionToPage(ListQuestionWithTypeAndLevel[count].Id);
            }




        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (QuestionList.Count == 0 || QuestionList.Count < QuestionLimit)
            {
                MessageBox.Show("Số lượng câu hỏi không phù hợp");
                return;
            }
            else
            {

                double scorePerQuestion = Convert.ToDouble(txtMaxScore.Text) / QuestionLimit;

                ExamDetail examDetail = new ExamDetail();
                examDetail.ExamId = Convert.ToInt32(lblExam.Text);
                examDetail.Status = true;
                examDetail.MaxiumMark = Convert.ToDouble(txtMaxScore.Text);
                examDetail.Duration = Convert.ToInt32(txtDuration.Text);
                examDetail.TotalQuestion = QuestionLimit;
                examDetail.CreatedAt = DateTime.Now;
                examDetail.UpdatedAt = null;
                examDetail.CreatedBy = "admin";
                examDetail.UpdatedBy = null;
                examDetail.PassMark = 5;
                examDetail.ReTestNumber = 4;
                examDetail.ExamDetailCode = lblExamDetailCode.Text;

                if (examDetailServices.Add(examDetail) == true)
                {

                    ExamDetail currentExamDetail = examDetailServices.GetByExamDetailCode(lblExamDetailCode.Text);

                    if (currentExamDetail == null)
                    {
                        MessageBox.Show("Không tìm thấy đề thi");
                        return;
                    }

                    foreach (var item in QuestionList)
                    {
                        ExamQuestion examQuestion = new ExamQuestion();
                        examQuestion.ExamDetailId = currentExamDetail.Id;
                        examQuestion.QuestionId = item;
                        examQuestion.Score = scorePerQuestion;
                        examQuestionServices.AddExamQuestion(examQuestion);

                    }

                    UpdateDataEvent?.Invoke(this, EventArgs.Empty);
                }



            }
        }
    }
}
