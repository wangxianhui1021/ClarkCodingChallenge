
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Models;




namespace TestApi.DataAccess
{
    public class ContactsDataAccess : IContactsDataAccess
    {
        //TODO: Place data access code here

        public List<Contact> _contacts;
        private int _nextId = 5;
        public ContactsDataAccess()
        {
            _contacts = new List <Contact> {
                new Contact(){
                    Id = 1,
                    FirstName = "Jane",
                    LastName = "Austin",
                    Email = "jane.austin@example.com"
                },
                new Contact(){
                    Id = 2,
                    FirstName = "Mark",
                    LastName = "Twain",
                    Email = "mark.twain@example.com"
                },
                new Contact(){
                    Id = 3,
                    FirstName = "Zi",
                    LastName = "Sun",
                    Email = "zi.sun@example.com"
                },
                new Contact(){
                    Id = 4,
                    FirstName = "Benjamin",
                    LastName = "Franklin",
                    Email = "benjamin.franklin@example.com"
                },
                new Contact(){
                    Id = 5,
                    FirstName = "Charles",
                    LastName = "Dickens",
                    Email = "charles.dickens@example.com"
                }

        };
        
              
        }
         public Contact Get(int id)
        {
            return _contacts.Find(c => c.Id == id);
        }
        public List <Contact> Add(Contact contact){
            if(contact == null)
            {
                throw new ArgumentNullException("contact");
            }
                contact.Id = ++_nextId;
                 _contacts.Add(contact);

                  return _contacts;
        }

        public IEnumerable <Contact> GetAllContacts(){
            return _contacts;
        }

         
    }
}
