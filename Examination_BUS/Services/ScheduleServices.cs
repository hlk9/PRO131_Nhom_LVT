using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ScheduleServices
    {

        ScheduleRepository scheduleRepository = new ScheduleRepository();
        public ScheduleServices()
        {
            
        }
        public List<ExamSchedule> GetListSchedule()
        {
            return scheduleRepository.GetListSchedule();
        }

        public ExamSchedule GetScheduleById(int id)
        {
            return scheduleRepository.GetScheduleById(id);
        }

        public bool AddSchedule(ExamSchedule schedule)
        {
            return scheduleRepository.AddSchedule(schedule);
        }

        public bool UpdateSchedule(ExamSchedule schedule)
        {
            return scheduleRepository.UpdateSchedule(schedule);
        }

        public bool DeleteSchedule(int id)
        {
            return scheduleRepository.DeleteSchedule(id);
        }

        public List<ExamSchedule> GetListScheduleByExamId(int examId)
        {
            return scheduleRepository.GetListScheduleByExamId(examId);
        }

        public List<ExamSchedule> GetListScheduleByExamRoomId(string examRoomId)
        {
            return scheduleRepository.GetListScheduleByExamRoomId(examRoomId);
        }

      


    }
}
