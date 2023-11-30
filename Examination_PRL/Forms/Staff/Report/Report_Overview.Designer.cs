namespace Examination_PRL.Forms.Staff
{
    partial class Report_Overview
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries1 = new Telerik.WinControls.UI.LineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint1 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint2 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint3 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint4 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint5 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint6 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint7 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint8 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint9 = new Telerik.Charting.CategoricalDataPoint();
            Telerik.Charting.CategoricalDataPoint categoricalDataPoint10 = new Telerik.Charting.CategoricalDataPoint();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            chartColumn = new Telerik.WinControls.UI.RadChartView();
            chartPie = new Telerik.WinControls.UI.RadChartView();
            radChartView3 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)chartColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radChartView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // chartColumn
            // 
            cartesianArea1.GridDesign.DrawHorizontalFills = false;
            cartesianArea1.GridDesign.DrawVerticalFills = false;
            cartesianArea1.GridDesign.DrawVerticalStripes = false;
            cartesianArea1.ShowGrid = true;
            chartColumn.AreaDesign = cartesianArea1;
            chartColumn.Location = new Point(12, 12);
            chartColumn.Name = "chartColumn";
            chartColumn.ShowPanZoom = true;
            chartColumn.ShowTitle = true;
            chartColumn.ShowToolTip = true;
            chartColumn.ShowTrackBall = true;
            chartColumn.Size = new Size(832, 544);
            chartColumn.TabIndex = 0;
            chartColumn.Title = "Phổ điểm của các bài thi";
            // 
            // chartPie
            // 
            chartPie.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            chartPie.Location = new Point(850, 12);
            chartPie.Name = "chartPie";
            chartPie.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.SingleDataPoint;
            chartPie.ShowGrid = false;
            chartPie.ShowLegend = true;
            chartPie.ShowTitle = true;
            chartPie.ShowToolTip = true;
            chartPie.Size = new Size(775, 544);
            chartPie.TabIndex = 1;
            chartPie.ThemeName = "MaterialTeal";
            chartPie.Title = "Tỉ lệ sinh viên Đạt và Trượt";
            // 
            // radChartView3
            // 
            radChartView3.AreaDesign = cartesianArea2;
            categoricalAxis1.IsPrimary = true;
            categoricalAxis1.LabelRotationAngle = 300D;
            categoricalAxis1.Title = "";
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.LabelRotationAngle = 300D;
            linearAxis1.MajorStep = 10D;
            linearAxis1.TickOrigin = null;
            linearAxis1.Title = "";
            radChartView3.Axes.AddRange(new Telerik.WinControls.UI.Axis[] { categoricalAxis1, linearAxis1 });
            radChartView3.Location = new Point(12, 562);
            radChartView3.Name = "radChartView3";
            categoricalDataPoint1.Category = "A";
            categoricalDataPoint1.Label = 55D;
            categoricalDataPoint1.Value = 55D;
            categoricalDataPoint2.Category = "B";
            categoricalDataPoint2.Label = 59D;
            categoricalDataPoint2.Value = 59D;
            categoricalDataPoint3.Category = "C";
            categoricalDataPoint3.Label = 32D;
            categoricalDataPoint3.Value = 32D;
            categoricalDataPoint4.Category = "D";
            categoricalDataPoint4.Label = 95D;
            categoricalDataPoint4.Value = 95D;
            categoricalDataPoint5.Category = "E";
            categoricalDataPoint5.Label = 59D;
            categoricalDataPoint5.Value = 59D;
            lineSeries1.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { categoricalDataPoint1, categoricalDataPoint2, categoricalDataPoint3, categoricalDataPoint4, categoricalDataPoint5 });
            lineSeries1.HorizontalAxis = categoricalAxis1;
            lineSeries1.LabelAngle = 90D;
            lineSeries1.LabelDistanceToPoint = 15D;
            lineSeries1.VerticalAxis = linearAxis1;
            categoricalDataPoint6.Category = "A";
            categoricalDataPoint6.Label = 16D;
            categoricalDataPoint6.Value = 16D;
            categoricalDataPoint7.Category = "B";
            categoricalDataPoint7.Label = 89D;
            categoricalDataPoint7.Value = 89D;
            categoricalDataPoint8.Category = "C";
            categoricalDataPoint8.Label = 13D;
            categoricalDataPoint8.Value = 13D;
            categoricalDataPoint9.Category = "D";
            categoricalDataPoint9.Label = 98D;
            categoricalDataPoint9.Value = 98D;
            categoricalDataPoint10.Category = "E";
            categoricalDataPoint10.Label = 45D;
            categoricalDataPoint10.Value = 45D;
            lineSeries2.DataPoints.AddRange(new Telerik.Charting.DataPoint[] { categoricalDataPoint6, categoricalDataPoint7, categoricalDataPoint8, categoricalDataPoint9, categoricalDataPoint10 });
            lineSeries2.HorizontalAxis = categoricalAxis1;
            lineSeries2.LabelAngle = 90D;
            lineSeries2.LabelDistanceToPoint = 15D;
            lineSeries2.LegendTitle = null;
            lineSeries2.VerticalAxis = linearAxis1;
            radChartView3.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] { lineSeries1, lineSeries2 });
            radChartView3.ShowGrid = false;
            radChartView3.Size = new Size(1613, 340);
            radChartView3.TabIndex = 2;
            // 
            // Report_Overview
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 951);
            Controls.Add(radChartView3);
            Controls.Add(chartPie);
            Controls.Add(chartColumn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report_Overview";
            // 
            // 
            // 
            RootElement.ApplyShapeToControl = true;
            Text = "Report_Overview";
            ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)chartColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ((System.ComponentModel.ISupportInitialize)radChartView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadChartView radChartView3;
        private Telerik.WinControls.UI.RadChartView chartPie;
        private Telerik.WinControls.UI.RadChartView chartColumn;
    }
}
