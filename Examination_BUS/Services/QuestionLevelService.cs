using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class QuestionLevelService
    {
        QuestionLevelRepository QuestionLevelRepository;
        public QuestionLevelService()
        {
            
            QuestionLevelRepository = new QuestionLevelRepository();
        }

        public bool Add(QuestionLevel questionLevel)
        {
            return QuestionLevelRepository.Add(questionLevel);
        }

        public bool DeleteById(byte id)
        {
            return QuestionLevelRepository.DeleteById(id);
        }

        public IEnumerable<QuestionLevel> GetAll()
        {
            return QuestionLevelRepository.GetAll();
        }

        public QuestionLevel GetById(byte id)
        {
            return QuestionLevelRepository.GetById(id);
        }

    }
}
