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
            try
            {
                _context.Add(staff);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
            try
            {
                var upDate = _context.Staffs.Find(staff.Id);
                upDate.FullName = staff.FullName;
                upDate.Gender = staff.Gender;
                upDate.DateOfBirth = staff.DateOfBirth;
                upDate.Email = staff.Email;
                upDate.PhoneNumber = staff.PhoneNumber;
                upDate.PhoneNumber = staff.PhoneNumber;
                upDate.Address = staff.Address;
                upDate.Status = staff.Status;

                _context.Staffs.Update(staff);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
