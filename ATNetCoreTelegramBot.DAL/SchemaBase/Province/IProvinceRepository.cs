namespace ATNetCoreTelegramBot.DAL.SchemaBase.Province
{
    public interface IProvinceRepository : 
        ID.IGuidRepository<Models.SchemaBase.Province>
    {
        #region Argument 2

        // ID
        Models.SchemaBase.Province GetByID
            (Guid id, bool isExceptID = false);

        Task<Models.SchemaBase.Province> GetByIdAsync
            (Guid id, bool isExceptID = false);

        // CountryId 
        IEnumerable<Models.SchemaBase.Province> GetByCountryId
            (Guid countryId, bool isExceptCountryId = false);

        Task<List<Models.SchemaBase.Province>> GetByCountryIdAsync(
            Guid countryId, bool isExceptCountryId = false);

        // Name 
        IEnumerable<Models.SchemaBase.Province> GetByName
            (string name, bool isExceptName = false);

        Task<List<Models.SchemaBase.Province>> GetByNameAsync
            (string name, bool isExceptName = false);

        #endregion /Argument 2

        #region Argument 4

        // Id - CountryId
        Models.SchemaBase.Province GetById_CountryId
            (Guid id, Guid countryId, bool isExceptID = false, bool isExceptCountryId = false);

        Task<Models.SchemaBase.Province> GetById_CountryIdAsync
            (Guid id, Guid countryId, bool isExceptID = false, bool isExceptCountryId = false);

        // Id - Name
        Models.SchemaBase.Province GetById_Name
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        Task<Models.SchemaBase.Province> GetById_NameAsync
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        // CountryId - Name
        IEnumerable<Models.SchemaBase.Province> GetByCountryId_Name
            (Guid countryId, string name, bool isExceptCountryId = false, bool isExceptName = false);

        Task<List<Models.SchemaBase.Province>> GetByCountryId_NameAsync
            (Guid countryId, string name, bool isExceptCountryId = false, bool isExceptName = false);

        #endregion /Argument 4

        #region Argument 6

        // Id - CountryId - Name
        Models.SchemaBase.Province GetById_CountryId_Name
            (Guid id, Guid countryId, string name, bool isExceptID = false, bool isExceptCountryId = false, bool isExceptName = false);

        Task<Models.SchemaBase.Province> GetById_CountryId_NameAsync
            (Guid id, Guid countryId, string name, bool isExceptID = false, bool isExceptCountryId = false, bool isExceptName = false);

        #endregion /Argument 6

        #region Full Items

        IEnumerable<Models.SchemaBase.Province> GetByAllProvinces
            ();

        Task<List<Models.SchemaBase.Province>> GetByAllProvincesAsync
            ();

        #endregion /Full Items
    }
}