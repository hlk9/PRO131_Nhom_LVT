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
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        [AllowNull]
        public string? ExamRoomId { get; set; }
        [ForeignKey("ExamRoomId")]
        public virtual ExamRoom? ExamRoom { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Subject { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Description { get; set; }

        [AllowNull]
        public bool? Status { get; set; }

        [AllowNull]
        public string? CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual Staff? Staff { get; set; }

        [AllowNull]
        public string? ClassRoomId { get; set; }
        [ForeignKey("ClassRoomId")]
        public virtual Classroom? ClassRoom { get; set; }
        

        public virtual ICollection<ExamScheduleDetail> ExamScheduleDetail { get; set;}
    }
}
