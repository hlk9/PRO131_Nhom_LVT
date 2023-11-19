using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface IParticipants
    {
        List<Participant> GetAll();

        bool createStudents(Participant par);

        bool updateStudents(Participant par);

        bool deleteStudents(Participant par);
    }
}
