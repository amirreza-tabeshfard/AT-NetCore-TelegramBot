using Telegram.Bot.Types.ReplyMarkups;

namespace ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

public class ReplyKeyboardMarkupViewModel : object
{
    #region Method(s)

    public ReplyKeyboardMarkup Main()
    {
        KeyboardButton[][] keyboardButtons = default;
        ReplyKeyboardMarkup result = default;
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        keyboardButtons = new KeyboardButton[][]
        {
            new KeyboardButton[]
            {
                new KeyboardButton(text: "❓ سوالات متداول")
                {

                },
                new KeyboardButton(text: "👤 حساب کاربری من")
                {

                },
            },
            new KeyboardButton[]
            {
                new KeyboardButton(text: "📜 قوانین")
                {

                },
                new KeyboardButton(text: "☎️ پشتیبانی")
                {

                },
                new KeyboardButton(text: "📨 ارتباط با ما")
                {

                },
            },
        };
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new ReplyKeyboardMarkup(keyboardButtons);
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    public ReplyKeyboardMarkup MembershipConfirmation()
    {
        KeyboardButton[][] keyboardButtons = default;
        ReplyKeyboardMarkup result = default;
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        keyboardButtons = new KeyboardButton[][]
        {
            new KeyboardButton[]
            {
                new KeyboardButton(text: "✅ تایید عضویت")
                {

                },
            }
        };
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new ReplyKeyboardMarkup(keyboardButtons);
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion
}