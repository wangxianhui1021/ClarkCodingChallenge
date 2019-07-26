using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.DataAccess;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
         static readonly IContactsDataAccess dataAccess = new ContactsDataAccess();
        // GET api/values
        [HttpGet]
        // api/contacts
        public IEnumerable<Contact> GetContacts(){
            
            return dataAccess.GetAllContacts();
        
        }
                //api/contacts/1
         
         [HttpGet("ID/{id}", Name = "GetContact")]
        public IActionResult GetContact(int id){
            var contact = dataAccess.Get(id);
            if (contact == null){
               return NotFound(); 
            }
            return Ok(contact);


        }
         [HttpGet("LASTNAME/{lastname}")]
         
         public IEnumerable <Contact> GetContactByLastName( string lastname){
            return dataAccess.GetAllContacts().Where(
                 c => string.Equals(c.LastName, lastname, StringComparison.OrdinalIgnoreCase)
             );

         }

        [HttpPost]

        public Contact CreateContact([FromBody] Contact contact){
            
             dataAccess.Add(contact);

            return contact;

        }


    }
}