using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class ExamQuestion_Service_Test
    {
        Examination_BUS.Services.ExamQuestionServices _service;
        [SetUp]
        public void Setup()
        {
            _service = new Examination_BUS.Services.ExamQuestionServices();
        }

        [Test]
        public void GetAllExamQuestion()
        {
            Assert.IsNotNull(_service.GetAllExamQuestions());
        }

        [Test]
        public void AddExam_Pass()
        {
            ExamQuestion question = new ExamQuestion();


            question.ExamDetailId = 31;
            question.QuestionId = 5;
            question.Score = 1;

            Assert.AreEqual(true, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_1()
        {
            ExamQuestion question = new ExamQuestion();


            question.Id = 2147483647;
            question.ExamDetailId = 2;
            question.QuestionId = 5;
            question.Score = 1;




            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_2()
        {
            ExamQuestion question = new ExamQuestion();


            question.Id = 1;
            question.ExamDetailId = 2147483647;
            question.QuestionId = 5;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_3()
        {
            ExamQuestion question = new ExamQuestion();


            question.Id = 0;
            question.ExamDetailId = 4;
            question.QuestionId = 5;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }
        [Test]
        public void AddExam_Fail_4()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 3;
            question.QuestionId = 2;
            question.Score = 0;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_5()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 3;
            question.QuestionId = 0;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }
        [Test]
        public void AddExam_Fail_6()
        {
            ExamQuestion question = new ExamQuestion();


            question.Id = -9999;
            question.ExamDetailId = 3;
            question.QuestionId = 7;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_7()
        {
            ExamQuestion question = new ExamQuestion();


          
            question.ExamDetailId = -9999;
            question.QuestionId = 7;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_8()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 0;
            question.QuestionId = 7;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_9()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 5;
            question.QuestionId = 7;
            question.Score = 0;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_10()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 5;
            question.QuestionId = 7;
            question.Score = 2147483647;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }

        [Test]
        public void AddExam_Fail_11()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 5;
            question.QuestionId = 2147483647;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }


        [Test]
        public void AddExam_Fail_12()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 1;
            question.QuestionId = 2147483647;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }


        [Test]
        public void AddExam_Fail_13()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = 4;
            question.QuestionId = 0;
            question.Score = 1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }



        [Test]
        public void AddExam_Fail_14()
        {
            ExamQuestion question = new ExamQuestion();



            question.ExamDetailId = -9994;
            question.QuestionId = -9999;
            question.Score = -1;



            Assert.AreEqual(false, _service.AddExamQuestion(question));
        }


    }
}
