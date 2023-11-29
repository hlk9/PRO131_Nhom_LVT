using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamQuestionServices
    {
        ExamQuestionRepository examQuestionRepository;
        public ExamQuestionServices()
        {
            examQuestionRepository = new ExamQuestionRepository();
        }
        public bool AddExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.AddExamQuestion(examQuestion);
        }
        public bool UpdateExamQuestion(ExamQuestion examQuestion)
        {
            return examQuestionRepository.UpdateExamQuestion(examQuestion);
        }
        public bool DeleteExamQuestion(int examQuestionId)
        {
            return examQuestionRepository.DeleteExamQuestion(examQuestionId);
        }
        public List<ExamQuestion> GetAllExamQuestions()
        {
            return examQuestionRepository.GetAllExamQuestions();
        }
        public ExamQuestion GetExamQuestionById(int examQuestionId)
        {
            return examQuestionRepository.GetExamQuestionById(examQuestionId);
        }

        public List<ExamQuestionWithPointViewModel> GetQuestionInExamWithPoint(string examDetailCode)
        {
            QuestionServices questionServices = new QuestionServices();
            ExamDetailServices examDetailServices = new ExamDetailServices();
            int examDetailId = examDetailServices.GetByExamDetailCode(examDetailCode).Id;

            var dataQ = from q in questionServices.GetAllQuestions()
                        join eq in examQuestionRepository.GetAllExamQuestions()
                        on q.Id equals eq.QuestionId
                        where eq.ExamDetailId == examDetailId
                        select new ExamQuestionWithPointViewModel
                        {
                            QuestionId = q.Id,
                            ExanDetailCode = examDetailCode,
                            Point = Convert.ToDouble(q.Point)
                        };

            var dataEQ = from eq in examQuestionRepository.GetAllExamQuestions()
                       where eq.ExamDetailId == examDetailId
                       select new ExamQuestionWithPointViewModel
                       {
                           QuestionId = eq.QuestionId,
                           ExanDetailCode = examDetailCode,
                           Point = Convert.ToDouble(eq.Score)
                       };


            foreach (var item in dataEQ)
            {
               if(item.Point==0)
                {
                    item.Point = dataQ.Where(x => x.QuestionId == item.QuestionId).FirstOrDefault().Point;
                }
            }

            return dataEQ.ToList();


        }

    }
}
