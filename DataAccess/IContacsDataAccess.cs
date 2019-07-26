using TestApi.Models;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TestApi.DataAccess{


    public interface IContactsDataAccess
    {
        IEnumerable<Contact> GetAllContacts();
        Contact Get(int id);
        List<Contact> Add(Contact contact);
       
    }
}