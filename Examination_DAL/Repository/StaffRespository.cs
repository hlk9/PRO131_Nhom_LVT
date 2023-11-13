using Examination_DAL.Context;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.Repository
{
    public class StaffRespository
    {
        ExaminationDbContext _context;
        public StaffRespository()
        {
            _context = new ExaminationDbContext();
        }
        public bool Add(Staff staff)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetAll()
        {
            return _context.Staffs.ToList();
        }

        public Staff GetById(int id)
        {
            return _context.Staffs.Find(id);
        }

        public bool Update(Staff staff)
        {
            throw new NotImplementedException();
        }
    }
}
