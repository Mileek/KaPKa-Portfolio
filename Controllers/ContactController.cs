using KaPKa.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaPKa.Controllers
{
    public class ContactController : Controller
    {
        static List<ContactModel> parameters = new List<ContactModel>();
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        [Route("Contact")]
        public IActionResult Contact(ContactModel contact)
        {
            if (contact.Topic == null)
            {
                contact.Topic = ""; //Topic might be blank
            }

            contact.Send(contact.fromName, contact.fromEmail, contact.Topic, contact.Message);

            if (contact.buttonName == "Send")
            {
                return View("_Message");
            }
            ModelState.Clear();

            return View();
        }
    }
}
