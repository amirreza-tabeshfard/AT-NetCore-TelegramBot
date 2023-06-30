using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Common.Enums;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class ChannelController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<ChannelController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

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
            _channelVM = _serviceScope.ServiceProvider.GetRequiredService<ChannelViewModel>();
        }

        public ChannelController(ILogger<ChannelController> logger,
                               IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
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
    }
}