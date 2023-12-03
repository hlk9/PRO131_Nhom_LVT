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
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Staff.Exam
{
    public partial class GetListQnA : Telerik.WinControls.UI.RadForm
    {
        QuestionServices questionServices = new QuestionServices();
        QuestionLevelService levelService = new QuestionLevelService();
        int currentQuestionId = -1;
        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        public event EventHandler DataAdded;

        ExamQuestionServices examQuestionServices = new ExamQuestionServices();
        int examDetailId = -1;
        public GetListQnA(int exmDetail)
        {
            this.examDetailId = exmDetail;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {

            gridViewQ.ColumnCount = 7;

            int stt = 1;
            gridViewQ.Columns[0].HeaderText = "STT";
            gridViewQ.Columns[1].HeaderText = "Mã câu hỏi";
            gridViewQ.Columns[2].HeaderText = "Nội dung";
            gridViewQ.Columns[3].HeaderText = "Mức độ";
            gridViewQ.Columns[4].HeaderText = "Loại câu hỏi";
            gridViewQ.Columns[5].HeaderText = "Mã môn";
            gridViewQ.Columns[6].HeaderText = "Ngày tạo";

            foreach (var item in questionServices.GetAllQuestions())
            {
                gridViewQ.Rows.Add(stt++, item.Id, item.Content, levelService.GetById(Convert.ToByte(item.QuestionLevelId)).Name, questionTypeServices.GetById(Convert.ToByte(item.QuestionTypeId)).Name, item.SubjectId, item.CreatedTime);
            }

            for (int i = 0; i < gridViewQ.Columns.Count; i++)
            {
                gridViewQ.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
            }

            gridViewQ.CurrentRow = gridViewQ.Rows[0];

            gridViewQ.CurrentRow = null;
            //OnDataAdded(EventArgs.Empty);


        }
        protected virtual void OnDataAdded(EventArgs e)
        {
            // Gọi sự kiện DataAdded để thông báo rằng dữ liệu đã được thêm
            DataAdded?.Invoke(this, e);
        }

        private void gridViewQ_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem Additem = new RadMenuItem("Thêm câu hỏi vào bài thi");
            Additem.Click += Item_Click;
            e.ContextMenu.Items.Add(Additem);

        }

        private void Item_Click(object? sender, EventArgs e)
        {
          try
            {
                ExamQuestion examQuestion = new ExamQuestion(); 
                examQuestion.ExamDetailId = examDetailId;
                examQuestion.QuestionId = Convert.ToInt32(gridViewQ.CurrentRow.Cells[1].Value);

                examQuestionServices.AddExamQuestion(examQuestion);
                OnDataAdded(EventArgs.Empty);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
