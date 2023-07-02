using Telegram.Bot;

namespace ATNetCoreTelegramBot.WFA.UI;

internal static class Program
{
    #region Properties

    public static string Token { get; set; }

    public static TelegramBotClient telegramBotClient { get; set; }

    #endregion

    static Program()
    {
        Token = "6067335133:AAH-xYOoqnZ9hNcd_6nx-6cYgTQ3Xq0GR6M";
    }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLoading());
    }
}