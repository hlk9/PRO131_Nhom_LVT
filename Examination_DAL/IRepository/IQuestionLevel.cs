using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IQuestionLevel
    {
        bool Add(QuestionLevel questionLevel);
        bool Update(QuestionLevel questionLevel);
        bool DeleteById(byte id);
        IEnumerable<QuestionLevel> GetAll();

    }
}
