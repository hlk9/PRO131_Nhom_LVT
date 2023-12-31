﻿using Examination_DAL.Context;
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

        public bool createStudents(Participant par)
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

        public bool deleteStudents(Participant par)
        {
            try
            {
                var dele = _context.Participants.Find(par.Id);

                dele.Status = par.Status;

                _context.Participants.Update(dele);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteAccountId(Participant par)
        {
            try
            {
                var dele = _context.Participants.Find(par.Id);
                
                dele.Id = par.Id;
                dele.AccountId = par.AccountId;
                _context.Participants.Update(dele);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Participant> GetAll()
        {
           return _context.Participants.ToList();
        }

        public List<Participant> GetAllByClassId(string classId)
        {
            return _context.Participants.Where(x => x.ClassroomId == classId).ToList();
        }

        public List<Account> GetAllByAccountId(string accountId)
        {
            return _context.Accounts.Where(x => x.Id == accountId).ToList();
        }
        public List<Participant> getAllRemove()
        {
            return _context.Participants.Where(x => x.Status == 255).ToList();
        }

        public bool updateStudents(Participant par)
        {
            try
            {
                var update = _context.Participants.Find(par.Id);

                update.Id = par.Id;
                update.Address = par.Address;
                update.FullName = par.FullName;
                update.Email = par.Email;
                update.Gender = par.Gender;
                update.DateOfBirth = par.DateOfBirth;
                update.Status = par.Status;
                update.PhoneNumber = par.PhoneNumber;
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

        public bool UpdateAccountIdToParticipant(Participant participant)
        {
            try
            {
                var update = _context.Participants.Find(participant.Id);
                update.Id = participant.Id;
                update.AccountId = participant.AccountId;

                _context.Participants.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateClasIdOfPar(Participant par)
        {
            try
            {
                var update = _context.Participants.Find(par.Id);

                update.Id = par.Id;
                update.ClassroomId = par.ClassroomId;

                _context.Participants.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Participant GetParticipantById(string id)
        {
            return _context.Participants.Find(id);
        }

    }
}
