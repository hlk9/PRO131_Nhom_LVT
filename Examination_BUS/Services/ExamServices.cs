using Examination_DAL.IRepository;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamServices:IExam
    {

        ExamRepository _examRepos;

        public ExamServices()
        {
            _examRepos = new ExamRepository();
        }
     
        public IEnumerable<Exam> GetAll()
        {
           return _examRepos.GetAll();
        }

        public Exam GetById(int id)
        {
            return _examRepos.GetById(id);
        }

        public Exam GetByCode(string code)
        {
            return _examRepos.GetByCode(code);
        }

        public bool Add(Exam exam)
        {
            return _examRepos.Add(exam);
        }

        public bool Update(Exam exam)
        {
            return _examRepos.Update(exam);
        }

        public bool DeleteById(int id)
        {
            return _examRepos.DeleteById(id);
        }

        public bool DeleteByCode(string code)
        {
            return _examRepos.DeleteByCode(code);
        }

        
    }
}
