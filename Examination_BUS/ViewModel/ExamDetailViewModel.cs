using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    

    public class ExamDetailViewModel
    {

        public int ExamId { get; set; }     
        public string? ExamCode { get; set; }      
        public string Name { get; set; }      
        public string? SubjectId { get; set; }
        public int ExamDetailId { get; set; }
        public string ExamDetailCode { get; set; }    
        public string? Description { get; set; }      
        public int Duration { get; set; }
        public double PassMark { get; set; }
        public int TotalQuestion { get; set; }
        public double MaxiumMark { get; set; }
        public int? ReTestNumber { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

    }
}
