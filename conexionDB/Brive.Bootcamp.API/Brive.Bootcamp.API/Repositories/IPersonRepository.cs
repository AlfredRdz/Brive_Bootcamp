using Brive.Bootcamp.API.Models;
using System.Collections.Generic;

namespace Brive.Bootcamp.API.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAllPersons();

        Person GetPersonById(int id);

        Person savePerson(Person person);

        Person editedPerson(Person person);

        void deletedPerson(Person person);
    }
}
