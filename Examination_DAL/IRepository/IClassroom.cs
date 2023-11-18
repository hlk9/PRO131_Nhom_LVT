using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface IClassroom
    {
        IEnumerable<Classroom>  GetClassrooms();
        List<Classroom> GetClassByName(string name);
        bool CreateClass(Classroom room);
        bool UpdateClass(Classroom room);
        bool DeleteClass(string ID);

    }
}
