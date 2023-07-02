namespace ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

public class UserViewModel : object
{
    public IEnumerable<Models.SchemaTelegram.User>? Users { get; set; }

    public long Total { get; set; }
}