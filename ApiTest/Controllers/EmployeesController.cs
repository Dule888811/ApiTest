using ApiTest.Repository;
using ApiTest.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace ApiTest.Controllers
{
   
    public class EmployeesController : ApiController
    {
        
        private readonly IEmployeeRepository _emplyeeRepository;
        public EmployeesController(EmplyeeRepository EmplyeeRepository)
        {
            this._emplyeeRepository = EmplyeeRepository;
        }
        [HttpGet]
        [Route("api/Employees/Get/{query}")]
        public List<Employee> Get([FromUri]string query)
        {
            return this._emplyeeRepository.Get(query);
        }
    }
}
