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

        public List<ExamSchedule> getAllByDateTimes(DateTime start, DateTime end)
        {
            return _resExamSchedule.getAllByDateTime(start, end);
        }       
    }
}
