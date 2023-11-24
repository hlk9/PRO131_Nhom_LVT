using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ExamRoomServices
    {
        ExamRoomResposiroty _res = new ExamRoomResposiroty();

        public ExamRoomServices()
        {
            
        }
        public ExamRoom GetExamRoomById(string id)
        {
            return _res.getExamRoomById(id);
        }

        public bool createExamRoom(string id, string name, string address, string note, int capacity, bool status) 
        {
            var room = new ExamRoom()
            {
                Id = id,
                Name = name,
                Address = address,
                Note = note,
                Capacity = capacity,
                Status = status
            };

            return _res.createExamRoom(room);
        }

        public bool updateExamRoom(string id, string name, string address, string note, int capacity, bool status)
        {
            ExamRoom room = new ExamRoom()
            {
                Id = id,
                Name = name,
                Address = address,
                Note = note,
                Capacity = capacity,
                Status = status
            };

            return _res.updateExamRoom(room);
        }

        public bool deleteExamRoom(string id, bool status)
        {
            ExamRoom room = new ExamRoom()
            {
                Id = id,
                Status = status
            };

            return _res.deleteExamRoom(room);
        }

        public List<ExamRoom> getAllRooms()
        {
            return _res.getAllRooms();
        }

        public List<ExamRoom> getAllRoomRemoves()
        {
            return _res.getRoomsRemove();
        }
    }
}
