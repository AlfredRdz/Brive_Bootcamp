using Brive.Bootcamp.API.Models;
using Brive.Bootcamp.API.Repositories;
using System.Collections.Generic;

namespace Brive.Bootcamp.API.Services
{
    public class PersonService : IPersonService
    {

        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public bool deletedPerson(Person person)
        {
            try
            {
                _personRepository.deletedPerson(person);
                return true;
            } catch
            {
                return false;
            }
        }

        public List<Person> deletedPerson2(Person person)
        {
            try
            {
                _personRepository.deletedPerson(person);
                return _personRepository.GetAllPersons();
            }
            catch
            {
                return null;
            }
        }

        public Person editedPerson(Person person)
        {
            return _personRepository.editedPerson(person);
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.GetPersonById(id);
        }

        public Person savePerson(Person person)
        {
            return _personRepository.savePerson(person);
        }
    }
}
