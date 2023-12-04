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
    public class AccountRepository : IAccount
    {

        ExaminationDbContext context;
        public AccountRepository()
        {
            context = new ExaminationDbContext();
        }

        public bool Add(Account obj)
        {
            try
            {
                context.Accounts.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Account id)
        {
            try
            {
                var account = context.Accounts.Find(id.Id);
                account.Id = id.Id;
                account.Status = 0;

                context.Accounts.Update(account);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Account> GetAll()
        {
            return context.Accounts.ToList();
        }

        public Account GetByID(string id)
        {
            return context.Accounts.Find(id);
        }

        public bool Update(Account obj)
        {
            try
            {
                var account = context.Accounts.Find(obj.Id);
                account.UserName = obj.UserName;
                account.Password = obj.Password;
                account.Status = obj.Status;
                
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
