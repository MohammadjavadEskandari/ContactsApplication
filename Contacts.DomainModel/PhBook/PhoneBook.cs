using Contacts.DomainModel.Persons;
using System;

namespace Contacts.DomainModel.PhBook
{
    public class PhoneBook
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public int TypeNumber { get; set; }
        public Guid PersonId { get; set; }
        public Person person { get; set; }

    } 

}
