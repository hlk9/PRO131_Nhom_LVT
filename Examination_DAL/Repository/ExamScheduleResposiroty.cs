using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ExamScheduleResposiroty
    {
        ExaminationDbContext _context;

        public ExamScheduleResposiroty()
        {
            _context = new ExaminationDbContext();
        }

        public ExamSchedule GetOneWithID(int id)
        {
            return _context.ExamSchedules.Find(id);
        }

        public bool Update(ExamSchedule examSchedule)
        {
            try
            {
                var examScheduleUpdate = _context.ExamSchedules.Find(examSchedule.Id);
                examScheduleUpdate.ExamId = examSchedule.ExamId;
                examScheduleUpdate.ExamRoomId = examSchedule.ExamRoomId;
                examScheduleUpdate.StartTime = examSchedule.StartTime;
                examScheduleUpdate.EndTime = examSchedule.EndTime;
                examScheduleUpdate.Status = examSchedule.Status;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(ExamSchedule examSchedule)
        {
            try
            {
                _context.ExamSchedules.Add(examSchedule);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var examSchedule = _context.ExamSchedules.Find(id);
                _context.ExamSchedules.Remove(examSchedule);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        public List<ExamSchedule> getAll()
        {
            return _context.ExamSchedules.ToList();
        }

        public List<ExamSchedule> getAllByDateTime(DateTime start, DateTime end)
        {
            if (start == null && end == null)
            {
                return _context.ExamSchedules.ToList();
            }
            else
            {
                return _context.ExamSchedules.Where(x => x.StartTime >= start && x.EndTime <= end).ToList();
            }
        }
    }
}
