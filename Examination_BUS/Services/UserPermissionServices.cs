using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class UserPermissionServices
    {
        UserPermissionRepository permissionRepository;

        public UserPermissionServices()
        {
            permissionRepository = new UserPermissionRepository();
        }

        public bool AddUserPermission(UserPermission userPermission)
        {
            return permissionRepository.AddUserPermission(userPermission);
        }

        public bool UpdateUserPermission(UserPermission userPermission)
        {
            return permissionRepository.UpdateUserPermission(userPermission);
        }
        
        public bool DeleteUserPermission(int id)
        {
            return permissionRepository.DeleteUserPermission(id);
        }

        public List<UserPermission> GetAllUserPermissions()
        {
            return permissionRepository.GetAllUserPermissions();
        }

        public UserPermission GetUserPermissionByID(int id)
        {
            return permissionRepository.GetUserPermissionByID(id);
        }
        public UserPermission GetUserPermissionByAccountId(string id)
        {
            return permissionRepository.GetUserPermissionByAccountId(id);
        }
        public List<UserPermission> GetUserPermissionByAccountID(string accountID)
        {
            return permissionRepository.GetUserPermissionByAccountID(accountID);
        }


      
    }
}
