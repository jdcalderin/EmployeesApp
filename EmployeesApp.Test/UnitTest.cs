using EmployessApp.BL;
using EmployessApp.Data;
using EmployessApp.Data.Repositories;
using EmployessApp.Data.Repositories.Interfaces;
using NUnit.Framework;
using System.Threading.Tasks;

namespace EmployeesApp.Test
{
    
    public class Tests
    {
        IEmployeeRepository _IEmployeeRepository;
        AutoMapConfig mapper;

        [SetUp]
        public void Setup()
        {
            mapper = new AutoMapConfig();
            AutoMapConfig.Initialize(); 
        }

        [Test]
        public async Task GetEmployees()
        {
            _IEmployeeRepository = new EmployeeRepository();

            EmployeeBL obj = new EmployeeBL(_IEmployeeRepository);
            var result = await obj.GetAll();
            
            Assert.IsTrue(result.Count >1);

        }
    }
}