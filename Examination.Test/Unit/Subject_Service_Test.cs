using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Subject_Service_Test
    {
        SubjectServices _serSubject;
        [SetUp]
        public void SetUp()
        {
            _serSubject = new SubjectServices();
        }
        // Get All
        [Test]
        public void GetSubjects_Test1()
        {
            Assert.IsNotNull(_serSubject.GetSubjects());
        }
        // Get ById
        [Test]
        public void GetClassById_Test1()
        {
           Assert.IsNotNull(_serSubject.GetOneWithID("COM1071"));
        }
        [Test]
        public void GetClassById_Test2()
        {
            Assert.IsNotNull(_serSubject.GetOneWithID("MATH-01"));
        }
        [Test]
        public void GetClassById_Test3()
        {
            Assert.IsNotNull(_serSubject.GetOneWithID("MATH-03"));
        }
        [Test]
        public void GetClassById_Test4()
        {
           Assert.IsNull(_serSubject.GetOneWithID(" "));
        }
        [Test]
        public void GetClassById_Test5()
        {
           Assert.IsNull(_serSubject.GetOneWithID("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"));
        }
        // Create
        [Test]
        public void AddSub_Test1()
        {
            Assert.AreEqual(false, _serSubject.AddSub("KTNC", "PRO132", Convert.ToByte(1)));
        }
        [Test]
        public void AddSub_Test2()
        {
            Assert.AreEqual(false, _serSubject.AddSub(" ", "PRO132", Convert.ToByte(1)));
        }
        [Test]
        public void AddSub_Test3()
        {
            Assert.AreEqual(false, _serSubject.AddSub("KTNC", " ", Convert.ToByte(1)));
        }
        [Test]
        public void AddSub_Test4()
        {
            Assert.AreEqual(false, _serSubject.AddSub(" ", " ", Convert.ToByte(1)));
        }
        [Test]
        public void AddSub_Test5()
        {
            Assert.AreEqual(false, _serSubject.AddSub("On a sunny morning, the young girl stepped out of the small gate of the ancient house. Her white Ao Dai fluttered lightly in the wind, her long black hair swaying with the cool breeze. She looked up at the deep blue sky, smiled, and walked away with the belief that today would be a wonderful day.", "PRO132", Convert.ToByte(1)));
        }
        [Test]
        public void AddSub_Test6()
        {
            Assert.AreEqual(false, _serSubject.AddSub("KTNC", "On a sunny morning, the young girl stepped out of the small gate of the ancient house. Her white Ao Dai fluttered lightly in the wind, her long black hair swaying with the cool breeze. She looked up at the deep blue sky, smiled, and walked away with the belief that today would be a wonderful day.", Convert.ToByte(1)));
        }
        // Status ko hợp lệ
        [Test]
        public void AddSub_Test7()
        {
            Assert.AreEqual(true, _serSubject.AddSub("KTNC", "PRO132", Convert.ToByte(-1)));
        }
        [Test]
        public void AddSub_Test8()
        {
            Assert.AreEqual(true, _serSubject.AddSub("KTNC", "PRO132", Convert.ToByte(5)));
        }
        // Trùng ID
        [Test]
        public void AddSub_Test9()
        {
            Assert.AreEqual(true, _serSubject.AddSub("History", "PRO132", Convert.ToByte(2)));
        }
        // Có Ký tự đặc biệt
        [Test]
        public void AddSub_Test10()
        {
            Assert.AreEqual(true, _serSubject.AddSub("KTNC", "PRO1#@!@#32", Convert.ToByte(2)));
        }
        // UpDate
        [Test]
        public void EditSub_Test1()
        {
            Assert.AreEqual(true, _serSubject.EditSub("CAM123", "History", Convert.ToByte(1)));
        }
        [Test]
        public void EditSub_Test2()
        {
            Assert.AreEqual(true, _serSubject.EditSub("CAM123", " ", Convert.ToByte(1)));
        }
        // Remove
        [Test]
        public void RemoveSub_Test1()
        {
            Assert.AreEqual(true, _serSubject.RemoveSub("CAM123"));
        }
        [Test]
        public void RemoveSub_Test2()
        {
            Assert.AreEqual(true, _serSubject.RemoveSub(" "));
        }
    }
}
