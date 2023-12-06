using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IExamDetail
    {
        IEnumerable<ExamDetail> GetAll();
        ExamDetail GetByID(int id);
        ExamDetail GetByCode(string code);
        bool Add(ExamDetail obj);
        bool Update(ExamDetail obj);
        bool Delete(int id);
        bool DeleteByCode(string code);
        
    }
}
