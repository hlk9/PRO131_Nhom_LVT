using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class ExamQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        //[Required]
        //[Column(Order = 2)]
        //public int ExamDetailId { get; set; }
        //[ForeignKey("ExamDetailId")]
        //public virtual ExamDetail ExamDetail { get; set; }
 

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }

    }
}
