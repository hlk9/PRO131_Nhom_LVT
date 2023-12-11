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

        public List<Classroom> GetClassrooms()
        {
            return _repos.GetClassrooms().ToList();
        }      

        public Classroom getClassById(string id)
        {
            return _repos.GetClassRoomById(id);
        }

        public bool AddNewClass(string id, string name)
        {
            var room = new Classroom()
            {
                Name = name,
                Id = id,
            };

            return _repos.CreateClass(room);

        }
        public bool RemoveClass(string id)
        {
            Classroom room = new Classroom()
            {
                Id = id,
            };

            return _repos.DeleteClass(room);
        }
        public bool UpdateClass(string ID, string name)
        {
            Classroom room = new Classroom()
            {
                Id = ID,
                Name = name             
            };

            return _repos.UpdateClass(room);
        }

    }
}
