using ATNetCoreTelegramBot.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Infrastructure;

public class BaseController : Controller
{
    #region Field(s)

    IConfigurationBuilder _builder;
    IConfigurationRoot _build;
    private string _currentLanguage;

    #endregion

    #region Constructor
    
    public BaseController()
    {
        _builder = ConfigurationBuilder();
        _build = _builder.Build();
    } 

    #endregion

    #region Properties

    private string CurrentLanguage
    {
        get
        {
            if (!string.IsNullOrEmpty(_currentLanguage))
                return _currentLanguage;

            if (string.IsNullOrEmpty(_currentLanguage))
            {
                var feature = HttpContext.Features.Get<IRequestCultureFeature>();
                _currentLanguage = feature.RequestCulture.Culture.TwoLetterISOLanguageName.ToLower();
                _currentLanguage = feature.RequestCulture.Culture.IetfLanguageTag;
            }

            return _currentLanguage;
        }
    }

    #endregion

    #region Private Method(s): (AppSettings: AppDetails)

    private string? GetVersion()
    {
        string? result = default;
        // --------------------------------------------------------------------------------------------------------------------------------------------------------
        result = _build
                 .GetSection("AppDetails")
                 .GetSection("Version").Value;

        if (string.IsNullOrEmpty(result))
            result = default;
        // ---------------------------------------  -----------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion

    #region Private Method(s)

    private IConfigurationBuilder ConfigurationBuilder()
    {
        return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    }

    private AppSettingsViewModel.AppDetailsViewModel GetAppDetails()
    {
        AppSettingsViewModel.AppDetailsViewModel result = default;
        // --------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new AppSettingsViewModel.AppDetailsViewModel()
        {
            Version = GetVersion()
        };
        // --------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion

    #region Protected Method(s)

    protected AppSettingsViewModel AppSettings()
    {
        AppSettingsViewModel result = default;
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        result = new AppSettingsViewModel()
        {
            AppDetails = GetAppDetails()
        };
        // ---------------------------------------------------------------------------------------------------------------------------------------------------------
        return result;
    }

    #endregion

    public ActionResult RedirectToDefaultCulture()
    {
        var culture = CurrentLanguage;

        return RedirectToAction(actionName: "Index", controllerName: "Home", routeValues: new { culture });
    }
}