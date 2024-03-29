using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class QuestionLevel_Service_Test
    {
        QuestionLevelService _serQuestionLevel;

        [SetUp]
        public void Run()
        {
            _serQuestionLevel = new QuestionLevelService();
        }

        //Test function GetAll
        [Test]
        public void GetAll_Test() 
        {
            Assert.IsNotNull(_serQuestionLevel.GetAll());
        }

        //Test fuction GetById
        [Test]
        public void GetById()
        {
            Assert.IsNotNull(_serQuestionLevel.GetById(1));
        }

        [Test]
        public void GetById_Test1()
        {
            Assert.IsNotNull(_serQuestionLevel.GetById(2));
        }

        [Test]
        public void GetById_Test2()
        {
            Assert.IsNotNull(_serQuestionLevel.GetById(3));
        }

        [Test]
        public void GetById_Test4()
        {
            Assert.IsNull(_serQuestionLevel.GetById(10));
        }

        [Test]
        public void GetById_Test5()
        {
            Assert.IsNull(_serQuestionLevel.GetById(0));
        }

        [Test]
        public void GetById_Test6()
        {
            Assert.IsNull(_serQuestionLevel.GetById(byte.MaxValue));
        }

        //Test function addQuestion
        [Test]
        public void Add_Test()
        {
            QuestionLevel questionLevel = new QuestionLevel() 
            {
                Id = 50,
                Name = "Cực Khó",
            };

            Assert.AreEqual(true, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test2()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 60,
                Name = "Cực kỳ Khó",
            };

            Assert.AreEqual(true, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test3()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 0,
                Name = "Siêu Dễ",
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test4()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 102,
                Name = ""
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test5()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 101,
                Name = "          "
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test6()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 100,
                Name = "     Mức trung bình     "
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test7()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Id = 115,
                Name = "dasgfdgdsgdfsgdfgbfhgfgsdkhjfgbdshkjfgbdshkjfvbkhjdbgvuhdsfgbuyesahgbrfhjsdbvf hjdsfvfgbdhdjgvbdhfkjgbvuhdfgbvjkdb gvjhdcbgvhjdsfbvjxczbvhfjdszbfvgdbsgfhuearbuyfsdbgv dfjhngbv dfhjbvhjxcbvhljdfgbyuergdjcbvhnhjcxvbjdhfgvbdhjgvyurbgdfvhjdfbhvjdfbjkvbfdjgvbdf"
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        [Test]
        public void Add_Test8()
        {
            QuestionLevel questionLevel = new QuestionLevel()
            {
                Name = "D"
            };

            Assert.AreEqual(false, _serQuestionLevel.Add(questionLevel));
        }

        //Test fuction DeleteById
        [Test]
        public void Delete_Test1()
        {
            Assert.AreEqual(true, _serQuestionLevel.DeleteById(150));
        }

        [Test]
        public void Delete_Test2()
        {
            Assert.AreEqual(true, _serQuestionLevel.DeleteById(151));
        }

        [Test]
        public void Delete_Test3()
        {
            Assert.AreEqual(false, _serQuestionLevel.DeleteById(0));
        }

        [Test]
        public void Delete_Test4()
        {
            Assert.AreEqual(false, _serQuestionLevel.DeleteById(254));
        }
    }
}
