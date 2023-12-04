using Examination_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class ThiSinhVoiTaiKhoan
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public byte? Status { get; set; }
        public string? ClassroomId { get; set; }
        public virtual Classroom? Classroom { get; set; }
        public string? AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
