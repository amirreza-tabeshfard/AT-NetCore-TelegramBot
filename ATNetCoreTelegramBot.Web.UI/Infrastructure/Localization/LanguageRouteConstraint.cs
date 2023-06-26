namespace ATNetCoreTelegramBot.Web.UI.Infrastructure.Localization;

public class LanguageRouteConstraint : IRouteConstraint
{
    public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        if (!values.ContainsKey("culture"))
            return false;

        string? culture = values["culture"]?.ToString();

        return (culture == Common.Infrastructure.Culture.Farsi_Iran) 
               || (culture == Common.Infrastructure.Culture.English_UnitedStates);
    }
}
