using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IQuestion
    {
        public bool AddQuestion(Question question);
        public bool UpdateQuestion(Question question);
        public bool DeleteQuestion(int questionId);
        public List<Question> GetAllQuestionsActive();
        public Question GetQuestionById(int questionId);

    }
}
