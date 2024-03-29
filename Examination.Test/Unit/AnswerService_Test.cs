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



        //CHECK UPDATE FUNCTION



    }

}
