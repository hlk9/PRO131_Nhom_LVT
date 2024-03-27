using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class ExamDetail_Service_Test
    {
        Examination_BUS.Services.ExamDetailServices _service;
        [SetUp]
        public void Setup()
        {
            _service = new Examination_BUS.Services.ExamDetailServices();
        }

        [Test]
        public void GetAllExamDetail()
        {
            Assert.IsNotNull(_service.GetAll());
        }

        [Test]
        public void AddExam_Pass()
        {
            ExamDetail ex = new ExamDetail { ExamDetailCode = "ED002", ExamId = 2, Duration = 90, PassMark = 60.0, TotalQuestion = 30, MaxiumMark = 150.0, CreatedAt = DateTime.Now, CreatedBy = "admin" };
            Assert.AreEqual(true, _service.Add(ex));
        }
    }
}
