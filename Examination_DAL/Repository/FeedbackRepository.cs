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
    public class FeedbackRepository : IFeedback
    {
        ExaminationDbContext _context = new ExaminationDbContext();
        public FeedbackRepository()
        {
            
        }

        public FeedbackRepository(ExaminationDbContext context)
        {
            _context = context;
        }

        public List<Feedback> GetAll()
        {
            return _context.Feedback.ToList();
        }

        public Feedback GetFeedBackById(int ID)
        {
            return _context.Feedback.Where(p => p.Id == ID).FirstOrDefault();
        }

        public bool SendFeedback(Feedback fback)
        {
            try
            {
                _context.Feedback.Add(fback);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
