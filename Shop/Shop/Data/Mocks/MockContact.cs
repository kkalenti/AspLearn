using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockContact : IContacts
    {
        public Contacts Contact
        {
            get
            {
                return new Contacts
                {
                    Address = "г.Томск, ул. Федора Лыткина, д. 10",
                    Mail = "kostik2000@inbox.ru",
                    Phone = "79539276820"
                };
            }
        }
    }
}