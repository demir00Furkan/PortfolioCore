using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ServicesController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ServicesList()
        {
            var values = context.Servicess.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServices(Services services)
        {
            context.Servicess.Add(services);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        [HttpGet]
        public IActionResult UpdateServices(int id)
        {
            var value = context.Servicess.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateServices(Services services)
        {
            context.Servicess.Update(services);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        public IActionResult DeleteServices(int id)
        {
            var value = context.Servicess.Find(id);
            context.Servicess.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
    }
}
