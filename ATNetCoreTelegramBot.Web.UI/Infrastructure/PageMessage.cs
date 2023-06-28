using ATNetCoreTelegramBot.Common.Enums;

namespace ATNetCoreTelegramBot.Web.UI.Infrastructure;

public class PageMessage : Object
{
    #region Constructor

    public PageMessage(AlertSeverity alertSeverity, string title, params string[] messages)
        : this(alertSeverity, title, default, default, messages)
    { }

    public PageMessage(AlertSeverity alertSeverity, string title, bool isRenderHTML, params string[] messages)
        : this(alertSeverity, title, isRenderHTML, default, messages)
    { }

    public PageMessage(AlertSeverity alertSeverity, string title, bool isRenderHTML, bool isPrintLTR, params string[] messages)
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