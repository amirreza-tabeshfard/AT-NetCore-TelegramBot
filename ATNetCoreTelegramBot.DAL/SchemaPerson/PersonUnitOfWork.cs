using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public class PersonUnitOfWork
    : object, IPersonUnitOfWork
{
    #region Field(s)

    private Address.IAddressRepository _addressRepository;
    private AddressType.IAddressTypeRepository _addressTypeRepository;
    private Avatar.IAvatarRepository _avatarRepository;
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

    public AddressType.IAddressTypeRepository AddressTypeRepository
    {
        get
        {
            if (_addressTypeRepository == null)
            {
                _addressTypeRepository =
                    new AddressType.AddressTypeRepository(DatabaseContext);
            }
            return (_addressTypeRepository);
        }
    }

    public Avatar.IAvatarRepository AvatarRepository
    {
        get
        {
            if (_avatarRepository == null)
            {
                _avatarRepository =
                    new Avatar.AvatarRepository(DatabaseContext);
            }
            return (_avatarRepository);
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