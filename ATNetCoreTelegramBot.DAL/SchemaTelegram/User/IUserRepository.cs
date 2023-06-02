namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.User;

public interface IUserRepository :
    ID.IGuidRepository<Models.SchemaTelegram.User>
{
    #region Argument 2

    // ID
    Models.SchemaTelegram.User GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaTelegram.User> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // TelegramID 
    Models.SchemaTelegram.User GetByTelegramID
        (long telegramID, bool isExceptTelegramID = false);

    Task<Models.SchemaTelegram.User> GetByTelegramIDAsync
        (long telegramID, bool isExceptTelegramID = false);

    #endregion /Argument 2
}