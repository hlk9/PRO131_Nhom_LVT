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
    public class ExamRoom
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string Name { get; set; }

        [AllowNull]
        public bool? Status { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Address { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string? Note { get; set; }

        [AllowNull]
        public int? Capacity { get; set; }


        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
    }
}
