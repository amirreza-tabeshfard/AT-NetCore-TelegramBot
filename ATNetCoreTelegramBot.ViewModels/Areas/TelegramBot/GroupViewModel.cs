namespace ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

public class GroupViewModel : object
{
    public IEnumerable<Models.SchemaTelegram.Group>? Groups { get; set; }

    public long Total { get; set; }
}