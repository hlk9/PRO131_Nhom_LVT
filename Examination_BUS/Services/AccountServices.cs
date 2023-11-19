using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class AccountServices
    {
        AccountRepository accountRepository;
        public AccountServices()
        {
            accountRepository = new AccountRepository();
        }
        public bool AddAccount(Account account)
        {
            return accountRepository.Add(account);
        }

        public bool UpdateAccount(Account account)
        {
            return accountRepository.Update(account);
        }

        public bool DeleteAccount(string accountId)
        {
            return accountRepository.Delete(accountId);
        }

        public List<Account> GetAllAccounts()
        {
            return accountRepository.GetAll().ToList();
        }

        public Account GetAccountById(string accountId)
        {
            return accountRepository.GetByID(accountId);
        }


    }
}
