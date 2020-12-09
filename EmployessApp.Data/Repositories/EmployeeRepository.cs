using EmployessApp.Data.Model;
using EmployessApp.Data.Repositories.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployessApp.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetAll()
        {
			try
			{
				//http://masglobaltestapi.azurewebsites.net/api/Employees
				var client = new HttpClient();
				HttpResponseMessage response = await client.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");
				response.EnsureSuccessStatusCode();
				string content = await response.Content.ReadAsStringAsync(); 

				return JsonConvert.DeserializeObject<IEnumerable<Employee>>(content);
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
