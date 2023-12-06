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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            chartColumn = new Telerik.WinControls.UI.RadChartView();
            chartPie = new Telerik.WinControls.UI.RadChartView();
            chartQuestionType = new Telerik.WinControls.UI.RadChartView();
            chartLevelQuestion = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)chartColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartQuestionType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLevelQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // chartColumn
            // 
            cartesianArea2.GridDesign.DrawHorizontalFills = false;
            cartesianArea2.GridDesign.DrawVerticalFills = false;
            cartesianArea2.GridDesign.DrawVerticalStripes = false;
            cartesianArea2.ShowGrid = true;
            chartColumn.AreaDesign = cartesianArea2;
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
            chartPie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // chartQuestionType
            // 
            chartQuestionType.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            chartQuestionType.Location = new Point(12, 562);
            chartQuestionType.Name = "chartQuestionType";
            chartQuestionType.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.SingleDataPoint;
            chartQuestionType.ShowGrid = false;
            chartQuestionType.ShowPanZoom = true;
            chartQuestionType.ShowTitle = true;
            chartQuestionType.ShowToolTip = true;
            chartQuestionType.ShowTrackBall = true;
            chartQuestionType.Size = new Size(493, 340);
            chartQuestionType.TabIndex = 2;
            chartQuestionType.Title = "Loại câu hỏi có trong hệ thống";
            // 
            // chartLevelQuestion
            // 
            chartLevelQuestion.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            chartLevelQuestion.Location = new Point(511, 562);
            chartLevelQuestion.Name = "chartLevelQuestion";
            chartLevelQuestion.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.SingleDataPoint;
            chartLevelQuestion.ShowGrid = false;
            chartLevelQuestion.ShowPanZoom = true;
            chartLevelQuestion.ShowTitle = true;
            chartLevelQuestion.ShowToolTip = true;
            chartLevelQuestion.ShowTrackBall = true;
            chartLevelQuestion.Size = new Size(493, 340);
            chartLevelQuestion.TabIndex = 3;
            chartLevelQuestion.Title = " Cấp độ câu hỏi";
            // 
            // Report_Overview
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 951);
            Controls.Add(chartLevelQuestion);
            Controls.Add(chartQuestionType);
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
            ((System.ComponentModel.ISupportInitialize)chartQuestionType).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLevelQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadChartView chartQuestionType;
        private Telerik.WinControls.UI.RadChartView chartPie;
        private Telerik.WinControls.UI.RadChartView chartColumn;
        private Telerik.WinControls.UI.RadChartView chartLevelQuestion;
    }
}
