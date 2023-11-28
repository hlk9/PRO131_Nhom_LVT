using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamResponseServices
    {
        ExamResponsesRepository _examResponsesRepository;
        public ExamResponseServices()
        {
            _examResponsesRepository = new ExamResponsesRepository();
        }

        public List<ExamResponse> GetAllExamResponse()
        {
            return _examResponsesRepository.GetAllExamResponse();
        }

        public ExamResponse GetExamResponseById(int id)
        {
            return _examResponsesRepository.GetExamResponseById(id);
        }

        public bool AddExamResponse(ExamResponse examResponse)
        {
            return _examResponsesRepository.AddExamResponse(examResponse);
        }

        public List<ExamResponse> GetExamResponseByExamDetailId(int examDetailId)
        {
            return _examResponsesRepository.GetExamResponseByExamDetailId(examDetailId);
        }

        public List<ExamResponse> GetExamResponseByParticipantId(string participantId)
        {
            return _examResponsesRepository.GetExamResponseByParticipantId(participantId);
        }

        public List<ExamResponse> GetExamResponseBySubjectId(string subjectId)
        {
            return _examResponsesRepository.GetExamResponseBySubjectId(subjectId);
        }

        public int AddExamResponseAndGetId(ExamResponse examResponse)
        {
            return _examResponsesRepository.AddExamResponseAndGetId(examResponse);
        }
    }
}
