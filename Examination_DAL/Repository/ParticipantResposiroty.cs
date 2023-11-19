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

        public bool createStudents(Participant par)
        {
            throw new NotImplementedException();
        }

        public bool deleteStudents(Participant par)
        {
            throw new NotImplementedException();
        }

        public List<Participant> GetAll()
        {
           return _context.Participants.ToList();
        }

        public bool updateStudents(Participant par)
        {
            throw new NotImplementedException();
        }
    }
}
