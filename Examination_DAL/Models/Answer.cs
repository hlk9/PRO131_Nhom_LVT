using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
        [Required]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<AnswerResponse> AnswerResponses { get; set; }

    }
}
