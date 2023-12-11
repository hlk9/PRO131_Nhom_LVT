using Examination_DAL.Context;
using Examination_DAL.IRepository;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ClassroomRepository: IClassroom
    {
        ExaminationDbContext _context = new ExaminationDbContext();
        public ClassroomRepository()
        {
            
        }

        public ClassroomRepository(ExaminationDbContext context)
        {
            _context = context;
        }

        public Classroom GetClassRoomById(string id)
        {
            return _context.Classrooms.Find(id);
        }

        public bool CreateClass(Classroom room)
        {
            try
            {
                _context.Classrooms.Add(room);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteClass(Classroom room)
        {
            try
            {
                var dele = _context.Classrooms.Find(room.Id);

                _context.Classrooms.Remove(dele);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Classroom> GetClassrooms()
        {
            return _context.Classrooms.ToList();
        }

        public bool UpdateClass(Classroom room)
        {
            try
            {
                var update = _context.Classrooms.Find(room.Id);

                update.Name = room.Name;
                update.Id = room.Id;

                _context.Classrooms.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
