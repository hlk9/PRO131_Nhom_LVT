using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Examination_DAL.Models;
using Examination_DAL.Repository;

namespace Examination_BUS.Services
{
    
    public class ClassroomServices
    {
        ClassroomRepository _repos = new ClassroomRepository();
        public ClassroomServices()
        {
            
        }

        public ClassroomServices(ClassroomRepository repos)
        {
            _repos = repos;
        }
        public List<Classroom> GetClassrooms()
        {
            return _repos.GetClassrooms().ToList();
        }
        public List<Classroom> GetClassByName(string name)
        {
            return _repos.GetClassByName(name).ToList();
        }

        public bool AddNewClass(string name, string ID)
        {
            var room = new Classroom()
            {
                Name = name,
                Id = ID,
            };
            return _repos.CreateClass(room);

        }
        public bool RemoveClass(string ID)
        {
            return _repos.DeleteClass(ID);
        }
        public bool UpdateClass(string ID, string name)
        {
            Classroom room = new Classroom()
            {
                Id = ID,
                Name = name,
               

            };
            return _repos.UpdateClass(room);
        }

    }
}
