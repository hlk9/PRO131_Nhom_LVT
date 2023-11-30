﻿using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff
{
    public partial class Report_Overview : Telerik.WinControls.UI.RadForm
    {
        ExamResponseServices examResponseServices = new ExamResponseServices();
        QuestionServices questionServices = new QuestionServices();
        public Report_Overview()
        {
            // var list= examResponseServices.GetAllExamResponse();
            //var list = questionServices.GetAllQuestions();
            //create a list of ExampleData objects, fake data



            InitializeComponent();

            LoadData();




        }
        public void LoadData()
        {

            double pass = 0, fail = 0, total = 0, passRate = 0, failRate = 0, unknown = 0, unknownRate = 0;

            var list = examResponseServices.GetAllExamResponse();

            pass = list.FindAll(x => x.IsPassed == true).Count;
            fail = list.FindAll(x => x.IsPassed == false).Count;
            unknown = list.FindAll(x => x.IsPassed == null).Count;

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
            chartPie.Series.Add(pieSeries);
            chartPie.ShowLegend = true;
            chartPie.ShowTitle = true;
            chartPie.Title = "Tỉ lệ sinh viên Đạt và Trượt";
            chartPie.ShowSmartLabels = true;
            pieSeries.DrawLinesToLabels = true;
            pieSeries.SyncLinesToLabelsColor = true;
        
            chartPie.Area.View.Palette = KnownPalette.Forest;

            //phổ điểm
            List<double> listPoint = new List<double>();
            foreach (var item in list)
            {
                listPoint.Add(Convert.ToDouble(item.Score));
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
            
            verticalAxis.Title = "Điểm";
          
            lineSeries.VerticalAxis = verticalAxis;
            verticalAxis.Minimum = 0;
            verticalAxis.Maximum = 10;
            verticalAxis.LabelOffset = 0;

            chartColumn.Series.Add(lineSeries);
            chartColumn.Area.View.Palette = KnownPalette.Arctic;



        }
        public double ChuanHoaDiem(double diemDatDuoc, double diemToiDa, double thangDiem)
        {
            return Math.Round((diemDatDuoc / diemToiDa) * thangDiem, 2);
        }
    }

    public class ExamResponseResult
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }

    public class ExamPointTotal
    {
        public string Point { get; set; }
        public int Total { get; set; }
    }

}
