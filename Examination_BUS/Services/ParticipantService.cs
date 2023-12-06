using Examination_BUS.ViewModel;
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
        AccountRepository _resposAcc = new AccountRepository();

        public ParticipantService()
        {
            
        }
        public Participant GetOneByID(string id)
        {
            return _respos.GetParticipantById(id);
        }

        public List<Participant> getAllStudents()
        {
            return _respos.GetAll();
        }

        public List<Participant> getAllRemove()
        {
            return _respos.getAllRemove();
        }

        public List<Participant> GetAllParByClassIds(string classId)
        {
            return _respos.GetAllByClassId(classId);
        }
        public List<Account> GetAccountById(string accountId)
        {
            return _respos.GetAllByAccountId(accountId);
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
        public bool updateAccountId(string id, string accountId)
        {
            Participant student = new Participant()
            {
                Id = id,
                AccountId = accountId
            };
            return _respos.UpdateAccountIdToParticipant(student);
        }
        public bool deleteAcountId(string id, string accountId)
        {
            Participant student = new Participant()
            { 
                Id = id,
                AccountId = accountId
            };
            return _respos.DeleteAccountId(student);
        }

        public bool updateClassIdOfPars(string id, string classId)
        {
            Participant participant = new Participant()
            {
                Id = id,
                ClassroomId = classId
            };

            return _respos.updateClasIdOfPar(participant);
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

        public List<Participant> GetListInClass(string classID)
        {
            return this.getAllStudents().Where(x => x.ClassroomId==classID).ToList();
        }  
    }
}
