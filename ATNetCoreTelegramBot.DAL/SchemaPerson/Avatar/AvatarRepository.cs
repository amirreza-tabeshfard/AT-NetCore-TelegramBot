using ATNetCoreTelegramBot.Models.SchemaBase;
using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Avatar;

public class AvatarRepository :
    ID.GuidRepository<Models.SchemaPerson.Avatar>, IAvatarRepository
{
    #region Constructor

    public AvatarRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaPerson.Avatar GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaPerson.Avatar? oEntities = default;

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

    public Task<Models.SchemaPerson.Avatar> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaPerson.Avatar?> oEntities = default;

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

    // PersonId
    public Models.SchemaPerson.Avatar GetByPersonId
        (Guid personId, bool isExceptPersonId = false)
    {
        Models.SchemaPerson.Avatar? oEntities = default;

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

    public Task<Models.SchemaPerson.Avatar> GetByPersonIdAsync
        (Guid personId, bool isExceptPersonId = false)
    {
        Task<Models.SchemaPerson.Avatar?> oEntities = default;

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

    // Name
    public Models.SchemaPerson.Avatar GetByName
        (byte[] name, bool isExceptName = false)
    {
        Models.SchemaPerson.Avatar? oEntities = default;

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

    public Task<Models.SchemaPerson.Avatar> GetByNameAsync
        (byte[] name, bool isExceptName = false)
    {
        Task<Models.SchemaPerson.Avatar?> oEntities = default;

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

    // PersonId - Name
    public Models.SchemaPerson.Avatar GetByPersonId_Name
        (Guid personId, byte[] name, bool isExceptPersonId = false, bool isExceptName = false)
    {
        Models.SchemaPerson.Avatar? oEntities = null;

        if ((isExceptPersonId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Avatar> GetByPersonId_NameAsync
        (Guid personId, byte[] name, bool isExceptPersonId = false, bool isExceptName = false)
    {
        Task<Models.SchemaPerson.Avatar?> oEntities = null;

        if ((isExceptPersonId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId == personId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptPersonId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.PersonId != personId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.PersonId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 4

    #region All Items

    public IEnumerable<Models.SchemaPerson.Avatar> GetAllAvatar
        ()
    {
        IEnumerable<Models.SchemaPerson.Avatar> oEntities =
            Get()
            .OrderBy(current => current.PersonId)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaPerson.Avatar>> GetAllAvatarAsync
        ()
    {
        Task<List<Models.SchemaPerson.Avatar>> oEntities =
            Get()
            .OrderBy(current => current.PersonId)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}