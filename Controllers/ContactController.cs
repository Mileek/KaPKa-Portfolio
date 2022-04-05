using KaPKa.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaPKa.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel contact)
        {
            contact.Send(contact.fromName, contact.fromEmail, contact.Subject, contact.Message);
            return View();
        }
    }
}
