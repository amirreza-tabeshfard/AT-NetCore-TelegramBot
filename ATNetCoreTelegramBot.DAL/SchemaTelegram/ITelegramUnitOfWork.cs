namespace ATNetCoreTelegramBot.DAL.SchemaTelegram;

public interface ITelegramUnitOfWork
{
    #region Properties

    Channel.IChannelRepository ChannelRepository { get; }

    Group.IGroupRepository GroupRepository { get; }

    User.IUserRepository UserRepository { get; }

    #endregion
}