using EmployessApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities
{
    public class MonthEmployeeFactory : IEmployeeFactory
    {
        public CalculateSalary GetEmployee()
        {
            return new EmployeeByMonth(); 
        }
    }

}
