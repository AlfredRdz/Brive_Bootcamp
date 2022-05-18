using Brive.Bootcamp.API.Models;
using System.Collections.Generic;

namespace Brive.Bootcamp.API.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();

        Person GetPersonById(int id);

        Person savePerson(Person person);

        Person editedPerson(Person person);

        bool deletedPerson(Person person);

        List<Person> deletedPerson2(Person person);
    }
}
