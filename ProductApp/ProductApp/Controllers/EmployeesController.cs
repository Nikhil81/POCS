using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using System.Web.Http.Cors;
using WebProject.Https;
using System.Threading;
using WebProject.Authorization;

namespace ProductApp.Controllers
{
    [EnableCors("http://localhost:58741", "*", "*")]
    //[RequireHttpsAttibute]

    public class EmployeesController : ApiController
    {

        private const string MALE = "male";
        private const string FEMALE = "female";
        private const string ALL = "all";

        EmployeeDBEntities _empDB = new EmployeeDBEntities();

        [HttpGet]
        [RequestServiceAuthorization]
        public IHttpActionResult LoadAllEmployees(string gender = "all")
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;
                switch (username.ToLower())
                {
                    case MALE:
                        return Ok<IEnumerable<Employee>>(_empDB.Employees.Where(x => x.Gender.ToLower() == MALE));
                    case FEMALE:
                        return Ok<IEnumerable<Employee>>(_empDB.Employees.Where(x => x.Gender.ToLower() == FEMALE));
                    case ALL:
                        return Ok<IEnumerable<Employee>>(_empDB.Employees);
                    default:
                        return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }



        [HttpGet]
        public IHttpActionResult LoadEmployeeById(int id)
        {
            var _emp = _empDB.Employees.FirstOrDefault(e => e.ID == id);
            //if (_emp == null)
            //   return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Employee id not found");
            //else
            //  return Request.CreateResponse(HttpStatusCode.OK,_emp);

            if (_emp == null)
            {
                return NotFound();
            }
            return Ok<Employee>(_emp);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] Employee employee)
        {
            try
            {
                _empDB.Employees.Add(employee);
                _empDB.SaveChanges();

                return Created<Employee>(Request.RequestUri + $"/{employee.ID}", employee);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);

            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {

                var employee = _empDB.Employees.Find(id);
                if (employee == null)
                {
                    return NotFound();
                }
                _empDB.Employees.Remove(employee);
                _empDB.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]Employee employee)
        {
            try
            {
                var emp = _empDB.Employees.Find(id);
                if (emp == null)
                {
                    return NotFound();
                }
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Salary = employee.Salary;
                emp.Gender = employee.Gender;
                _empDB.SaveChanges();
                return Ok();

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
