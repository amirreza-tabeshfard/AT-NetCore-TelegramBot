using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Common.Enums;

using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class HomeController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<HomeController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private User _user;

        #endregion

        #region Constructor(s)

        private HomeController()
             : base()
        {
            TelegramBotClient = new TelegramBotClient(Token);
        }

        private HomeController(IServiceProvider serviceProvider)
             : this()
        {
            _serviceProvider = serviceProvider;
            _serviceScope = _serviceProvider.CreateScope();
        }

        public HomeController(ILogger<HomeController> logger,
                              IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
        }

        #endregion

        #region Private Method(s)

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
                if (_user is not null)
                    await telegramBotClient.SendTextMessageAsync(chatId: _user.Id,
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
            Message? message = default;
            Chat? chat = default;
            User? user = default;
            MessageType type = default;
            GroupStatus groupStatus = default;
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            message = update.Message;
            chat = message?.Chat;
            user = message?.From;
            type = message.Type;
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                if (user is not null)
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

        #region Index

        public IActionResult Index()
        {
            try
            {
                TelegramBotClient.StartReceiving(updateHandler: UpdateHandler, pollingErrorHandler: PollingErrorHandler, receiverOptions: ReceiverOption());
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (TimeoutException ex)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "TimeoutException", ex.Message));
            }
            catch (Exception ex)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "خطای سیستمی", "[ Message ]", ex.Message));
            }
            finally
            {

            }
            return View();
        }

        #endregion
    }
}