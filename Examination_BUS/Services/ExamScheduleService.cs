using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamScheduleService
    {
        ExamScheduleResposiroty _resExamSchedule = new ExamScheduleResposiroty();
        ExamResponsesRepository _resExamResponses = new ExamResponsesRepository();
        public ExamScheduleService()
        {
            
        }

        public List<ExamSchedule> getAlls()
        {
            return _resExamSchedule.getAll();
        }

        public List<ExamSchedule_ResponsesViewModel> getExamResponses_ScheduleViewModels(string start, string end)
        {
            var lst = from exS in _resExamSchedule.getAll()
                      join exR in _resExamResponses.GetAllExamResponse()
                      on exS.Id equals exR.ExamScheduleId
                      select new ExamSchedule_ResponsesViewModel
                      {
                          idExamSchedule = exS.Id,
                          idExamResponses = exR.Id,
                          nameSchedule = exS.Name,
                          subject = exS.Subject,
                          StartTime = exS.StartTime,
                          EndTime = exS.EndTime,
                          Score = Convert.ToDouble(exR.Score),
                          QuestionCorrect = Convert.ToInt32(exR.QuestionCorrect),
                          QuestionWrong = Convert.ToInt32(exR.QuestionWrong),
                          QuestionNotAnswered = Convert.ToInt32(exR.QuestionNotAnswered)
                      };

            return lst.ToList();
        }
    }
}
