using Contacts.DomainModel.PhBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.DomainModel.Persons
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NikName { get; set; }
        public ICollection<PhoneBook> phoneBooks { get; set; }


    }

}
