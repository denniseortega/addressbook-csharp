using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBookApp.Models;
using System;

namespace AddressBookApp.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult Index()
    {
      List<Contact>allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/contacts")]
    public ActionResult Create()
    {
      Contact newContact = new Contact(Request.Form["new-contact"]);
      List<Contact> allContacts = Contact.GetAll();
      return View("Index", allContacts);
    }

    [HttpGet("/contacts/{id}")]
    public ActionResult Details (int id)
    {
      Contact contact = Contact.Find(id);
      return View(contact);
    }

    [HttpPost("/contacts/delete")]
       public ActionResult Delete()
       {
           Contact.ClearAll();
           return View();
       }
  }
}
