using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var values =  context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult createExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
            
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience x)
        {
            context.Experiences.Update(x);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
