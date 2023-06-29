using ATNetCoreTelegramBot.Common.Enums;

namespace ATNetCoreTelegramBot.ViewModels;

public class ExceptionViewModel : object
{
    public string? Title { get; set; }

    public string? Message { get; set; }

    public string? InnerException { get; set; }

    public string? MessageHTML { get; set; }

    public AlertSeverity AlertSeverity { get; set; }

    public Alignment Alignment { get; set; }
}