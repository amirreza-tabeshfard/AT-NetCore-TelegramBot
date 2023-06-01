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
        Token = "1936144475:AAGwL-4GRQDskAnXAQafJKlujf1cbjEUeuw";
    }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmGroupIndex());
    }
}