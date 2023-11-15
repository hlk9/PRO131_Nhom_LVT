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
    public class QuestionServices
    {
        QuestionRepository questionRepository;
        ExamQuestionRepository examQuestionRepository;
        AnswerRepository answerRepository;
        public QuestionServices()
        {
            questionRepository = new QuestionRepository();
            examQuestionRepository = new ExamQuestionRepository();
            answerRepository = new AnswerRepository();
        }
        public bool AddQuestion(Question question)
        {
            return questionRepository.AddQuestion(question);
        }
        public bool UpdateQuestion(Question question)
        {
            return questionRepository.UpdateQuestion(question);
        }
        public bool DeleteQuestion(int questionId)
        {
            return questionRepository.DeleteQuestion(questionId);
        }
        public List<Question> GetAllQuestions()
        {
            return questionRepository.GetAllQuestions();
        }
        public Question GetQuestionById(int questionId)
        {
            return questionRepository.GetQuestionById(questionId);
        }

        public QuestionsInExamViewModel GetQuestionsByExamCode(int id)
        {
            List<Question> allQuestion = (from eq in examQuestionRepository.GetAllExamQuestions()
                                          join q in questionRepository.GetAllQuestions() on eq.QuestionId equals q.Id
                                          where eq.ExamDetailId == id
                                          select q).ToList();
            List<Answer> allAnswer = (from q in allQuestion
                                      join a in answerRepository.GetAllAnswers()
                                      on q.Id equals a.QuestionId
                                      select a).ToList();

            QuestionsInExamViewModel questionsInExamViewModel = new QuestionsInExamViewModel();
            questionsInExamViewModel.Questions = allQuestion;
            questionsInExamViewModel.Answers = allAnswer;
            questionsInExamViewModel.ExamDetailID = id;
            return questionsInExamViewModel;



        }
        public QuestionWithAnswerViewModel GetQuestionWithAnswer(int id)
        {
            var answerData = (from q in questionRepository.GetAllQuestions()
                       join a in answerRepository.GetAllAnswers()
                       on q.Id equals a.QuestionId
                       where q.Id == id
                       select a).ToList();

            var questionData = questionRepository.GetQuestionById(id);
            QuestionWithAnswerViewModel questionWithAnswerViewModel = new QuestionWithAnswerViewModel();
            questionWithAnswerViewModel.Id = questionData.Id;
            questionWithAnswerViewModel.Content = questionData.Content;
            questionWithAnswerViewModel.Point = questionData.Point;
            questionWithAnswerViewModel.QuestionType = questionData.QuestionLevelId;
            questionWithAnswerViewModel.QuestionLevel = questionData.QuestionLevelId;
            questionWithAnswerViewModel.Subject = questionData.SubjectId;
            questionWithAnswerViewModel.Docs = questionData.Docs;
            questionWithAnswerViewModel.Status = questionData.Status;
            questionWithAnswerViewModel.Answers = answerData;
            return questionWithAnswerViewModel;


        }

    }
}
