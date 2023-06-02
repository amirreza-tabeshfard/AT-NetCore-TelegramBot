using ATNetCoreTelegramBot.Common.Enums;
using System;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATNetCoreTelegramBot.WFA.UI;

public partial class FrmTelegramBot : Form
{
    #region Field(s)

    internal static DateTime currentDateTime;
    internal static User telegramBotUser;
    internal static bool isOnline;

    private FrmGroupIndex _frmGroupIndex;

    #endregion

    #region Constructor

    public FrmTelegramBot()
    {
        InitializeComponent();
        _frmGroupIndex = new FrmGroupIndex();
    }

    #endregion

    #region Private Method(s)

    private void SetOnline()
    {
        Program.telegramBotClient = new TelegramBotClient(token: Program.Token, httpClient: null);
        telegramBotUser = Program.telegramBotClient.GetMeAsync().Result;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        if (telegramBotUser is not null)
        {
            currentDateTime = DateTime.Now;
            txtToken.Enabled = false;
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            toolStriplblCheckOnline.Text = "Online";
            toolStriplblCheckOnline.ForeColor = System.Drawing.Color.Green;
            isOnline = true;
        }
    }

    private void SetOffline()
    {
        txtToken.Enabled = true;
        btnStart.Enabled = true;
        btnEnd.Enabled = false;
        toolStriplblCheckOnline.Text = "OffLine";
        toolStriplblCheckOnline.ForeColor = System.Drawing.Color.Red;
        isOnline = false;
    }

    private void IsOnline()
    {
        if (isOnline)
        {
            Program.Token = txtToken.Text;
            SetOnline();
        }
        else
            SetOffline();
    }

    #endregion

    #region Method(s): TelegramBot

    private ReceiverOptions? ReceiverOption()
    {
        ReceiverOptions? result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new ReceiverOptions()
        {
            AllowedUpdates = new UpdateType[]
            {
                UpdateType.Message,
                UpdateType.EditedMessage,
            }
        };
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    private async Task PollingErrorHandler(ITelegramBotClient telegramBotClient, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is ApiRequestException apiRequestException)
            await telegramBotClient.SendTextMessageAsync(chatId: telegramBotUser.Id,
                                                         text: exception.Message,
                                                         messageThreadId: default,
                                                         parseMode: default,
                                                         entities: default,
                                                         disableNotification: default,
                                                         disableWebPagePreview: default,
                                                         protectContent: default,
                                                         replyToMessageId: default,
                                                         allowSendingWithoutReply: default,
                                                         replyMarkup: default,
                                                         cancellationToken: default
                                                         );
    }

    private async Task UpdateHandler(ITelegramBotClient telegramBotClient, Update update, CancellationToken cancellationToken)
    {
        Telegram.Bot.Types.Message? message = update.Message;
        Chat chat = message.Chat;
        User? user = message.From;
        MessageType type = message.Type;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        GroupStatus groupStatus = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        try
        {
            if (user is not null)
                groupStatus = _frmGroupIndex.InitializeGroups(userId: user.Id, userName: user.Username);

            if (groupStatus == GroupStatus.Unknown || groupStatus == GroupStatus.Membered)
            {

            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            await telegramBotClient.SendTextMessageAsync(chatId: chat.Id,
                                                         text: ex.Message,
                                                         messageThreadId: default,
                                                         parseMode: default,
                                                         entities: default,
                                                         disableNotification: default,
                                                         disableWebPagePreview: default,
                                                         protectContent: default,
                                                         replyToMessageId: default,
                                                         allowSendingWithoutReply: default,
                                                         replyMarkup: default,
                                                         cancellationToken: default
                                                         );
        }
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmTelegramBot_Load(object sender, EventArgs e)
    {
        txtToken.Text = Program.Token;
        IsOnline();
    }

    private void FrmTelegramBot_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (isOnline)
            e.Cancel = true;
        else
            e.Cancel = false;
    }

    #endregion

    #region Event(s) ==> Button

    private void BtnStart_Click(object sender, EventArgs e)
    {
        isOnline = true;
        IsOnline();
        Program.telegramBotClient.StartReceiving(updateHandler: UpdateHandler, pollingErrorHandler: PollingErrorHandler, receiverOptions: ReceiverOption());
    }

    private void BtnEnd_Click(object sender, EventArgs e)
    {
        SetOffline();
        if (Program.telegramBotClient != null)
            Program.telegramBotClient = default;
    }

    #endregion
}