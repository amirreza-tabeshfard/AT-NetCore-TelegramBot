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
        Token = "6105915531:AAEaNaJWSJyqlrMo1vVxYM1iTU6sPT7KEgg";
    }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLoading());
    }
}