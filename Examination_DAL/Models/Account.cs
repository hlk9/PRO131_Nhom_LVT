using Microsoft.EntityFrameworkCore;
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
    public class Account
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [AllowNull]
        public DateTime? LastLogin { get; set; }

        [AllowNull]
        public byte? Status { get; set; }

        [Required]
        public int UserPermissionId { get; set; }
        [ForeignKey("UserPermissionId")]
        public virtual UserPermission UserPermission { get; set; }


    }
}
