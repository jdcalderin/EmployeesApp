using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities
{
    public class EmployeeByHour : CalculateSalary
    {
        public override double CalculateAnnualSalary(double salary)
        {
            return 120 * salary * 12;
        }

        
    }
}
