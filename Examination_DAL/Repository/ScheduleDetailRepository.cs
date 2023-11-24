using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ScheduleDetailRepository
    {
        ExaminationDbContext context;
        public ScheduleDetailRepository()
        {
            context = new ExaminationDbContext();
        }

        public List<ExamScheduleDetail> GetAllScheduleDetails()
        {
            return context.ExamScheduleDetails.ToList();
        }

        public ExamScheduleDetail GetScheduleDetailById(int id)
        {
            return context.ExamScheduleDetails.Find(id);
        }

        public bool AddScheduleDetail(ExamScheduleDetail scheduleDetail)
        {
            try
            {
                context.ExamScheduleDetails.Add(scheduleDetail);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateScheduleDetail(ExamScheduleDetail scheduleDetail)
        {
            try
            {
                ExamScheduleDetail scheduleDetailToUpdate = context.ExamScheduleDetails.Find(scheduleDetail.Id);
                scheduleDetailToUpdate.ExamScheduleId = scheduleDetail.ExamScheduleId;
                scheduleDetailToUpdate.ParticipantId = scheduleDetail.ParticipantId;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteScheduleDetail(int id)
        {
            try
            {
                ExamScheduleDetail scheduleDetailToDelete = context.ExamScheduleDetails.Find(id);
                context.ExamScheduleDetails.Remove(scheduleDetailToDelete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ExamScheduleDetail> GetScheduleDetailByScheduleId(int id)
        {
            return context.ExamScheduleDetails.Where(x => x.ExamScheduleId == id).ToList();
        }

        public List<ExamScheduleDetail> GetScheduleDetailByParticipantId(string id)
        {
            return context.ExamScheduleDetails.Where(x => x.ParticipantId == id).ToList();
        }

    }
}
