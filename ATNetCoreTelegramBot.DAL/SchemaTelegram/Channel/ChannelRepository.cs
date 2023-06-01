using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.Channel;

public class ChannelRepository :
    ID.GuidRepository<Models.SchemaTelegram.Channel>, IChannelRepository
{
    #region Constructor

    public ChannelRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaTelegram.Channel GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaTelegram.Channel oEntities = default;

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

    public Task<Models.SchemaTelegram.Channel> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaTelegram.Channel> oEntities = default;

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
    public Models.SchemaTelegram.Channel GetByName
        (string name, bool isExceptName = false)
    {
        Models.SchemaTelegram.Channel oEntities = default;

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

    public Task<Models.SchemaTelegram.Channel> GetByNameAsync
        (string name, bool isExceptName = false)
    {
        Task<Models.SchemaTelegram.Channel> oEntities = default;

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
}