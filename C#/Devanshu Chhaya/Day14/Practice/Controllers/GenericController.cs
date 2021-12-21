using ApiHTTPMethods.EmployeeData;
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
    public class GenericController<T> : Controller where T: class
    {
        private IGenericRepositorycs<T> _geneicRepository;
        public GenericController(IGenericRepositorycs<T> genericRepositorycs)
        {
            _geneicRepository = genericRepositorycs;
        }

        [HttpGet]
        public List<T> Get()
        {
            return (List<T>)_geneicRepository.GetAll();
        }
        
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _geneicRepository.GetById(id);
        }

        [HttpPost]
        public void Post(T value)
        {
             _geneicRepository.Insert(value);
        }

    }
}
