using AddressBook.Shared;
using System.Collections.Generic;

namespace AddressBook.Server
{
    public class ContactService
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
