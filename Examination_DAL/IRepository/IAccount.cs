using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IAccount
    {
        bool Add(Account obj);
        bool Update(Account obj);
        bool Delete(Account id);
       
        IEnumerable<Account> GetAll();
        Account GetByID(string id);
       
    }
}
