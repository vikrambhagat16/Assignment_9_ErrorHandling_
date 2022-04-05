using Assignment_10_ErrorHandling.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_10_ErrorHandling.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employees = new List<Employee>()
         {
                new Employee() { EmpId = 1, EmpName = "Vikram", EmailId = "vikram@gmail.com",MobileNumber = 9393939, Address="Nashik" },
                new Employee() { EmpId = 2, EmpName = "Vikram1",EmailId = "vikram1@gmail.com",MobileNumber = 9393939,Address="Nashik1" },
                new Employee() { EmpId = 3, EmpName = "Vikram2",EmailId = "vikram2@gmail.com",MobileNumber = 9393939,Address="Nashik2" },
                new Employee() { EmpId = 4, EmpName = "Vikram3",EmailId = "vikram3@gmail.com",MobileNumber = 9393939,Address="Nashik3" }
         };
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employees.Where(x => x.EmpId == id).FirstOrDefault();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IEnumerable<Employee> Post([FromBody] Employee value)
        {
            return employees.Append<Employee>(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
