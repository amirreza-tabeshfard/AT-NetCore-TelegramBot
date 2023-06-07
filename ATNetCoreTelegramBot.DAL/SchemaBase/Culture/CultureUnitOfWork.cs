namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture;

public class CultureUnitOfWork :
    object, ICultureUnitOfWork
{
    #region Field(s)

    private All.IAllRepository _allRepository;
    private Argument2.IArgument2Repository _argument2Repository;
    private Argument4.IArgument4Repository _argument4Repository;

    #endregion

    #region Constructor

    public CultureUnitOfWork(Models.DatabaseContext databaseContext)
    {
        if (databaseContext == null)
        {
            throw (new System.ArgumentNullException("databaseContext"));
        }

        DatabaseContext = databaseContext;
    }

    #endregion

    #region Properties

    protected Models.DatabaseContext DatabaseContext { get; set; }

    #endregion /Properties

    #region Implement Interface(s)

    public All.IAllRepository AllRepository
    {
        get
        {
            if (_allRepository == null)
            {
                _allRepository =
                    new All.AllRepository(DatabaseContext);
            }
            return (_allRepository);
        }
    }

    public Argument2.IArgument2Repository Argument2Repository
    {
        get
        {
            if (_argument2Repository == null)
            {
                _argument2Repository =
                    new Argument2.Argument2Repository(DatabaseContext);
            }
            return (_argument2Repository);
        }
    }

    public Argument4.IArgument4Repository Argument4Repository
    {
        get
        {
            if (_argument4Repository == null)
            {
                _argument4Repository =
                    new Argument4.Argument4Repository(DatabaseContext);
            }
            return (_argument4Repository);
        }
    }

    #endregion
}