namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public interface IPersonUnitOfWork
{
    #region Properties

    Address.IAddressRepository AddressRepository { get; }

    Person.IPersonRepository PersonRepository { get; }

    #endregion
}