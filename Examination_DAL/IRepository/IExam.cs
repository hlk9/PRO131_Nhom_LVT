using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IExam
    {
        IEnumerable<Exam> GetAll();
        Exam GetById(int id);
        Exam GetByCode(string code);
        bool Add(Exam exam);
        bool Update(Exam exam);
        bool DeleteById(int id);
        bool DeleteByCode(string code);
    }
}
