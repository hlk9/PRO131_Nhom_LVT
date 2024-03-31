using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class AnswerResponse_Service_Test
    {
        Examination_BUS.Services.AnswerResponseServices _service;

        [SetUp]

        public void SetUp()
        {
            _service = new Examination_BUS.Services.AnswerResponseServices();

        }

        [Test]
        public void GetAllAnsResponse()
        {
            Assert.IsNotNull(_service.GetAllAnswerResponses());
        }

        [Test]
        public void AddAnsRespone_Pass()
        {
            AnswerResponse ansresponse = new AnswerResponse { Id = 1, IsCorrect= true,QuestionId =1 ,AnswerId =1, ExamResponseId=1, AnswerAt = DateTime.Now };
            Assert.AreEqual(true, _service.AddAnswerResponse(ansresponse));
        }
    }
}
