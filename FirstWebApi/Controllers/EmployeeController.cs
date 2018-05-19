using FirstWebApi.Common;
using FirstWebApi.Models;
using FirstWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeRepository repository = new EmployeeRepository();
        ProjectTrackContext db = new ProjectTrackContext();

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            var employees = repository.GetAllEmployees();
            return employees;
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            var emp = repository.SearchEmployeeById(id);
            return  emp;
        }

        // POST: api/Employee
        public void Post(Employee value)
        {
            repository.CreteNewEmployee(value);
        }

        // PUT: api/Employee/5
        public void Put(int id, Employee value)
        {
            repository.EditEmployee(id, value);
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
            repository.DeleteEmployee(id);
        }
    }
}
