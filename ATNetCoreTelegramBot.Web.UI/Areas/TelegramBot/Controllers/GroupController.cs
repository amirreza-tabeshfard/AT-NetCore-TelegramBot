using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Common.Enums;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class GroupController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<GroupController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

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
            _groupVM = _serviceScope.ServiceProvider.GetService<GroupViewModel>();
        }

        public GroupController(ILogger<GroupController> logger,
                               IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
        }

        #endregion

        #region Index

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                _groupVM.Groups = _unitOfWork
                                  .SchemaTelegramUnitOfWork
                                  .GroupRepository
                                  .GetByAllGroups()
                                  ;

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
    }
}