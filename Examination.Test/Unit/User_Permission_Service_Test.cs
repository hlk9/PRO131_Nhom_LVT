using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class User_Permission_Service_Test
    {
        Examination_BUS.Services.UserPermissionServices _service;
        [SetUp]
        public void SetUp()
        {
            _service = new Examination_BUS.Services.UserPermissionServices();
        }

        [Test]
        public void GetAllUserPermissions()
        {
            Assert.IsNotNull(_service.GetAllUserPermissions());
        }

        [Test]
        public void Add_Pass()
        {
            UserPermission userPermission = new UserPermission { Id =1, AccountId ="TF001",PermissionId =1};

           Assert.AreEqual(true, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_1()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_2()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 0;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_3()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "TF0001JKUDSFGSSDFSGDFGSDFGSDFSDF";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_4()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_5()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_6()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 0;
            userPermission.AccountId = "";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_7()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = -1;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_8()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = -1;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }
        [Test]
        public void Add_Fail_9()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = -9999;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }
        [Test]
        public void Add_Fail_10()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 255;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }
        [Test]
        public void Add_Fail_11()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "TF0001$%%%%$$";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_12()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 199999999;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }

        [Test]
        public void Add_Fail_13()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = -199999999;
            userPermission.AccountId = "TF0001";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.AddUserPermission(userPermission));
        }
        [Test]
        public void Update_Fail_4()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "";
            userPermission.PermissionId = 1;

            Assert.AreEqual(false, _service.UpdateUserPermission(userPermission));
        }

        [Test]
        public void Update_Fail_5()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 1;
            userPermission.AccountId = "";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.UpdateUserPermission(userPermission));
        }

        [Test]
        public void Update_Fail_6()
        {
            UserPermission userPermission = new UserPermission();

            userPermission.Id = 0;
            userPermission.AccountId = "";
            userPermission.PermissionId = 0;

            Assert.AreEqual(false, _service.UpdateUserPermission(userPermission));
        }

        [Test]
        public void Delete_Fail_1()
        {
            Assert.AreEqual(false, _service.DeleteUserPermission(110));
        }
        [Test]
        public void Delete_Fail_2()
        {
            Assert.AreEqual(false, _service.DeleteUserPermission(0));
        }
        [Test]
        public void Delete_Fail_3()
        {
            Assert.AreEqual(false, _service.DeleteUserPermission(222222));
        }
        [Test]
        public void Delete_Fail_4()
        {
            Assert.AreEqual(false, _service.DeleteUserPermission(-199));
        }




    }
}
