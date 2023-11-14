using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface ISubject
    {
        IEnumerable<Subject> GetSubjects();
        List<Subject> GetSubjectByname(string name);
        bool AddNewSub (Subject subject);
        bool UpdateSub (Subject subject);
        bool DeleteSub (string ID);

    }
}
