using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ExamRepository 
    {
        ExaminationDbContext _context = new ExaminationDbContext();
        public ExamRepository()
        {
            
        }
        public IEnumerable<Exam> GetAll()
        {
            return _context.Exams.ToList();
        }
        public Exam GetById(int id)
        {
            return _context.Exams.Find(id);
        }
        public Exam GetByCode(string code)
        {
            return _context.Exams.Where(e => e.ExamCode == code).FirstOrDefault();
        }
        public bool AddAllExam(Exam exam)
        {
            try
            {
                _context.Exams.Add(exam);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Exam exam)
        {
            try
            {
                var examUpdate = _context.Exams.Find(exam.Id);
                examUpdate.Name = exam.Name;
                examUpdate.SubjectId = exam.SubjectId;
                examUpdate.ExamCode = exam.ExamCode;
                _context.Update(examUpdate);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteById(int id)
        {
            try
            {
                var exam = _context.Exams.Find(id);
                _context.Exams.Remove(exam);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteByCode(string code)
        {
            try
            {
                var exam = _context.Exams.Where(e => e.ExamCode == code).FirstOrDefault();
                _context.Exams.Remove(exam);
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
