using Examination_BUS.Services;
using Examination_DAL.Models;
using Examination_PRL.Forms.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms
{
    public partial class ReportByScore : Telerik.WinControls.UI.RadForm
    {
        int _idExamWhenClick;

        ExamScheduleService _serExamSchedule = new ExamScheduleService();
        ExamDetailServices _serExamDetail = new ExamDetailServices();
        ExamResponseServices _serExamResponses = new ExamResponseServices();

        public ReportByScore()
        {
            InitializeComponent();
            loadGrid();
        }

        public void loadGrid()
        {
            radGridViewExam.Rows.Clear();

            radGridViewExam.ColumnCount = 4;

            int stt = 1;

            radGridViewExam.Columns[0].HeaderText = "STT";
            radGridViewExam.Columns[1].HeaderText = "Mã Lịch Thi";
            radGridViewExam.Columns[2].HeaderText = "Tên Đợt Thi";
            radGridViewExam.Columns[3].HeaderText = "Mã Bài Thi";

            radGridViewExam.Columns[1].IsVisible = false;
            radGridViewExam.Columns[3].IsVisible = false;

            foreach (var x in _serExamSchedule.getAlls())
            {
                radGridViewExam.Rows.Add(stt++, x.Id, x.Name, x.ExamId);
            }
        }

        public void loadChart(int id)
        {
            chartColumnScore.Series.Clear();
            chartPieAnSwer.Series.Clear();
            chartPieIsPassed.Series.Clear();

            List<ExamDetail> examDetails = new List<ExamDetail>();

            foreach (var x in _serExamDetail.getByExamIds(id))
            {
                examDetails.Add(x);
            }

            List<ExamResponse> examResponses = new List<ExamResponse>();

            foreach (var x in examDetails)
            {
                //var list = _serExamResponses.GetExamResponseByExamDetailId(x.Id);
                //examResponses.AddRange(list);
                examResponses.AddRange(_serExamResponses.GetExamResponseByExamDetailId(x.Id));
            }

            double pass = 0, fail = 0, total = 0, passRate = 0, failRate = 0, unknown = 0, unknownRate = 0;         

            pass = examResponses.FindAll(x => x.IsPassed == true).Count;
            fail = examResponses.FindAll(x => x.IsPassed == false).Count;
            unknown = examResponses.FindAll(x => x.IsPassed == null).Count;

            total = pass + fail + unknown;
            passRate = (pass / total) * 100;
            failRate = (fail / total) * 100;
            unknownRate = 100 - passRate - failRate;

            List<ExamResponseResult> examResponseResults = new List<ExamResponseResult>();
            examResponseResults.Add(new ExamResponseResult() { Name = "Đạt", Value = passRate });
            examResponseResults.Add(new ExamResponseResult() { Name = "Trượt", Value = failRate });
            examResponseResults.Add(new ExamResponseResult() { Name = "Chưa xét", Value = unknownRate });

            PieSeries pieSeries = new PieSeries();
            pieSeries.ShowLabels = true;
            pieSeries.ValueMember = "Value";
            pieSeries.LegendTitleMember = "Name";
            pieSeries.DataSource = examResponseResults;
            chartPieIsPassed.Series.Add(pieSeries);
            chartPieIsPassed.ShowLegend = true;
            chartPieIsPassed.ShowTitle = true;
            chartPieIsPassed.Title = "Tỉ lệ bài làm Đạt và Trượt\nTổng số: " + examResponses.Count;
            chartPieIsPassed.ShowSmartLabels = true;
            pieSeries.DrawLinesToLabels = true;
            pieSeries.SyncLinesToLabelsColor = true;

            chartPieIsPassed.Area.View.Palette = KnownPalette.Sun;

            double totalQuestion = 0, correct = 0, wrong = 0, notAnswered = 0, correctRate = 0, wrongRate = 0, notAnsweredRate = 0;

            foreach (var x in examResponses)
            {
                try
                {
                    if (x.QuestionCorrect != null || x.QuestionNotAnswered != null || x.QuestionWrong != null)
                    {
                        correct += x.QuestionCorrect.Value;
                        wrong += x.QuestionWrong.Value;
                        notAnswered += x.QuestionNotAnswered.Value;
                    }
                }
                catch 
                {
                    correct += 0;
                    wrong += 0;
                    notAnswered += 0;
                }
                           
            }          

            totalQuestion = correct + wrong + notAnswered;
            correctRate = (correct / totalQuestion) * 100;
            wrongRate = (wrong / totalQuestion) * 100;
            notAnsweredRate = 100 - correctRate - wrongRate;

            List<Question> questionResult = new List<Question>();
            questionResult.Add(new Question() { Name = "Câu đúng", Total = correctRate});
            questionResult.Add(new Question() { Name = "Câu sai", Total = wrongRate});
            questionResult.Add(new Question() { Name = "Câu chưa chọn", Total = notAnsweredRate});

            PieSeries pieSeriesQuestion = new PieSeries();
            pieSeriesQuestion.ShowLabels = true;
            pieSeriesQuestion.ValueMember = "Total";
            pieSeriesQuestion.LegendTitleMember = "Name";
            pieSeriesQuestion.DataSource = questionResult;
            chartPieAnSwer.Series.Add(pieSeriesQuestion);
            chartPieAnSwer.ShowLegend = true;
            chartPieAnSwer.ShowTitle = true;
            chartPieAnSwer.Title = "Câu trả lời\nTổng số: " + totalQuestion;
            chartPieAnSwer.ShowSmartLabels = true;
            pieSeriesQuestion.DrawLinesToLabels = true;
            pieSeriesQuestion.SyncLinesToLabelsColor = true;

            chartPieAnSwer.Area.View.Palette = KnownPalette.Sun;

            //phổ điểm
            List<double> listPoint = new List<double>();
            foreach (var item in examResponses)
            {
                double point = Convert.ToDouble(item.Score);
                double maxScore = _serExamDetail.GetById(item.ExamDetailId).MaxiumMark;
                listPoint.Add(chuanHoaDiem(point, maxScore, 10));

            }

            var listDauDiem = listPoint.Distinct().OrderBy(x => x);
            List<ExamPointTotal> examPointTotals = new List<ExamPointTotal>();
            foreach (var item in listDauDiem)
            {
                examPointTotals.Add(new ExamPointTotal() { Point = item.ToString(), Total = listPoint.FindAll(x => x == item).Count });

            }

            BarSeries lineSeries = new BarSeries();
            lineSeries.ShowLabels = true;
            lineSeries.ValueMember = "Total";
            lineSeries.CategoryMember = "Point";
            lineSeries.DataSource = examPointTotals;
            //  lineSeries.PointSize = new SizeF(0, 0);

            lineSeries.BorderWidth = 1;
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
            // verticalAxis.LogarithmBase = 10;

            verticalAxis.Title = "Số lượng thí sinh";

            lineSeries.VerticalAxis = verticalAxis;
            verticalAxis.Minimum = 0;

            verticalAxis.LabelOffset = 0;

            chartColumnScore.Series.Add(lineSeries);
            chartColumnScore.Area.View.Palette = KnownPalette.Arctic;
            chartColumnScore.ShowTitle = true;
            chartColumnScore.Title = "Phổ điểm\nTổng số: " + examResponses.Count;

        }

        private void radGridViewExam_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _idExamWhenClick = Convert.ToInt32(radGridViewExam.CurrentRow.Cells[3].Value);

            loadChart(_idExamWhenClick);
        }

        public double chuanHoaDiem(double diemDat, double diemToiDa, double thangDiem)
        {
            return Math.Round((diemDat / diemToiDa) * thangDiem, 2);
        }

        public class ExamResponseResult
        {
            public string Name { get; set; }
            public double Value { get; set; }
        }

        public class Question
        {
            public string Name { get; set; }
            public double Total { get; set; }
        }

        
    }
}
