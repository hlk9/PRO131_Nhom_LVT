using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class PermissionResposiroty
    {
        ExaminationDbContext _context;

        public PermissionResposiroty()
        {
            _context = new ExaminationDbContext();
        }

        public List<Permission> getAll()
        {
            return _context.Permissions.ToList();
        }

        public Permission getPerByID(byte id)
        {
            return _context.Permissions.Find(id);
        }
    }
}
