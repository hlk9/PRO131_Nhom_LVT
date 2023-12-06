using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class PermissionService
    {
        PermissionResposiroty _res = new PermissionResposiroty();

        public PermissionService()
        {
            
        }
        public List<Permission> GetAllPermission()
        {
            return _res.getAll().ToList();
        }

        public Permission GetById(byte id)
        {
            return _res.getPerByID(id);
        }
    }
}
