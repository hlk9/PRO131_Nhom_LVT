using Examination_BUS.Services;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Classroom_Service_Test
    {
        ClassroomServices _serClassroom;
        [SetUp]
        public void SetUp()
        {
            _serClassroom = new ClassroomServices();
        }
        // Get All
        [Test]
        public void GetClassrooms_Test1()
        {
            Assert.IsNotNull(_serClassroom.GetClassrooms());
        }
        // Get ById
        [Test]
        public void GetClassById_Test1()
        {
            Assert.IsNotNull(_serClassroom.getClassById("IT10302"));
        }
        [Test]
        public void GetClassById_Test2()
        {
            Assert.IsNotNull(_serClassroom.getClassById("IT10303"));
        }
        [Test]
        public void GetClassById_Test3()
        {
            Assert.IsNotNull(_serClassroom.getClassById("IT10304"));
        }
        [Test]
        public void GetClassById_Test4()
        {
            Assert.IsNull(_serClassroom.getClassById(" "));
        }
        [Test]
        public void GetClassById_Test5()
        {
            Assert.IsNull(_serClassroom.getClassById("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"));
        }
        // Create
        [Test]
        public void AddNewClass_Test1()
        {
            Assert.AreEqual(false ,_serClassroom.AddNewClass("IT10307", "Lớp IT10307"));
        }
        [Test]
        public void AddNewClass_Test2()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass("IT10308", "Lớp IT10308"));
        }
        [Test]
        public void AddNewClass_Test3()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass(" ", "Lớp IT10308"));
        }
        [Test]
        public void AddNewClass_Test4()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass("IT10308", " "));
        }
        [Test]
        public void AddNewClass_Test5()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass(" ", " "));
        }
        [Test]
        public void AddNewClass_Test6()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", "Lớp IT10308"));
        }
        [Test]
        public void AddNewClass_Test7()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass("IT10308", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"));
        }
        [Test]
        public void AddNewClass_Test8()
        {
            Assert.AreEqual(true, _serClassroom.AddNewClass("IT10308", "Lớp IT10308"));
        }
        // UpDate
        [Test]
        public void UpdateClass_Test1()
        {
            Assert.AreEqual(true, _serClassroom.UpdateClass("IT#@!$%^10307", "Lớp IT10308"));
        }
        [Test]
        public void UpdateClass_Test2()
        {
            Assert.AreEqual(true, _serClassroom.UpdateClass("IT10307", " "));
        }
        [Test]
        public void UpdateClass_Test3()
        {
            Assert.AreEqual(false, _serClassroom.UpdateClass("IT10307", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"));
        }
        //Remove
        [Test]
        public void RemoveClass_Test1()
        {
            Assert.AreEqual(true, _serClassroom.RemoveClass("IT10307"));
        }
        [Test]
        public void RemoveClass_Test2()
        {
            Assert.AreEqual(false, _serClassroom.RemoveClass(" "));
        }
        [Test]
        public void RemoveClass_Test3()
        {
            Assert.AreEqual(false, _serClassroom.RemoveClass("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum"));
        }
    }
}
