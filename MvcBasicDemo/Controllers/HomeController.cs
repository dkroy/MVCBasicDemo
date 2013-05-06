using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Title = "Contact";
            List<Contact> contacts = LoadContacts();
            return View(contacts);
        }

        private List<Contact> LoadContacts()
        {
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < 10; i++ )
            {
                Contact NewContact = new Contact();
                NewContact.name = "name " + i;
                NewContact.phone = "phone " + i;
                NewContact.email = "email " + i;
                contacts.Add(NewContact);
            }
            return contacts;
        }

    }
}
