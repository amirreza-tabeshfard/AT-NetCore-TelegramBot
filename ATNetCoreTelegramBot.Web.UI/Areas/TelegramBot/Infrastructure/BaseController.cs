using Microsoft.AspNetCore.Mvc;

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
        Token = "6067335133:AAHK5hOnVe5y5dqkLjIzGQ4QsZC_R91U7aA";
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

    #endregion
}