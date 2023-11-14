using Examination_DAL.Models;
using Examination_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_BUS.Services
{
    public class StaffService
    {
        StaffRespository _staffRepos;
        public StaffService()
        {
            _staffRepos = new StaffRespository();
        }
        public IEnumerable<Staff> GetAll()
        {
            return _staffRepos.GetAll();
        }
        public Staff GetStaff(int id)
        {
            return _staffRepos.GetById(id);
        }
        public bool UpDateStaff(string id, string name, bool sex, DateTime dateofbirth, string email, string phone, string address, byte status)
        {
            Staff staff = new Staff
            {
                Id = id,
                FullName = name,
                Gender = sex,
                DateOfBirth = dateofbirth,
                Email = email,
                PhoneNumber = phone,
                Address = address,
                Status = status
            };
            return _staffRepos.Update(staff);
        }
    }
}
