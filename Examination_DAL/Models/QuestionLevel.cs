﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Models
{
    public class QuestionLevel
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
