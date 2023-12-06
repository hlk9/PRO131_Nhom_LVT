using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class ScheduleWithExamInforViewModel
    {
        public int ScheduleDetailId { get; set; }
        public int ExamScheduleId { get; set; }
        public string ParticipantId { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamStartTime { get; set; }
        public DateTime ExamEndTime { get; set; }
        public int ExamDuration { get; set; }
        public string ExamRoomId { get; set; }
        public int? ExamRepeat { get; set; }
        public string ExamDetailCode { get; set; }
        public string ExamDes { get; set; }
        public int ExamID { get; set; }

    }
}
