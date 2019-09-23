using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Contracts;
using Contacts.DomainModel.Persons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactApiController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ContactApiController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: api/ContactApi
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(unitOfWork.personRepository.GetAll());
        }

        // GET: api/ContactApi/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            return Ok(unitOfWork.personRepository.GetPerson(id));
        }

        // POST: api/ContactApi
        [HttpPost]
        public IActionResult Post([FromBody] Person value)
        {
            unitOfWork.personRepository.AddPerson(value);
            return Created("Api/ContactApi"+value.Id,value);

        }

        // PUT: api/ContactApi/5
        [HttpPut]
        public IActionResult Put([FromBody] Person value)
        {
            unitOfWork.personRepository.UpdatePerson(value);
            return Ok(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            unitOfWork.personRepository.DeletePerson(id);
            return Ok(id);

            
        }
    }
}
