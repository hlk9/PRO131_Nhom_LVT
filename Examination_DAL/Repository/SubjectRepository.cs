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

    public class SubjectRepository : ISubject
    {
        ExaminationDbContext _context= new ExaminationDbContext();
        public SubjectRepository()
        {
            
        }

        public SubjectRepository(ExaminationDbContext context)
        {
            _context = context;
        }

        public bool AddNewSub(Subject subject)
        {
            try
            {
                _context.Subjects.Add(subject);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteSub(string ID)
        {
            try
            {
                var deleteItem = _context.Subjects.Find(ID);
                _context.Subjects.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Subject> GetSubjectByname(string name)
        {
            return _context.Subjects.Where(x => x.Name.Contains(name)).ToList();
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        public bool UpdateSub(Subject subject)
        {
            try
            {
                var updateSub = _context.Subjects.Find(subject.Id);
                updateSub.Name = subject.Name;             
                updateSub.Status = subject.Status;
                _context.Subjects.Update(updateSub);
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
