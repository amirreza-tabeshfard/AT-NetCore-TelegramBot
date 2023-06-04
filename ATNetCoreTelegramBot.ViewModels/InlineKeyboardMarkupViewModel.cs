using System.Text;
using Telegram.Bot.Types.ReplyMarkups;

namespace ATNetCoreTelegramBot.ViewModels;

public class InlineKeyboardMarkupViewModel : Object
{
    public InlineKeyboardMarkup TermsAndConditions()
    {
        InlineKeyboardButton[][] keyboardButtons = default;
        InlineKeyboardMarkup result = default;
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        keyboardButtons = new InlineKeyboardButton[][]
        {
            new InlineKeyboardButton[]
            {
                new InlineKeyboardButton(text: "قوانین سایت")
                {
                    CallbackData = "قوانین سایت"
                },
                new InlineKeyboardButton(text: "قوانین بات")
                {
                    CallbackData = "قوانین بات"
                }
            }
        };
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new InlineKeyboardMarkup(keyboardButtons);
        // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }
}