using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public class PersonUnitOfWork
    : object, IPersonUnitOfWork
{
    #region Field(s)

    private Address.IAddressRepository _addressRepository;
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

    public Address.IAddressRepository AddressRepository
    {
        get
        {
            if (_addressRepository == null)
            {
                _addressRepository =
                    new Address.AddressRepository(DatabaseContext);
            }
            return (_addressRepository);
        }
    }

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