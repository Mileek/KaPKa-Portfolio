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
        [Route("Contact")]
        public IActionResult Contact(ContactModel contact)
        {
            if (contact.Topic == null)
            {
                contact.Topic = ""; //Topic might be blank
            }
            contact.Send(contact.fromName, contact.fromEmail, contact.Topic, contact.Message);
            
            ModelState.Clear();
            return View();
        }

        public void button_Click(object sender, EventArgs e)
        {
            ViewBag.SuccessMessage = "Success";
        }
    }
}
