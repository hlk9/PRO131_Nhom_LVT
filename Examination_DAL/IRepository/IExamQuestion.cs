using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IExamQuestion
    {
        public bool AddExamQuestion(ExamQuestion examQuestion);
        public bool UpdateExamQuestion(ExamQuestion examQuestion);
        public bool DeleteExamQuestion(int examQuestionId);
        public List<ExamQuestion> GetAllExamQuestions();
        public ExamQuestion GetExamQuestionById(int examQuestionId);

    }
}
