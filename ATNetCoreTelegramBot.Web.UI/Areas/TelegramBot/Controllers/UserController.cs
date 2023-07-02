using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.Models.SchemaTelegram;
using ATNetCoreTelegramBot.ViewModels.Areas.TelegramBot;

namespace ATNetCoreTelegramBot.Web.UI.Areas.TelegramBot.Controllers
{
    public class UserController : Infrastructure.BaseController
    {
        #region Field(s)

        private readonly ILogger<UserController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IServiceScope _serviceScope;
        private readonly DAL.UnitOfWork _unitOfWork;

        private User _user;
        private UserViewModel _userVM;

        #endregion

        #region Constructor

        private UserController()
            : base()
        {

        }

        private UserController(IServiceProvider serviceProvider)
             : this()
        {
            _serviceProvider = serviceProvider;
            _serviceScope = _serviceProvider.CreateScope();

            _unitOfWork = _serviceScope.ServiceProvider.GetRequiredService<DAL.UnitOfWork>();
            _user = _serviceScope.ServiceProvider.GetRequiredService<User>();
            _userVM = _serviceScope.ServiceProvider.GetRequiredService<UserViewModel>();
        }

        public UserController(ILogger<UserController> logger,
                               IServiceProvider serviceProvider)
            : this(serviceProvider)
        {
            _logger = logger;
        }

        #endregion

        #region Index

        public IActionResult Index()
        {
            return View(_userVM);
        } 

        #endregion
    }
}