using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
        
    }
}
