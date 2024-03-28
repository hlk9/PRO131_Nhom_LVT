using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class ExamResponse_Service_Test
    {
        Examination_BUS.Services.ExamResponseServices _service;
        [SetUp]
        public void Setup()
        {
            _service = new Examination_BUS.Services.ExamResponseServices();
        }

        [Test]
        public void GetAllExamQuestion()
        {
            Assert.IsNotNull(_service.GetAllExamResponse());
        }

        [Test]
        public void AddExam_Pass()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = 1;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("19/03/2024");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod =true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;

            //Assert.AreEqual(true, _service.AddExamQuestion());
        }
    }
}
