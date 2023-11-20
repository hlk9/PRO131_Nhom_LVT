using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class ParticipantService
    {
        ParticipantResposiroty _respos = new ParticipantResposiroty();

        public ParticipantService()
        {
            
        }

        public List<Participant> getAllStudents()
        {
            return _respos.GetAll();
        }

        public bool createStudents(string id, string name, string address, string email, string phone, bool gender, byte status, DateTime dateOfBirth, string classRoomId)
        {
            var student = new Participant()
            {
                Id = id,
                FullName = name,
                Address = address,
                Email = email,
                PhoneNumber = phone,
                Gender = gender,
                Status = status,
                DateOfBirth = dateOfBirth,
                ClassroomId = classRoomId           
            };

            return _respos.createStudents(student);
        }

        public bool updateStudents(string id, string name, string address, string email, string phone, bool gender, byte status,DateTime dateOfBirth, string classRoomId)
        {
            Participant student = new Participant()
            {
                Id = id,
                FullName = name,
                Address = address,
                Email = email,
                PhoneNumber = phone,
                Gender = gender,
                Status= status,
                DateOfBirth = dateOfBirth,
                ClassroomId = classRoomId
            };

            return _respos.updateStudents(student);
        }

        public bool deleteStudents(string id, byte status)
        {
            Participant student = new Participant()
            {
                Id = id,
                Status = status
            };

            return _respos.deleteStudents(student);
        }
    }
}
