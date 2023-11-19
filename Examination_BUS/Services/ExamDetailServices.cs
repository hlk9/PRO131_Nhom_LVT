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
    public class ExamDetailServices
    {
        ExamDetailRepository _examDetailRepos;
        ExamRepository _examRepos;
        public ExamDetailServices()
        {
            _examDetailRepos = new ExamDetailRepository();
            _examRepos = new ExamRepository();
        }

        public IEnumerable<ExamDetail> GetAll()
        {
            return _examDetailRepos.GetAll();
        }

        public ExamDetail GetById(int id)
        {
            return _examDetailRepos.GetByID(id);
        }

        public ExamDetail GetByCode(string code)
        {
            return _examDetailRepos.GetByCode(code);
        }

        public IEnumerable<ExamDetailViewModel> GetExamDetailWithExam()
        {
            var data = from examDetail in _examDetailRepos.GetAll()
                       join exam in _examRepos.GetAll()
                       on examDetail.ExamId equals exam.Id
                       select new ExamDetailViewModel
                       {
                           ExamId = examDetail.ExamId,
                           ExamCode = exam.ExamCode,
                           Name = exam.Name,
                           SubjectId = exam.SubjectId,
                           ExamDetailId = examDetail.Id,
                           ExamDetailCode = examDetail.ExamDetailCode,
                           Description = examDetail.Description,
                           Duration = examDetail.Duration,
                           PassMark = examDetail.PassMark,
                           TotalQuestion = examDetail.TotalQuestion,
                           MaxiumMark = examDetail.MaxiumMark,
                           ReTestNumber = examDetail.ReTestNumber,
                           Status = examDetail.Status,
                           CreatedAt = examDetail.CreatedAt,
                           UpdatedAt = examDetail.UpdatedAt,
                           CreatedBy = examDetail.CreatedBy,
                           UpdatedBy = examDetail.UpdatedBy
                       };
            return data.ToList();
        }

        public bool Add(ExamDetail examDetail)
        {
            return _examDetailRepos.Add(examDetail);
        }

        public bool Update(ExamDetail examDetail)
        {
            return _examDetailRepos.Update(examDetail);
        }

        public bool Delete(int id)
        {
            return _examDetailRepos.Delete(id);
        }

        public bool DeleteByCode(string code)
        {
            return _examDetailRepos.DeleteByCode(code);
        }

        public ExamDetail GetByExamDetailCode(string code)
        {
            return _examDetailRepos.GetByCode(code);
        }




    }
}
