using CompanyDataBase.Entities;
using CompanyDataBase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private DepartmentServices departmentServices;
        public DepartmentController(DepartmentServices departmentServices)
        {
            this.departmentServices = departmentServices;
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment(Department department)
        {
            departmentServices.AddDepartment(department);
            return Ok();
        }
        [HttpGet("GetDepartment")]
        public IActionResult GetDepartment()
        {
            var getAll = departmentServices.getDepartment();
            return Ok(getAll);
        }
        [HttpGet("GetDepartmentById/{id}")]
        public IActionResult GetById(int id)
        {
            var emp = departmentServices.GetDepartmentById(id);
            return Ok(emp);
        }
        [HttpPut("updateDepartment/{id}")]
        public IActionResult UpdateDepartment(int id, Department department)
        {
            var emp = departmentServices.UpdateDepartment(id, department);
            return Ok(emp);
        }
        [HttpDelete("DeletebyId/{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            departmentServices.DeleteDepartment(id);
            return Ok();
        }
    }
}
