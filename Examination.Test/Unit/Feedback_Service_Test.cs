using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Feedback_Service_Test
    {
        Examination_BUS.Services.FeedbackServices _service;

        [SetUp]

        public void SetUp()
        {
            _service = new Examination_BUS.Services.FeedbackServices();
        }

        [Test]
        public void GetAllFeedback()
        {
            Assert.IsNotNull(_service.GetAll());
        }
        //Add Feedback thành công
        [Test]

        public void AddFeedback_Test1()
        {
            Feedback fb = new Feedback { Title = "Đánh giá sau sử dụng", Name = "Lê Huỳnh Đức", IdParticipant = "PH32245", Content = "Nội dung 1", SubmitTime = DateTime.Now, Status = true };
            Assert.AreEqual(true, _service.Send(fb));
        }

        //Add feedback k thành công với Title là giá trị tối đa với  256 ký tự

        [Test]

        public void AddFeedback_Test2()
        {
            Feedback fb = new Feedback { Title = "Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh giá sau sử dụng Đánh", Name = "Lê Huỳnh Đức", IdParticipant = "PH32245", Content = "Nội dung 1", SubmitTime = DateTime.Now, Status = true };
            Assert.AreEqual(false, _service.Send(fb));


        }
       

        //Add feedback k thành công với Name là giá trị tối đa với  256 ký tự

        [Test]

        public void AddFeedback_Test3()
        {
            Feedback fb = new Feedback { Title = "Đánh giá sau sử dụng", Name = "Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức" +
                " Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnh Đức Lê Huỳnhh",
                IdParticipant = "PH32245", Content = "Phần mềm đẹp, có hơi chậm một xíu", SubmitTime = DateTime.Now, Status = true };
            Assert.AreEqual(false, _service.Send(fb));
        }


        //Add không thành công với IDParticipant là giá trị tối đa với 256 ký tự
        [Test]

        public void AddFeedback_Test4()
        {
            Feedback fb = new Feedback
            {
                Title = "Đánh giá sau sử dụng",
                Name = "Lê Huỳnh Đức",
                IdParticipant = "PH32245123456789123456789ph123456789ph123456789PH32245123456789123456789ph123456789ph123456789PH32245123456789123456789ph123456789ph123456789PH32245123456789123456789ph123456789ph123456789PH32245123456789123456789ph123456789ph123456789PH3224512345678912345",
                Content = "Nội dung 1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với Title bỏ trống
        [Test]

        public void AddFeedback_Test5()
        {
            Feedback fb = new Feedback
            {
              
                Name = "Lê Huỳnh Đức",
                IdParticipant = "PH32245",
                Content = "Nội dung 1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với IdPArticipant  bỏ trống
        [Test]

        public void AddFeedback_Test6()
        {
            Feedback fb = new Feedback
            {
                Title = "Tiêu đề 1",
                Name = "Lê Huỳnh Đức",

                Content = "Nội dung 1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với Content  bỏ trống
        [Test]

        public void AddFeedback_Test7()
        {
            Feedback fb = new Feedback
            {
                Title = "Tiêu đề 1",
                Name = "Lê Huỳnh Đức",
                IdParticipant = "PH32245",
                
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với Name  có ký tự đặc biệt
        [Test]

        public void AddFeedback_Test8()
        {
            Feedback fb = new Feedback
            {
                Title = "Tiêu đề 1",
                Name = "Lê Huỳnh Đức!@#$%^&*",
                IdParticipant = "PH32245",
                Content="Content1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với Name  quá ngắn

        public void AddFeedback_Test9()
        {
            Feedback fb = new Feedback
            {
                Title = "Tiêu đề 1",
                Name = "L",
                IdParticipant = "PH32245",
                Content = "Content1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }

        //Add không thành công với IdParticipant  quá ngắn

        public void AddFeedback_Test10()
        {
            Feedback fb = new Feedback
            {
                Title = "Tiêu đề 1",
                Name = "Lê Huỳnh Đức",
                IdParticipant = "P",
                Content = "Content1",
                SubmitTime = DateTime.Now,
                Status = true
            };
            Assert.AreEqual(false, _service.Send(fb));
        }


        //Get Id thành công
        [Test]
        public void GetById1()
        {
            Assert.IsNotNull(_service.GetFeedBackByID(1));

        }

        [Test]
        public void GetById2()
        {
            Assert.IsNotNull(_service.GetFeedBackByID(2));
        }

        [Test]
        public void GetById3()
        {
            Assert.IsNotNull(_service.GetFeedBackByID(5));
        }

    

        [Test]
        public void GetById4()
        {
            Assert.IsNull(_service.GetFeedBackByID(0));
        }

        [Test]
        public void GetById5()
        {
            Assert.IsNull(_service.GetFeedBackByID(byte.MaxValue));
        }
    }
}
