using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.Argument4;

internal class Argument4Repository :
    ID.IntRepository<Models.SchemaBase.Culture>, IArgument4Repository
{
    #region Constructor

    public Argument4Repository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Implementation(s): IArgument4Repository

    // Id - LanguageCultureName 
    public Models.SchemaBase.Culture GetById_LanguageCultureName
          (int id, string languageCultureName)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.LanguageCultureName == languageCultureName)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetById_LanguageCultureNameAsync
        (int id, string languageCultureName)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.LanguageCultureName == languageCultureName)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // Id - DisplayName 
    public Models.SchemaBase.Culture GetById_DisplayName
        (int id, string displayName)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.DisplayName == displayName)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetById_DisplayNameAsync
        (int id, string displayName)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.DisplayName == displayName)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // Id - CultureCode 
    public Models.SchemaBase.Culture GetById_CultureCode
        (int id, string cultureCode)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetById_CultureCodeAsync
        (int id, string cultureCode)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // Id - IsActive 
    public Models.SchemaBase.Culture GetById_IsActive
        (int id, bool isActive)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetById_IsActiveAsync
        (int id, bool isActive)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // LanguageCultureName - DisplayName 
    public Models.SchemaBase.Culture GetByLanguageCultureName_DisplayName
        (string languageCultureName, string displayName)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.DisplayName == displayName)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByLanguageCultureName_DisplayNameAsync
        (string languageCultureName, string displayName)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.DisplayName == displayName)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // LanguageCultureName - CultureCode 
    public Models.SchemaBase.Culture GetByLanguageCultureName_CultureCode
         (string languageCultureName, string cultureCode)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByLanguageCultureName_CultureCodeAsync
        (string languageCultureName, string cultureCode)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // LanguageCultureName - IsActive
    public Models.SchemaBase.Culture GetByLanguageCultureName_IsActive
        (string languageCultureName, bool isActive)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByLanguageCultureName_IsActiveAsync
        (string languageCultureName, bool isActive)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // DisplayName - CultureCode
    public Models.SchemaBase.Culture GetByDisplayName_CultureCode
        (string displayName, string cultureCode)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByDisplayName_CultureCodeAsync
        (string displayName, string cultureCode)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .Where(current => current.CultureCode == cultureCode)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // DisplayName - IsActive
    public Models.SchemaBase.Culture GetByDisplayName_IsActive
        (string displayName, bool isActive)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByDisplayName_IsActiveAsync
        (string displayName, bool isActive)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // CultureCode - IsActive
    public Models.SchemaBase.Culture GetByCultureCode_IsActive
        (string cultureCode, bool isActive)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.CultureCode == cultureCode)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByCultureCode_IsActiveAsync
        (string cultureCode, bool isActive)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.CultureCode == cultureCode)
            .Where(current => current.IsActive == isActive)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    #endregion
}