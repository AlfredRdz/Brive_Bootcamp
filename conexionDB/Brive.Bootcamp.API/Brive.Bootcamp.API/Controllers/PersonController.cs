using Brive.Bootcamp.API.Models;
using Brive.Bootcamp.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brive.Bootcamp.API.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
    
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<Person>> GetAllPersons()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetAllPersons());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetPersonById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("savePerson")]
        public ActionResult<bool> SavePerson([FromBody] Person person)
        {
            try
            {
                person.CreatedDate = DateTime.Now;
                return StatusCode(StatusCodes.Status200OK, _personService.savePerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        [Route("editedPerson")]
        public ActionResult<Person> EditedPerson([FromBody] Person person)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.editedPerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> deletedPerson(int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);

                if (person == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                }
                return StatusCode(StatusCodes.Status200OK, _personService.deletedPerson(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<List<Person>> deletedPerson2(int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);

                if (person == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                }
                return StatusCode(StatusCodes.Status200OK, _personService.deletedPerson2(person));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
