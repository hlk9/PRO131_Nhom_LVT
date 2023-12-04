namespace Examination_PRL.Forms
{
    partial class ReportByScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.DonutSeries donutSeries1 = new Telerik.WinControls.UI.DonutSeries();
            Telerik.Charting.PieDataPoint pieDataPoint1 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint2 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint3 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint4 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint5 = new Telerik.Charting.PieDataPoint();
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.BarSeries barSeries1 = new Telerik.WinControls.UI.BarSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.BarSeries barSeries2 = new Telerik.WinControls.UI.BarSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint6 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint7 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint8 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint9 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint10 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.DonutSeries donutSeries2 = new Telerik.WinControls.UI.DonutSeries();
            Telerik.Charting.PieDataPoint pieDataPoint6 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint7 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint8 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint9 = new Telerik.Charting.PieDataPoint();
            Telerik.Charting.PieDataPoint pieDataPoint10 = new Telerik.Charting.PieDataPoint();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            radGridViewExam = new Telerik.WinControls.UI.RadGridView();
            chartPieIsPassed = new Telerik.WinControls.UI.RadChartView();
            chartColumnScore = new Telerik.WinControls.UI.RadChartView();
            chartPieAnSwer = new Telerik.WinControls.UI.RadChartView();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radDtpStar = new DateTimePicker();
            radDtpEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPieIsPassed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartColumnScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPieAnSwer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radGridViewExam
            // 
            radGridViewExam.Location = new Point(12, 68);
            // 
            // 
            // 
            radGridViewExam.MasterTemplate.AllowAddNewRow = false;
            radGridViewExam.MasterTemplate.AllowColumnReorder = false;
            radGridViewExam.MasterTemplate.AllowDeleteRow = false;
            radGridViewExam.MasterTemplate.AllowEditRow = false;
            radGridViewExam.MasterTemplate.AllowSearchRow = true;
            radGridViewExam.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            radGridViewExam.MasterTemplate.EnablePaging = true;
            radGridViewExam.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridViewExam.Name = "radGridViewExam";
            radGridViewExam.ReadOnly = true;
            radGridViewExam.Size = new Size(622, 367);
            radGridViewExam.TabIndex = 0;
            radGridViewExam.ThemeName = "MaterialTeal";
            radGridViewExam.CellClick += radGridViewExam_CellClick;
            // 
            // chartPieIsPassed
            // 
            chartPieIsPassed.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            chartPieIsPassed.Location = new Point(659, 12);
            chartPieIsPassed.Name = "chartPieIsPassed";
            pieDataPoint1.Label = 0.18817204301075269D;
            pieDataPoint1.LegendTitle = "0.1881720430107527";
            pieDataPoint1.OffsetFromCenter = 0D;
            pieDataPoint1.RadiusAspectRatio = 1F;
            pieDataPoint1.Value = 70D;
            pieDataPoint2.Label = 0.15860215053763441D;
            pieDataPoint2.LegendTitle = "0.1586021505376344";
            pieDataPoint2.OffsetFromCenter = 0D;
            pieDataPoint2.RadiusAspectRatio = 1F;
            pieDataPoint2.Value = 59D;
            pieDataPoint3.Label = 0.24193548387096775D;
            pieDataPoint3.LegendTitle = "0.24193548387096775";
            pieDataPoint3.OffsetFromCenter = 0D;
            pieDataPoint3.RadiusAspectRatio = 1F;
            pieDataPoint3.Value = 90D;
            pieDataPoint4.Label = 0.15591397849462366D;
            pieDataPoint4.LegendTitle = "0.15591397849462366";
            pieDataPoint4.OffsetFromCenter = 0D;
            pieDataPoint4.RadiusAspectRatio = 1F;
            pieDataPoint4.Value = 58D;
            pieDataPoint5.Label = 0.2553763440860215D;
            pieDataPoint5.LegendTitle = "0.2553763440860215";
            pieDataPoint5.OffsetFromCenter = 0D;
            pieDataPoint5.RadiusAspectRatio = 1F;
            pieDataPoint5.Value = 95D;
            donutSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { pieDataPoint1, pieDataPoint2, pieDataPoint3, pieDataPoint4, pieDataPoint5 });
            chartPieIsPassed.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] { donutSeries1 });
            chartPieIsPassed.ShowGrid = false;
            chartPieIsPassed.ShowLegend = true;
            chartPieIsPassed.ShowTitle = true;
            chartPieIsPassed.Size = new Size(456, 423);
            chartPieIsPassed.TabIndex = 1;
            chartPieIsPassed.ThemeName = "MaterialTeal";
            // 
            // chartColumnScore
            // 
            chartColumnScore.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            chartColumnScore.Axes.AddRange(new Telerik.WinControls.UI.Axis[] { categoricalAxis1, linearAxis1 });
            chartColumnScore.Location = new Point(12, 441);
            chartColumnScore.Name = "chartColumnScore";
            categoricalDataPoint1.Category = "A";
            categoricalDataPoint1.Label = 92D;
            categoricalDataPoint1.Value = 92D;
            categoricalDataPoint2.Category = "B";
            categoricalDataPoint2.Label = 14D;
            categoricalDataPoint2.Value = 14D;
            categoricalDataPoint3.Category = "C";
            categoricalDataPoint3.Label = 32D;
            categoricalDataPoint3.Value = 32D;
            categoricalDataPoint4.Category = "D";
            categoricalDataPoint4.Label = 33D;
            categoricalDataPoint4.Value = 33D;
            categoricalDataPoint5.Category = "E";
            categoricalDataPoint5.Label = 95D;
            categoricalDataPoint5.Value = 95D;
            barSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { categoricalDataPoint1, categoricalDataPoint2, categoricalDataPoint3, categoricalDataPoint4, categoricalDataPoint5 });
            barSeries1.HorizontalAxis = categoricalAxis1;
            barSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries1.VerticalAxis = linearAxis1;
            categoricalDataPoint6.Category = "A";
            categoricalDataPoint6.Label = 99D;
            categoricalDataPoint6.Value = 99D;
            categoricalDataPoint7.Category = "B";
            categoricalDataPoint7.Label = 69D;
            categoricalDataPoint7.Value = 69D;
            categoricalDataPoint8.Category = "C";
            categoricalDataPoint8.Label = 93D;
            categoricalDataPoint8.Value = 93D;
            categoricalDataPoint9.Category = "D";
            categoricalDataPoint9.Label = 33D;
            categoricalDataPoint9.Value = 33D;
            categoricalDataPoint10.Category = "E";
            categoricalDataPoint10.Label = 46D;
            categoricalDataPoint10.Value = 46D;
            barSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { categoricalDataPoint6, categoricalDataPoint7, categoricalDataPoint8, categoricalDataPoint9, categoricalDataPoint10 });
            barSeries2.HorizontalAxis = categoricalAxis1;
            barSeries2.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top;
            barSeries2.LegendTitle = null;
            barSeries2.VerticalAxis = linearAxis1;
            chartColumnScore.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] { barSeries1, barSeries2 });
            chartColumnScore.ShowGrid = false;
            chartColumnScore.Size = new Size(1607, 503);
            chartColumnScore.TabIndex = 2;
            chartColumnScore.ThemeName = "MaterialTeal";
            // 
            // chartPieAnSwer
            // 
            chartPieAnSwer.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            chartPieAnSwer.Location = new Point(1163, 12);
            chartPieAnSwer.Name = "chartPieAnSwer";
            pieDataPoint6.Label = 0.18817204301075269D;
            pieDataPoint6.LegendTitle = "0.1881720430107527";
            pieDataPoint6.OffsetFromCenter = 0D;
            pieDataPoint6.RadiusAspectRatio = 1F;
            pieDataPoint6.Value = 70D;
            pieDataPoint7.Label = 0.15860215053763441D;
            pieDataPoint7.LegendTitle = "0.1586021505376344";
            pieDataPoint7.OffsetFromCenter = 0D;
            pieDataPoint7.RadiusAspectRatio = 1F;
            pieDataPoint7.Value = 59D;
            pieDataPoint8.Label = 0.24193548387096775D;
            pieDataPoint8.LegendTitle = "0.24193548387096775";
            pieDataPoint8.OffsetFromCenter = 0D;
            pieDataPoint8.RadiusAspectRatio = 1F;
            pieDataPoint8.Value = 90D;
            pieDataPoint9.Label = 0.15591397849462366D;
            pieDataPoint9.LegendTitle = "0.15591397849462366";
            pieDataPoint9.OffsetFromCenter = 0D;
            pieDataPoint9.RadiusAspectRatio = 1F;
            pieDataPoint9.Value = 58D;
            pieDataPoint10.Label = 0.2553763440860215D;
            pieDataPoint10.LegendTitle = "0.2553763440860215";
            pieDataPoint10.OffsetFromCenter = 0D;
            pieDataPoint10.RadiusAspectRatio = 1F;
            pieDataPoint10.Value = 95D;
            donutSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { pieDataPoint6, pieDataPoint7, pieDataPoint8, pieDataPoint9, pieDataPoint10 });
            chartPieAnSwer.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] { donutSeries2 });
            chartPieAnSwer.ShowGrid = false;
            chartPieAnSwer.ShowLegend = true;
            chartPieAnSwer.ShowTitle = true;
            chartPieAnSwer.Size = new Size(456, 423);
            chartPieAnSwer.TabIndex = 2;
            chartPieAnSwer.ThemeName = "MaterialTeal";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(12, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(95, 21);
            radLabel1.TabIndex = 5;
            radLabel1.Text = "Ngày Bắt Đầu";
            radLabel1.ThemeName = "MaterialTeal";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(338, 12);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(102, 21);
            radLabel2.TabIndex = 6;
            radLabel2.Text = "Ngày Kết Thúc";
            radLabel2.ThemeName = "MaterialTeal";
            // 
            // radDtpStar
            // 
            radDtpStar.Location = new Point(12, 39);
            radDtpStar.Name = "radDtpStar";
            radDtpStar.Size = new Size(265, 23);
            radDtpStar.TabIndex = 0;
            radDtpStar.ValueChanged += radDtpStar_ValueChanged_1;
            // 
            // radDtpEnd
            // 
            radDtpEnd.Location = new Point(338, 39);
            radDtpEnd.Name = "radDtpEnd";
            radDtpEnd.Size = new Size(296, 23);
            radDtpEnd.TabIndex = 7;
            radDtpEnd.ValueChanged += radDtpEnd_ValueChanged_1;
            // 
            // ReportByScore
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 956);
            Controls.Add(radDtpEnd);
            Controls.Add(radDtpStar);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Controls.Add(chartPieAnSwer);
            Controls.Add(chartColumnScore);
            Controls.Add(chartPieIsPassed);
            Controls.Add(radGridViewExam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportByScore";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "ReportBySubject";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)radGridViewExam.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGridViewExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPieIsPassed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartColumnScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPieAnSwer).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadGridView radGridViewExam;
        private Telerik.WinControls.UI.RadChartView chartPieIsPassed;
        private Telerik.WinControls.UI.RadChartView chartColumnScore;
        private Telerik.WinControls.UI.RadChartView chartPieAnSwer;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private DateTimePicker radDtpStar;
        private DateTimePicker radDtpEnd;
    }
}
