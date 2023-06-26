using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ATNetCoreTelegramBot.Web.UI.Infrastructure;

public class BaseController : Controller
{
    #region Field(s)

    private string _currentLanguage;

    #endregion

    #region Constructor
    
    public BaseController()
    {

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

    public ActionResult RedirectToDefaultCulture()
    {
        var culture = CurrentLanguage;

        return RedirectToAction(actionName: "Index", controllerName: "Home", routeValues: new { culture });
    }
}