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
    public class AnswerResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        [Required]
        public int AnswerId { get; set; }
        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
        [Required]
        public int ExamResponseId { get; set; }
        [ForeignKey("ExamResponseId")]
        public virtual ExamResponse ExamResponse { get; set; }
        [AllowNull]
        public DateTime? AnswerTime { get; set; }
        
  



    }
}
