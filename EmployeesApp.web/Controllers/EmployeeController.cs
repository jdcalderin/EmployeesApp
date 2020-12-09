using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeesApp.web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmployeesApp.web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApiConfig _myConfiguration;

        public EmployeeController(ApiConfig myConfiguration)
        {
            _myConfiguration = myConfiguration;
        }

        public IActionResult Index()
        {
            //  var obj = GetEmployeesFromService(0); 
            return View(null);
        }


        public JsonResult GetEmployeesFromService(int Id)
        {
            string UrlBase = _myConfiguration.urlBase;
            try
            {
                var httpClient = new HttpClient();
                var content = new HttpResponseMessage();


                if (Id == 0)
                {
                    UrlBase += "GetAllEmployees";
                    content = httpClient.GetAsync(UrlBase).Result;
                    var json = JsonConvert.DeserializeObject<IEnumerable<Employee>>(content.Content.ReadAsStringAsync().Result);

                    return Json(json);
                }
                else
                {
                    UrlBase += "Get?Id=" + Id;
                    content = httpClient.GetAsync(UrlBase).Result;
                    var json = JsonConvert.DeserializeObject<IEnumerable<Employee>>(content.Content.ReadAsStringAsync().Result);

                    return Json(json);
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}