namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Address;

public interface IAddressRepository :
    ID.IGuidRepository<Models.SchemaPerson.Address>
{
    #region Argument 2

    // ID
    Models.SchemaPerson.Address GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaPerson.Address> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // CultureId
    Models.SchemaPerson.Address GetByCultureId
        (int cultureId, bool isExceptCultureId = false);

    Task<Models.SchemaPerson.Address> GetByCultureIdAsync
        (int cultureId, bool isExceptCultureId = false);

    // PersonId
    Models.SchemaPerson.Address GetByPersonId
        (Guid personId, bool isExceptPersonId = false);

    Task<Models.SchemaPerson.Address> GetByPersonIdAsync
        (Guid personId, bool isExceptPersonId = false);

    // CityId
    Models.SchemaPerson.Address GetByCityId
        (Guid cityId, bool isExceptCityId = false);

    Task<Models.SchemaPerson.Address> GetByCityIdAsync
        (Guid cityId, bool isExceptCityId = false);

    // AddressTypeId
    Models.SchemaPerson.Address GetByAddressTypeId
        (int addressTypeId, bool isExceptAddressTypeId = false);

    Task<Models.SchemaPerson.Address> GetByAddressTypeIdAsync
        (int addressTypeId, bool isExceptAddressTypeId = false);

    #endregion /Argument 2

    #region Argument 4

    // CultureId - PersonId
    Models.SchemaPerson.Address GetByCultureId_PersonId
        (int cultureId, Guid personId, bool isExceptCultureId = false, bool isExceptPersonId = false);

    Task<Models.SchemaPerson.Address> GetByCultureId_PersonIdAsync
        (int cultureId, Guid personId, bool isExceptCultureId = false, bool isExceptPersonId = false);

    // CultureId - CityId
    Models.SchemaPerson.Address GetByCultureId_CityId
        (int cultureId, Guid cityId, bool isExceptCultureId = false, bool isExceptCityId = false);

    Task<Models.SchemaPerson.Address> GetByCultureId_CityIdAsync
        (int cultureId, Guid cityId, bool isExceptCultureId = false, bool isExceptCityId = false);

    // CultureId - AddressTypeId
    Models.SchemaPerson.Address GetByCultureId_AddressTypeId
        (int cultureId, int addressTypeId, bool isExceptCultureId = false, bool isExceptAddressTypeId = false);

    Task<Models.SchemaPerson.Address> GetByCultureId_AddressTypeIdAsync
        (int cultureId, int addressTypeId, bool isExceptCultureId = false, bool isExceptAddressTypeId = false);

    // PersonId - CityId
    Models.SchemaPerson.Address GetByPersonId_CityId
        (Guid personId, Guid cityId, bool isExceptPersonId = false, bool isExceptCityId = false);

    Task<Models.SchemaPerson.Address> GetByPersonId_CityIdAsync
        (Guid personId, Guid cityId, bool isExceptPersonId = false, bool isExceptCityId = false);

    // PersonId - AddressTypeId
    Models.SchemaPerson.Address GetByPersonId_AddressTypeId
        (Guid personId, int addressTypeId, bool isExceptPersonId = false, bool isExceptAddressTypeId = false);

    Task<Models.SchemaPerson.Address> GetByPersonId_AddressTypeIdAsync
        (Guid personId, int addressTypeId, bool isExceptPersonId = false, bool isExceptAddressTypeId = false);

    // CityId - AddressTypeId
    Models.SchemaPerson.Address GetByCityId_AddressTypeId
        (Guid cityId, int addressTypeId, bool isExceptCityId = false, bool isExceptAddressTypeId = false);

    Task<Models.SchemaPerson.Address> GetByCityId_AddressTypeIdAsync
        (Guid cityId, int addressTypeId, bool isExceptCityId = false, bool isExceptAddressTypeId = false);

    #endregion /Argument 4

    #region All Items

    IEnumerable<Models.SchemaPerson.Address> GetAllAddress
        ();

    Task<List<Models.SchemaPerson.Address>> GetAllAddressAsync
        ();

    #endregion
}