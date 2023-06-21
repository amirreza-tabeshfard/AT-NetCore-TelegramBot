namespace ATNetCoreTelegramBot.ViewModels;

public class ErrorViewModel : object
{
    public ErrorViewModel()
    {

    }

    public string RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}