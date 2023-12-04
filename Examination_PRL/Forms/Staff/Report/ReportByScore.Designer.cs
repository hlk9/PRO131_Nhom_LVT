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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
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
            chartColumnScore.Location = new Point(12, 441);
            chartColumnScore.Name = "chartColumnScore";
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
