namespace ATNetCoreTelegramBot.DAL.SchemaBase.Country
{
    public interface ICountryRepository : 
        ID.IGuidRepository<Models.SchemaBase.Country>
    {
        #region Argument 2

        // ID
        Models.SchemaBase.Country GetByID
            (Guid id, bool isExceptID = false);

        Task<Models.SchemaBase.Country> GetByIdAsync
            (Guid id, bool isExceptID = false);

        // Name 
        IEnumerable<Models.SchemaBase.Country> GetByName
            (string name, bool isExceptName = false);

        Task<List<Models.SchemaBase.Country>> GetByNameAsync
            (string name, bool isExceptName = false);

        #endregion /Argument 2

        #region Argument 4

        // Id - Name 
        Models.SchemaBase.Country GetById_Name
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        Task<Models.SchemaBase.Country> GetById_NameAsync
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        #endregion /Argument 4

        #region Full Items

        // Name
        IEnumerable<string> GetByCountriesName
            ();

        Task<List<string>> GetByCountriesNameAsync
            ();

        // All Items
        IEnumerable<Models.SchemaBase.Country> GetByAllCountries
            ();

        Task<List<Models.SchemaBase.Country>> GetByAllCountriesAsync
            ();

        #endregion /Full Items
    }
}