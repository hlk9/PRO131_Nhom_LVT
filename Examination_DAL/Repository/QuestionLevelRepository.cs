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
    public class QuestionLevelRepository : IQuestionLevel
    {
        ExaminationDbContext dbContext;
        public QuestionLevelRepository()
        {
            dbContext = new ExaminationDbContext();
        }

        public bool Add(QuestionLevel questionLevel)
        {
            try
            {
                dbContext.QuestionLevels.Add(questionLevel);
                dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteById(byte id)
        {
            try
            {
                var questionLevel = dbContext.QuestionLevels.Find(id);
                dbContext.QuestionLevels.Remove(questionLevel);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public IEnumerable<QuestionLevel> GetAll()
        {
            return dbContext.QuestionLevels.ToList();
        }

        public bool Update(QuestionLevel questionLevel)
        {
            try
            {
                var questionLevelUpdate = dbContext.QuestionLevels.Find(questionLevel.Id);
                questionLevelUpdate.Name = questionLevel.Name;
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public QuestionLevel GetById(byte id)
        {
            return dbContext.QuestionLevels.Find(id);
        }
    }
}
