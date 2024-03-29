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

        [Test]
        public void AddExam_Fail()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = " ",
                ExamId = 1,
                Duration = 60,
                PassMark = 50.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }

        [Test]
        public void AddExam_Fail_1()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001E",
                ExamId = 1,
                Duration = 60,
                PassMark = 50.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }

        [Test]
        public void AddExam_Fail_2()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 0,
                PassMark = 50.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }

        [Test]
        public void AddExam_Fail_3()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 50.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }


        [Test]
        public void AddExam_Fail_4()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = -10.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }

        [Test]
        public void AddExam_Fail_5()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 10.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "adminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadmin"
            };

            Assert.AreEqual(false, _service.Add(ex));
        }


        [Test]
        public void UpdateExam_Fail_1()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 10.0,
                TotalQuestion = 0,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Update(ex));
        }

        [Test]
        public void UpdateExam_Fail_2()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 10.0,
                TotalQuestion = 20,
                MaxiumMark = -10.0,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Update(ex));
        }

        [Test]
        public void UpdateExam_Fail_3()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark =-10.0,
                TotalQuestion = 20,
                MaxiumMark = 100,
                CreatedAt = DateTime.Now,
                CreatedBy = "admin"
            };

            Assert.AreEqual(false, _service.Update(ex));
        }

        [Test]
        public void UpdateExam_Fail_4()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 10.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy =  "adminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadminadmin"
            };

            Assert.AreEqual(false, _service.Update(ex));
        }

        [Test]
        public void UpdateExam_Fail_5()
        {
            ExamDetail ex = new ExamDetail
            {
                ExamDetailCode = "ED001",
                ExamId = 1,
                Duration = 60,
                PassMark = 10.0,
                TotalQuestion = 20,
                MaxiumMark = 100.0,
                CreatedAt = DateTime.Now,
                CreatedBy = " ",
            };

            Assert.AreEqual(false, _service.Update(ex));
        }

        [Test]
        public void DeleteExam_Pass_1()
        {
                      Assert.AreEqual(true, _service.Delete(1));
        }

        [Test]
        public void DeleteExam_Fail_1()
        {
            Assert.AreEqual(false, _service.Delete(0));
        }
        [Test]
        public void DeleteExam_Fail_2()
        {
            Assert.AreEqual(false, _service.Delete(-100));
        }
        [Test]
        public void DeleteExam_Fail_3()
        {
            Assert.AreEqual(false, _service.Delete(2222222));
        }

        [Test]
        public void DeleteExam_Fail_4()
        {
            Assert.AreEqual(false, _service.Delete(100));
        }
    }
}
