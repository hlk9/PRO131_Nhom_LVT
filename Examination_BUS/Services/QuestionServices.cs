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
        ExamDetailRepository examDetailRepository;
        public QuestionServices()
        {
            questionRepository = new QuestionRepository();
            examQuestionRepository = new ExamQuestionRepository();
            answerRepository = new AnswerRepository();
            examDetailRepository = new ExamDetailRepository();
        }

        public int AddQuestionReturnId(Question question)
        {
            return questionRepository.AddQuestionReturnId(question);
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
            return questionRepository.GetAllQuestionsActive();
        }
        public Question GetQuestionById(int questionId)
        {
            return questionRepository.GetQuestionById(questionId);
        }

        public bool DisableQuestion(int questionId)
        {

            var q = GetQuestionById(questionId);
            q.Status = false;

            return questionRepository.UpdateQuestion(q);
        }

        public QuestionsInExamViewModel GetQuestionsByExamCode(string code)
        {
            List<Question> allQuestion = (from eq in examQuestionRepository.GetAllExamQuestions()
                                          join q in questionRepository.GetAllQuestionsActive()
                                          on eq.QuestionId equals q.Id
                                          join ed in examDetailRepository.GetAll()
                                          on eq.ExamDetailId equals ed.Id                                        
                                          where ed.ExamDetailCode == code
                                          select q).ToList();
            List<Answer> allAnswer = (from q in allQuestion
                                      join a in answerRepository.GetAllAnswers()
                                      on q.Id equals a.QuestionId
                                      select a).ToList();

            QuestionsInExamViewModel questionsInExamViewModel = new QuestionsInExamViewModel();
            questionsInExamViewModel.Questions = allQuestion;
            questionsInExamViewModel.Answers = allAnswer;
            questionsInExamViewModel.ExamDetailCode = code;
            return questionsInExamViewModel;



        }
        public QuestionWithAnswerViewModel GetQuestionWithAnswer(int id)
        {
            var answerData = (from q in questionRepository.GetAllQuestionsActive()
                              join a in answerRepository.GetAllAnswers()
                              on q.Id equals a.QuestionId
                              where q.Id == id
                              select a).ToList();

            var questionData = questionRepository.GetQuestionById(id);
            QuestionWithAnswerViewModel questionWithAnswerViewModel = new QuestionWithAnswerViewModel();
            questionWithAnswerViewModel.Id = questionData.Id;
            questionWithAnswerViewModel.Content = questionData.Content;
            questionWithAnswerViewModel.Point = questionData.Point;
            questionWithAnswerViewModel.QuestionType = questionData.QuestionTypeId;
            questionWithAnswerViewModel.QuestionLevel = questionData.QuestionLevelId;
            questionWithAnswerViewModel.Subject = questionData.SubjectId;
            questionWithAnswerViewModel.Docs = questionData.Docs;
            questionWithAnswerViewModel.Status = questionData.Status;
            questionWithAnswerViewModel.Answers = answerData;
            return questionWithAnswerViewModel;


        }

        public QuestionWithAnswerViewModel GetQuestionWithTRUEAnswer(int id)
        {
            var answerData = (from q in questionRepository.GetAllQuestionsActive()
                              join a in answerRepository.GetAllAnswers()
                              on q.Id equals a.QuestionId
                              where q.Id == id
                              && a.IsCorrect == true
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


        public List<QuestionWithAnswerViewModel> GetListQuestionWithLevel(byte? level)
        {

            var data = from ojb in questionRepository.GetAllQuestionsActive()
                       where ojb.QuestionLevelId == level
                       select new QuestionWithAnswerViewModel
                       {
                           Id = ojb.Id,
                           Content = ojb.Content,
                           Point = ojb.Point,
                           QuestionType = ojb.QuestionTypeId,
                           QuestionLevel = ojb.QuestionLevelId,
                           Subject = ojb.SubjectId,
                           Docs = ojb.Docs,
                           Status = ojb.Status,
                           Answers = (from a in answerRepository.GetAllAnswers()
                                      where a.QuestionId == ojb.Id
                                      select a).ToList()
                       };
            return data.ToList();


        }
        public List<QuestionWithAnswerViewModel> GetListQuestionWithSubject(string subject)
        {

            var data = from ojb in questionRepository.GetAllQuestionsActive()
                       where ojb.SubjectId == subject
                       select new QuestionWithAnswerViewModel
                       {
                           Id = ojb.Id,
                           Content = ojb.Content,
                           Point = ojb.Point,
                           QuestionType = ojb.QuestionTypeId,
                           QuestionLevel = ojb.QuestionLevelId,
                           Subject = ojb.SubjectId,
                           Docs = ojb.Docs,
                           Status = ojb.Status,
                           Answers = (from a in answerRepository.GetAllAnswers()
                                      where a.QuestionId == ojb.Id
                                      select a).ToList()
                       };
            return data.ToList();
        }

        public List<QuestionWithAnswerViewModel> GetListQuestionWithType(byte? type)
        {
            var data = from ojb in questionRepository.GetAllQuestionsActive()
                       where ojb.QuestionTypeId == type
                       select new QuestionWithAnswerViewModel
                       {
                           Id = ojb.Id,
                           Content = ojb.Content,
                           Point = ojb.Point,
                           QuestionType = ojb.QuestionTypeId,
                           QuestionLevel = ojb.QuestionLevelId,
                           Subject = ojb.SubjectId,
                           Docs = ojb.Docs,
                           Status = ojb.Status,
                           Answers = (from a in answerRepository.GetAllAnswers()
                                      where a.QuestionId == ojb.Id
                                      select a).ToList()
                       };
            return data.ToList();

        }

        public List<QuestionWithAnswerViewModel> GetListQuestionWithTypeAndLevel(byte? type, byte? level,string subjectID)
        {
            var data = from ojb in questionRepository.GetAllQuestionsActive()
                       where ojb.QuestionTypeId == type && ojb.QuestionLevelId == level && ojb.SubjectId == subjectID
                       select new QuestionWithAnswerViewModel
                       {
                           Id = ojb.Id,
                           Content = ojb.Content,
                           Point = ojb.Point,
                           QuestionType = ojb.QuestionTypeId,
                           QuestionLevel = ojb.QuestionLevelId,
                           Subject = ojb.SubjectId,
                           Docs = ojb.Docs,
                           Status = ojb.Status,
                           Answers = (from a in answerRepository.GetAllAnswers()
                                      where a.QuestionId == ojb.Id
                                      select a).ToList()
                       };
            return data.ToList();

        }

      

    }
}
