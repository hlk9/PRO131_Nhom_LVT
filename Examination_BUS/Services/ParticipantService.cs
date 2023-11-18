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

        public List<Participant> getAllRemoveStudents()
        {
            return _respos.getStudentRemove();
        }

        public bool addStudents(string id, string FullName, bool Gender, DateTime DateOfBirth, string Email, string PhoneNumber, string Address, byte Status, string ClassRoomId, string AccountId)
        {
            Participant pr = new Participant()
            {
                Id = id,
                FullName = FullName,
                Gender = Gender,
                DateOfBirth = DateOfBirth,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Address = Address,
                Status = Status,
                AccountId = AccountId,
                ClassroomId = ClassRoomId
            };

            if (_respos.addStudent(pr)) return true;
            return false;
        }

        public bool updateStudents(string id, string FullName, bool Gender, DateTime DateOfBirth, string Email, string PhoneNumber, string Address, byte Status, string ClassRoomId, string AccountId)
        {
            Participant pr = new Participant()
            {
                Id = id,
                FullName = FullName,
                Gender = Gender,
                DateOfBirth = DateOfBirth,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Address = Address,
                Status = Status,
                AccountId = AccountId,
                ClassroomId = ClassRoomId
            };

            if (_respos.updateSutudent(pr)) return true;
            return false;
        }

        public bool deleStudent(string id, byte status)
        {
            Participant pr = new Participant()
            {
                Id = id,
                Status = status
            };

            if (_respos.deleteStudents(pr)) return true;
            return false;
        }
    }
}
