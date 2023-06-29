using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Common.Enums;
using ATNetCoreTelegramBot.Common.Exceptions;
using ATNetCoreTelegramBot.ViewModels;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

using Newtonsoft.Json;
using ATNetCoreTelegramBot.Web.UI.Infrastructure;
using ATNetCoreTelegramBot.Models.SchemaTelegram;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class GroupController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<GroupController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

        private Models.SchemaTelegram.Group? _group = default;
        private GroupViewModel? _groupVM = default;

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
            _group = _serviceScope.ServiceProvider.GetRequiredService<Models.SchemaTelegram.Group>();
            _groupVM = _serviceScope.ServiceProvider.GetService<GroupViewModel>();
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
                                  .GetByAllGroups() ;

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
        public IActionResult Create([Bind("Name,Ordering,InsertDateTime")] Models.SchemaTelegram.Group model)
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

            return View(_group);
        }

        #endregion
    }
}