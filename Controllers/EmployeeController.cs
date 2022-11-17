using CompanyDataBase.Entities;
using CompanyDataBase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeServices employeeServices;
        public EmployeeController(EmployeeServices employeeServices) 
        { 
            this.employeeServices = employeeServices;
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeServices.AddEmployee(employee);
            return Ok();
        }
        [HttpGet("GetEmployees")]
        public IActionResult GetEmployee()
        {
            var getAll = employeeServices.getEmployees();
            return Ok(getAll);
        }
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetById(int id)
        {
            var emp = employeeServices.GetEmployeeById(id);
            return Ok(emp);
        }
        [HttpPut("updateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var emp = employeeServices.UpdateEmployee(id, employee);
            return Ok(emp);
        }
        [HttpDelete("DeletebyId/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            employeeServices.DeleteEmployee(id);
            return Ok();
        }
    }
}
