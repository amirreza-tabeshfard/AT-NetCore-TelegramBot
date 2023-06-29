using ATNetCoreTelegramBot.Common.Enums;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Infrastructure;

public class TelegramBotPageMessage : Object
{
    #region Constructor

    public TelegramBotPageMessage(AlertSeverity alertSeverity, string title, params string[] messages)
        : this(alertSeverity, title, default, default, messages)
    { }

    public TelegramBotPageMessage(AlertSeverity alertSeverity, string title, bool isRenderHTML, params string[] messages)
        : this(alertSeverity, title, isRenderHTML, default, messages)
    { }

    public TelegramBotPageMessage(AlertSeverity alertSeverity, string title, bool isRenderHTML, bool isPrintLTR, params string[] messages)
    {
        AlertSeverity = alertSeverity;
        Title = title;
        IsRenderHTML = isRenderHTML;
        IsPrintLTR = isPrintLTR;
        Messages = messages;
    }

    #endregion

    #region Properties

    public AlertSeverity AlertSeverity { get; set; }

    public string Title { get; set; }

    public IEnumerable<string> Messages { get; set; }

    public bool IsRenderHTML { get; set; }

    public bool IsPrintLTR { get; set; }

    #endregion
}