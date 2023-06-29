using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class DashboardController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<DashboardController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;

        #endregion

        #region Constructor(s)

        private DashboardController()
             : base()
        {

        }

        private DashboardController(IServiceProvider serviceProvider)
             : this()
        {
            _serviceProvider = serviceProvider;
            _serviceScope = _serviceProvider.CreateScope();
        }

        public DashboardController(ILogger<DashboardController> logger,
                                   IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
        }

        #endregion

        #region Index

        public IActionResult Index()
        {
            return View();
        } 

        #endregion
    }
}