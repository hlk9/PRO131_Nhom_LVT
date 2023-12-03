using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class ExamSchedule_ResponsesViewModel
    {
        public int idExamSchedule { get; set; }

        public int idExamResponses { get; set; }

        public string nameSchedule { get; set; }

        public string subject { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double Score { get; set; }

        public int QuestionCorrect { get; set; }

        public int QuestionWrong { get; set; }

        public int QuestionNotAnswered { get; set; }
    }
}
