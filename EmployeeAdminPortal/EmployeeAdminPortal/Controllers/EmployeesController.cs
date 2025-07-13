using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{

    //local host port number  and name of controller localhost:xxx/api/employees
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
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var emp = dbContext.Employees.Find(id);

            if (emp is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(emp);
            }

        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            //apart from id we need name email salary and phone is optional

            var employeeEntity = new Employee()
            {
                name = addEmployeeDto.name,
                email = addEmployeeDto.email,
                phone=addEmployeeDto.phone,
                salary = addEmployeeDto.salary,
            };
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpadteEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var emp = dbContext.Employees.Find(id);
            if(emp is null)
            {
                return NotFound();
            }
            
                emp.name = updateEmployeeDto.name; 
                emp.email=updateEmployeeDto.email;
                emp.phone=updateEmployeeDto.phone;
                emp.salary= updateEmployeeDto.salary;

                dbContext.SaveChanges();
                return Ok(emp);
            
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {

            var emp = dbContext.Employees.Find(id);
            if (emp is null)
            {
                return NotFound();
            }
          
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return Ok();
            

        }

    }
}
