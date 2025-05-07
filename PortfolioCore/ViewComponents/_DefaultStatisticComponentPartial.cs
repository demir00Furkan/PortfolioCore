using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext contex = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.MemnunMus = (contex.Servicess.Count()) * 0.7;
            ViewBag.Projeler = contex.Portfolios.Count();
            ViewBag.Destekci = contex.Testimonials.Count();
            return View();
        }
    }
}
