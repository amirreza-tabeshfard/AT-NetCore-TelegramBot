namespace ATNetCoreTelegramBot.DAL.SchemaPerson.AddressType;

public interface IAddressTypeRepository :
    ID.IIntRepository<Models.SchemaPerson.AddressType>
{
    #region Argument 2

    // ID
    Models.SchemaPerson.AddressType GetByID
        (int id, bool isExceptID = false);

    Task<Models.SchemaPerson.AddressType> GetByIdAsync
        (int id, bool isExceptID = false);

    // CultureId
    Models.SchemaPerson.AddressType GetByCultureId
        (int cultureId, bool isExceptCultureId = false);

    Task<Models.SchemaPerson.AddressType> GetByCultureIdAsync
        (int cultureId, bool isExceptCultureId = false);

    // Name
    Models.SchemaPerson.AddressType GetByName
        (string name, bool isExceptName = false);

    Task<Models.SchemaPerson.AddressType> GetByNameAsync
        (string name, bool isExceptName = false);

    #endregion /Argument 2

    #region Argument 4

    // CultureId - Name
    Models.SchemaPerson.AddressType GetByCultureId_Name
        (int cultureId, string name, bool isExceptCultureId = false, bool isExceptName = false);

    Task<Models.SchemaPerson.AddressType> GetByCultureId_NameAsync
        (int cultureId, string name, bool isExceptCultureId = false, bool isExceptName = false);

    #endregion /Argument 4

    #region All Items

    IEnumerable<Models.SchemaPerson.AddressType> GetAllAddressType
        ();

    Task<List<Models.SchemaPerson.AddressType>> GetAllAddressTypeAsync
        ();

    #endregion
}