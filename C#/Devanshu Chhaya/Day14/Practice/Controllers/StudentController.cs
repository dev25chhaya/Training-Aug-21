using ApiHTTPMethods.EmployeeData;
using ApiHTTPMethods.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHTTPMethods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenericController<Student>
    {
        public StudentController(IGenericRepositorycs<Student> genericService):base(genericService)
        {
            
        }
    }
}
