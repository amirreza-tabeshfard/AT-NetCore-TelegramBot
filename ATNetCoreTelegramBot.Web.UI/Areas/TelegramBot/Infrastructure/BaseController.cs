using Microsoft.AspNetCore.Mvc;

using Telegram.Bot;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Infrastructure;

[Area(areaName: "TelegramBot")]
public class BaseController : Controller
{
    #region Field(s)

    private List<TelegramBotPageMessage> _telegramBotPageMessages;

    #endregion

    #region Constructor

    public BaseController()
    {
        Token = "6067335133:AAH-xYOoqnZ9hNcd_6nx-6cYgTQ3Xq0GR6M";
    }

    #endregion

    #region Properties

    protected string Token { get; set; }

    protected List<TelegramBotPageMessage> TelegramBotPageMessages
    {
        get
        {
            if (_telegramBotPageMessages is null)
                _telegramBotPageMessages = new List<TelegramBotPageMessage>();

            TempData["TelegramBotPageMessages"] = _telegramBotPageMessages;
            return (_telegramBotPageMessages);
        }
    }

    protected TelegramBotClient TelegramBotClient;

    #endregion
}