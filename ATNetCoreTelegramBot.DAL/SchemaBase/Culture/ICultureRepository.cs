namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture
{
    public interface ICultureRepository :
        ID.IIntRepository<Models.SchemaBase.Culture>
    {
        #region Argument 2

        // ID
        Models.SchemaBase.Culture GetByID
            (int id, bool isExceptID = false);

        Task<Models.SchemaBase.Culture> GetByIdAsync
            (int id, bool isExceptID = false);

        // LanguageCultureName
        IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName
            (string languageCultureName, bool isExceptLanguageCultureName = false);

        Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureNameAsync
            (string languageCultureName, bool isExceptLanguageCultureName = false);

        // DisplayName
        IEnumerable<Models.SchemaBase.Culture> GetByDisplayName
            (string displayName, bool isExceptDisplayName = false);

        Task<List<Models.SchemaBase.Culture>> GetByDisplayNameAsync
            (string displayName, bool isExceptDisplayName = false);

        // CultureCode
        IEnumerable<Models.SchemaBase.Culture> GetByCultureCode
            (string cultureCode, bool isExceptCultureCode = false);

        Task<List<Models.SchemaBase.Culture>> GetByCultureCodeAsync
            (string cultureCode, bool isExceptCultureCode = false);

        // IsActive
        IEnumerable<Models.SchemaBase.Culture> GetByIsActive
            (bool isActive);

        Task<List<Models.SchemaBase.Culture>> GetByIsActiveAsync
            (bool isActive);

        #endregion /Argument 2

        #region Argument 4

        // Id - LanguageCultureName 
        Models.SchemaBase.Culture GetById_LanguageCultureName
            (int id, string languageCultureName, bool isExceptID = false, bool isExceptLanguageCultureName = false);

        Task<Models.SchemaBase.Culture> GetById_LanguageCultureNameAsync
            (int id, string languageCultureName, bool isExceptID = false, bool isExceptLanguageCultureName = false);

        // Id - DisplayName 
        Models.SchemaBase.Culture GetById_DisplayName
            (int id, string displayName, bool isExceptID = false, bool isExceptDisplayName = false);

        Task<Models.SchemaBase.Culture> GetById_DisplayNameAsync
            (int id, string displayName, bool isExceptID = false, bool isExceptDisplayName = false);

        // Id - CultureCode 
        Models.SchemaBase.Culture GetById_CultureCode
            (int id, string cultureCode, bool isExceptID = false, bool isExceptCultureCode = false);

        Task<Models.SchemaBase.Culture> GetById_CultureCodeAsync
            (int id, string cultureCode, bool isExceptID = false, bool isExceptCultureCode = false);

        // Id - IsActive 
        Models.SchemaBase.Culture GetById_IsActive
            (int id, bool isActive, bool isExceptID = false);

        Task<Models.SchemaBase.Culture> GetById_IsActiveAsync
            (int id, bool isActive, bool isExceptID = false);

        // LanguageCultureName - DisplayName 
        IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_DisplayName
            (string languageCultureName, string displayName, bool isExceptLanguageCultureName = false, bool isExceptDisplayName = false);

        Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_DisplayNameAsync
            (string languageCultureName, string displayName, bool isExceptLanguageCultureName = false, bool isExceptDisplayName = false);

        // LanguageCultureName - CultureCode 
        IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_CultureCode
            (string languageCultureName, string cultureCode, bool isExceptLanguageCultureName = false, bool isExceptCultureCode = false);

        Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_CultureCodeAsync
            (string languageCultureName, string cultureCode, bool isExceptLanguageCultureName = false, bool isExceptCultureCode = false);

        // LanguageCultureName - IsActive
        IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_IsActive
            (string languageCultureName, bool isActive, bool isExceptLanguageCultureName = false);

        Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_IsActiveAsync
            (string languageCultureName, bool isActive, bool isExceptLanguageCultureName = false);

        // DisplayName - CultureCode
        IEnumerable<Models.SchemaBase.Culture> GetByDisplayName_CultureCode
            (string displayName, string cultureCode, bool isExceptDisplayName = false, bool isExceptCultureCode = false);

        Task<List<Models.SchemaBase.Culture>> GetByDisplayName_CultureCodeAsync
            (string displayName, string cultureCode, bool isExceptDisplayName = false, bool isExceptCultureCode = false);

        // DisplayName - IsActive
        IEnumerable<Models.SchemaBase.Culture> GetByDisplayName_IsActive
            (string displayName, bool isActive, bool isExceptDisplayName = false);

        Task<List<Models.SchemaBase.Culture>> GetByDisplayName_IsActiveAsync
            (string displayName, bool isActive, bool isExceptDisplayName = false);

        // CultureCode - IsActive
        IEnumerable<Models.SchemaBase.Culture> GetByCultureCode_IsActive
            (string cultureCode, bool isActive, bool isExceptCultureCode = false);

        Task<List<Models.SchemaBase.Culture>> GetByCultureCode_IsActiveAsync
            (string cultureCode, bool isActive, bool isExceptCultureCode = false);

        #endregion /Argument 4

        #region Full Items

        IEnumerable<Models.SchemaBase.Culture> GetByAllCultures
            ();

        Task<List<Models.SchemaBase.Culture>> GetByAllCulturesAsync
            ();

        #endregion /Full Items
    }
}