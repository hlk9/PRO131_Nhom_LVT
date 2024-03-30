using Examination_DAL.IRepository;
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

        //CHECK ADD FUNCTION
        //Add thành công với các trường hợp lệ, không cần nhập Id vì Id tự tăng
        [Test]
        public void AddAnsRespone_Pass()
        {
            AnswerResponse answerResponse = new AnswerResponse {  IsCorrect= false,QuestionId =11 ,AnswerId =40, ExamResponseId=1, AnswerAt = DateTime.Now };
            Assert.AreEqual(true, _service.AddAnswerResponse(answerResponse));
        }

        //Add thành công với AnswerId bị bỏ trống

        [Test]


        public void AddAnsRespone_Pass1()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 13, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(true, _service.AddAnswerResponse(answerResponse));
        }

        //Add thành công với IsCorrect bỏ trống , các trường còn lại nhập hợp lệ, 
        [Test]
        public void AddAnsRespone_Pass_2()
        {
            AnswerResponse answerResponse = new AnswerResponse { QuestionId = 14, AnswerId = 55, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(true, _service.AddAnswerResponse(answerResponse));
        }

        //Add thành công với AnswerAt bị bỏ trống
        [Test]
        public void AddAnsRespone_Pass_3()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 15, AnswerId = 42, ExamResponseId = 1};
            Assert.AreEqual(true, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với AnswerResponse.QuestionId là số âm, các trường còn lại nhập hợp lệ, không cần nhập Id vì Id tự tăng

        [Test]
        public void AddAnsRespone_Fail_1()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = -1, AnswerId = 2, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));


        }

        //Add không thành công với QuestionId bỏ trống , các trường còn lại nhập hợp lệ, 
        [Test]
        public void AddAnsRespone_Fail_2()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = false, AnswerId = 2, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }


        

        //Add không thành công với AnswerId là số âm, các trường còn lại nhập hợp lệ, 
        [Test]

        public void AddAnsRespone_Fail_3()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect=true, QuestionId = 13, AnswerId = -2, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với ExamResponseId là số âm, các trường còn lại nhập hợp lệ,
        [Test]

        public void AddAnsRespone_Fail_4()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 13, AnswerId = 2, ExamResponseId = -1, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }



        //Add không thành công với tất cả các trường dữ liệu bỏ trống
        [Test]

        public void AddAnsRespone_Fail_5()
        {
            AnswerResponse answerResponse = new AnswerResponse { };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với ExamResponseId bỏ trống, các trường còn lại nhập hợp lệ,
        [Test]

        public void AddAnsRespone_Fail_6()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 50, AnswerId = 4, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với ExamResponseId =0, các trường còn lại nhập hợp lệ,


        [Test]

        public void AddAnsRespone_Fail_7()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 50, AnswerId = 4, ExamResponseId = 0, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với QuestionId = 0, các trường còn lại nhập hợp lệ,


        [Test]

        public void AddAnsRespone_Fail_8()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 0, AnswerId = 4, ExamResponseId = 1, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }

        //Add không thành công với AnswerId = 0, các trường còn lại nhập hợp lệ,


        [Test]

        public void AddAnsRespone_Fail_9()
        {
            AnswerResponse answerResponse = new AnswerResponse { IsCorrect = true, QuestionId = 51, AnswerId = 0, ExamResponseId =11, AnswerAt = DateTime.Now };
            Assert.AreEqual(false, _service.AddAnswerResponse(answerResponse));
        }




        //CHECK UPDATE FUNCTION


        //Update không thành công với AnswerId là số âm
        [Test]        
        
        public void UpdateAnsResponse_Test1()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 1,
                IsCorrect = true,
                QuestionId = 1,
                AnswerId = -1,
                ExamResponseId = 1,
                AnswerAt = DateTime.Now
            };
            Assert.AreEqual(false, _service.UpdateAnswerResponse(answer));
        }

        //Update khoogn thành công với QuestionId là số âm
        [Test]
        public void UpdateAnsResponse_Test2()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 1,
                IsCorrect = true,
                QuestionId = -1,
                AnswerId = 1,
                ExamResponseId = 1,
                AnswerAt = DateTime.Now
            };
            Assert.AreEqual(false, _service.UpdateAnswerResponse(answer));
        }

        //Update không thành công với ExamResponseId là số âm
        [Test]
        public void UpdateAnsResponse_Test3()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 1,
                IsCorrect = true,
                QuestionId = 1,
                AnswerId = 1,
                ExamResponseId = -1,
                AnswerAt = DateTime.Now
            };
            Assert.AreEqual(false, _service.UpdateAnswerResponse(answer));
        }

        //Update thành công với AnswerAt bị bỏ trống
        [Test]

        public void UpdateAnswerResponse_Test4()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 12,
                IsCorrect = true,
                QuestionId = 12,
                AnswerId = 41,
                ExamResponseId = 1
            };
            Assert.AreEqual(true, _service.UpdateAnswerResponse(answer));

        }

        //Update thành công với AnswerId bị bỏ trống
        [Test]

        public void UpdateAnswerResponse_Test5()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 12,
                IsCorrect = true,
                QuestionId = 12,
                ExamResponseId = 1,
                AnswerAt = DateTime.Now
                
            };
            Assert.AreEqual(true, _service.UpdateAnswerResponse(answer));

        }

        //Update thành công với IsCorrect bị bỏ trống
        [Test]

        public void UpdateAnswerResponse_Test6()
        {
            AnswerResponse answer = new AnswerResponse()
            {
                Id = 12,
                QuestionId = 12,
                ExamResponseId = 1,
                AnswerAt = DateTime.Now

            };
            Assert.AreEqual(true, _service.UpdateAnswerResponse(answer));

        }

        //Check function Delete

        [Test]

        public void Delete_1()
        {
            Assert.AreEqual(true, _service.DeleteAnswerResponse(1));

        }
 

        public void Delete_2()
        {
            Assert.AreEqual(false, _service.DeleteAnswerResponse(0));
        }
        [Test]

        public void Delete_3()
        {
            Assert.AreEqual(false, _service.DeleteAnswerResponse(-100));
        }

        //GET ID
        [Test]
        public void GetById1()
        {
            Assert.IsNotNull(_service.GetAnswerResponseById(1));

        }

        [Test]
        public void GetById2()
        {
            Assert.IsNotNull(_service.GetAnswerResponseById(10));
        }

        [Test]
        public void GetById3()
        {
            Assert.IsNotNull(_service.GetAnswerResponseById(12));
        }



        [Test]
        public void GetById4()
        {
            Assert.IsNull(_service.GetAnswerResponseById(0));
        }

        [Test]
        public void GetById5()
        {
            Assert.IsNull(_service.GetAnswerResponseById(byte.MaxValue));
        }





    }
}
