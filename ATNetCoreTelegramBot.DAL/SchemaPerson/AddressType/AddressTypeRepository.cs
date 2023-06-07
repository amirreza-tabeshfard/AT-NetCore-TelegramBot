using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson.AddressType;

public class AddressTypeRepository :
    ID.IntRepository<Models.SchemaPerson.AddressType>, IAddressTypeRepository
{
    #region Constructor

    public AddressTypeRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaPerson.AddressType GetByID
        (int id, bool isExceptID = false)
    {
        Models.SchemaPerson.AddressType? oEntities = default;

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

    public Task<Models.SchemaPerson.AddressType> GetByIdAsync
        (int id, bool isExceptID = false)
    {
        Task<Models.SchemaPerson.AddressType?> oEntities = default;

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
    public Models.SchemaPerson.AddressType GetByCultureId
        (int cultureId, bool isExceptCultureId = false)
    {
        Models.SchemaPerson.AddressType? oEntities = default;

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

    public Task<Models.SchemaPerson.AddressType> GetByCultureIdAsync
        (int cultureId, bool isExceptCultureId = false)
    {
        Task<Models.SchemaPerson.AddressType?> oEntities = default;

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

    // Name
    public Models.SchemaPerson.AddressType GetByName
        (string name, bool isExceptName = false)
    {
        Models.SchemaPerson.AddressType? oEntities = default;

        if (isExceptName == false)
        {
            oEntities =
            Get()
                .Where(current => current.Name == name)
                .OrderBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if (isExceptName == true)
        {
            oEntities =
            Get()
                .Where(current => current.Name != name)
                .OrderBy(current => current.Name)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.AddressType> GetByNameAsync
        (string name, bool isExceptName = false)
    {
        Task<Models.SchemaPerson.AddressType?> oEntities = default;

        if (isExceptName == false)
        {
            oEntities =
            Get()
                .Where(current => current.Name == name)
                .OrderBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptName == true)
        {
            oEntities =
            Get()
                .Where(current => current.Name != name)
                .OrderBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2

    #region Argument 4

    // CultureId - Name
    public Models.SchemaPerson.AddressType GetByCultureId_Name
        (int cultureId, string name, bool isExceptCultureId = false, bool isExceptName = false)
    {
        Models.SchemaPerson.AddressType? oEntities = null;

        if ((isExceptCultureId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.AddressType> GetByCultureId_NameAsync
        (int cultureId, string name, bool isExceptCultureId = false, bool isExceptName = false)
    {
        Task<Models.SchemaPerson.AddressType?> oEntities = null;

        if ((isExceptCultureId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptCultureId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.CultureId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 4

    #region All Items

    public IEnumerable<Models.SchemaPerson.AddressType> GetAllAddressType
        ()
    {
        IEnumerable<Models.SchemaPerson.AddressType> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaPerson.AddressType>> GetAllAddressTypeAsync
        ()
    {
        Task<List<Models.SchemaPerson.AddressType>> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}