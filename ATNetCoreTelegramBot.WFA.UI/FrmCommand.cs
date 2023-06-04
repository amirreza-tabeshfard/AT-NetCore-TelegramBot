using System.Text;

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using ATNetCoreTelegramBot.Common.Enums;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmCommand : Form
{
    #region Field(s)

    private ViewModels.ReplyKeyboardMarkupViewModel _replyKeyboardMarkupVM;
    private ViewModels.InlineKeyboardMarkupViewModel _inlineKeyboardMarkupVM;

    #endregion

    #region Constructor

    public FrmCommand()
    {
        InitializeComponent();
        _replyKeyboardMarkupVM = new ViewModels.ReplyKeyboardMarkupViewModel();
        _inlineKeyboardMarkupVM = new ViewModels.InlineKeyboardMarkupViewModel();
    }

    #endregion

    #region Private Method(s)

    private async Task CommandStart(GroupStatus groupStatus, Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        if (groupStatus == GroupStatus.Membered)
        {
            textBuilder.AppendLine("☑️ عضویت شما در کلیه گروه ها و کانال ها تایید شد");
            textBuilder.AppendLine();
        }
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Markdown,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandHelp(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("دستواراتی که شما می توانید در بات 'GoGoldis' استفاده کنید:");
        textBuilder.AppendLine();
        textBuilder.AppendLine("🔹 /start | شروع به کار");
        textBuilder.AppendLine("🔹 /help | راهنما");
        textBuilder.AppendLine("🔹 /home | صفحه اصلی");
        textBuilder.AppendLine("🔹 /profile | پروفایل کاربری");
        textBuilder.AppendLine("🔹 /support | پشتیبانی");
        textBuilder.AppendLine("🔹 /aboutus | درباره ما");
        textBuilder.AppendLine("🔹 /setting | تنظیمات");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Markdown,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandHome(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine(string.Concat("به ", "<strong>صفحه اصلی</strong> ", "خیلی خوش آمدید"));
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandProfile(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandSupport(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandAboutUs(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandSetting(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("👇گزینه دلخواه را انتخاب کنید👇");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    private async Task CommandNoneExists(Telegram.Bot.Types.Message message, Chat chat)
    {
        StringBuilder textBuilder = new StringBuilder();
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        textBuilder.AppendLine($"سرکار/جناب: {message.From.FirstName + " " + message.From.LastName}");
        textBuilder.AppendLine($"با نام کاربری: @{message.From.Username}");
        textBuilder.AppendLine("➖➖➖➖➖➖➖➖➖➖");
        textBuilder.AppendLine("دستور وارد شده در بات تعریف نشده است");
        textBuilder.AppendLine();
        textBuilder.AppendLine("لطفا دستور /help را انتخاب کرده، تا با دستورات این بات آشنا شوید.");
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        await Program.telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                             text: Convert.ToString(textBuilder),
                                                             messageThreadId: default,
                                                             parseMode: ParseMode.Html,
                                                             entities: default,
                                                             disableNotification: false,
                                                             disableWebPagePreview: false,
                                                             protectContent: false,
                                                             replyToMessageId: message.MessageId,
                                                             allowSendingWithoutReply: false,
                                                             replyMarkup: _replyKeyboardMarkupVM.Main(),
                                                             cancellationToken: CancellationToken.None
                                                             );
    }

    #endregion

    #region Internal Method(s)

    internal async Task InitializeCommands(GroupStatus groupStatus, Telegram.Bot.Types.Message message, Chat chat)
    {
        if (message.Text is not null)
            if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.start))))
                await CommandStart(groupStatus, message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.help))))
                await CommandHelp(message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.home))))
                await CommandHome(message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.profile))))
                await CommandProfile(message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.support))))
                await CommandSupport(message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.aboutus))))
                await CommandAboutUs(message, chat);
            else if (message.Text.Equals(string.Concat("/", Convert.ToString(Command.setting))))
                await CommandSetting(message, chat);
            else
                await CommandNoneExists(message, chat);
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmCommand_Load(object sender, EventArgs e)
    {

    }

    #endregion
}