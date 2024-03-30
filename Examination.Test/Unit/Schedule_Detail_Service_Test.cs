using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public  class Schedule_Detail_Service_Test
    {
        Examination_BUS.Services.ScheduleDetailServices _service;
        [SetUp]
        public void SetUp()
        {
            _service = new Examination_BUS.Services.ScheduleDetailServices();
        }


        [Test]
        public void GetAllScheduleDetails()
        {
            Assert.IsNotNull(_service.GetAllScheduleDetails());
        }


        [Test]
        public void Add_Fail_1()
        {
                ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 1;
            examScheduleDetail.ExamScheduleId = 1;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_2()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 0;
            examScheduleDetail.ExamScheduleId = 1;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }
        [Test]
        public void Add_Fail_3()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 0;
            examScheduleDetail.ExamScheduleId = 0;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }
        [Test]
        public void Add_Fail_4()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 0;
            examScheduleDetail.ExamScheduleId = 0;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_5()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 9999999;
            examScheduleDetail.ExamScheduleId = 0;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_6()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = -9999999;
            examScheduleDetail.ExamScheduleId = 0;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_7()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 1;
            examScheduleDetail.ExamScheduleId = -11111110;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

       [Test]
        public void Add_Fail_8()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 1;
            examScheduleDetail.ExamScheduleId = -11111110;
            examScheduleDetail.ParticipantId = "TF1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_9()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 1;
            examScheduleDetail.ExamScheduleId = -11111110;
            examScheduleDetail.ParticipantId = "TF!!#%#%#%$#1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Add_Fail_10()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id =1999999;
            examScheduleDetail.ExamScheduleId = -11111110;
            examScheduleDetail.ParticipantId = "TF!!#%#%#%$#1";

            Assert.AreEqual(false, _service.AddScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Update_Fail_1()
        {
            ExamScheduleDetail examScheduleDetail = new ExamScheduleDetail();

            examScheduleDetail.Id = 1;
            examScheduleDetail.ExamScheduleId = -1;
            examScheduleDetail.ParticipantId = "TF!!#%#%#%$#1";

            Assert.AreEqual(false, _service.UpdateScheduleDetail(examScheduleDetail));
        }

        [Test]
        public void Delete_Fail_1()
        {
            Assert.AreEqual(false, _service.DeleteScheduleDetail(0));
        }

        [Test]
        public void Delete_Fail_2()
        {
            Assert.AreEqual(false, _service.DeleteScheduleDetail(-100));
        }

        [Test]
        public void Delete_Fail_3()
        {
            Assert.AreEqual(false, _service.DeleteScheduleDetail(44444));
        }

        [Test]
        public void Delete_Fail_4()
        {
            Assert.AreEqual(false, _service.DeleteScheduleDetail(110));
        }

       







    }
}
