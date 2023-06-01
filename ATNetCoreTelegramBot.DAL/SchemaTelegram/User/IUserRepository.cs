namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.User;

public interface IUserRepository :
    ID.IGuidRepository<Models.SchemaTelegram.TelegramUser>
{
    #region Argument 2

    // ID
    Models.SchemaTelegram.TelegramUser GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaTelegram.TelegramUser> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // TelegramID 
    Models.SchemaTelegram.TelegramUser GetByTelegramID
        (long telegramID, bool isExceptTelegramID = false);

    Task<Models.SchemaTelegram.TelegramUser> GetByTelegramIDAsync
        (long telegramID, bool isExceptTelegramID = false);

    #endregion /Argument 2
}