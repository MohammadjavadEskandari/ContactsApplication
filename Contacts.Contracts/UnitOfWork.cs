using Contacts.Contracts.Persons;
using Contacts.Contracts.PhBook;
using Contacts.DAL;
using System;

namespace Contacts.Contracts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextDB contextDB;

        public UnitOfWork(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }

        public IPersonRepository personRepository { get => new PersonRepository(contextDB); set => throw new NotImplementedException(); }
        public IPhoneBookRepository iphoneBook { get => new PhoneBookRepository(contextDB); set => throw new NotImplementedException(); }
    }
}
