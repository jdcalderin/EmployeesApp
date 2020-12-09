using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployessApp.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeBL _IEmployeeLogic;

        public EmployeeController(IEmployeeBL iEmployeeLogic)
        {
            _IEmployeeLogic = iEmployeeLogic;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _IEmployeeLogic.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _IEmployeeLogic.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


    }
}