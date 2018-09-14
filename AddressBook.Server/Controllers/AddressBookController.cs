using AddressBook.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AddressBook.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly ContactService contactService;

        public AddressBookController(ContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("contacts")]
        public IActionResult GetContacts()
        {
            return Ok(contactService.Contacts);
        }

        [HttpPost("contacts")]
        public IActionResult NewContact(Contact newContact)
        {
            contactService.Contacts.Add(newContact);

            return Ok();
        }

        [HttpDelete("contacts/{name}")]
        public IActionResult DeleteContact(string name)
        {
            var contact = contactService.Contacts.SingleOrDefault(x => x.Name == name);

            contactService.Contacts.Remove(contact);

            return Ok();
        }
    }
}