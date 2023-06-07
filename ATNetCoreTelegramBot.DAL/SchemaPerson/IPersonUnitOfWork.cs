namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public interface IPersonUnitOfWork
{
    #region Properties

    Address.IAddressRepository AddressRepository { get; }

    AddressType.IAddressTypeRepository AddressTypeRepository { get; }

    Avatar.IAvatarRepository AvatarRepository { get; }

    Person.IPersonRepository PersonRepository { get; }

    #endregion
}