using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using OfficeOpenXml;
using Examination_DAL.Models;
using Examination_BUS.Services;
using Examination_DAL.IRepository;

namespace Examination_PRL.Forms.Staff.QuestionForm
{
    public partial class AddQuestion : Telerik.WinControls.UI.RadForm
    {
        public string staffCode = "admin";

        QuestionServices questionServices = new QuestionServices();
        AnswerServices answerServices = new AnswerServices();
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }

        }

        public void ImportFileQuestion(string path)
        {

            ExcelPackage package = new ExcelPackage(new FileInfo(path));
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelWorksheet worksheetQuestion = package.Workbook.Worksheets[0];
            ExcelWorksheet worksheetAnswer = package.Workbook.Worksheets[1];
            int rowCount = worksheetQuestion.Dimension.Rows;
            int colCount = worksheetQuestion.Dimension.Columns;

            //int totalRowQuestion = worksheetQuestion.Dimension.Rows;
            //int totalRowAnswer = worksheetAnswer.Dimension.Rows;
            List<QuestionInExcel> listQiExcel = new List<QuestionInExcel>();

            for (int rowQ = 2; rowQ < worksheetQuestion.Dimension.Rows; rowQ++)
            {
                try
                {
                    QuestionInExcel question = new QuestionInExcel();
                    question.ConnectionId = Convert.ToInt32(worksheetQuestion.Cells[rowQ, 1].Value.ToString());
                    question.Content = worksheetQuestion.Cells[rowQ, 2].Value.ToString();
                    question.QuestionLevelId = Convert.ToByte(worksheetQuestion.Cells[rowQ, 3].Value.ToString());
                    question.QuestionTypeId = Convert.ToByte(worksheetQuestion.Cells[rowQ, 4].Value.ToString());
                    question.SubjectId = worksheetQuestion.Cells[rowQ, 5].Value.ToString();

                    List<AnswerInExcel> answers = new List<AnswerInExcel>();

                    for (int rowA = 2; rowA < worksheetAnswer.Dimension.Rows; rowA++)
                    {

                        try
                        {

                            if (worksheetQuestion.Cells[rowQ, 1].Value.ToString() == worksheetAnswer.Cells[rowA, 1].Value.ToString())
                            {

                                AnswerInExcel answer = new AnswerInExcel();
                                answer.Content = worksheetAnswer.Cells[rowA, 2].Value.ToString();
                                answer.IsCorrect = worksheetAnswer.Cells[rowA, 3].Value.ToString() == "1" ? true : false;
                                answer.ConnectionId = Convert.ToInt32(worksheetAnswer.Cells[rowA, 1].Value.ToString());
                                answers.Add(answer);
                            }
                        }

                        catch
                        {
                            MessageBox.Show("Dòng KV1 " + rowA+"\nMax: "+ worksheetAnswer.Dimension.Rows);
                        }


                    }
                    question.Answers = answers;
                    listQiExcel.Add(question);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Import failed!");
                    MessageBox.Show(ex.Message + " Dòng KV2 " + rowQ+ "\nMax: " + worksheetQuestion.Dimension.Rows);
                }
            }



            try
            {

                foreach (var item in listQiExcel)
                {
                    Question q = new Question();
                    q.QuestionTypeId = item.QuestionTypeId;
                    q.QuestionLevelId = item.QuestionLevelId;
                    q.SubjectId = item.SubjectId;
                    q.Content = item.Content;
                    q.Docs = null;
                    q.CreatedBy = staffCode;
                    q.CreatedTime = DateTime.Now;
                    switch (q.QuestionLevelId)
                    {
                        case 1:
                            q.Point = 0.25;
                            break;
                        case 2:
                            q.Point = 0.5;
                            break;
                        case 3:
                            q.Point = 0.75;
                            break;
                        default:
                            q.Point = 1;
                            break;

                    }
                    q.Status = true;


                    int questionId = questionServices.AddQuestionReturnId(q);
                    if (questionId != -1)
                    {
                        foreach (var answer in item.Answers)
                        {
                            Answer a = new Answer();
                            a.QuestionId = questionId;
                            a.Content = answer.Content;
                            a.IsCorrect = answer.IsCorrect;
                            a.CreatedBy = staffCode;
                            a.Status = true;
                            a.CreatedAt = DateTime.Now;
                            a.UpdatedAt = null;
                            answerServices.AddAnswer(a);

                        }
                    }

                }

                MessageBox.Show("Thêm thành công " + listQiExcel.Count + "câu hỏi kèm đáp án");

            }
            catch
            {
                MessageBox.Show("Import failed!");
            }






            //for (int row = 2; row <= rowCount; row++)
            //{
            //    Question q = new Question();
            //    Answer a = new Answer();
            //    q.QuestionTypeId = Convert.ToByte(worksheetQuestion.Cells[row, 1].Value.ToString());
            //    q.QuestionLevelId = Convert.ToByte(worksheetQuestion.Cells[row, 2].Value.ToString());
            //    q.SubjectId = worksheetQuestion.Cells[row, 3].Value?.ToString();
            //    q.Content = worksheetQuestion.Cells[row, 4].Value?.ToString();
            //    q.Docs = worksheetQuestion.Cells[row, 5].Value?.ToString();
            //    q.CreatedBy = staffCode;
            //    q.CreatedTime = DateTime.Now;
            //    switch (q.QuestionLevelId)
            //    {
            //        case 1:
            //            q.Point = 0.25;
            //            break;
            //        case 2:
            //            q.Point = 0.5;
            //            break;
            //        case 3:
            //            q.Point = 0.75;
            //            break;
            //        default:
            //            q.Point = 1;
            //            break;

            //    }
            //    q.Status = true;

            //    questionServices.AddQuestion(q);



            //    MessageBox.Show("Import successful!");

            //}







        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != null)
            {
                ImportFileQuestion(txtPath.Text);
            }




        }
    }

    public class QuestionInExcel
    {
        public int ConnectionId { get; set; }
        public string Content { get; set; }
        public byte QuestionTypeId { get; set; }
        public byte QuestionLevelId { get; set; }
        public string SubjectId { get; set; }
        public List<AnswerInExcel>? Answers { get; set; }

    }
    public class AnswerInExcel
    {
        public int ConnectionId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}
