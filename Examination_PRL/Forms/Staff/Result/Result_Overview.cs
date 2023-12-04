using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.Windows.Diagrams.Core;

namespace Examination_PRL.Forms.Staff.Result
{
    public partial class Result_Overview : Telerik.WinControls.UI.RadForm
    {
        ExamResponseServices _serResponses = new ExamResponseServices();
        ParticipantService _serPar = new ParticipantService();
        ExamServices _serExam = new ExamServices();
        ExamDetailServices _serExamDetail = new ExamDetailServices();
        SubjectServices _serSubjects = new SubjectServices();

        public Result_Overview()
        {
            InitializeComponent();
            loadData();
            radLblSumPassed.Text = _serResponses.GetAllExamResponse().Where(x => x.IsPassed == true).ToList().Count.ToString();
            radLblSumFail.Text = _serResponses.GetAllExamResponse().Where(x => x.IsPassed == false).ToList().Count.ToString();
            radLblExamSum.Text = _serResponses.GetAllExamResponse().Count.ToString();
            radLblParSum.Text = _serResponses.GetAllExamResponse().GroupBy(x => x.ParticipantId).ToList().Count.ToString();

        }

        public void loadData()
        {
            radGridView.Rows.Clear();

            radGridView.ColumnCount = 5;

            int stt = 1;

            radGridView.Columns[0].HeaderText = "STT";
            radGridView.Columns[1].HeaderText = "Tên Thí Sinh";
            radGridView.Columns[2].HeaderText = "Tên Bài Thi";
            radGridView.Columns[3].HeaderText = "Tên Môn";
            radGridView.Columns[4].HeaderText = "Điểm";
            radGridView.Columns[3].Name = "Proper";
            radGridView.Columns[4].Name = "Proper2";

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("Proper", ListSortDirection.Ascending);
            radGridView.GroupDescriptors.Add(groupDescriptor);

            foreach (var x in _serResponses.GetAllExamResponse().OrderByDescending(x=>x.Score).ToList())
            {


                string name = _serExam.GetById(_serExamDetail.GetById(x.ExamDetailId).ExamId).Name;
                string nameSubject = _serSubjects.GetOneWithID(x.SubjectId.ToString()).Name;
                radGridView.Rows.Add(stt++, _serPar.getAllStudents().Where(a => a.Id == x.ParticipantId).Select(b => b.FullName).FirstOrDefault(), name, nameSubject, x.Score);
            }  
        }
    }
}
