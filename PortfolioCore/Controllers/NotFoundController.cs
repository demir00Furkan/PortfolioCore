using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult NotFoundPage()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
