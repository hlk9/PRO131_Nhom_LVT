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
        //Add feedback k thành công với Title là giá trị tối đa với  256 ký tự

        [Test]

        public void AddFeedback_Test3()
        {
            Feedback fb = new Feedback { Title = "Đánh giá sau sử dụng", Name = "Lê Huỳnh Đức", IdParticipant = "PH32245", Content = "Nội dung 1", SubmitTime = DateTime.Now, Status = true };
            Assert.AreEqual(false, _service.Send(fb));
        }
    }
}
