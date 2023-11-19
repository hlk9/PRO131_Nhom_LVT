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

namespace Examination_PRL.Forms.Staff.QuestionForm
{
    public partial class AddQuestion : Telerik.WinControls.UI.RadForm
    {
        public string staffCode = "admin";

        QuestionServices questionServices = new QuestionServices();
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

            try
            {
                ExcelPackage package = new ExcelPackage(new FileInfo(path));
                ExcelWorksheet worksheetQuestion = package.Workbook.Worksheets[0];
                ExcelWorksheet worksheetAnswer = package.Workbook.Worksheets[1];
                int rowCount = worksheetQuestion.Dimension.Rows;
                int colCount = worksheetQuestion.Dimension.Columns;

                for (int row = 2; row <= rowCount; row++)
                {
                    Question q = new Question();
                    Answer a = new Answer();
                    q.QuestionTypeId = Convert.ToByte(worksheetQuestion.Cells[row, 1].Value.ToString());
                    q.QuestionLevelId = Convert.ToByte(worksheetQuestion.Cells[row, 2].Value.ToString());
                    q.SubjectId = worksheetQuestion.Cells[row, 3].Value?.ToString();
                    q.Content = worksheetQuestion.Cells[row, 4].Value?.ToString();
                    q.Docs = worksheetQuestion.Cells[row, 5].Value?.ToString();
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

                    questionServices.AddQuestion(q);



                    MessageBox.Show("Import successful!");

                }




            }
            catch
            {

                MessageBox.Show("Import failed!");

            }


        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != null)
            {
                ImportFileQuestion(txtPath.Text);
            }




        }
    }
}
