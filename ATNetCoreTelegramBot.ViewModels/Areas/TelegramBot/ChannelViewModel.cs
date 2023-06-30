namespace ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

public class ChannelViewModel : object
{
    public IEnumerable<Models.SchemaTelegram.Channel>? Channels { get; set; }

    public long Total { get; set; }
}