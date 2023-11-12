using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class Classroom
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string Name { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }

    }
}
