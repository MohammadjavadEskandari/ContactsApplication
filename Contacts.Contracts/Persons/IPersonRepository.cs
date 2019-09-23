using Contacts.DomainModel.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Contracts.Persons
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetPerson(Guid ID);
        void AddPerson(Person person);
        void DeletePerson(Guid guid);
        void UpdatePerson(Person person);
    }
}
