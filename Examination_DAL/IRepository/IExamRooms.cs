using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface IExamRooms
    {
        List<ExamRoom> getAllRooms();

        List<ExamRoom> getRoomsRemove();

        bool createExamRoom(ExamRoom room);
        bool updateExamRoom(ExamRoom room);
        bool deleteExamRoom(ExamRoom room);
    }
}
