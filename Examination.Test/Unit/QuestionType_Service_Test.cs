using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class QuestionType_Service_Test
    {
        QuestionTypeServices _serQuestionType;

        [SetUp]
        public void SetUp()
        {
            _serQuestionType = new QuestionTypeServices();
        }

        // Test function GetAll
        [Test]
        public void GetAll()
        {
            Assert.IsNotNull(_serQuestionType.GetAll());
        }

        // Test function GetById
        [Test]
        public void GetById()
        {
            Assert.IsNotNull(_serQuestionType.GetById(1));
        }

        [Test]
        public void GetById_Test1()
        {
            Assert.IsNotNull(_serQuestionType.GetById(2));
        }

        [Test]
        public void GetById_Test2()
        {
            Assert.IsNotNull(_serQuestionType.GetById(3));
        }

        [Test]
        public void GetById_Test4()
        {
            Assert.IsNull(_serQuestionType.GetById(10));
        }

        [Test]
        public void GetById_Test5()
        {
            Assert.IsNull(_serQuestionType.GetById(0));
        }

        [Test]
        public void GetById_Test6()
        {
            Assert.IsNull(_serQuestionType.GetById(byte.MaxValue));
        }

        // Test function GetQuestionTypeNameById
        [Test]
        public void GetQuestionTypeNameById_Test1()
        {
            Assert.AreEqual("Chọn câu trả lời đúng nhất", _serQuestionType.GetQuestionTypeNameById(1));
        }

        [Test]
        public void GetQuestionTypeNameById_Test2()
        {
            Assert.AreEqual("Chọn các đáp án đúng", _serQuestionType.GetQuestionTypeNameById(2));
        }

        [Test]
        public void GetQuestionTypeNameById_Test3()
        {
            Assert.AreEqual("Chọn Đúng hoặc Sai", _serQuestionType.GetQuestionTypeNameById(3));
        }

        // Test Function Add
        [Test] 
        public void Add_Test()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "Chọn câu trả lời khác",
                Id = 4
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test1()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "Chọn câu trả lời sai",
                Id = Convert.ToByte(null)
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test2()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = ""
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test3()
        {
            QuestionType questionType = new QuestionType();
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test4()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "abfdkjgjdkgdjfskgbvfdjgberyhfbgdfhjgbfdhgbjfdgjskfd"
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test5()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "Chọn câu hỏi chủ ngữ",
                Id = Convert.ToByte(byte.MaxValue)
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test6()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "Chọn câu hỏi chủ ngữ",
                Id = 0
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test7()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "Chọn"
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test8()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "       Chọn câu hỏi chủ ngữ     "
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        [Test]
        public void Add_Test9()
        {
            QuestionType questionType = new QuestionType()
            {
                Name = "       "
            };
            Assert.AreEqual(false, _serQuestionType.Add(questionType));
        }

        //Test fuction Update
        [Test]
        public void Update_Test1()
        {
            QuestionType questionType = new QuestionType()
            {
                Id = 1,
                Name = "Chọn câu hỏi chủ ngữ"
            };
            Assert.AreEqual(true, _serQuestionType.Update(questionType));
        }

        [Test]
        public void Update_Test2()
        {
            QuestionType questionType = new QuestionType()
            {
                Id = 5,
                Name = "       "
            };
            Assert.AreEqual(false, _serQuestionType.Update(questionType));
        }

        [Test]
        public void Update_Test3()
        {
            QuestionType questionType = new QuestionType()
            {
                Id = 7,
                Name = ""
            };
            Assert.AreEqual(false, _serQuestionType.Update(questionType));
        }

        [Test]
        public void Update_Test4()
        {
            QuestionType questionType = new QuestionType()
            {
                Id = 6,
                Name = "abfdkjgjdkgdjfskgbvfdjgberyhfbgdfhjgbfdhgbjfdgjskfd"
            };
            Assert.AreEqual(false, _serQuestionType.Update(questionType));
        }

        [Test]
        public void Update_Test5()
        {
            QuestionType questionType = new QuestionType()
            {
                Id = 6,
                Name = "    Câu hỏi khác câu còn lại      "
            };
            Assert.AreEqual(false, _serQuestionType.Update(questionType));
        }

        //Test function remove
        [Test]
        public void Delete_Test1()
        {
            Assert.AreEqual(false, _serQuestionType.DeleteById(0));
        }

        [Test]
        public void Delete_Test2()
        {
            Assert.AreEqual(false, _serQuestionType.DeleteById(11));
        }

        [Test]
        public void Delete_Test3()
        {
            Assert.AreEqual(false, _serQuestionType.DeleteById(byte.MaxValue));
        }

        [Test]
        public void Delete_Test4()
        {
            Assert.AreEqual(true, _serQuestionType.DeleteById(5));
        }
    }
}
