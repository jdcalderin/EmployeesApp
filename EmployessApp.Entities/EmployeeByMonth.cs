using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities
{
    public class EmployeeByMonth : CalculateSalary
    {
        public override double CalculateAnnualSalary(double salary)
        {
            return salary * 12;
        }


    }
}
