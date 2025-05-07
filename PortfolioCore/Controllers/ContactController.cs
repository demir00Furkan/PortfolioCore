using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult ContactUpdate(Contact contact)
        {
            var value = context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
