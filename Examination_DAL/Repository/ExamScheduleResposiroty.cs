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
    }
}
