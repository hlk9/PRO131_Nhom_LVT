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
    public class ExamQuestionRepository : IExamQuestion
    {
        ExaminationDbContext _context;
        public ExamQuestionRepository() 
        {
            _context = new ExaminationDbContext();
        }

        public bool AddExamQuestion(ExamQuestion examQuestion)
        {
            try
            {
                _context.ExamQuestions.Add(examQuestion);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteExamQuestion(int examQuestionId)
        {
            try
            {
            _context.ExamQuestions.Remove(GetExamQuestionById(examQuestionId));
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public List<ExamQuestion> GetAllExamQuestions()
        {
            return _context.ExamQuestions.ToList();
        }

        public ExamQuestion GetExamQuestionById(int examQuestionId)
        {
            return _context.ExamQuestions.Where(e => e.Id == examQuestionId).FirstOrDefault();
        }

        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
