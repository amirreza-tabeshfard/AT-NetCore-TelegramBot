using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.User;

public class UserRepository :
    ID.GuidRepository<Models.SchemaTelegram.User>, IUserRepository
{
    #region Constructor

    public UserRepository(DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaTelegram.User GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaTelegram.User oEntities = default;

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

    public Task<Models.SchemaTelegram.User> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaTelegram.User> oEntities = default;

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

    // ChatID 
    public Models.SchemaTelegram.User GetByChatID
        (long chatID, bool isExceptChatID = false)
    {
        Models.SchemaTelegram.User oEntities = default;

        if (isExceptChatID == false)
        {
            oEntities =
                Get()
                .Where(current => current.ChatID == chatID)
                .OrderBy(current => current.ChatID)
                .FirstOrDefault()
                ;
        }
        else if (isExceptChatID == true)
        {
            oEntities =
                Get()
                .Where(current => current.ChatID != chatID)
                .OrderBy(current => current.ChatID)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaTelegram.User> GetByChatIDAsync
        (long chatID, bool isExceptChatID = false)
    {
        Task<Models.SchemaTelegram.User> oEntities = default;

        if (isExceptChatID == false)
        {
            oEntities =
                Get()
                .Where(current => current.ChatID == chatID)
                .OrderBy(current => current.ChatID)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptChatID == true)
        {
            oEntities =
                Get()
                .Where(current => current.ChatID != chatID)
                .OrderBy(current => current.ChatID)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2

    #region Full Items

    // All Items
    public IEnumerable<Models.SchemaTelegram.User> GetByAllUsers
        ()
    {
        IEnumerable<Models.SchemaTelegram.User> oEntities =
            Get()
            .OrderBy(current => current.ChatID)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaTelegram.User>> GetByAllUsersAsync
        ()
    {
        Task<List<Models.SchemaTelegram.User>> oEntities =
            Get()
            .OrderBy(current => current.ChatID)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}