using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.Group;

public class GroupRepository :
    ID.GuidRepository<Models.SchemaTelegram.Group>, IGroupRepository
{
    #region Constructor

    public GroupRepository(DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaTelegram.Group GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaTelegram.Group oEntities = default;

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

    public Task<Models.SchemaTelegram.Group> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaTelegram.Group> oEntities = default;

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

    // Name
    public Models.SchemaTelegram.Group GetByName
        (string name, bool isExceptName = false)
    {
        Models.SchemaTelegram.Group oEntities = default;

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

    public Task<Models.SchemaTelegram.Group> GetByNameAsync
        (string name, bool isExceptName = false)
    {
        Task<Models.SchemaTelegram.Group> oEntities = default;

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

    #endregion

    #region Full Items

    // All Items
    public System.Collections.Generic.IEnumerable<Models.SchemaTelegram.Group> GetByAllGroups
        ()
    {
        System.Collections.Generic.IEnumerable<Models.SchemaTelegram.Group> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToList()
            ;

        return oEntities;
    }

    public Task<System.Collections.Generic.List<Models.SchemaTelegram.Group>> GetByAllGroupsAsync
        ()
    {
        Task<System.Collections.Generic.List<Models.SchemaTelegram.Group>> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion /Full Items
}