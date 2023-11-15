using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class QuestionTypeServices
    {
        QuestionTypeRepository questionTypeRepository = new QuestionTypeRepository();
        public QuestionTypeServices()
        {

        }

        public bool Add(QuestionType questionType)
        {
            return questionTypeRepository.Add(questionType);
        }

        public bool DeleteById(int id)
        {
            return questionTypeRepository.DeleteById(id);
        }

        public IEnumerable<QuestionType> GetAll()
        {
            return questionTypeRepository.GetAll();
        }

        public QuestionType GetById(int id)
        {
            return questionTypeRepository.GetById(id);
        }

        public bool Update(QuestionType questionType)
        {
            return questionTypeRepository.Update(questionType);
        }
        public string GetQuestionTypeNameById(int id)
        {
            return questionTypeRepository.GetById(id).Name;
        }

      


    }
}
