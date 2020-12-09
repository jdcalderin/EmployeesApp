using EmployessApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployessApp.Data.Repositories.Interfaces
{
   public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll(); 
    }
}
