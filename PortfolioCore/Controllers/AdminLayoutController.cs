using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult partialHead()
        {
            return PartialView();
        }
        public PartialViewResult partialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult partialScript()
        {
            return PartialView();
        }
    }
}
