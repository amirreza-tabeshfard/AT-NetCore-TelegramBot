using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Components;

public class PageMessageViewComponent : ViewComponent
{
    public PageMessageViewComponent()
    {

    }

    public IViewComponentResult Invoke(IEnumerable<Infrastructure.PageMessage> pageMessages)
    {
        if (pageMessages is not null)
            return View(pageMessages);

        return View();
    }
}