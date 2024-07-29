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

        [Test]

        public void AddFeedback_Pass()
        {
            Feedback fb = new Feedback {Id=1, Title ="Tiêu đề 1",Name="Lê Huỳnh Đức",IdParticipant="PH32245", Content="Nội dung 1", SubmitTime = DateTime.Now,Status=true };
            Assert.AreEqual(true,_service.Send(fb));
        }
    }
}
