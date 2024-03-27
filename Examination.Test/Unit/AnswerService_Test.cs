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

        [Test]

        public void AddAns_Pass()
        {
            Answer ans = new Answer { Id = 1, Content = "First Answer", IsCorrect = true , CreatedAt = DateTime.Now , UpdatedAt = DateTime.Now , CreatedBy="admin" ,UpdatedBy="admin" };
            Assert.AreEqual(true, _service.AddAnswer(ans));
        }
    }
}
