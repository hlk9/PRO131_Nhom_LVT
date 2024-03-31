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
    }
}
