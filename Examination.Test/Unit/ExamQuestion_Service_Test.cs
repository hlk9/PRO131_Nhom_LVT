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

            //question.Id = " admin ";
            //question.Content = " Kiem Tra Mot Tiet";
            //question.Point = " 10";
            //question.QuestionType = " Trắc Nghiệm";
            //question.QuestionLevel = "Trung Bình";
            //question.Subject = "Toán";
            //question.Docs = "Hình Học Không gian";
            //question.CreatedTime = "19/03/2024"
            //question.ModifiedTime = "20/03/2024";
            //question.CreatedBy = "GV CXH";
            //question.ModifiedBy = "GV CXH";
            //question.Status = "1";

            //Assert.AreEqual(true, _service.AddExamQuestion());
        }
    }
}
