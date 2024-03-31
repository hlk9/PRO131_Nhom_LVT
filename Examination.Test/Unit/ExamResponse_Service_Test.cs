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

            exRes.Id = 16;
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

        [Test]
        public void AddExam_Fail_1()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = 17;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;

            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_2()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = 12;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;

            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_3()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = 13;
            exRes.ExamDetailId = 2147483647;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_4()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = 187;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "ssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_5()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = -2147483647;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;

            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Pass_6()
        {
            ExamResponse exRes = new ExamResponse();
          
            exRes.ExamDetailId = 31;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MATH-LV-1";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;
            Assert.AreEqual(true, _service.AddExamResponse(exRes));
        }


        [Test]
        public void AddExam_Fail_6()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = 53;
            exRes.ExamDetailId =1 ;
            exRes.ParticipantId = "";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;

            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_7()
        {
            ExamResponse exRes = new ExamResponse();
            exRes.Id = 187;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "ddddddddddddddddddddddddddddddddddddddddddddddddddddddd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2024/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_8()
        {
            ExamResponse exRes = new ExamResponse();      
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("1000/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_9()
        {
            ExamResponse exRes = new ExamResponse();
          
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth0sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss1";
            exRes.SubmitTime = DateTime.Parse("2023/02/12");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_10()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = -999999991;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2023/01/02");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_11()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = -999999991;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2023/01/02");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }


        [Test]
        public void AddExam_Fail_12()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = 2147483647;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2023/01/02");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }



        [Test]
        public void AddExam_Fail_13()
        {
            ExamResponse exRes = new ExamResponse();

            exRes.Id = 2147483647;
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("2023/01/02");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.AreEqual(false, _service.AddExamResponse(exRes));
        }

        [Test]
        public void AddExam_Fail_14()
        {
            ExamResponse exRes = new ExamResponse();

    
            exRes.ExamDetailId = 1;
            exRes.ParticipantId = "longhd";
            exRes.SubjectId = "MAth01";
            exRes.SubmitTime = DateTime.Parse("19/13/2024");
            exRes.Score = 10;
            exRes.Status = 1;
            exRes.QuestionCorrect = 10;
            exRes.QuestionWrong = 0;
            exRes.QuestionNotAnswered = 0;
            exRes.ScoredBy = "";
            exRes.FinishTime = 10;
            exRes.ScoredMethod = true;
            exRes.Note = "Không";
            exRes.ExamScheduleId = 1;


            Assert.Throws<Exception>(() =>
            {
                _service.AddExamResponse(exRes);
            });
           
        }

    }
}
