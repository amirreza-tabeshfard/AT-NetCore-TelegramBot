using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.User;

public class UserRepository :
    ID.GuidRepository<Models.SchemaTelegram.TelegramUser>, IUserRepository
{
    #region Constructor

    public UserRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaTelegram.TelegramUser GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaTelegram.TelegramUser oEntities = default;

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

    public Task<Models.SchemaTelegram.TelegramUser> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaTelegram.TelegramUser> oEntities = default;

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
    public Models.SchemaTelegram.TelegramUser GetByTelegramID
        (long telegramID, bool isExceptTelegramID = false)
    {
        Models.SchemaTelegram.TelegramUser oEntities = default;

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

    public Task<Models.SchemaTelegram.TelegramUser> GetByTelegramIDAsync
        (long telegramID, bool isExceptTelegramID = false)
    {
        Task<Models.SchemaTelegram.TelegramUser> oEntities = default;

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