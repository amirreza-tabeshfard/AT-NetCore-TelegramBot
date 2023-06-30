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
    public class GroupController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<GroupController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

        private ViewModels.Areas.TelegramBot.ReplyKeyboardMarkupViewModel _replyKeyboardMarkupViewModel;
        private Group? _group;
        private GroupViewModel? _groupVM;

        #endregion

        #region Constructor

        private GroupController()
            : base()
        {

        }

        private GroupController(IServiceProvider serviceProvider)
             : this()
        {
            _serviceProvider = serviceProvider;
            _serviceScope = _serviceProvider.CreateScope();

            _unitOfWork = _serviceScope.ServiceProvider.GetRequiredService<DAL.UnitOfWork>();
            _group = _serviceScope.ServiceProvider.GetRequiredService<Group>();
            _groupVM = _serviceScope.ServiceProvider.GetRequiredService<GroupViewModel>();
            _replyKeyboardMarkupViewModel = _serviceScope.ServiceProvider.GetRequiredService<ViewModels.Areas.TelegramBot.ReplyKeyboardMarkupViewModel>();
        }

        public GroupController(ILogger<GroupController> logger,
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

        private void ClientForGetException(Group group)
        {
            ExceptionViewModel _exceptionViewModel = default;
            // -----------------------------------------------------------------------------------------------------------------------------------------
            if (group is null)
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

        private IEnumerable<Group> AllGroups()
        {
            IEnumerable<Group> _groups;

            _groups = _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .GroupRepository
                        .GetByAllGroups
                        ();

            return _groups;
        }

        private IEnumerable<string> InitializeChannelAndGroups()
        {
            List<string> results = new List<string>();
            IEnumerable<Group> groups = AllGroups();

            if (groups != null)
                foreach (Group group in groups)
                    results.Add(group.Name);

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

        public GroupStatus Initialize(Telegram.Bot.Types.User user)
        {
            IEnumerable<string> NamesOfGroupsThatTheUserIsNotAMember = default;
            IEnumerable<string> groupNames = InitializeChannelAndGroups();
            GroupStatus result = GroupStatus.Unknown;
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (groupNames is not null)
                if (groupNames.Any())
                {
                    NamesOfGroupsThatTheUserIsNotAMember = InMemberOfGroups(groupNames, user.Id);

                    if (NamesOfGroupsThatTheUserIsNotAMember is not null)
                        if (NamesOfGroupsThatTheUserIsNotAMember.Count() != 0)
                        {
                            StringBuilder sb = new StringBuilder();

                            sb.AppendLine($"کاربر گرامی (<b><i>{user.Username}</i></b>)");
                            sb.AppendLine("جهت استفاده از این ربات باید عضو گروه های ذیل شوید.");
                            sb.AppendLine();
                            sb.AppendLine("👥 لیست گروه ها");

                            foreach (var item in NamesOfGroupsThatTheUserIsNotAMember)
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

                            result = GroupStatus.UnMembered;
                        }
                        else
                            result = GroupStatus.Membered;
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

                _groupVM.Groups = _unitOfWork
                                  .SchemaTelegramUnitOfWork
                                  .GroupRepository
                                  .GetByAllGroups();

                if (!_groupVM.Groups.Any())
                    _groupVM.Groups = default;
                else
                    _groupVM.Total = _groupVM.Groups.Count();
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
            return View(_groupVM);
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View(_group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Ordering")] Group model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _group.Id = Guid.NewGuid();
                    _group.Name = string.Concat("@", model.Name);
                    _group.Ordering = model.Ordering;
                    _group.InsertDateTime = DateTime.Now;

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .GroupRepository
                        .Insert(_group)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"گروه {_group.Name} با موفقیت ثبت گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
        }

        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _group = _unitOfWork
                         .SchemaTelegramUnitOfWork
                         .GroupRepository
                         .GetByID(id);

                ClientForGetException(_group);
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
                return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
        }

        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _group = _unitOfWork
                         .SchemaTelegramUnitOfWork
                         .GroupRepository
                         .GetByID(id);

                ClientForGetException(_group);
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
                return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Ordering")] Group model)
        {
            try
            {
                ClientForGetException(id);

                if (ModelState.IsValid)
                {
                    _group = _unitOfWork
                             .SchemaTelegramUnitOfWork
                             .GroupRepository
                             .GetByID(id);

                    ClientForGetException(_group);

                    _group.Name = string.Concat("@", model.Name);
                    _group.Ordering = model.Ordering;

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .GroupRepository
                        .Update(_group)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"گروه {_group.Name} با موفقیت به روز رسانی گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
                return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
        }

        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            try
            {
                ClientForGetException(id);

                _group = _unitOfWork
                         .SchemaTelegramUnitOfWork
                         .GroupRepository
                         .GetByID(id);

                ClientForGetException(_group);
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
                return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
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
                    _group = _unitOfWork
                             .SchemaTelegramUnitOfWork
                             .GroupRepository
                             .GetByID(id);

                    ClientForGetException(_group);

                    _unitOfWork
                        .SchemaTelegramUnitOfWork
                        .GroupRepository
                        .Delete(_group)
                        ;

                    _unitOfWork
                        .SaveChanges();

                    TempData["AlertSeverity"] = (int)AlertSeverity.Success;
                    TempData["StatusMessage"] = $"گروه {_group.Name} با موفقیت حذف گردید.";
                    return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
                return RedirectToAction(actionName: nameof(Index), controllerName: "Group", routeValues: new { Area = "TelegramBot" });
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
            return View(_group);
        }

        #endregion
    }
}