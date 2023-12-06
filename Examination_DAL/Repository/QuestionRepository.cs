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
            _context.Questions.Add(question);
            _context.SaveChanges();
            return true;

        }

        public int AddQuestionReturnId(Question question)
        {
            try
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
                return question.Id;
            }
            catch (Exception)
            {

                return -1;
            }
            
        }



        public bool DeleteQuestion(int questionId)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAllQuestionsActive()
        {
            return _context.Questions.ToList().Where(x=>x.Status==true).ToList();
        }

        public Question GetQuestionById(int questionId)
        {
            return _context.Questions.Where(q => q.Id == questionId).FirstOrDefault();
        }

        public bool UpdateQuestion(Question question)
        {
           try
            {
                var questionUpdate = _context.Questions.Where(q => q.Id == question.Id).FirstOrDefault();
                questionUpdate.Content = question.Content;
                questionUpdate.QuestionLevelId = question.QuestionLevelId;
                questionUpdate.QuestionTypeId = question.QuestionTypeId;
                questionUpdate.SubjectId = question.SubjectId;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
