using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Test.Unit
{
    public class Permission_Service_Test
    {
        PermissionService _serPermission;

        [SetUp]
        public void SetUp()
        {
            _serPermission = new PermissionService();
        }

        [Test]
        public void GetAllPermission() 
        { 
            Assert.IsNotNull( _serPermission.GetAllPermission());
        }

        [Test]
        public void GetById()
        {
            Assert.IsNotNull(_serPermission.GetById(1));
        }

        [Test]
        public void GetById_Test1()
        {
            Assert.IsNotNull(_serPermission.GetById(2));
        }

        [Test]
        public void GetById_Test2()
        {
            Assert.IsNotNull(_serPermission.GetById(3));
        }

        [Test]
        public void GetById_Test3()
        {
            Assert.IsNull(_serPermission.GetById(10));
        }

        [Test]
        public void GetById_Test4()
        {
            Assert.IsNull(_serPermission.GetById(5));
        }

        [Test]
        public void GetById_Test5()
        { 
            Assert.IsNull( _serPermission.GetById(0));
        }

        [Test]
        public void GetById_Test6()
        {
            Assert.IsNull(_serPermission.GetById(byte.MaxValue));
        }
    }
}
