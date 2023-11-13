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

        public bool CreateClass(Classroom room)
        {
            try
            {
                _context.Classrooms.Add(room);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteClass(string ID)
        {
            try
            {
                var deleteItem = _context.Classrooms.Find(ID);
                _context.Classrooms.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Classroom> GetClassByName(string name)
        {
            return _context.Classrooms.Where(x=>x.Name.Contains(name)).ToList();
        }

        public IEnumerable<Classroom> GetClassrooms()
        {
            return _context.Classrooms.ToList();
        }

        public bool UpdateClass(Classroom room)
        {
            try
            {
                var updateClass = _context.Classrooms.Find(room.Id);
                updateClass.Name = room.Name;
                updateClass.Id  = room.Id;
                _context.Classrooms.Update(updateClass);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
