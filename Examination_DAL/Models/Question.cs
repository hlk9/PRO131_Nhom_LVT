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
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string Content { get; set; }

        [AllowNull]
        public double? Point { get; set; }

        [AllowNull]
        [Column(Order = 2)]
        public byte? QuestionTypeId { get; set; }
        [ForeignKey("QuestionTypeId")]
        public virtual QuestionType QuestionType { get; set; }

        [AllowNull]
        [Column(Order = 3)]
        public byte? QuestionLevelId { get; set; }
        [ForeignKey("QuestionLevelId")]
        public virtual QuestionLevel QuestionLevel { get; set; }

        [AllowNull]
        [Column(Order = 4)]
        public string? SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? Docs { get; set; }

        [AllowNull]
        public DateTime CreatedTime { get; set; }

        [AllowNull]
        public DateTime? ModifiedTime { get; set; }

        [AllowNull]
        public string CreatedBy { get; set; }

        [AllowNull]
        public string? ModifiedBy { get; set; }

        [AllowNull]
        public bool? Status { get; set; }


        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AnswerResponse> AnswerResponses { get; set; }




    }
}
