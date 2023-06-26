using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using ATNetCoreTelegramBot.ViewModels;

namespace ATNetCoreTelegramBot.Web.UI.Controllers;

public class HomeController : Infrastructure.BaseController
{
    #region Field(s)

    private readonly ILogger<HomeController> _logger;
    private readonly AppSettingsViewModel _appSettingsViewModel;

    #endregion

    #region Constructor
    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _appSettingsViewModel = AppSettings();
    }

    #endregion

    #region Index
    
    public IActionResult Index()
    {
        return View();
    }

    #endregion

    #region Error
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    } 

    #endregion
}