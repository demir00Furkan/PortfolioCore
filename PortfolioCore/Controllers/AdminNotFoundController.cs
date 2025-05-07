using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class AdminNotFoundController : Controller
    {
        public IActionResult NotFoundAdmin()
        {
            return View();
        }
    }
}
