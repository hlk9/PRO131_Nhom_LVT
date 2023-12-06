using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DAL.IRepository
{
    public interface IStaff
    {
        IEnumerable<Staff> GetAll();
        Staff GetById(int id);
        bool Add(Staff staff);
        bool Update(Staff staff);
        bool Delete(int id);
    }
}
