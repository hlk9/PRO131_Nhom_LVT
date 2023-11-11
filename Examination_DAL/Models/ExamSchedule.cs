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
        [Column(TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required]
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        [AllowNull]
        public string? ExamRoomId { get; set; }
        [ForeignKey("ExamRoomId")]
        public virtual ExamRoom ExamRoom { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? Subject { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? Description { get; set; }

        public virtual ICollection<ExamScheduleDetail> ExamScheduleDetail { get; set;}
    }
}
