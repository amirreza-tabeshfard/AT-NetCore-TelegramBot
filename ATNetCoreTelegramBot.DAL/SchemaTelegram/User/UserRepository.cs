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

    // TelegramID 
    public Models.SchemaTelegram.User GetByTelegramID
        (long telegramID, bool isExceptTelegramID = false)
    {
        Models.SchemaTelegram.User oEntities = default;

        if (isExceptTelegramID == false)
        {
            oEntities =
                Get()
                .Where(current => current.TelegramID == telegramID)
                .OrderBy(current => current.TelegramID)
                .FirstOrDefault()
                ;
        }
        else if (isExceptTelegramID == true)
        {
            oEntities =
                Get()
                .Where(current => current.TelegramID != telegramID)
                .OrderBy(current => current.TelegramID)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaTelegram.User> GetByTelegramIDAsync
        (long telegramID, bool isExceptTelegramID = false)
    {
        Task<Models.SchemaTelegram.User> oEntities = default;

        if (isExceptTelegramID == false)
        {
            oEntities =
                Get()
                .Where(current => current.TelegramID == telegramID)
                .OrderBy(current => current.TelegramID)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptTelegramID == true)
        {
            oEntities =
                Get()
                .Where(current => current.TelegramID != telegramID)
                .OrderBy(current => current.TelegramID)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2
}