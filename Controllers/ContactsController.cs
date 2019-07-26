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
        
        [HttpGet]
        //GET api/contacts
        public IEnumerable<Contact> GetContacts(){
            
            return dataAccess.GetAllContacts().OrderBy(c => c.LastName);
        
        }
                
         
         [HttpGet("ID/{id}", Name = "GetContact")]
         //GET api/contacts/id/1
        public IActionResult GetContact(int id){
            var contact = dataAccess.Get(id);
            if (contact == null){
               return NotFound(); 
            }
            return Ok(contact);


        }
         [HttpGet("LASTNAME/{lastname}")]
         //GET api/contacts/lastname/person's_lastname
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