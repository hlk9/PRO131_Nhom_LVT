using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.QuestionForm
{
    public partial class QuestionOverview : Telerik.WinControls.UI.RadForm
    {

        QuestionServices questionServices;
        QuestionLevelService levelService = new QuestionLevelService();
        int currentQuestionId = -1;
        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        public QuestionOverview()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            questionServices = new QuestionServices();
            questionGridView.Rows.Clear();

            questionGridView.ColumnCount = 7;

            int stt = 1;

            questionGridView.Columns[0].HeaderText = "STT";
            questionGridView.Columns[1].HeaderText = "Mã câu hỏi";
            questionGridView.Columns[2].HeaderText = "Nội dung";
            questionGridView.Columns[3].HeaderText = "Mức độ";
            questionGridView.Columns[4].HeaderText = "Loại câu hỏi";
            questionGridView.Columns[5].HeaderText = "Mã môn";
            questionGridView.Columns[6].HeaderText = "Ngày tạo";

            foreach (var item in questionServices.GetAllQuestions())
            {
                questionGridView.Rows.Add(stt++, item.Id, item.Content, levelService.GetById(Convert.ToByte(item.QuestionLevelId)).Name, questionTypeServices.GetById(Convert.ToByte(item.QuestionTypeId)).Name, item.SubjectId, item.CreatedTime);
            }

            for (int i = 0; i < questionGridView.Columns.Count; i++)
            {
                questionGridView.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            questionGridView.CurrentRow = questionGridView.Rows[0];

            lblTotal.Text = questionGridView.Rows.Count.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.ShowDialog();
        }

        private void questionGridView_SelectionChanged(object sender, EventArgs e)
        {
            questionServices = new QuestionServices();
            try
            {
                currentQuestionId = Convert.ToInt32(questionGridView.CurrentRow.Cells[1].Value);
                Question q = questionServices.GetQuestionById(currentQuestionId);
                lblCreatedBy.Text = q.CreatedBy;
                lblCreateTime.Text = q.CreatedTime.ToString();
                lblID.Text = q.Id.ToString();
                lblLevel.Text = levelService.GetById(Convert.ToByte(q.QuestionLevelId)).Name;
                lblSubjectCode.Text = q.SubjectId.ToString();
                lblQType.Text = questionTypeServices.GetById(Convert.ToByte(q.QuestionTypeId)).Name;
                lblStatus.Text = q.Status.ToString();
                lblAnswerCount.Text = questionServices.GetQuestionWithAnswer(currentQuestionId).Answers.Count.ToString();

            }
            catch (Exception)
            {
                currentQuestionId = -1;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            EditQuestion editQuestion = new EditQuestion(currentQuestionId);
            editQuestion.DataAdded += EditQuestion_DataAdded;
            editQuestion.ShowDialog();

        }

        private void EditQuestion_DataAdded(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            questionServices = new QuestionServices();
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                questionServices.DisableQuestion(currentQuestionId);
                LoadData();
            }
          
        }
    }
}
