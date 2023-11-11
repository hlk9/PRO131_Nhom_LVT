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
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="NVARCHAR")]
        public string Content { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
        [AllowNull]
        public DateTime? CreatedAt { get; set; }
        [AllowNull]
        public DateTime? UpdatedAt { get; set; }
        [AllowNull]
        public string? CreatedBy { get; set; }
        [AllowNull]
        public string? UpdatedBy { get; set; }
        [AllowNull]
        public bool? Status { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }


        public virtual ICollection<AnswerResponse> AnswerResponses { get; set; }

    }
}
