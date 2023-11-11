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
    public class Staff
    {
        [Key]
        [Required]
        [MaxLength(255)]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string FullName { get; set; }

        [AllowNull]
        public bool? Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string Email { get; set; }

        [AllowNull]
        [MaxLength(30)]
        public string? PhoneNumber { get; set; }

        [AllowNull]
        [Column(TypeName = "NVARCHAR")]
        public string? Address { get; set; }

        [AllowNull]
        public byte? Status { get; set; }

        [AllowNull]
        public string? AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }

        public virtual ICollection<ExamSchedule> ExamSchedules { get; set; }
        public virtual ICollection<ExamResponse> ExamResponses { get; set; }
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

  

    }
}
