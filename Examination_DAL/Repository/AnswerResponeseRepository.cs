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
    }
}
