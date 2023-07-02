using System.Text;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Common.Enums;
using ATNetCoreTelegramBot.Common.Exceptions;
using ATNetCoreTelegramBot.Models.SchemaTelegram;
using ATNetCoreTelegramBot.ViewModels;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;

using Newtonsoft.Json;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class ChannelController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<ChannelController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

        private ViewModels.Areas.TelegramBot.ReplyKeyboardMarkupViewModel _replyKeyboardMarkupViewModel;
        private Channel _channel;
        private ChannelViewModel _channelVM;

        #endregion

        #region Constructor

        private ChannelController()
            : base()
        {

        }

        private ChannelController(IServiceProvider serviceProvider)
             : this()
        {
            _serviceProvider = serviceProvider;
            _serviceScope = _serviceProvider.CreateScope();

            _unitOfWork = _serviceScope.ServiceProvider.GetRequiredService<DAL.UnitOfWork>();
            _channel = _serviceScope.ServiceProvider.GetRequiredService<Channel>();
            _channelVM = _serviceScope.ServiceProvider.GetRequiredService<ChannelViewModel>();
            _replyKeyboardMarkupViewModel = _serviceScope.ServiceProvider.GetRequiredService<ViewModels.Areas.TelegramBot.ReplyKeyboardMarkupViewModel>();
        }

        public ChannelController(ILogger<ChannelController> logger,
                               IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
        }

        #endregion

        #region Method(s): Exception

        private void ClientForGetException(Guid? id)
        {
            ExceptionViewModel _exceptionViewModel = default;
            // -----------------------------------------------------------------------------------------------------------------------------------------
            if (id.Equals(default(Guid)))
            {
                _exceptionViewModel = new ExceptionViewModel()
                {
                    Title = default,
                    Message = $"شناسه وارد شده صحیح نمی باشد",
                    Alignment = Alignment.Right,
                    AlertSeverity = AlertSeverity.Error
                };

                throw new ClientForGetException(JsonConvert.SerializeObject(_exceptionViewModel));
            }
        }

        private void ClientForGetException(Channel channel)
        {
            ExceptionViewModel _exceptionViewModel = default;
            // -----------------------------------------------------------------------------------------------------------------------------------------
            if (channel is null)
            {
                _exceptionViewModel = new ExceptionViewModel()
                {
                    Title = default,
                    Message = $"شناسه وارد شده صحیح نمی باشد",
                    Alignment = Alignment.Right,
                    AlertSeverity = AlertSeverity.Error
                };

                throw new ClientForGetException(JsonConvert.SerializeObject(_exceptionViewModel));
            }
        }

        #endregion

        #region Method(s) : Private

        private IEnumerable<Channel> AllChannels()
        {
            IEnumerable<Channel> _channels;

            _channels = _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .ChannelRepository
                        .GetByAllChannels();

            return _channels;
        }

        private IEnumerable<string> InitializeChannels()
        {
            List<string> results = new List<string>();
            IEnumerable<Channel> channels = AllChannels();

            if (channels != null)
                foreach (Channel channel in channels)
                    results.Add(channel.Name);

            return results;
        }

        private IEnumerable<string> InMemberOfGroups(IEnumerable<string> groups, long userId)
        {
            List<string> result = new List<string>();

            if (groups != null)
            {
                foreach (string group in groups)
                {
                    try
                    {
                        Task<ChatMember> chatMember = TelegramBotClient.GetChatMemberAsync(group, userId);

                        if (chatMember is not null)
                            if (chatMember.Result is not null)
                            {
                                if (chatMember.Result.Status.ToString().Length > 25)
                                    result.Add(group);

                                if (chatMember.Result.Status.ToString() == "Left")
                                    result.Add(group);
                            }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return result;
        }

        #endregion

        #region Method(s) : Public

        public ChannelStatus Initialize(Telegram.Bot.Types.User user)
        {
            IEnumerable<string> NamesOfChannelsThatTheUserIsNotAMember = default;
            IEnumerable<string> channelNames = InitializeChannels();
            ChannelStatus result = ChannelStatus.Unknown;
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (channelNames is not null)
                if (channelNames.Any())
                {
                    NamesOfChannelsThatTheUserIsNotAMember = InMemberOfGroups(channelNames, user.Id);

                    if (NamesOfChannelsThatTheUserIsNotAMember is not null)
                        if (NamesOfChannelsThatTheUserIsNotAMember.Count() != 0)
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.AppendLine($"کاربر گرامی (<b><i>{user.Username}</i></b>)");
                            sb.AppendLine("جهت استفاده از این ربات باید عضو کانال های ذیل شوید.");
                            sb.AppendLine();
                            sb.AppendLine("👥 لیست کانال ها");

                            foreach (var item in NamesOfChannelsThatTheUserIsNotAMember)
                            {
                                string url = item.Replace("@", "https://t.me/");
                                sb.AppendLine($"🔘 <a href='{url}'>{item.Replace("@", "")}</a>");
                            }

                            TelegramBotClient.SendTextMessageAsync(chatId: user.Id,
                                                                   text: sb.ToString(),
                                                                   messageThreadId: default,
                                                                   parseMode: ParseMode.Html,
                                                                   entities: default,
                                                                   disableNotification: default,
                                                                   disableWebPagePreview: default,
                                                                   protectContent: default,
                                                                   replyToMessageId: default,
                                                                   allowSendingWithoutReply: default,
                                                                   replyMarkup: _replyKeyboardMarkupViewModel.MembershipConfirmation(),
                                                                   cancellationToken: CancellationToken.None);

                            result = ChannelStatus.UnMembered;
                        }
                        else
                            result = ChannelStatus.Membered;
                }
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            return result;
        }

        #endregion

        #region Index

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                if (!(string.IsNullOrEmpty(TempData["AlertSeverity"]?.ToString()) && string.IsNullOrEmpty(TempData["StatusMessage"]?.ToString())))
                {
                    if (Enum.TryParse(TempData["AlertSeverity"]?.ToString(), out AlertSeverity alertSeverity))
                        TelegramBotPageMessages.Add(item: new Infrastructure.TelegramBotPageMessage(alertSeverity, default, isRenderHTML: true, TempData["StatusMessage"]?.ToString()));

                    TempData["AlertSeverity"] = default(string);
                    TempData["StatusMessage"] = default(string);
                }

                _channelVM.Channels = _unitOfWork
                                      .SchemaTelegramUnitOfWork
                                      .ChannelRepository
                                      .GetByAllChannels();

                if (!_channelVM.Channels.Any())
                    _channelVM.Channels = default;
                else
                    _channelVM.Total = _channelVM.Channels.Count();
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
            return View(_channelVM);
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View(_channel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Ordering")] Channel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _channel.Id = Guid.NewGuid();
                    _channel.Name = string.Concat("@", model.Name);
                    _channel.Ordering = model.Ordering;
                    _channel.InsertDateTime = DateTime.Now;

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .ChannelRepository
                        .Insert(_channel)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"کانال {_channel.Name} با موفقیت ثبت گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
                }
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
            return View(_channel);
        }

        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _channel = _unitOfWork
                            .SchemaTelegramUnitOfWork
                            .ChannelRepository
                            .GetByID(id);

                ClientForGetException(_channel);
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (ClientForGetException cex)
            {
                ExceptionViewModel? exceptionViewModel = JsonConvert.DeserializeObject<ExceptionViewModel>(cex.Message);

                TempData["AlertSeverity"] = (int)exceptionViewModel.AlertSeverity;
                TempData["StatusMessage"] = exceptionViewModel.Message;
                return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
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
            return View(_channel);
        }

        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _channel = _unitOfWork
                            .SchemaTelegramUnitOfWork
                            .ChannelRepository
                            .GetByID(id);

                ClientForGetException(_channel);

                _channel.Name = _channel.Name.Split('@')[1];
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (ClientForGetException cex)
            {
                ExceptionViewModel? exceptionViewModel = JsonConvert.DeserializeObject<ExceptionViewModel>(cex.Message);

                TempData["AlertSeverity"] = (int)exceptionViewModel.AlertSeverity;
                TempData["StatusMessage"] = exceptionViewModel.Message;
                return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
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
            return View(_channel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Ordering")] Channel model)
        {
            try
            {
                ClientForGetException(id);

                if (ModelState.IsValid)
                {
                    _channel = _unitOfWork
                                .SchemaTelegramUnitOfWork
                                .ChannelRepository
                                .GetByID(id);

                    ClientForGetException(_channel);

                    _channel.Name = string.Concat("@", model.Name);
                    _channel.Ordering = model.Ordering;

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .ChannelRepository
                        .Update(_channel)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"کانال {_channel.Name} با موفقیت به روز رسانی گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
                }
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (ClientForGetException cex)
            {
                ExceptionViewModel? exceptionViewModel = JsonConvert.DeserializeObject<ExceptionViewModel>(cex.Message);

                TempData["AlertSeverity"] = (int)exceptionViewModel.AlertSeverity;
                TempData["StatusMessage"] = exceptionViewModel.Message;
                return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "DbUpdateConcurrencyException", ex.Message));
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
            return View(_channel);
        }

        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _channel = _unitOfWork
                            .SchemaTelegramUnitOfWork
                            .ChannelRepository
                            .GetByID(id);

                ClientForGetException(_channel);
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (ClientForGetException cex)
            {
                ExceptionViewModel? exceptionViewModel = JsonConvert.DeserializeObject<ExceptionViewModel>(cex.Message);

                TempData["AlertSeverity"] = (int)exceptionViewModel.AlertSeverity;
                TempData["StatusMessage"] = exceptionViewModel.Message;
                return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
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
            return View(_channel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                ClientForGetException(id);

                if (ModelState.IsValid)
                {
                    _channel = _unitOfWork
                                .SchemaTelegramUnitOfWork
                                .ChannelRepository
                                .GetByID(id);

                    ClientForGetException(_channel);

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .ChannelRepository
                        .Delete(_channel)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"کانال {_channel.Name} با موفقیت حذف گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
                }
            }
            catch (Exception ex) when (ex.InnerException is HttpRequestException)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "Service", $"هیچ ارتباطی با سرویس فوق برقرار نبوده و ارتباط ماشین با سرویس قطع می باشد.", "(عدم ارتباط با سرویس دهنده)"));
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Information, title: "Service", $"ممکن است، سرویس فوق در حال به روز رسانی بوده و یا خاموش می باشد."));
            }
            catch (ClientForGetException cex)
            {
                ExceptionViewModel? exceptionViewModel = JsonConvert.DeserializeObject<ExceptionViewModel>(cex.Message);

                TempData["AlertSeverity"] = (int)exceptionViewModel.AlertSeverity;
                TempData["StatusMessage"] = exceptionViewModel.Message;
                return RedirectToAction(actionName: nameof(Index), controllerName: "Channel", routeValues: new { Area = "TelegramBot" });
            }
            catch (DbUpdateConcurrencyException ex)
            {
                TelegramBotPageMessages.Add(new Infrastructure.TelegramBotPageMessage(alertSeverity: AlertSeverity.Error, title: "DbUpdateConcurrencyException", ex.Message));
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
            return View(_channel);
        }

        #endregion
    }
}