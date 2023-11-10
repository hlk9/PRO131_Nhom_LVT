using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class Classroom
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }

    }
}
