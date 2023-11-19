using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class UserPermissionRepository
    {
        ExaminationDbContext context;
        public UserPermissionRepository()
        {
            context = new ExaminationDbContext();
        }

        public bool AddUserPermission(UserPermission obj)
        {
            try
            {
                context.UserPermissions.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUserPermission(int id)
        {
            try
            {
                var userPermission = context.UserPermissions.Find(id);
                context.UserPermissions.Remove(userPermission);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UserPermission> GetAllUserPermissions()
        {
            return context.UserPermissions.ToList();
        }

        public UserPermission GetUserPermissionByID(int id)
        {
            return context.UserPermissions.Find(id);
        }

        public List<UserPermission> GetUserPermissionByAccountID(string accountID)
        {
            return context.UserPermissions.Where(x => x.AccountId == accountID).ToList();
        }

    }
}
