using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class ExamScheduleDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ExamScheduleId { get; set; }
        [ForeignKey("ExamScheduleId")]
        public virtual ExamSchedule ExamSchedule { get; set; }
        [Required]
        public string ParticipantId { get; set; }
        [ForeignKey("ParticipantId")]
        public virtual Participant Participant { get; set; }        

    }
}
