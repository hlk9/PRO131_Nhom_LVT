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
    public class ExamRoomResposiroty : IExamRooms
    {
        ExaminationDbContext _context = new ExaminationDbContext();

        public ExamRoomResposiroty()
        {
            
        }

        public bool createExamRoom(ExamRoom room)
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

        public bool deleteExamRoom(ExamRoom room)
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

        public List<ExamRoom> getAllRooms()
        {
            return _context.ExamRooms.ToList();
        }

        public List<ExamRoom> getRoomsRemove()
        {
            return _context.ExamRooms.Where(x => x.Status == false).ToList();
        }

        public bool updateExamRoom(ExamRoom room)
        {
            try
            {
                var update = _context.ExamRooms.Find(room.Id);

                update.Id = room.Id;
                update.Name = room.Name;    
                update.Status = room.Status;
                update.Address = room.Address;
                update.Capacity = room.Capacity;
                update.Note = room.Note;

                _context.ExamRooms.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ExamRoom getExamRoomById(string id)
        {
            return _context.ExamRooms.Find(id);
        }
    }
}
