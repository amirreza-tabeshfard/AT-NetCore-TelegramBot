using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class HomeController : Infrastructure.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}