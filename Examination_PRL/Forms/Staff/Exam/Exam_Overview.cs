using Examination_BUS.Services;
using Examination_BUS.ViewModel;
using Examination_PRL.Forms.Staff.Exam;
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


        ExamDetailServices examDetailServices = new ExamDetailServices();
        ExamServices examServices = new ExamServices();
        string curentExamDetailCode = "";
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
            ConditionalFormattingObject formattingObject = new ConditionalFormattingObject("StatusFalse", ConditionTypes.Equal, "false", "", true);
            formattingObject.RowBackColor = Color.MistyRose;

            int stt = 1;
            examGridView.ColumnCount = 18;
            examGridView.Columns[0].HeaderText = "ID Exam";
            examGridView.Columns[1].HeaderText = "ID ExamDetail";
            examGridView.Columns[2].HeaderText = "STT";
            examGridView.Columns[3].HeaderText = "Mã bài thi";
            examGridView.Columns[4].HeaderText = "Tên bài thi";
            examGridView.Columns[5].HeaderText = "Mã môn";
            examGridView.Columns[6].HeaderText = "Mã đề thi";
            examGridView.Columns[7].HeaderText = "Mô tả";
            examGridView.Columns[8].HeaderText = "Tạo bởi";
            examGridView.Columns[9].HeaderText = "Thời lượng";
            examGridView.Columns[10].HeaderText = "Điểm đạt";
            examGridView.Columns[11].HeaderText = "Số lượng câu hỏi";
            examGridView.Columns[12].HeaderText = "Điểm tối đa";
            examGridView.Columns[13].HeaderText = "Số lần thi lại";
            examGridView.Columns[14].HeaderText = "Trạng thái";
            examGridView.Columns[15].HeaderText = "Ngày tạo";
            examGridView.Columns[16].HeaderText = "Ngày cập nhật";
            examGridView.Columns[17].HeaderText = "Cập nhật bởi";

            examGridView.Columns[0].IsVisible = false;
            examGridView.Columns[1].IsVisible = false;
            for (int i = 9; i < 18; i++)
            {
                examGridView.Columns[i].IsVisible = false;
            }


            foreach (var item in examDetailServices.GetExamDetailWithExam())
            {
                examGridView.Rows.Add(item.ExamId, item.ExamDetailId, stt++, item.ExamCode, item.Name, item.SubjectId, item.ExamDetailCode, item.Description, item.CreatedBy, item.Duration, item.PassMark, item.TotalQuestion, item.MaxiumMark, item.ReTestNumber, item.Status, item.CreatedAt, item.UpdatedAt, item.UpdatedBy);


            }
            // lblTotalExam.Text = examGridView.RowCount.ToString();
            lblExamDetailCount.Text = examGridView.RowCount.ToString();
            lblExamCount.Text = examServices.GetAll().Count().ToString();
            this.examGridView.Columns[14].ConditionalFormattingObjectList.Add(formattingObject);

        }

        private void examGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                curentExamDetailCode = examGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                ExamDetailViewModel ed = examDetailServices.GetExamDetailWithExam().FirstOrDefault(x => x.ExamDetailCode == curentExamDetailCode);
                if (ed != null)
                {
                    lblCurrentCode.Text = ed.ExamDetailCode;
                    lblName.Text = ed.Name;
                    lblSubjectCode.Text = ed.SubjectId;
                    lblTotalQuestion.Text = ed.TotalQuestion.ToString();
                    lblDuration.Text = ed.Duration.ToString();
                    lblCreatedBy.Text = ed.CreatedBy;
                    lblCreateTime.Text = ed.CreatedAt.ToString();
                    lblMaxMark.Text = ed.MaxiumMark.ToString();
                    lblReTest.Text = ed.ReTestNumber.ToString();
                    lblPassmark.Text = ed.PassMark.ToString();
                    lblUpdateAt.Text = ed.UpdatedAt.ToString();
                    lblStatus.Text = Convert.ToBoolean(ed.Status) ? "Đang mở" : "Đã đóng";
                    btnViewDetail.Enabled = true;


                }
            }
            catch
            {
                curentExamDetailCode = "";
                btnViewDetail.Enabled = false;


            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if(curentExamDetailCode!="" && examGridView.SelectedRows.Count>0)
            {
                int examDetailId =Convert.ToInt32( examGridView.Rows[examGridView.SelectedRows[0].Index].Cells[1].Value);
                ViewOneExam oneExam = new ViewOneExam(examDetailId);
                oneExam.ShowDialog();
            }
        }
    }
}
