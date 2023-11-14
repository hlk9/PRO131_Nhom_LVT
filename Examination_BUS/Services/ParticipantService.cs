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
    }
}
