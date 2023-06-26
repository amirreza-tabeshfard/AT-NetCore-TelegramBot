using System.Globalization;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models;
using ATNetCoreTelegramBot.Web.UI.Infrastructure.Localization;
using ATNetCoreTelegramBot.Web.UI.Infrastructure.Identity;

using WebMarkupMin.AspNetCore5;
using Microsoft.Extensions.Options;

#region Field(s)

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
ConfigurationManager configurationManager = builder.Configuration;
IServiceProvider serviceProvider = builder.Services.BuildServiceProvider();
IServiceCollection services = builder.Services;
IServiceScope serviceScope = serviceProvider.CreateScope();

string? connectionString = default;

#endregion

#region services to the container

services.AddControllersWithViews();

//services.AddControllersWithViews()
//        .AddRazorRuntimeCompilation();

services.AddRazorPages();
services.AddDatabaseDeveloperPageExceptionFilter();

#region connectionString

connectionString = configurationManager
                   .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString)); 

#endregion

#region <IdentityUser, IdentityRole>

services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    // Lockout
options.Lockout.AllowedForNewUsers = true;
options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
options.Lockout.MaxFailedAccessAttempts = 5;

    // Password
options.Password.RequireDigit = true;
options.Password.RequiredLength = 6;
options.Password.RequiredUniqueChars = 0;
options.Password.RequireLowercase = true;
options.Password.RequireNonAlphanumeric = true;
options.Password.RequireUppercase = true;

    // SignIn
options.SignIn.RequireConfirmedAccount = true;
options.SignIn.RequireConfirmedEmail = true;
options.SignIn.RequireConfirmedPhoneNumber = false;

    // User
options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
options.User.RequireUniqueEmail = false;
})
        .AddEntityFrameworkStores<DatabaseContext>()
        .AddDefaultTokenProviders()
        .AddDefaultUI()
        .AddErrorDescriber<ErrorDescriber>();

#endregion

#region Cookie

services.ConfigureApplicationCookie(options =>
{
    //options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    //options.Cookie.Name = "YourAppCookieName";
    //options.Cookie.HttpOnly = true;
    //options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    //options.LoginPath = "/Identity/Account/Login";
    // ReturnUrlParameter requires 
    //using Microsoft.AspNetCore.Authentication.Cookies;
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = true;
});

#endregion

#region SecurityStamp

services.Configure<SecurityStampValidatorOptions>(option =>
{
    option.ValidationInterval = TimeSpan.FromSeconds(5);
});

#endregion

#region PasswordHasher

services.Configure<PasswordHasherOptions>(option =>
{
    option.IterationCount = 12000;
}); 

#endregion

#region Minification

services.AddWebMarkupMin(option =>
                 {
                     //option.AllowCompressionInDevelopmentEnvironment = true;
                     //option.AllowMinificationInDevelopmentEnvironment = true;
                 })
        .AddHtmlMinification()
        .AddHttpCompression()
        .AddXhtmlMinification()
        .AddXmlMinification(); 

#endregion

#region Localization

services.AddMvc();

services.AddLocalization(options => options.ResourcesPath = "Resources");

services.AddMvc()
        .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
        .AddDataAnnotationsLocalization();

services.AddRazorPages()
        .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
        .AddDataAnnotationsLocalization();

services.Configure<RequestLocalizationOptions>(options =>
{
    CultureInfo[] supportedCultures = new[]
    {
        new CultureInfo(ATNetCoreTelegramBot.Common.Infrastructure.Culture.English_UnitedStates),
        new CultureInfo(ATNetCoreTelegramBot.Common.Infrastructure.Culture.Farsi_Iran),
    };

    options.DefaultRequestCulture = new RequestCulture(culture: ATNetCoreTelegramBot.Common.Infrastructure.Culture.Farsi_Iran, uiCulture: ATNetCoreTelegramBot.Common.Infrastructure.Culture.Farsi_Iran);
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    options.RequestCultureProviders = new[]
    {
        new QueryStringRequestCultureProvider
        {
            QueryStringKey = "culture",
            UIQueryStringKey = "culture"
        }
    };
});

services.Configure<RouteOptions>(options =>
{
    options.ConstraintMap.Add("culture", typeof(LanguageRouteConstraint));
});

services.Configure<MvcOptions>(options =>
{
    options.Filters.Add(new RequireHttpsAttribute());
});

#endregion

#endregion

#region Configure the HTTP request pipeline

WebApplication app = builder.Build();
IWebHostEnvironment environment = app.Environment;

if (environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseDatabaseErrorPage();
    app.UseMigrationsEndPoint();
}
else if (environment.IsProduction() || environment.IsStaging())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseWebMarkupMin();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

#region Check HTTPS & NOT WWW

app.Use(async (context, next) =>
{
    // check the website-content amd all element images
    string sHost = context.Request.Host.HasValue == true ? context.Request.Host.Value.ToLower() : string.Empty;
    string sPath = context.Request.Path.HasValue == true ? context.Request.Path.Value : string.Empty;
    string? sQueryString = context.Request.QueryString.HasValue == true ? context.Request.QueryString.Value : string.Empty;

    // Check if the request is "not" using the HTTPS schema
    if (!context.Request.IsHttps)
    {
        string newHttpsUrl = "https://" + sHost;

        if (sPath != string.Empty)
            newHttpsUrl = newHttpsUrl + sPath;

        if (sQueryString != string.Empty)
            newHttpsUrl = newHttpsUrl + sQueryString;

        context.Response.Redirect(newHttpsUrl);

        return;
    }

    // Check www
    if (sHost.IndexOf("www.") == 0)
    {
        // is www
        string newUrlWithoutWWW = "https://" + sHost.Replace(oldValue: "www.", newValue: string.Empty);

        if (sPath != string.Empty)
            newUrlWithoutWWW = newUrlWithoutWWW + sPath;

        if (sQueryString != string.Empty)
            newUrlWithoutWWW = newUrlWithoutWWW + sQueryString;

        context.Response.Redirect(newUrlWithoutWWW);

        return;
    }

    // also check images inside the content
    await next();
});

#endregion

#region Localization

IOptions<RequestLocalizationOptions> options = serviceScope.ServiceProvider.GetRequiredService<IOptions<RequestLocalizationOptions>>();
LocalizationPipeline.ConfigureOptions(options.Value);
app.UseRequestLocalization(options.Value);

#endregion

app.MapControllerRoute(name: "Culture_Areas",
                       pattern: "{culture}/{area}/{controller}/{action}/{id?}");

app.MapControllerRoute(name: "default",
                       pattern: "{culture:culture}/{controller}/{action}/{id?}",
                       constraints: new { culture = "fa-IR|en-US" },
                       defaults: new
                       {
                           culture = ATNetCoreTelegramBot.Common.Infrastructure.Culture.Farsi_Iran,
                           controller = "Home",
                           action = "RedirectToDefaultCulture"
                       });

app.MapRazorPages();
app.Run();

#endregion