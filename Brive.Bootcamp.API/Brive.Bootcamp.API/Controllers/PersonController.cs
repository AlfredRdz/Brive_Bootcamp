using Brive.Bootcamp.API.Models;
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
        public List<Person> persons = new List<Person>();

        public PersonController()
        {
            for (int i = 0; i <= 10; i++)
            {
                persons.Add(new Person
                {
                    Id = i + 1,
                    Name = $"Persona {i + 1}",
                    Age = i + 1,
                    Email = $"correo{i + 1}@gmail.com",
                    CreatedDate = DateTime.UtcNow
                });
            }
        }

        


        [HttpGet]
        [Route("all")]
        public ActionResult<List<Person>> GetAllPersons()
        {
            return StatusCode(200, persons);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            return StatusCode(200, persons.Where(person => person.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [Route("savePerson")]
        public ActionResult<bool> SavePerson([FromBody] Person person)
        {
            return StatusCode(StatusCodes.Status200OK, person);
        }

        [HttpPut]
        [Route("editedPerson")]
        public ActionResult<Person> EditedPerson([FromBody] Person person)
        {
            Person editedPerson = persons.Where(x => x.Id == person.Id).FirstOrDefault();
            if(editedPerson == null)
            {
                return StatusCode(StatusCodes.Status200OK, editedPerson);
            }

            person.Name = "Guardado";
            person.Age = 24;
            person.Email = person.Email;
            return StatusCode(200, person);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> deletedPerson(int id)
        {
            return StatusCode(StatusCodes.Status200OK , true);
        }
    }
}
