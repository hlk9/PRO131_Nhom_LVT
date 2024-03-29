using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_DAL.Repository;


namespace Examination_BUS.Services
{
    public class SubjectServices
    {
        SubjectRepository _repos = new SubjectRepository();

        ExamResponsesRepository _reposExamResponses = new ExamResponsesRepository();

        ExamDetailRepository _reposExamDetail = new ExamDetailRepository();
        public SubjectServices()
        {
            
        }

        public SubjectServices(SubjectRepository repos)
        {
            _repos = repos;
        }
       

        public Subject GetOneWithID(string id)
        {
            return _repos.GetOneSubjectByID(id);
        }

        public List<Subject> GetSubjects()
        {
            return _repos.GetSubjects().ToList();
        }
        public List<Subject> GetSubjectByName(string name)
        {
            return _repos.GetSubjectByname(name).ToList();
        }
        public bool AddSub(string name, string ID, byte status)//truyền vào các thuộc tính
        {
            var sub = new Subject()
            {
                Name = name,
               Id = ID,
               Status = status
             
            };
            return _repos.AddNewSub(sub);

        }
        public bool RemoveSub(string ID)
        {
            return _repos.DeleteSub(ID);
        }
        public bool EditSub(string ID, string name, byte status)
        {
            Subject subject = new Subject()
            {
                Name= name,
                Id= ID,
                Status = status,

            };
            return _repos.UpdateSub(subject);
        }

        public List<ExamResponses_DetailViewModel> GetSubject_ViewModel(string id)
        {
            var examDetail = from exam in _reposExamResponses.GetAllExamResponse()
                      join exD in _reposExamDetail.GetAll()
                      on exam.ExamDetailId equals exD.Id
                      select new ExamResponses_DetailViewModel
                      {
                          participantId = exam.ParticipantId,
                          SubjectId = exam.SubjectId,
                          idExamResponses = exam.Id,
                          SubmitTime = exam.SubmitTime,
                          Score = Convert.ToDouble(exam.Score),
                          Ispassed = Convert.ToBoolean(exam.IsPassed),
                          examDetailId = exam.ExamDetailId,
                          ExamDetailCode = exD.ExamDetailCode
                      };

            if(id == null)
            {
                return examDetail.ToList();
            }
            else
            {
                return examDetail.Where(x => x.SubjectId == id).ToList();
            }
        }
    }
}
