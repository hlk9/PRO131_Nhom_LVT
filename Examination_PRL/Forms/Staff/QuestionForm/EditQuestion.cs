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

namespace Examination_PRL.Forms.Staff.QuestionForm
{
    public partial class EditQuestion : Telerik.WinControls.UI.RadForm
    {
        public event EventHandler DataAdded;

        int currentQuestionId = -1;

        QuestionServices questionServices = new QuestionServices();
        QuestionLevelService levelService = new QuestionLevelService();
        QuestionTypeServices questionTypeServices = new QuestionTypeServices();
        SubjectServices subjectServices = new SubjectServices();

        public EditQuestion(int qId)
        {
            this.currentQuestionId = qId;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dropDownLevel.Items.Clear();
            dropDownSubject.Items.Clear();
            dropDownType.Items.Clear();

            foreach (var item in subjectServices.GetSubjects().Where(x => x.Status == 1))
            {
                dropDownSubject.Items.Add(item.Id);
            }

            dropDownLevel.Items.Add("Dễ");
            dropDownLevel.Items.Add("Trung bình");
            dropDownLevel.Items.Add("Nâng cao");
            dropDownLevel.Items.Add("Vận dụng cao");

            dropDownType.Items.Add("Chọn câu trả lời đúng nhất");
            dropDownType.Items.Add("Chọn các đáp án đúng");
            dropDownType.Items.Add("Chọn Đúng hoặc Sai");

            var question = questionServices.GetQuestionById(currentQuestionId);
            richContent.Text = question.Content;
            dropDownSubject.SelectedValue = question.SubjectId;
            dropDownLevel.SelectedIndex = Convert.ToInt32(question.QuestionLevelId) - 1;
            dropDownType.SelectedIndex = Convert.ToInt32(question.QuestionTypeId) - 1;



        }
        protected virtual void OnDataAdded(EventArgs e)
        {
            // Gọi sự kiện DataAdded để thông báo rằng dữ liệu đã được thêm
            DataAdded?.Invoke(this, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (richContent.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung câu hỏi");
                return;
            }

           var question = questionServices.GetQuestionById(currentQuestionId);

            var newQuestion = new Question();
            newQuestion = question;
            newQuestion.Content = richContent.Text;
            newQuestion.SubjectId = dropDownSubject.SelectedItem.ToString();
            newQuestion.QuestionLevelId = Convert.ToByte(dropDownLevel.SelectedIndex + 1);
            newQuestion.QuestionTypeId = Convert.ToByte(dropDownType.SelectedIndex + 1);

             if(questionServices.UpdateQuestion(newQuestion)==true)
                MessageBox.Show("Cập nhật thành công");
             else
                MessageBox.Show("Cập nhật thất bại");

            OnDataAdded(EventArgs.Empty);
        }


       
    }
}
