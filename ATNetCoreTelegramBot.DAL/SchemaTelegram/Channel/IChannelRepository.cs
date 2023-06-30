namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.Channel;

public interface IChannelRepository :
    ID.IGuidRepository<Models.SchemaTelegram.Channel>
{
    #region Argument 2

    // ID
    Models.SchemaTelegram.Channel GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaTelegram.Channel> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // Name
    Models.SchemaTelegram.Channel GetByName
        (string name, bool isExceptName = false);

    Task<Models.SchemaTelegram.Channel> GetByNameAsync
        (string name, bool isExceptName = false);

    #endregion

    #region Full Items

    // All Items
    IEnumerable<Models.SchemaTelegram.Channel> GetByAllChannels
        ();

    Task<List<Models.SchemaTelegram.Channel>> GetByAllChannelsAsync
        ();

    #endregion /Full Items
}