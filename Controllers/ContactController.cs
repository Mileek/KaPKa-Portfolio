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
            if (contact.Topic == null)
            {
                contact.Topic = "";
            }
            contact.Send(contact.fromName, contact.fromEmail, contact.Topic, contact.Message);
            ModelState.Clear();
            return View();
        }
    }
}
