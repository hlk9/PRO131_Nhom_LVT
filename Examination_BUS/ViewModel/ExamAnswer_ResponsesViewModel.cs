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
    public class ExamAnswer_ResponsesViewModel
    {
        public int Id { get; set; }
        public int ExamDetailId { get; set; }
        public string ParticipantId { get; set; }
        public string SubjectId { get; set; }
        public DateTime SubmitTime { get; set; }
        public double? Score { get; set; }
        public byte? Status { get; set; }
        public bool? IsPassed { get; set; }
        public int? QuestionCorrect { get; set; }
        public int? QuestionWrong { get; set; }
        public int? QuestionNotAnswered { get; set; }
        public string? ScoredBy { get; set; }
        public double? FinishTime { get; set; }
        public bool? ScoredMethod { get; set; }
        public string? Note { get; set; }
        public int IdExam { get; set; }
        public string NameExam { get; set; }
        public string ExamDetailcode { get; set; }
        public int IdAnswers { get; set; }
        public List<AnswerResponse> answerResponses { get; set; }
    }
}
