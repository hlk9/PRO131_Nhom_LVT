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
        [ForeignKey("ParticipantId")]
        public virtual Participant Participant { get; set; }
        [Required]
        public string SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
        [Required]
        public DateTime SubmitTime { get; set; }
        [AllowNull]
        public double? Score { get; set; }
        [Required]
        public byte Status { get; set; }
        [Required]
        public bool IsPassed { get; set; }
        [Required]
        public int QuestionCorrect { get; set; }
        [Required]
        public int QuestionWrong { get; set; }
        [Required]
        public int QuestionNotAnswered { get; set; }
        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? ScoredBy { get; set; }
        [ForeignKey("ScoredBy")]
        public virtual Account Account { get; set; }
        [Required]
        public double FinishTime { get; set; }
        [AllowNull]
        public bool? ScoredMethod { get; set; }
        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? Note { get; set; }

        public virtual ICollection<AnswerResponse> AnswerResponses { get; set; }     

    }
}
