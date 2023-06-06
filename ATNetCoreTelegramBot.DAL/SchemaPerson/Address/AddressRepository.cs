using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Address;

public class AddressRepository :
    ID.GuidRepository<Models.SchemaPerson.Address>, IAddressRepository
{
    #region Constructor

    public AddressRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaPerson.Address GetByID
         (Guid id, bool isExceptID = false)
    {
        Models.SchemaPerson.Address? oEntities = default;

        if (isExceptID == false)
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .OrderBy(current => current.Id)
                .FirstOrDefault()
                ;
        }
        else if (isExceptID == true)
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .OrderBy(current => current.Id)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = default;

        if (isExceptID == false)
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .OrderBy(current => current.Id)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptID == true)
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .OrderBy(current => current.Id)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // CultureId
    public Models.SchemaPerson.Address GetByCultureId
        (int cultureId, bool isExceptCultureId = false)
    {
        Models.SchemaPerson.Address? oEntities = default;

        if (isExceptCultureId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .OrderBy(current => current.CultureId)
                .FirstOrDefault()
                ;
        }
        else if (isExceptCultureId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .OrderBy(current => current.CultureId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCultureIdAsync
        (int cultureId, bool isExceptCultureId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = default;

        if (isExceptCultureId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .OrderBy(current => current.CultureId)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptCultureId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .OrderBy(current => current.CultureId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // PersonId
    public Models.SchemaPerson.Address GetByPersonId
        (Guid personId, bool isExceptPersonId = false)
    {
        Models.SchemaPerson.Address? oEntities = default;

        if (isExceptPersonId == false)
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }
        else if (isExceptPersonId == true)
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByPersonIdAsync
        (Guid personId, bool isExceptPersonId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = default;

        if (isExceptPersonId == false)
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptPersonId == true)
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // CityId
    public Models.SchemaPerson.Address GetByCityId
        (Guid cityId, bool isExceptCityId = false)
    {
        Models.SchemaPerson.Address? oEntities = default;

        if (isExceptCityId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if (isExceptCityId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCityIdAsync
        (Guid cityId, bool isExceptCityId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = default;

        if (isExceptCityId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptCityId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // AddressTypeId
    public Models.SchemaPerson.Address GetByAddressTypeId
        (int addressTypeId, bool isExceptAddressTypeId = false)
    {
        Models.SchemaPerson.Address? oEntities = default;

        if (isExceptAddressTypeId == false)
        {
            oEntities =
                Get()
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if (isExceptAddressTypeId == true)
        {
            oEntities =
                Get()
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByAddressTypeIdAsync
        (int addressTypeId, bool isExceptAddressTypeId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = default;

        if (isExceptAddressTypeId == false)
        {
            oEntities =
                Get()
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptAddressTypeId == true)
        {
            oEntities =
                Get()
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2

    #region Argument 4

    // CultureId - PersonId
    public Models.SchemaPerson.Address GetByCultureId_PersonId
        (int cultureId, Guid personId, bool isExceptCultureId = false, bool isExceptPersonId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptCultureId == false) && (isExceptPersonId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptPersonId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptPersonId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptPersonId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCultureId_PersonIdAsync
        (int cultureId, Guid personId, bool isExceptCultureId = false, bool isExceptPersonId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptCultureId == false) && (isExceptPersonId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptPersonId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptPersonId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.PersonId == personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptPersonId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.PersonId != personId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.PersonId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // CultureId - CityId
    public Models.SchemaPerson.Address GetByCultureId_CityId
        (int cultureId, Guid cityId, bool isExceptCultureId = false, bool isExceptCityId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptCultureId == false) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCultureId_CityIdAsync
        (int cultureId, Guid cityId, bool isExceptCultureId = false, bool isExceptCityId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptCultureId == false) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // CultureId - AddressTypeId
    public Models.SchemaPerson.Address GetByCultureId_AddressTypeId
        (int cultureId, int addressTypeId, bool isExceptCultureId = false, bool isExceptAddressTypeId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptCultureId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCultureId_AddressTypeIdAsync
        (int cultureId, int addressTypeId, bool isExceptCultureId = false, bool isExceptAddressTypeId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptCultureId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // PersonId - CityId
    public Models.SchemaPerson.Address GetByPersonId_CityId
        (Guid personId, Guid cityId, bool isExceptPersonId = false, bool isExceptCityId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptPersonId == false) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByPersonId_CityIdAsync
        (Guid personId, Guid cityId, bool isExceptPersonId = false, bool isExceptCityId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptPersonId == false) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptCityId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.CityId == cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptCityId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.CityId != cityId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.CityId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // PersonId - AddressTypeId
    public Models.SchemaPerson.Address GetByPersonId_AddressTypeId
        (Guid personId, int addressTypeId, bool isExceptPersonId = false, bool isExceptAddressTypeId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptPersonId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByPersonId_AddressTypeIdAsync
        (Guid personId, int addressTypeId, bool isExceptPersonId = false, bool isExceptAddressTypeId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptPersonId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // CityId - AddressTypeId
    public Models.SchemaPerson.Address GetByCityId_AddressTypeId
        (Guid cityId, int addressTypeId, bool isExceptCityId = false, bool isExceptAddressTypeId = false)
    {
        Models.SchemaPerson.Address? oEntities = null;

        if ((isExceptCityId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCityId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCityId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCityId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Address> GetByCityId_AddressTypeIdAsync
        (Guid cityId, int addressTypeId, bool isExceptCityId = false, bool isExceptAddressTypeId = false)
    {
        Task<Models.SchemaPerson.Address?> oEntities = null;

        if ((isExceptCityId == false) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCityId == false) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CityId == cityId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCityId == true) && (isExceptAddressTypeId == false))
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .Where(current => current.AddressTypeId == addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCityId == true) && (isExceptAddressTypeId == true))
        {
            oEntities =
                Get()
                .Where(current => current.CityId != cityId)
                .Where(current => current.AddressTypeId != addressTypeId)
                .OrderBy(current => current.CityId)
                .ThenBy(current => current.AddressTypeId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 4

    #region All Items

    public IEnumerable<Models.SchemaPerson.Address> GetAllAddress
        ()
    {
        IEnumerable<Models.SchemaPerson.Address> oEntities =
            Get()
            .OrderBy(current => current.Location)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaPerson.Address>> GetAllAddressAsync
        ()
    {
        Task<List<Models.SchemaPerson.Address>> oEntities =
            Get()
            .OrderBy(current => current.Location)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}