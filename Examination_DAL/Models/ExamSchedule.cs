using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class ExamSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }
        [Required]
        public string ExamRoomId { get; set; }
        [ForeignKey("ExamRoomId")]
        public virtual ExamRoom ExamRoom { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string Subject { get; set; }
        [AllowNull]
        public string? Description { get; set; }
        public virtual ICollection<ExamScheduleDetail> ExamScheduleDetail { get; set;}
    }
}
