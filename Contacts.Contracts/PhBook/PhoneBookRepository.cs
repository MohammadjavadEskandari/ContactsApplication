using Contacts.DAL;

namespace Contacts.Contracts.PhBook
{
    public class PhoneBookRepository:IPhoneBookRepository
    {
        private readonly ContextDB contextDB;

        public PhoneBookRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
    }
}
