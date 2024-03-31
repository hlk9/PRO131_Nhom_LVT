using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Schedule_Service_Test
    {
        Examination_BUS.Services.ScheduleServices _service;
        [SetUp]
        public void SetUp()
        {
            _service = new Examination_BUS.Services.ScheduleServices();
        }

        [Test]
        public void GetAllSchedule()
        {
            Assert.IsNotNull(_service.GetAllSchedule());
        }
        [Test]
        public void Add_Pass()
        {
            ExamSchedule examSchedule = new ExamSchedule { StartTime = new DateTime(2024, 03, 16, 14, 00, 00), EndTime = new DateTime(2024, 03, 16, 16, 00, 00),Name ="HOp", 
                
                Description = "Bài thi giữa kì môn toán",Status = true, CreatedBy = "Auto",ExamId = 18,Subject = "Toán Sơ Cấp" };
            

            Assert.AreEqual(true, _service.AddSchedule(examSchedule));
        }

        [Test]
        public void Add_Fail_1()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new (2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "";
            examSchedule.Description = "Bài thi giữa kì môn toán";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }

        [Test]
        public void Add_Fail_2()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Kì thi giữ kì môn toán";
            examSchedule.Description = "Bài thi giữa kì môn toán";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }

        [Test]
        public void Add_Fail_3()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Kì thi giữ kì môn toán";
            examSchedule.Description = "Bài thi giữa kì môn toán";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "EOEOEOEOEOEOEOOOOOOOOOOOOOOOOOOOOOOOOOsadfghbsdfgnbsfdghdsfxghsfdgnSDgfsadfbsdfgbsdfgbsfgd";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }


        [Test]
        public void Add_Fail_4()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Kì thi giữ kì môn toán danh cho trẻ em trên 20 tuổi có học vấn trình độ Sư Phạm, Đặc biệt là Fan MU và Fan của Chị 7777777777777777777777777777777777777777";
            examSchedule.Description = "Bài thi giữa kì môn toán";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }

        [Test]
        public void Add_Fail_5()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Kì thi giữ kì môn toán";
            examSchedule.Description = "Bài thi giữa kì môn toánnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnmmmmmmmmmmmmmmm";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Ngữ Văn";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }

        [Test]
        public void Add_Fail_6()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Kì thi giữ kì môn toán";
            examSchedule.Description = "Bài Thi giữa kì môn Văn";
            examSchedule.ExamRoomId = "";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Ngữ Văn";

            Assert.AreEqual(false, _service.AddSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_1()
        {
            ExamSchedule examSchedule = new ExamSchedule
            {
                StartTime = new DateTime(2024, 03, 16, 14, 00, 00),
                EndTime = new DateTime(2024, 03, 16, 16, 00, 00),
                Name = "",
                Description = "Bài Thi giữa kì môn Văn",
                ExamRoomId = "P301",
                Status = true,
                CreatedBy = "Auto",
                ExamId = 18,
                Subject = "Ngữ Văn"
            };

            

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_2()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon toan";
            examSchedule.Description = "Bài Thi giữa kì môn Văn";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_3()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon toan";
            examSchedule.Description = "Bài Thi giữa kì môn Văn";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "aadsfgasdafghadfhasdnrtadfadftgnsdgfsndghsdfskduygvalsdfcbasdjfhasvdjfajsdhfvasd";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_4()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon toanaadsfgasdafghadfhasdnrtadfadftgnsdgfsndghsdfskduygvalsdfcbasdjfhasvdjfajsdhfvasd";
            examSchedule.Description = "Bài Thi giữa kì môn Văn";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_5()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_6()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "anhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhassssssssssssssssssss";
            examSchedule.ExamRoomId = "P301";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_7()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_8()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "P102";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "Auto";
            examSchedule.ExamId = 0;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_9()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "P102";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }


        [Test]
        public void Update_Fail_10()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh@@@@###*(&%*";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "P102";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_11()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Pha@@@@###*(&%*";
            examSchedule.ExamRoomId = "P102";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_12()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(2024, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(2024, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "P10@@@@###*(&%*";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Update_Fail_13()
        {
            ExamSchedule examSchedule = new ExamSchedule();

            examSchedule.StartTime = new DateTime(4000, 03, 16, 14, 00, 00);
            examSchedule.EndTime = new DateTime(4000, 03, 16, 16, 00, 00);
            examSchedule.Name = "Ki Thi giua ki mon Anh";
            examSchedule.Description = "Bài Thi Ngu Phap";
            examSchedule.ExamRoomId = "P10";
            examSchedule.Status = true;
            examSchedule.CreatedBy = "";
            examSchedule.ExamId = 18;
            examSchedule.Subject = "Toán Sơ Cấp@@@@###*(&%$%^%";

            Assert.AreEqual(false, _service.UpdateSchedule(examSchedule));

        }

        [Test]
        public void Delete_Fail_1()
        {
            Assert.AreEqual(false, _service.DeleteSchedule(110));
        }
        [Test]
        public void Delete_Fail_2()
        {
            Assert.AreEqual(false, _service.DeleteSchedule(999999));
        }
        [Test]
        public void Delete_Fail_3()
        {
            Assert.AreEqual(false, _service.DeleteSchedule(0));
        }
        [Test]
        public void Delete_Fail_4()
        {
            Assert.AreEqual(false, _service.DeleteSchedule(-110));
        }



    }
}
