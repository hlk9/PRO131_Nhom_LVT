using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        [Test]

        public void AddSubject_Pass()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("PRO132", "KTNC", 1);



        }

        [Test]

        public void AddSubject_Test1()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("", "KTNC", 1);



        }

        [Test]

        public void AddSubject_Test3()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("On a sunny morning, the young girl stepped out of the small" +
                " gate of the ancient house. Her white Ao Dai fluttered lightly in the wind," +
                " her long black hair swaying with the cool breeze. She looked up at the deep blue sky," +
                " smiled, and walked away with the belief that today would be a wonderful day", "KTNC", 1);



        }


        [Test]

        public void AddSubject_Test4()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("PRO132", "", 1);



        }
        [Test]

        public void AddSubject_Test5()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("PRO132", " On a sunny morning, the young girl stepped out of the small gate of the ancient house." +
                " Her white Ao Dai fluttered lightly in the wind, her long black hair swaying with the cool breeze." +
                " She looked up at the deep blue sky, smiled, and walked away with the belief that today would be a wonderful day", 1);



        }

        [Test]

        public void AddSubject_Test6()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("", " ", 1);





        }
        [Test]

        public void AddSubject_Test7()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("MATH-01", "KTNC ", 1);




        }

        [Test]

        public void AddSubject_Test8()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.AddSub("PRO132", "KT@E#@#NC ", 1);



        }



        //DELETE

        [Test]

        public void DeleteSub()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.RemoveSub("PRO132");
        }

        //Update 

        [Test]
        public void UpdateSub()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.EditSub("PRO132", "Math", 1);
        }


        [Test]
        public void UpdateSub1()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.EditSub("PRO132", "", 1);
        }

        [Test]
        public void UpdateSub2()
        {
            SubjectServices _ser = new SubjectServices();
            _ser.EditSub("PRO132", "On a sunny morning, the young girl stepped out of the small gate of the ancient house. Her white Ao" +
                " Dai fluttered lightly in the wind, her long black hair swaying with the cool breeze" +
                ". She looked up at the deep blue sky, smiled, and walked away with the belief that today would be a wonderful day", 1);
        }

        //GétubjectByName

        //[Test]
        //public void GetSubjetcByName()
        //{
        //    SubjectServices _ser = new SubjectServices();
        //    _ser.GetSubjectByName("Tin học");


        //}
        //[Test]
        //public void GetSubjetcByName1()
        //{
        //    SubjectServices _ser = new SubjectServices();
        //    _ser.GetSubjectByName("Tiếng Anh sơ cấp");
        //}

        //[Test]
        //public void GetSubjetcByName2()
        //{
        //    SubjectServices _ser = new SubjectServices();
        //    _ser.GetSubjectByName("Toán sơ cấp");
        //}

        //[Test]
        //public void GetSubjetcByName3()
        //{
        //    SubjectServices _ser = new SubjectServices();
        //    _ser.GetSubjectByName("Toán hình hahaha");

        //}
        //[Test]
        //public void GetSubjetcByName4()
        //{
        //    SubjectServices _ser = new SubjectServices();
        //    _ser.GetSubjectByName("Địa lý hahaha");
        //}


    }
}
