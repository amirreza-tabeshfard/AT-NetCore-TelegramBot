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

    // ChatID 
    Models.SchemaTelegram.User GetByChatID
        (long chatID, bool isExceptChatID = false);

    Task<Models.SchemaTelegram.User> GetByChatIDAsync
        (long chatID, bool isExceptChatID = false);

    #endregion /Argument 2

    #region Full Items

    // All Items
    IEnumerable<Models.SchemaTelegram.User> GetByAllUsers
        ();

    Task<List<Models.SchemaTelegram.User>> GetByAllUsersAsync
        ();

    #endregion
}