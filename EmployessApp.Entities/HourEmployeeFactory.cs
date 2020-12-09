using EmployessApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities
{
    public class HourEmployeeFactory : IEmployeeFactory
    {
        public CalculateSalary GetEmployee()
        {
            return new EmployeeByHour();
        }
    }
}
