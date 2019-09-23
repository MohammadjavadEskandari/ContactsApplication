using Contacts.Contracts.Persons;
using Contacts.Contracts.PhBook;
using Contacts.DomainModel.PhBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Contracts
{
    public interface IUnitOfWork
    {

        IPersonRepository personRepository { get; set; }
        IPhoneBookRepository iphoneBook { get; set; }

    }
}
