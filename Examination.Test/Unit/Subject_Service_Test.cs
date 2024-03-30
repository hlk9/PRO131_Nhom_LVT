using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Subject_Service_Test
    {
        Examination_BUS.Services.SubjectServices _service;
      

        [SetUp]

        public void Setup()
        {
            _service = new Examination_BUS.Services.SubjectServices();

        }
        //GET SUBJECT
        [Test]
        public void GetAllSubjetc()
        {
            Assert.IsNotNull(_service.GetSubjects());
        }

        //GET By NAme

        [Test]
        public void GetSbjByName()
        {
            Assert.IsNotNull(_service.GetSubjectByName("Tin học"));
        }

        [Test]
        public void GetSbjByName1()
        {
            Assert.IsNotNull(_service.GetSubjectByName("Tiếng Anh sơ cấp"));
        }
  

        [Test]
        public void GetSbjByName2()
        {
            Assert.IsNotNull(_service.GetSubjectByName("Toán sơ cấp"));
        }
        [Test]
        public void GetSbjByName3()
        {
            Assert.IsNull(_service.GetSubjectByName("Toán hình"));
        }
        [Test]
        public void GetSbjByName4()
        {
            Assert.IsNull(_service.GetSubjectByName("Địa lý"));
        }

        //Add

        public void AddSubjetc_Pass()
        {
            Subject sbj = new Subject { Id = "T104", Name = "Toán", Status = 1, Description = "Mô tả 1" };
            Assert.AreEqual(true, _service.AddSub(sbj));
        }

        //DELETE

      

    }
}
