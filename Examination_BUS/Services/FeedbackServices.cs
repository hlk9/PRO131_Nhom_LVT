using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class FeedbackServices
    {
        FeedbackRepository _repos = new FeedbackRepository();
        public FeedbackServices()
        {
            
        }

        public FeedbackServices(FeedbackRepository repos)
        {
            _repos = repos;
        }
        public List<Feedback> GetAll()
        {
            return _repos.GetAll();
        }
        public Feedback GetFeedBackByID(int ID) 
        {
            return _repos.GetFeedBackById(ID);
        }
       public  bool Send(Feedback fback) 
        {
            var fb = new Feedback()
            {
                Title = fback.Title,
                Name = fback.Name,
                IdParticipant = fback.IdParticipant,
                Content = fback.Content,
                Status = fback.Status,
                SubmitTime = fback.SubmitTime
            };
            return _repos.SendFeedback(fb);
        }
    }
}
