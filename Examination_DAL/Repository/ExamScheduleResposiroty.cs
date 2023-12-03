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
