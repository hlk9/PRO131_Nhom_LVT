using Examination_BUS.ViewModel;
using Examination_DAL.Models;
using Examination_DAL.Repository;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_BUS.Services
{
    public class AccountServices
    {
        AccountRepository _repsAcc;
        StaffRespository _repsStaff;
        UserPermissionRepository _userPermission;
        PermissionResposiroty permissionResposiroty;

        public AccountServices()
        {
            _repsAcc = new AccountRepository();
            _repsStaff = new StaffRespository();
            _userPermission = new UserPermissionRepository();
            permissionResposiroty = new PermissionResposiroty();    

        }
        public bool AddAccount(string id, string name, string passWord)
        {
            Account account = new Account
            {
                Id = id,
                UserName = name,
                Password = passWord,
                Status = 1
            };
            return _repsAcc.Add(account);
        }

        public bool UpdateAccount(string id, string name, string passWord,DateTime? lastLogin)
        {
            Account account = new Account
            {
                Id = id,
                UserName = name,
                Password = passWord,
                LastLogin = lastLogin
            };
            return _repsAcc.Update(account);
        }

        public bool DeleteAccount(string id)
        {
            Account acc = new Account() { Id = id };
            return _repsAcc.Delete(acc);
        }

        public List<Account> GetAllAccounts()
        {
            return _repsAcc.GetAll().ToList();
        }

        public Account GetAccountById(string accountId)
        {
            return _repsAcc.GetByID(accountId);
        }
        public List<Account> GetAllById(string id)
        {
            return _repsAcc.GetAllByID(id);
        }

        public List<Staff_Account_PermissionViewModel> Getstaff_Account_PermissionViewModels()
        {
            var listStaff_Acc_Per = (from acc in _repsAcc.GetAll()
                                     join staff in _repsStaff.GetAll()
                                     on acc.Id equals staff.AccountId
                                     select new Staff_Account_PermissionViewModel
                                     {
                                         IdAccount = acc.Id,
                                         UserName = acc.UserName,
                                         Password = acc.Password,
                                         Id = staff.Id,
                                         FullName = staff.FullName,
                                         Gender = staff.Gender,
                                         Name = permissionResposiroty.getPerByID(_userPermission.GetUserPermissionByAccountID(acc.Id).FirstOrDefault().PermissionId).Name
                                     });
            return listStaff_Acc_Per.ToList();
        }
    }
}
