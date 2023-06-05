namespace ATNetCoreTelegramBot.DAL.SchemaPerson;

public interface IPersonUnitOfWork
{
    #region Properties

    Person.IPersonRepository PersonRepository { get; }

    #endregion
}