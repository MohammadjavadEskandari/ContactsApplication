using Contacts.DAL;
using Contacts.DomainModel.Persons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Contracts.Persons
{
    public class PersonRepository:IPersonRepository
    {
        private readonly ContextDB contextDB;

        public PersonRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }

        public void AddPerson(Person person)
        {
            contextDB.people.Add(person);
            contextDB.SaveChanges();
            
        }

        public void DeletePerson(Guid guid)
        {
            contextDB.Remove<Person>(new Person { Id = guid });
            contextDB.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return contextDB.people.ToList();
        }

        public Person GetPerson(Guid ID)
        {
            return contextDB.people.Where(c => c.Id == ID).FirstOrDefault();
        }

        public void UpdatePerson(Person person)
        {
            //var result = GetPerson(guid);
            contextDB.Attach(person);
            contextDB.Entry<Person>(person).State = EntityState.Modified;
            contextDB.SaveChanges();

        }
    }
}
