namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.Argument4;

public interface IArgument4Repository :
    ID.IIntRepository<Models.SchemaBase.Culture>
{
    // Id - LanguageCultureName 
    Models.SchemaBase.Culture GetById_LanguageCultureName
        (int id, string languageCultureName);

    Task<Models.SchemaBase.Culture> GetById_LanguageCultureNameAsync
        (int id, string languageCultureName);

    // Id - DisplayName 
    Models.SchemaBase.Culture GetById_DisplayName
        (int id, string displayName);

    Task<Models.SchemaBase.Culture> GetById_DisplayNameAsync
        (int id, string displayName);

    // Id - CultureCode 
    Models.SchemaBase.Culture GetById_CultureCode
        (int id, string cultureCode);

    Task<Models.SchemaBase.Culture> GetById_CultureCodeAsync
        (int id, string cultureCode);

    // Id - IsActive 
    Models.SchemaBase.Culture GetById_IsActive
        (int id, bool isActive);

    Task<Models.SchemaBase.Culture> GetById_IsActiveAsync
        (int id, bool isActive);

    // LanguageCultureName - DisplayName 
    Models.SchemaBase.Culture GetByLanguageCultureName_DisplayName
        (string languageCultureName, string displayName);

    Task<Models.SchemaBase.Culture> GetByLanguageCultureName_DisplayNameAsync
        (string languageCultureName, string displayName);

    // LanguageCultureName - CultureCode 
    Models.SchemaBase.Culture GetByLanguageCultureName_CultureCode
         (string languageCultureName, string cultureCode);

    Task<Models.SchemaBase.Culture> GetByLanguageCultureName_CultureCodeAsync
        (string languageCultureName, string cultureCode);

    // LanguageCultureName - IsActive
    Models.SchemaBase.Culture GetByLanguageCultureName_IsActive
        (string languageCultureName, bool isActive);

    Task<Models.SchemaBase.Culture> GetByLanguageCultureName_IsActiveAsync
        (string languageCultureName, bool isActive);

    // DisplayName - CultureCode
    Models.SchemaBase.Culture GetByDisplayName_CultureCode
        (string displayName, string cultureCode);

    Task<Models.SchemaBase.Culture> GetByDisplayName_CultureCodeAsync
        (string displayName, string cultureCode);

    // DisplayName - IsActive
    Models.SchemaBase.Culture GetByDisplayName_IsActive
        (string displayName, bool isActive);

    Task<Models.SchemaBase.Culture> GetByDisplayName_IsActiveAsync
        (string displayName, bool isActive);

    // CultureCode - IsActive
    Models.SchemaBase.Culture GetByCultureCode_IsActive
        (string cultureCode, bool isActive);

    Task<Models.SchemaBase.Culture> GetByCultureCode_IsActiveAsync
        (string cultureCode, bool isActive);
}