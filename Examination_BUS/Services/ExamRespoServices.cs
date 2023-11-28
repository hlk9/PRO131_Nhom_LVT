using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamRespoServices
    {
        ExamResponsesRepository _res = new ExamResponsesRepository();

        public ExamRespoServices()
        {
            
        }

        public List<ExamResponse> getAll()
        {
            return _res.GetAllExamResponse();
        }

        public List<ExamResponse> getAllStudent(string id)
        {
            return _res.getAllStudent(id);
        }
    }
}
