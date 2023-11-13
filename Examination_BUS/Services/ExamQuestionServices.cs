using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamQuestionServices
    {
        ExamQuestionRepository examQuestionRepository;
        public ExamQuestionServices()
        {
            examQuestionRepository = new ExamQuestionRepository();
        }
        public bool AddExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.AddExamQuestion(examQuestion);
        }
        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.UpdateExamQuestion(examQuestion);
        }
        public bool DeleteExamQuestion(int examQuestionId)
        {
            return examQuestionRepository.DeleteExamQuestion(examQuestionId);
        }
        public List<ExamQuestion> GetAllExamQuestions()
        {
            return examQuestionRepository.GetAllExamQuestions();
        }
        public ExamQuestion GetExamQuestionById(int examQuestionId)
        {
            return examQuestionRepository.GetExamQuestionById(examQuestionId);
        }

    }
}
