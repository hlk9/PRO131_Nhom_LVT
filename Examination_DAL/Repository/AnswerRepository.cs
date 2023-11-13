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
    public class AnswerRepository : IAnswer
    {

        ExaminationDbContext _context;

        public AnswerRepository()
        {
            _context = new ExaminationDbContext();
        }

        public bool AddAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnswer(int id)
        {
            throw new NotImplementedException();
        }

        public Answer GetAnswerById(int id)
        {
            return _context.Answers.Where(a => a.Id == id).FirstOrDefault();
        }

        public List<Answer> GetAllAnswers()
        {
           return _context.Answers.ToList();
        }

        public bool UpdateAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }
    }
}
