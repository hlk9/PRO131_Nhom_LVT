using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ScheduleRepository
    {
        ExaminationDbContext context = new ExaminationDbContext();

        public List<ExamSchedule> GetListSchedule()
        {
            return context.ExamSchedules.ToList();
        }

        public ExamSchedule GetScheduleById(int id)
        {
            return context.ExamSchedules.Find(id);
        }


        public bool AddSchedule(ExamSchedule schedule)
        {
            try
            {
                context.ExamSchedules.Add(schedule);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSchedule(ExamSchedule schedule)
        {
            try
            {
                var scheduleUpdate = context.ExamSchedules.Find(schedule.Id);
                scheduleUpdate.Name = schedule.Name;
                scheduleUpdate.ExamId = schedule.ExamId;
                scheduleUpdate.ExamRoomId = schedule.ExamRoomId;
                scheduleUpdate.StartTime = schedule.StartTime;
                scheduleUpdate.EndTime = schedule.EndTime;
                scheduleUpdate.Subject = schedule.Subject;
                scheduleUpdate.Description = schedule.Description;
                scheduleUpdate.Status = schedule.Status;
                scheduleUpdate.CreatedBy = schedule.CreatedBy;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSchedule(int id)
        {
            try
            {
                var scheduleDelete = context.ExamSchedules.Find(id);
                context.ExamSchedules.Remove(scheduleDelete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        

        public List<ExamSchedule> GetListScheduleByExamId(int examId)
        {
            return context.ExamSchedules.Where(x => x.ExamId == examId).ToList();
        }

        public List<ExamSchedule> GetListScheduleByExamRoomId(string examRoomId)
        {
            return context.ExamSchedules.Where(x => x.ExamRoomId == examRoomId).ToList();
        }

        public List<ExamSchedule> GetListScheduleByStaffId(string staffId)
        {
            return context.ExamSchedules.Where(x => x.CreatedBy == staffId).ToList();
        }

        public List<ExamSchedule> GetListScheduleByDate(DateTime date)
        {
            return context.ExamSchedules.Where(x => x.StartTime.Date == date.Date).ToList();
        }


    }
}
