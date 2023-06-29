using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Components;

public class TelegramBotPageMessageViewComponent : ViewComponent
{
    public TelegramBotPageMessageViewComponent()
    {

    }

    public IViewComponentResult Invoke(IEnumerable<Areas.TelegramBot.Infrastructure.TelegramBotPageMessage> pageMessages)
    {
        if (pageMessages is not null)
            return View(pageMessages);

        return View();
    }
}