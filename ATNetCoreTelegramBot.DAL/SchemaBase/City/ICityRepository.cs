namespace ATNetCoreTelegramBot.DAL.SchemaBase.City
{
    public interface ICityRepository : 
        ID.IGuidRepository<Models.SchemaBase.City>
    {
        #region Argument 2

        // ID
        Models.SchemaBase.City GetByID
            (Guid id, bool isExceptID = false);

        Task<Models.SchemaBase.City> GetByIdAsync
            (Guid id, bool isExceptID = false);

        // CultureId 
        IEnumerable<Models.SchemaBase.City> GetByCultureId
            (int cultureId, bool isExceptCultureId = false);

        Task<List<Models.SchemaBase.City>> GetByCultureIdAsync
            (int cultureId, bool isExceptCultureId = false);

        // ProvinceId 
        IEnumerable<Models.SchemaBase.City> GetByProvinceId
            (Guid provinceId, bool isExceptProvinceId = false);

        Task<List<Models.SchemaBase.City>> GetByProvinceIdAsync
            (Guid provinceId, bool isExceptProvinceId = false);

        // Name 
        IEnumerable<Models.SchemaBase.City> GetByName
            (string name, bool isExceptName = false);

        Task<List<Models.SchemaBase.City>> GetByNameAsync
            (string name, bool isExceptName = false);

        #endregion /Argument 2

        #region Argument 4

        // Id - ProvinceId
        Models.SchemaBase.City GetById_ProvinceId
            (Guid id, Guid provinceId, bool isExceptID = false, bool isExceptProvinceId = false);

        Task<Models.SchemaBase.City> GetById_ProvinceIdAsync
            (Guid id, Guid provinceId, bool isExceptID = false, bool isExceptProvinceId = false);

        // Id - Name
        Models.SchemaBase.City GetById_Name
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        Task<Models.SchemaBase.City> GetById_NameAsync
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false);

        // ProvinceId - Name
        IEnumerable<Models.SchemaBase.City> GetByProvinceId_Name
            (Guid provinceId, string name, bool isExceptProvinceId = false, bool isExceptName = false);

        Task<List<Models.SchemaBase.City>> GetByProvinceId_NameAsync
            (Guid provinceId, string name, bool isExceptProvinceId = false, bool isExceptName = false);

        #endregion /Argument 4

        #region Argument 6

        // Id - ProvinceId - Name
        Models.SchemaBase.City GetById_ProvinceId_Name
            (Guid id, Guid provinceId, string name, bool isExceptID = false, bool isExceptProvinceId = false, bool isExceptName = false);

        Task<Models.SchemaBase.City> GetById_ProvinceId_NameAsync
            (Guid id, Guid provinceId, string name, bool isExceptID = false, bool isExceptProvinceId = false, bool isExceptName = false);

        #endregion /Argument 6

        #region Full Items

        IEnumerable<Models.SchemaBase.City> GetByAllCities
            ();

        Task<List<Models.SchemaBase.City>> GetByAllCitiesAsync
            ();

        #endregion /Full Items
    }
}