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
        List<Classroom>  GetClassrooms();

        bool CreateClass(Classroom room);

        bool UpdateClass(Classroom room);

        bool DeleteClass(Classroom room);
    }
}
