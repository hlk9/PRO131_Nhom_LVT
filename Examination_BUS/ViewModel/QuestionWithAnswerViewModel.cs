using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.ViewModel
{
    public class QuestionWithAnswerViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double? Point { get; set; }
        public byte? QuestionType { get; set; }
        public byte? QuestionLevel { get; set; }
        public string? Subject { get; set; }
        public string? Docs { get; set; }
        public bool? Status { get; set; }       
        public List<Answer>? Answers { get; set; }
    }
}
