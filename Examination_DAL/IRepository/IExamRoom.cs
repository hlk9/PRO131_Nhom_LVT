using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface IExamRoom
    {
        List<ExamRoom>  GetExamRooms();
        List<ExamRoom> GetAllRoomRemove();
        bool CreateExamRoom(ExamRoom room);
        bool UpdateExamRoom(ExamRoom room);
        bool DeleteExamRoom(ExamRoom room);

    }
}
