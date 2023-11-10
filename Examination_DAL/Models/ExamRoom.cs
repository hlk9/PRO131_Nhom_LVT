using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class ExamRoom
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        [AllowNull]
        public string? Address { get; set; }
        [AllowNull]
        public string? Note { get; set; }
        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
    }
}
