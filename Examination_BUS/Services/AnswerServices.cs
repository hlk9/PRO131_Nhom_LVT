using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class AnswerServices
    {
        AnswerRepository answerRepository;
        public AnswerServices()
        {
            answerRepository = new AnswerRepository();
        }
        public bool AddAnswer(Answer answer)
        {
            return answerRepository.AddAnswer(answer);
        }
        public bool UpdateAnswer(Answer answer)
        {
            return answerRepository.UpdateAnswer(answer);
        }
        public bool DeleteAnswer(int answerId)
        {
            return answerRepository.DeleteAnswer(answerId);
        }
        public List<Answer> GetAllAnswers()
        {
            return answerRepository.GetAllAnswers();
        }
        public Answer GetAnswerById(int answerId)
        {
            return answerRepository.GetAnswerById(answerId);
        }

    }
}
