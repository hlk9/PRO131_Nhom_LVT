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

        //[Test]
        //public void GetAllSubjetc()
        //{
        //    Assert.IsNotNull(_service.GetSubjects());
        //}

        //[Test]

        //public void AddSubjetc_Pass()
        //{
        //    Subject sbj = new Subject { Id = "T104", Name="Toán",Status = 1, Description = "Mô tả 1"};
        //    //Assert.AreEqual(true, _service.AddSub(sbj));
        //}
    }
}
