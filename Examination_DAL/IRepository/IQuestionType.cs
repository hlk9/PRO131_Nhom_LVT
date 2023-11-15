using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IQuestionType
    {
        public IEnumerable<QuestionType> GetAll();
        public QuestionType GetById(int id);
        public bool Add(QuestionType questionType);
        public bool Update(QuestionType questionType);
        public bool DeleteById(int id);

    }
}
