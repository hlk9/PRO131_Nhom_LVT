using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ExamResponsesRepository
    {
        ExaminationDbContext _context;
        public ExamResponsesRepository()
        {
            _context = new ExaminationDbContext();
        }

        public List<ExamResponse> GetAllExamResponse()
        {
            return _context.ExamResponses.ToList();
        }

        public List<ExamResponse> getAllStudent(string id)
        {
            return _context.ExamResponses.Where(x => x.ParticipantId == id).ToList();
        }
    }
}
