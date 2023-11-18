using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Examination_DAL.Models;
using Examination_DAL.Repository;

namespace Examination_BUS.Services
{
    
    public class ExamroomServices
    {
        ExamroomRepository _repos = new ExamroomRepository();
        public ExamroomServices()
        {
            
        }

        public ExamroomServices(ExamroomRepository repos)
        {
            _repos = repos;
        }
        public List<ExamRoom> GetExamRooms()
        {
            return _repos.GetExamRooms();
        }

        public List<ExamRoom> GetAllExamRoomRemove()
        {
            return _repos.GetAllRoomRemove().ToList();
        }

        public bool AddExamRoom(string id, string name, string address, string note, int capacity, bool status)
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
            return _repos.CreateExamRoom(room);
        }

        public bool RemoveExamRoom(string id, bool status)
        {
            ExamRoom room = new ExamRoom()
            {
                Id= id,
                Status = status
            };

            return _repos.DeleteExamRoom(room);
        }

        public bool UpdateExamRoom(string id, string name, string address, string note, int capacity, bool status)
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
            return _repos.UpdateExamRoom(room);

        }

    }
}
