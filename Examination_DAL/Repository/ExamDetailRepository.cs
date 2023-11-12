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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public ExamDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ExamDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
