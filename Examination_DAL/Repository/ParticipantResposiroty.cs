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
    public class ParticipantResposiroty : IParticipants
    {
        ExaminationDbContext _context  = new ExaminationDbContext();

        public ParticipantResposiroty()
        {
            
        }

        public bool addStudent(Participant par)
        {
            try
            {
                _context.Participants.Add(par);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteStudents(Participant pr)
        {
            try
            {
                var dele = _context.Participants.Find(pr.Id);

                dele.Status = pr.Status;

                _context.Participants.Update(dele);
                _context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public List<Participant> GetAll()
        {
           return _context.Participants.ToList();
        }

        public List<Participant> getStudentRemove()
        {
            return _context.Participants.Where(x => x.Status == 255).ToList();
        }

        public bool updateSutudent(Participant par)
        {
            try
            {
                var update = _context.Participants.Find(par.Id);
                update.Id = par.Id;
                update.FullName = par.FullName;
                update.Status = par.Status;
                update.Address = par.Address;
                update.PhoneNumber = par.PhoneNumber;
                update.Gender = par.Gender;
                update.Email = par.Email;
                update.DateOfBirth = par.DateOfBirth;
                update.ClassroomId = par.ClassroomId;
                update.AccountId = par.AccountId;

                _context.Participants.Update(update);
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
