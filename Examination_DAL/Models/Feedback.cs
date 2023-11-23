using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Examination_DAL.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(255)]
        public string Name { get; set; }
    
        public string IdParticipant { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(1000)]
        public string Content { get; set; }
        [AllowNull]
         public bool ? Status { get; set; }

    }
}
