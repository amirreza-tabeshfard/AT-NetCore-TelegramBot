namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Person;

public interface IPersonRepository :
    ID.IGuidRepository<Models.SchemaPerson.Person>
{
    #region Argument 2

    // ID
    Models.SchemaPerson.Person GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaPerson.Person> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // UserId
    Models.SchemaPerson.Person GetByUserId
        (Guid userId, bool isExceptUserId = false);

    Task<Models.SchemaPerson.Person> GetByUserIdAsync
        (Guid userId, bool isExceptUserId = false);

    #endregion /Argument 2

    #region All Items

    IEnumerable<Models.SchemaPerson.Person> GetAllPeople
        ();

    Task<List<Models.SchemaPerson.Person>> GetAllPeopleAsync
        ();

    #endregion
}