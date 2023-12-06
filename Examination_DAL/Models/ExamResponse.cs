using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Examination_DAL.Models
{
    public class ExamResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ExamDetailId { get; set; }
        [ForeignKey("ExamDetailId")]
        public virtual ExamDetail ExamDetail { get; set; }

        [Required]
        public string ParticipantId { get; set; }
        [MaxLength(255)]
        [ForeignKey("ParticipantId")]
        public virtual Participant Participant { get; set; }

        [AllowNull]
        public string? SubjectId { get; set; }
        [MaxLength(255)]
        [ForeignKey("SubjectId")]
        public virtual Subject? Subject { get; set; }

        [Required]
        public DateTime SubmitTime { get; set; }

        [AllowNull]
        public double? Score { get; set; }

        [AllowNull]
        public byte? Status { get; set; }

        [AllowNull]
        public bool? IsPassed { get; set; }

        [AllowNull]
        public int? QuestionCorrect { get; set; }

        [AllowNull]
        public int? QuestionWrong { get; set; }

        [AllowNull]
        public int? QuestionNotAnswered { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? ScoredBy { get; set; }

        [AllowNull]
        public double? FinishTime { get; set; }

        [AllowNull]
        public bool? ScoredMethod { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Note { get; set; }

        [AllowNull]
        public int ExamScheduleId { get; set; }
        [ForeignKey("ExamScheduleId")]
        public virtual ExamSchedule? ExamSchedule { get; set; }

        public virtual ICollection<AnswerResponse> AnswerResponses { get; set; }     

    }
}
