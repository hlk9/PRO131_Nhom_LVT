using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class AnswerResponseServices
    {
        AnswerResponeseRepository answerResponeseRepository;
        public AnswerResponseServices()
        {
            answerResponeseRepository = new AnswerResponeseRepository();
        }

        public bool AddAnswerResponse(AnswerResponse answerResponse)
        {
            return answerResponeseRepository.Add(answerResponse);
        }

        public bool UpdateAnswerResponse(AnswerResponse answerResponse)
        {
            return answerResponeseRepository.Update(answerResponse);
        }

        public bool DeleteAnswerResponse(int answerResponseId)
        {
            return answerResponeseRepository.Delete(answerResponseId);
        }

        public List<AnswerResponse> GetAllAnswerResponses()
        {
            return answerResponeseRepository.GetAll();
        }

        public AnswerResponse GetAnswerResponseById(int answerResponseId)
        {
            return answerResponeseRepository.GetById(answerResponseId);
        }


      


    }
}
