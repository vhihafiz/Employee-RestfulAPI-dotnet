using EmployeeBackOffice.Data;
using EmployeeBackOffice.Models;
using EmployeeBackOffice.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeBackOffice.Controllers
{
    // localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(dbContext.Employees.ToList());
        }

        [HttpGet]
        public IActionResult GetEmployeeById(string id)
        {
            return Ok(dbContext.Employees.ToList());
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto employeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = employeeDto.Name,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone,
                Salary = employeeDto.Salary
            };

            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);

        }

      
       
    }
}
