using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class ExamResponses_DetailViewModel
    {
        public string participantId { get; set; }

        public List<ExamDetail> ExamDetailCode { get; set; }

        public int idExamResponses { get; set; }

        public string SubjectId { get; set; }

        public DateTime SubmitTime { get; set; }

        public double Score { get; set; }

        public bool Ispassed { get; set; }

        public int examDetailId { get; set; }
    }
}
