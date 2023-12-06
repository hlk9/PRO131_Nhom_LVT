using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class AnswerResponeseRepository
    {
        ExaminationDbContext _context;
        public AnswerResponeseRepository()
        {
            _context = new ExaminationDbContext();
        }
        public List<AnswerResponse> GetAll()
        {
            return _context.AnswerResponses.ToList();
        }
        public AnswerResponse GetById(int id)
        {
            return _context.AnswerResponses.Find(id);
        }
        public bool Add(AnswerResponse answerResponse)
        {
            try
            {
                _context.AnswerResponses.Add(answerResponse);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(AnswerResponse answerResponse)
        {
            try
            {
                _context.AnswerResponses.Update(answerResponse);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            AnswerResponse answerResponse = _context.AnswerResponses.Find(id);
            if (answerResponse != null)
            {
                try
                {
                    _context.AnswerResponses.Remove(answerResponse);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;


        }

      
    }
}
