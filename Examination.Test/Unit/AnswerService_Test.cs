using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class AnswerService_Test
    {
        Examination_BUS.Services.AnswerServices _service;
        [SetUp]
        public void SetUp()
        {
            _service = new Examination_BUS.Services.AnswerServices();
        }

        [Test]
        public void GetAllAns()
        {
            Assert.IsNotNull(_service.GetAllAnswers());
        }


        //Add Answer thành công, Id tự tăng không cần thêm
        [Test]

        public void AddAns_Test1()
        {
            Answer ans = new Answer { Content = "First Answer", IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin", Status = true, QuestionId =1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer không thành công với Content bỏ trống

        [Test]

        public void AddAns_Test2()
        {
            Answer ans = new Answer { IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin" , Status = true, QuestionId = 1 };
            Assert.AreEqual(false, _service.AddAnswer(ans));
        }

        //Add Answer không thành công với Content là giá trị tối đa với 501 ký tự

        [Test]

        public void AddAns_Test3()
        {
            Answer ans = new Answer { Content= " Lê Quang Liêm Lê Quang Liêm " +
                "Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm" +
                " Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê " +
                "Quang Liêm Lê Quang Liêm  Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê" +
                " Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm" +
                " Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm  Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm" +
                " Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm Lê Quang Liêm LêQ" +
                " Quang Liêm Lê Quang Liêm Lê Quan", 
                IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin",Status = true, QuestionId =1 };
            Assert.AreEqual(false, _service.AddAnswer(ans));


        }

        //Add Answer không thành công với  isCorect bỏ trống

        [Test]

        public void AddAns_Test4()
        {
            Answer ans = new Answer { Content="Lê Quang Liêm", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin", Status = true, QuestionId = 1 };
            Assert.AreEqual(false, _service.AddAnswer(ans));
        }


        //Add Answer thành công với CreateAt bỏ trống

        [Test]

        public void AddAns_Test5()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm",IsCorrect=true , UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin", Status = true, QuestionId = 1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer thành công với UpdateAt bỏ trống

        [Test]

        public void AddAns_Test6()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm", IsCorrect = true, CreatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin", Status = true, QuestionId = 1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer thành công với CreateBy bỏ trống

        [Test]

        public void AddAns_Test7()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm", IsCorrect = true, CreatedAt = DateTime.Now,UpdatedAt =DateTime.Now, UpdatedBy = "admin", Status = true, QuestionId = 1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer thành công với UpdateBy bỏ trống

        [Test]

        public void AddAns_Test8()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm", IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", Status = true, QuestionId = 1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer thành công với Status bỏ trống

        [Test]

        public void AddAns_Test9()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm", IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin",UpdatedBy= "admin", QuestionId = 1 };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }

        //Add Answer không thành công với Question bỏ trống

        [Test]

        public void AddAns_Test10()
        {
            Answer ans = new Answer { Content = "Lê Quang Liêm", IsCorrect = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "admin", UpdatedBy = "admin", Status = true };
            Assert.AreEqual(false, _service.AddAnswer(ans));
        }



        //CHECK delete FUNCTION

        [Test]
        public void Delete_Test1()
        {
            Assert.AreEqual(true, _service.DeleteAnswer(1));
        }

        [Test]
        public void Delete_Test2()
        {
            Assert.AreEqual(true, _service.DeleteAnswer(10));
        }


        [Test]
        public void Delete_Test3()
        {
            Assert.AreEqual(true, _service.DeleteAnswer(20));
        }

        [Test]
        public void Delete_Test4()
        {
            Assert.AreEqual(false, _service.DeleteAnswer(0));
        }

        [Test]
        public void Delete_Test5()
        {
            Assert.AreEqual(false, _service.DeleteAnswer(100));
        }
        //GetById

        [Test]
        public void GetById_Test()
        {
            Assert.IsNotNull(_service.GetAnswerById(1));
        }


        [Test]
        public void GetById_Test1()
        {
            Assert.IsNotNull(_service.GetAnswerById(1));
        }


        [Test]
        public void GetById_Test2()
        {
            Assert.IsNotNull(_service.GetAnswerById(10));
        }



        [Test]
        public void GetById_Test3()
        {
            Assert.IsNotNull(_service.GetAnswerById(12));
        }


        [Test]
        public void GetById_Test4()
        {
            Assert.IsNull(_service.GetAnswerById(0));
        }

        [Test]
        public void GetById_Test5()
        {
            Assert.IsNull(_service.GetAnswerById(100));
        }

        //Update

        [Test]

        public void Update_Test1()
        {
            Answer answer = new Answer()
            {
                Id = 1,
                Content = "Content1",
                IsCorrect = false,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Đức",
                CreatedAt = DateTime.Now,
                CreatedBy = "Đức",
                Status = false,
                QuestionId = 10
            };

            Assert.AreEqual(true,_service.UpdateAnswer(answer));
        }


        [Test]

        public void Update_Test2()
        {
            Answer answer = new Answer()
            {
                Id = 1,
                Content = "Content1",
             
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Đức",
                CreatedAt = DateTime.Now,
                CreatedBy = "Đức",
                Status = false,
                QuestionId = 10
            };

            Assert.AreEqual(false, _service.UpdateAnswer(answer));
        }


        [Test]

        public void Update_Test3()
        {
            Answer answer = new Answer()
            {
                Id = 1,
                Content = "Content1",
                IsCorrect = false,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Đức",
                CreatedAt = DateTime.Now,
                CreatedBy = "Đức",
                Status = false,
              
            };

            Assert.AreEqual(false, _service.UpdateAnswer(answer));
        }


    }

}
