using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    internal interface IFeedback
    {
        public List<Feedback> GetAll();
        public Feedback GetFeedBackById(int ID);

        bool SendFeedback (Feedback fback);
    }
}
