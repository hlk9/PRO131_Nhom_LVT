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
    public class QuestionRepository : IQuestion
    {

        ExaminationDbContext _context;
        public QuestionRepository()
        {
            _context = new ExaminationDbContext();
        }
        public bool AddQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuestion(int questionId)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }

        public Question GetQuestionById(int questionId)
        {
            return _context.Questions.Where(q => q.Id == questionId).FirstOrDefault();
        }

        public bool UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
