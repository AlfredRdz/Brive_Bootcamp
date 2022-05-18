using Brive.Bootcamp.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Brive.Bootcamp.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly BootcampContext _context;

        public PersonRepository(BootcampContext context)
        {
            _context = context;
        }

        public void deletedPerson(Person person)
        {
            _context.Person.Remove(person);
            _context.SaveChanges();
        }

        public Person editedPerson(Person person)
        {
            Person personed = _context.Person.Find(person.Id);

            if (personed == null)
            {
                return null;
            }

            personed.Name = person.Name;
            personed.Age = person.Age;
            personed.Email = person.Email;

            _context.Person.Update(personed);
            _context.SaveChanges();
            return personed;
        }

        public List<Person> GetAllPersons()
        {
            return _context.Person.ToList();
        }

        public Person GetPersonById(int id)
        {
            return _context.Person.Find(id);
        }

        public Person savePerson(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return person;

        }
    }
}
