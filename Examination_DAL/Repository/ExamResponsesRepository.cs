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

        public ExamResponse GetExamResponseById(int id)
        {
            return _context.ExamResponses.Find(id);
        }

        public bool AddExamResponse(ExamResponse examResponse)
        {
            try
            {
                _context.ExamResponses.Add(examResponse);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ExamResponse> GetExamResponseByExamDetailId(int examDetailId)
        {
            return _context.ExamResponses.Where(e => e.ExamDetailId == examDetailId).ToList();
        }

        public List<ExamResponse> GetExamResponseByParticipantId(string participantId)
        {
            return _context.ExamResponses.Where(e => e.ParticipantId == participantId).ToList();
        }

        public List<ExamResponse> GetExamResponseBySubjectId(string subjectId)
        {
            return _context.ExamResponses.Where(e => e.SubjectId == subjectId).ToList();
        }

        public List<ExamResponse> GetExamResponseByExamScheduleId(int ExamScheduleid)
        {
            return _context.ExamResponses.Where(e => e.ExamScheduleId == ExamScheduleid).ToList();
        }

        public int AddExamResponseAndGetId(ExamResponse examResponse)
        {
            try
            {
                _context.ExamResponses.Add(examResponse);
                _context.SaveChanges();
                return examResponse.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
