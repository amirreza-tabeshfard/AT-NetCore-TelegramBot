using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.Argument2;

internal class Argument2Repository :
    ID.IntRepository<Models.SchemaBase.Culture>, IArgument2Repository
{
    #region Constructor

    public Argument2Repository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Implementation(s): IArgument2Repository

    // ID
    public Models.SchemaBase.Culture GetByID
        (int id)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .OrderBy(current => current.Id)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByIdAsync
        (int id)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.Id == id)
            .OrderBy(current => current.Id)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // LanguageCultureName
    public Models.SchemaBase.Culture GetByLanguageCultureName
        (string languageCultureName)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .OrderBy(current => current.LanguageCultureName)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByLanguageCultureNameAsync
        (string languageCultureName)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.LanguageCultureName == languageCultureName)
            .OrderBy(current => current.LanguageCultureName)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // DisplayName
    public Models.SchemaBase.Culture GetByDisplayName
        (string displayName)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .OrderBy(current => current.DisplayName)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByDisplayNameAsync
        (string displayName)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.DisplayName == displayName)
            .OrderBy(current => current.DisplayName)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // CultureCode
    public Models.SchemaBase.Culture GetByCultureCode
        (string cultureCode)
    {
        Models.SchemaBase.Culture? oEntities = null;

        oEntities =
            Get()
            .Where(current => current.CultureCode == cultureCode)
            .OrderBy(current => current.CultureCode)
            .FirstOrDefault()
            ;

        return (oEntities);
    }

    public Task<Models.SchemaBase.Culture> GetByCultureCodeAsync
        (string cultureCode)
    {
        Task<Models.SchemaBase.Culture?> oEntities = null;

        oEntities =
            Get()
            .Where(current => current.CultureCode == cultureCode)
            .OrderBy(current => current.CultureCode)
            .FirstOrDefaultAsync()
            ;

        return (oEntities);
    }

    // IsActive
    public IEnumerable<Models.SchemaBase.Culture> GetByIsActive
        (bool isActive)
    {
        IEnumerable<Models.SchemaBase.Culture> oEntities = default;

        oEntities =
            Get()
            .Where(current => current.IsActive == isActive)
            .OrderBy(current => current.IsActive)
            .ToList()
            ;

        return (oEntities);
    }

    public Task<List<Models.SchemaBase.Culture>> GetByIsActiveAsync
        (bool isActive)
    {
        Task<List<Models.SchemaBase.Culture>> oEntities = default;

        oEntities =
            Get()
            .Where(current => current.IsActive == isActive)
            .OrderBy(current => current.IsActive)
            .ToListAsync()
            ;

        return (oEntities);
    }

    #endregion
}