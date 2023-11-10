using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class QuestionType
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
