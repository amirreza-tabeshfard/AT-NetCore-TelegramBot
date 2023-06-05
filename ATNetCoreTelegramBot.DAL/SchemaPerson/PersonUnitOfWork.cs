using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public class PersonUnitOfWork
    : Object, IPersonUnitOfWork
{
    #region Field(s)

    private Person.IPersonRepository _personRepository;

    #endregion

    #region Constructor

    public PersonUnitOfWork(DatabaseContext databaseContext)
    {
        if (databaseContext == null)
        {
            throw (new ArgumentNullException("databaseContext"));
        }

        DatabaseContext = databaseContext;
    }

    #endregion

    #region Properties

    protected DatabaseContext DatabaseContext { get; set; }

    #endregion /Properties

    #region Implement Interface(s)

    public Person.IPersonRepository PersonRepository
    {
        get
        {
            if (_personRepository == null)
            {
                _personRepository =
                    new Person.PersonRepository(DatabaseContext);
            }
            return (_personRepository);
        }
    }

    #endregion
}