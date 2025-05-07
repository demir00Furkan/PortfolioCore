using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;
using System;

namespace PortfolioCore.Controllers
{
    public class MessageComponentController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now; 
                context.Messages.Add(message);
                context.SaveChanges();

                TempData["Success"] = "Mesajınız başarıyla gönderildi.";
                return RedirectToAction("Index", "Default");
            }

            TempData["Error"] = "Mesaj gönderilirken bir hata oluştu.";
            return RedirectToAction("Index", "Default");
        }
    }
}
