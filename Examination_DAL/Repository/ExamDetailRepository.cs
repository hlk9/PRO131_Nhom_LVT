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
    public class ExamDetailRepository : IExamDetail
    {

        ExaminationDbContext _context;
        public ExamDetailRepository()
        {
            _context = new ExaminationDbContext();
        }

        public bool Add(ExamDetail obj)
        {
            try
            {
                _context.ExamDetails.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByCode(string code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExamDetail> GetAll()
        {
            return _context.ExamDetails.ToList();
        }

        public ExamDetail GetByCode(string code)
        {
           return _context.ExamDetails.Where(x => x.ExamDetailCode == code).FirstOrDefault();
        }

        public ExamDetail GetByID(int id)
        {
            return _context.ExamDetails.Find(id);
        }

        public List<ExamDetail> getByExamId(int id)
        {
            return _context.ExamDetails.Where(x => x.ExamId == id).ToList();
        }

        public bool Update(ExamDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
