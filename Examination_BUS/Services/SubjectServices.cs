using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_DAL.Models;
using Examination_DAL.Repository;


namespace Examination_BUS.Services
{
    public class SubjectServices
    {
        SubjectRepository _repos = new SubjectRepository();
        public SubjectServices()
        {
            
        }

        public SubjectServices(SubjectRepository repos)
        {
            _repos = repos;
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
               Status = status,
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
    }
}
