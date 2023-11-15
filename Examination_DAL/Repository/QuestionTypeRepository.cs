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
    public class QuestionTypeRepository : IQuestionType
    {
        ExaminationDbContext dbContext = new ExaminationDbContext();
        public QuestionTypeRepository()
        {
            
        }

        public bool Add(QuestionType questionType)
        {
           dbContext.QuestionTypes.Add(questionType);
            dbContext.SaveChanges();
            return true;
        }

        public bool DeleteById(int id)
        {
            try
            {
                var questionType = dbContext.QuestionTypes.Find(id);
                dbContext.QuestionTypes.Remove(questionType);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<QuestionType> GetAll()
        {
            return dbContext.QuestionTypes.ToList();
        }

        public QuestionType GetById(int id)
        {
            return dbContext.QuestionTypes.Find(id);
        }

        public bool Update(QuestionType questionType)
        {
            try
            {
                var questionTypeUpdate = dbContext.QuestionTypes.Find(questionType.Id);
                questionTypeUpdate.Name = questionType.Name;
                dbContext.Update(questionTypeUpdate);
                dbContext.SaveChanges();
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
