using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultServicesComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Servicess.ToList();
            return View(value);
        }
    }
}
