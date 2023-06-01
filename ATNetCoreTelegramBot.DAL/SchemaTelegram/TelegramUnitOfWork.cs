namespace ATNetCoreTelegramBot.DAL.SchemaTelegram;

public class TelegramUnitOfWork :
    object, ITelegramUnitOfWork
{
    #region Field(s)

    private Channel.IChannelRepository _channelRepository;
    private Group.IGroupRepository _groupRepository;
    private User.IUserRepository _userRepository;

    #endregion

    #region Constructor

    public TelegramUnitOfWork(Models.DatabaseContext databaseContext)
    {
        if (databaseContext == null)
        {
            throw (new ArgumentNullException("databaseContext"));
        }

        DatabaseContext = databaseContext;
    }

    #endregion

    #region Properties

    protected Models.DatabaseContext DatabaseContext { get; set; }

    #endregion /Properties

    #region Implement Interface(s)

    public Channel.IChannelRepository ChannelRepository
    {
        get
        {
            if (_channelRepository == null)
            {
                _channelRepository =
                    new Channel.ChannelRepository(DatabaseContext);
            }
            return (_channelRepository);
        }
    }

    public Group.IGroupRepository GroupRepository
    {
        get
        {
            if (_groupRepository == null)
            {
                _groupRepository =
                    new Group.GroupRepository(DatabaseContext);
            }
            return (_groupRepository);
        }
    }

    public User.IUserRepository UserRepository
    {
        get
        {
            if (_userRepository == null)
            {
                _userRepository =
                    new User.UserRepository(DatabaseContext);
            }
            return (_userRepository);
        }
    }

    #endregion
}