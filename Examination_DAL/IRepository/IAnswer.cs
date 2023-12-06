using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IAnswer
    {
        public bool AddAnswer(Answer answer);
        public bool UpdateAnswer(Answer answer);
        public bool DeleteAnswer(int id);
        public List<Answer> GetAllAnswers();
        public Answer GetAnswerById(int id);
    }
}
