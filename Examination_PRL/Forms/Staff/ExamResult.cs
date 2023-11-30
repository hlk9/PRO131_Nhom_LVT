using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff
{
    public partial class ExamResult : Telerik.WinControls.UI.RadForm
    {

        ExamServices _serExam = new ExamServices();
        QuestionServices _serQues = new QuestionServices();

        int _idWhenClick;

        string _ExamDetailCode;

        public ExamResult()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            radGridViewExam.Rows.Clear();

            int stt = 1;

            radGridViewExam.ColumnCount = 4;

            radGridViewExam.Columns[0].HeaderText = "STT";
            radGridViewExam.Columns[1].HeaderText = "ID Bài Thi";
            radGridViewExam.Columns[2].HeaderText = "Mã Bài Thi";
            radGridViewExam.Columns[3].HeaderText = "Tên Bài Thi";

            foreach (var x in _serExam.GetAll())
            {
                radGridViewExam.Rows.Add(stt++, x.Id, x.ExamCode, x.Name);
            }
        }

        public void loadExamDetail(int id)
        {
            radGridViewExamDetail.Rows.Clear();

            int stt = 1;

            radGridViewExamDetail.ColumnCount = 7;

            radGridViewExamDetail.Columns[0].HeaderText = "STT";
            radGridViewExamDetail.Columns[1].HeaderText = "Mã Đề Thi";
            radGridViewExamDetail.Columns[2].HeaderText = "Thời Gian (phút)";
            radGridViewExamDetail.Columns[3].HeaderText = "Thang Điểm";
            radGridViewExamDetail.Columns[4].HeaderText = "Tổng Số Câu";
            radGridViewExamDetail.Columns[5].HeaderText = "Điểm Đạt";
            radGridViewExamDetail.Columns[6].HeaderText = "Số Lần Được Làm";

            foreach (var x in _serExam.getExam_DetailViewModelss(id))
            {
                radGridViewExamDetail.Rows.Add(stt++, x.examDetailCode, x.duration, x.maxiumMark, x.totalQuestion, x.passMark, x.reTestNumber);
            }
        }

        private void radGridViewExam_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idWhenClick = Convert.ToInt32(radGridViewExam.CurrentRow.Cells[1].Value);
            radLblSumExamDetail.Text = _serExam.getExam_DetailViewModelss(_idWhenClick).ToList().Count.ToString();
            loadExamDetail(_idWhenClick);
        }

        private void radGridViewExamDetail_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _ExamDetailCode = radGridViewExamDetail.CurrentRow.Cells[1].Value.ToString();

            radLblExamDetailCode.Text = _ExamDetailCode;

            radLblQuestionLevelEasy.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionLevelId == 1).Count().ToString();
            radLblQuestionLevelAvg.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionLevelId == 2).Count().ToString();
            radLblQuestionLevelAdvanced.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionLevelId == 3).Count().ToString();
            radLblQuestionLevelSuperAdvanced.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionLevelId == 4).Count().ToString();

            radLblQuestionTypeOnly.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionTypeId == 1).Count().ToString();
            radLblQuestionTypeMany.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionTypeId == 2).Count().ToString();
            radLblQuestionTypeYN.Text = _serQues.GetQuestionsByExamCode(_ExamDetailCode).Questions.Where(x => x.QuestionTypeId == 3).Count().ToString();
        }
    }
}
