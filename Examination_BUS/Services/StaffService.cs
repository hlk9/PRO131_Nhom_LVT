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
        public Staff GetStaff(string id)
        {
            return _staffRepos.GetById(id);
        }
        public bool AddStaff(string id, string name, bool sex, DateTime dateofbirth, string email, string phone, string address, byte status)
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
            return _staffRepos.Add(staff);
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
        public bool UpDateAccountStaff(string id, string accountId)
        {
            Staff staff = new Staff
            {
                Id = id,
                AccountId = accountId
            };
            return _staffRepos.UpdateAccountId(staff);
        }

            public bool deleteStaff(string id, byte status) 
        {
            Staff staff = new Staff()
            {
                Id = id,
                Status = status
            };

            return _staffRepos.deleStaff(staff);
        }

        public List<Staff> getStaffAllRemove() 
        {
            return _staffRepos.GetAllStaffRemove();
        }

        public Staff GetStaffById(string id)
        {
            return _staffRepos.GetById(id);
        }
    }
}
