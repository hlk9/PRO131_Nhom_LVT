using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace Examination_PRL.Forms.Staff
{
    public partial class Exam_Overview : Telerik.WinControls.UI.RadForm
    {


        ExamServices examService = new ExamServices();
        public Exam_Overview()
        {
            InitializeComponent();
            RoundRectShape roundRectShape = new RoundRectShape();
            roundRectShape.Radius = 30;
            //panelOverview.RootElement.Shape = roundRectShape;
            //panelOverview.RootElement.ApplyShapeToControl = true;


            LoadData();


        }

        private void ExamGridView_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridHeaderCellElement)
            {
                if (e.CellElement.Text == "Mã bài thi" || e.CellElement.Text == "Tên bài thi" || e.CellElement.Text == "Mã môn" || e.CellElement.Text == "")
                {
                    e.CellElement.DrawBorder = true;
                    e.CellElement.DrawFill = true;
                    e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                    e.CellElement.BackColor = Color.Teal;
                    e.CellElement.ForeColor = Color.White;
                }
            }
        }

        public void LoadData()
        {
            examGridView.ColumnCount = 4;
            examGridView.Columns[0].HeaderText = "ID";
            examGridView.Columns[1].HeaderText = "Mã bài thi";
            examGridView.Columns[2].HeaderText = "Tên bài thi";
            examGridView.Columns[3].HeaderText = "Mã môn";
            examGridView.Columns[0].IsVisible = false;


            foreach (var item in examService.GetAll())
            {
                examGridView.Rows.Add(item.Id, item.ExamCode, item.Name, item.SubjectId);
            }
            // lblTotalExam.Text = examGridView.RowCount.ToString();

        }
    }
}
