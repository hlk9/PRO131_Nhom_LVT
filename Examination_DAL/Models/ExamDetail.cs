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
    public class ExamDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ExamDetailCode { get; set; }

        [Required]
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Description { get; set; }

        [Required]
        public int Duration { get; set; }

        [AllowNull]
        public double PassMark { get; set; }

        [Required]
        public int TotalQuestion { get; set; }

        [Required]
        public double MaxiumMark { get; set; }

        [AllowNull]
        public int? ReTestNumber { get; set; }

        [AllowNull]
        public bool? Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [AllowNull]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual Staff Staff { get; set; }

        [AllowNull]
        public string? UpdatedBy { get; set; }





    }
}
