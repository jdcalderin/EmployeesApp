using System;
using System.Collections.Generic;
using System.Text;

namespace EmployessApp.Entities
{
    public abstract class CalculateSalary:Employee
    {
        public abstract double CalculateAnnualSalary(double salary);
    }
}
