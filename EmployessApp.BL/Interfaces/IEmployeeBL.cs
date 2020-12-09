using EmployessApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployessApp.BL.Interfaces
{
   public interface IEmployeeBL
    {
        Task<List<Employee>> GetAll();

        Task<List<Employee>> GetById(int Id);
    }
}
