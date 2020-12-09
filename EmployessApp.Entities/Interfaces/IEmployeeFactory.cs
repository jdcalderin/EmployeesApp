using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities.Interfaces
{
   public interface IEmployeeFactory
    {
        CalculateSalary GetEmployee(); 
    }
}
