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
        ExamScheduleResposiroty _res = new ExamScheduleResposiroty();

        public ExamScheduleService()
        {
            
        }

        public List<ExamSchedule> getAlls()
        {
            return _res.getAll();
        }
    }
}
