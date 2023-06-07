namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.Argument2;

public interface IArgument2Repository :
    ID.IIntRepository<Models.SchemaBase.Culture>
{
    // ID
    Models.SchemaBase.Culture GetByID
        (int id);

    Task<Models.SchemaBase.Culture> GetByIdAsync
        (int id);

    // LanguageCultureName
    Models.SchemaBase.Culture GetByLanguageCultureName
        (string languageCultureName);

    Task<Models.SchemaBase.Culture> GetByLanguageCultureNameAsync
        (string languageCultureName);

    // DisplayName
    Models.SchemaBase.Culture GetByDisplayName
        (string displayName);

    Task<Models.SchemaBase.Culture> GetByDisplayNameAsync
        (string displayName);

    // CultureCode
    Models.SchemaBase.Culture GetByCultureCode
        (string cultureCode);

    Task<Models.SchemaBase.Culture> GetByCultureCodeAsync
        (string cultureCode);

    // IsActive
    IEnumerable<Models.SchemaBase.Culture> GetByIsActive
        (bool isActive);

    Task<List<Models.SchemaBase.Culture>> GetByIsActiveAsync
        (bool isActive);
}