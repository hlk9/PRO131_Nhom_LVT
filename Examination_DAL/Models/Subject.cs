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
    public class Subject
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName ="NVARCHAR")]
        public string Name { get; set; }

        [AllowNull] 
        public byte Status { get; set; }

        [AllowNull]
        public string? Description { get; set;}

        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ExamResponse> ExamResponses { get; set; }

    }
}
