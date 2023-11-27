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

namespace Examination_PRL.Forms.Staff.Exam
{
    public partial class ViewOneExam : Telerik.WinControls.UI.RadForm
    {
        public string examDetailCode;
        QuestionServices questionServices = new QuestionServices();
        QuestionsInExamViewModel QuestionsInExamViewModel = new QuestionsInExamViewModel();
        int currentQuestionId = -1;
        public ViewOneExam(string examDetailCode)
        {
            InitializeComponent();
            this.examDetailCode = examDetailCode;
            GetData();
        }
        public void GetData()
        {
            QuestionsInExamViewModel = questionServices.GetQuestionsByExamCode(this.examDetailCode);
            if (QuestionsInExamViewModel != null)
            {
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Không có câu hỏi nào trong bài thi này");
            }
        }
        void LoadGrid()
        {
            examGridView.ColumnCount = 7;
            int stt = 1;
            examGridView.Columns[0].HeaderText = "STT";
            examGridView.Columns[1].HeaderText = "Mã câu hỏi";
            examGridView.Columns[2].HeaderText = "Nội dung câu hỏi";
            examGridView.Columns[3].HeaderText = "Điểm số đạt được";
            examGridView.Columns[4].HeaderText = "Loại câu hỏi";
            examGridView.Columns[5].HeaderText = "Mức độ";
            examGridView.Columns[6].HeaderText = "Mã môn";
            foreach (var question in QuestionsInExamViewModel.Questions)
            {
                string questionType = "";
                byte type = Convert.ToByte(question.QuestionTypeId);
                if (type == 1)
                {
                    questionType = "Chọn đáp án đúng nhất";
                }
                else if (type == 2)
                {
                    questionType = "Chọn CÁC đáp án đúng";
                }
                else if (type == 3)
                {
                    questionType = "Đúng/Sai";
                }

                string questionLevel = "";
                byte level = Convert.ToByte(question.QuestionLevelId);
                if (level == 1)
                {
                    questionLevel = "Dễ";
                }
                else if (level == 2)
                {
                    questionLevel = "Trung bình";
                }
                else if (level == 3)
                {
                    questionLevel = "Khó";
                }



                examGridView.Rows.Add(stt, question.Id, question.Content, question.Point, questionType, questionLevel, question.SubjectId);
                stt++;
            }
        }

        private void examGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                currentQuestionId = Convert.ToInt32(examGridView.Rows[e.RowIndex].Cells[1].Value);
                LoadAnswer(currentQuestionId);

            }
            catch (Exception)
            {
                currentQuestionId = -1;
            }
        }

        void LoadAnswer(int id)
        {
            ConditionalFormattingObject formattingObject = new ConditionalFormattingObject("Status", ConditionTypes.Equal, "Đúng", "", true);
            formattingObject.RowBackColor = Color.Honeydew;
            gridAnswer.Rows.Clear();
            gridAnswer.ColumnCount = 3;
            gridAnswer.Columns[0].HeaderText = "STT";
            gridAnswer.Columns[1].HeaderText = "Nội dung đáp án";
            gridAnswer.Columns[2].HeaderText = "Đúng/Sai";

            foreach (var answer in QuestionsInExamViewModel.Answers)
            {
                if (answer.QuestionId == id)
                {
                    string isCorrect = "";
                    if (answer.IsCorrect == true)
                    {
                        isCorrect = "Đúng";
                    }
                    else
                    {
                        isCorrect = "Sai";
                    }
                    gridAnswer.Rows.Add(answer.Id, answer.Content, isCorrect);
                   
                }

            }
            gridAnswer.Columns[2].ConditionalFormattingObjectList.Add(formattingObject);

        }
    }
}
