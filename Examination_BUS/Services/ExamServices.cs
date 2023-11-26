using Examination_BUS.ViewModel;
using Examination_DAL.IRepository;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamServices:IExam
    {
        ExamRepository _examRepos;
        AnswerResponeseRepository _AnswerResponese;
        ExamResponsesRepository _examResponses;
        ExamDetailRepository _examDetailRepos;

        public ExamServices()
        {
            _examRepos = new ExamRepository();
            _AnswerResponese = new AnswerResponeseRepository();
            _examResponses = new ExamResponsesRepository();
            _examDetailRepos = new ExamDetailRepository();
        }
     
        public IEnumerable<Exam> GetAll()
        {
           return _examRepos.GetAll();
        }

        public Exam GetById(int id)
        {
            return _examRepos.GetById(id);
        }

        public Exam GetByCode(string code)
        {
            return _examRepos.GetByCode(code);
        }

        public bool Add(Exam exam)
        {
            return _examRepos.Add(exam);
        }

        public bool Update(Exam exam)
        {
            return _examRepos.Update(exam);
        }

        public bool DeleteById(int id)
        {
            return _examRepos.DeleteById(id);
        }

        public bool DeleteByCode(string code)
        {
            return _examRepos.DeleteByCode(code);
        }

        public List<ExamAnswer_ResponsesViewModel> GetAnswer_ResponsesViewModels(string idAnswer)
        {
            var listExamRes = (from ex in _examResponses.GetAll()
                               where ex.ParticipantId == idAnswer
                               select new ExamAnswer_ResponsesViewModel
                               {
                                   Id = ex.Id,
                                   ExamDetailId = ex.ExamDetailId,
                                   ParticipantId = ex.ParticipantId,
                                   SubjectId = ex.SubjectId,
                                   SubmitTime = ex.SubmitTime,
                                   Score = ex.Score,
                                   Status = ex.Status,
                                   IsPassed = ex.IsPassed,
                                   QuestionCorrect = ex.QuestionCorrect,
                                   QuestionWrong = ex.QuestionWrong,
                                   QuestionNotAnswered = ex.QuestionNotAnswered,
                                   ScoredBy = ex.ScoredBy,
                                   FinishTime = ex.FinishTime,
                                   ScoredMethod = ex.ScoredMethod,
                                   Note = ex.Note,
                                   IdExam = _examDetailRepos.GetByID(ex.ExamDetailId).ExamId,
                                   NameExam = _examRepos.GetById(_examDetailRepos.GetByID(ex.ExamDetailId).ExamId).Name,
                                   ExamDetailcode = _examDetailRepos.GetByID(ex.ExamDetailId).ExamDetailCode,
                                   answerResponses = (from exam in _examResponses.GetAll()
                                                      join answer in _AnswerResponese.GetAll()
                                                      on exam.Id equals answer.ExamResponseId
                                                      select answer).ToList()
                                   
                               }).ToList();
            return listExamRes;
        }
    }
}
