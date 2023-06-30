using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Common.Enums;
using ATNetCoreTelegramBot.Common.Exceptions;
using ATNetCoreTelegramBot.Models.SchemaTelegram;
using ATNetCoreTelegramBot.ViewModels;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;
using System.Threading.Channels;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class ChannelController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<ChannelController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

        private Models.SchemaTelegram.Channel _channel;
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
            _channel = _serviceScope.ServiceProvider.GetRequiredService<Models.SchemaTelegram.Channel>();
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

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View(_channel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Ordering")] Models.SchemaTelegram.Channel model)
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
    }
}