using EmployessApp.BL.Interfaces;
using EmployessApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployessApp.Data.Repositories;
using EmployessApp.Data.Repositories.Interfaces;
using EmployessApp.Entities.Interfaces;
using AutoMapper;
using System.Linq;
namespace EmployessApp.BL
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRepository _EmployeeRepo;

        public EmployeeBL(IEmployeeRepository employeeRepo)
        {
            _EmployeeRepo = employeeRepo;
        }

        public async Task<List<Employee>> GetAll()
        {
            try
            {
                List<Employee> employesInfo = new List<Employee>();
                var result = await _EmployeeRepo.GetAll();

                employesInfo = Mapper.Map<IEnumerable<EmployessApp.Data.Model.Employee>, IEnumerable<Employee>>(result).ToList();

                employesInfo.ForEach(employees =>
                {
                    EmployeeSalaryCalc(employees);
                });

                return employesInfo;

            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<Employee>> GetById(int id)
        {
            try
            {
                List<Employee> employesInfo = new List<Employee>();
                var result = await _EmployeeRepo.GetAll();

                employesInfo = Mapper.Map<IEnumerable<EmployessApp.Data.Model.Employee>, IEnumerable<Employee>>(result).ToList();

                employesInfo.ForEach(employees =>
                {
                    EmployeeSalaryCalc(employees);
                });

                return employesInfo.Where(e=> e.Id == id).ToList();

            }
            catch (Exception)
            {
                throw;
            }
        }



        private static void EmployeeSalaryCalc(Employee employee)
        {
            IEmployeeFactory factory = null;
            double salary = 0;
            switch (employee.ContractTypeName)
            {
                case "MonthlySalaryEmployee":
                    factory = new HourEmployeeFactory();
                    salary = employee.MonthlySalary;
                    break;
                case "HourlySalaryEmployee":
                    factory = new MonthEmployeeFactory();
                    salary = employee.HourlySalary;
                    break;

                default:
                    salary = 0;
                    break;
            }

            employee.AnnualSalary = factory.GetEmployee().CalculateAnnualSalary(salary);
        }



        
    }
}
