using Examination_DAL.Context;
using Examination_DAL.IRepository;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class ExamroomRepository: IExamRoom
    {
        ExaminationDbContext _context = new ExaminationDbContext();
        public ExamroomRepository()
        {
            
        }

        public ExamroomRepository(ExaminationDbContext context)
        {
            _context = context;
        }

        public bool CreateExamRoom(ExamRoom room)
        {
            try
            {
                _context.ExamRooms.Add(room);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExamRoom(ExamRoom room)
        {
            try
            {
                var dele = _context.ExamRooms.Find(room.Id);
                dele.Status = room.Status;

                _context.ExamRooms.Update(dele);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ExamRoom> GetAllRoomRemove()
        {
            return _context.ExamRooms.Where(x => x.Status == false).ToList(); 
        }

        public List<ExamRoom> GetExamRooms()
        {
            return _context.ExamRooms.ToList();
        }

        public bool UpdateExamRoom(ExamRoom room)
        {
            try
            {
                var update = _context.ExamRooms.Find(room.Id);

                update.Id = room.Id;
                update.Name = room.Name;
                update.Status = room.Status;
                update.Address = room.Address;
                update.Note = room.Note;
                update.Capacity = room.Capacity;

                _context.ExamRooms.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
