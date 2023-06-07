namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Avatar;

public interface IAvatarRepository :
    ID.IGuidRepository<Models.SchemaPerson.Avatar>
{
    #region Argument 2

    // ID
    Models.SchemaPerson.Avatar GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaPerson.Avatar> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // PersonId
    Models.SchemaPerson.Avatar GetByPersonId
        (Guid personId, bool isExceptPersonId = false);

    Task<Models.SchemaPerson.Avatar> GetByPersonIdAsync
        (Guid personId, bool isExceptPersonId = false);

    // Name
    Models.SchemaPerson.Avatar GetByName
        (byte[] name, bool isExceptName = false);

    Task<Models.SchemaPerson.Avatar> GetByNameAsync
        (byte[] name, bool isExceptName = false);

    #endregion /Argument 2

    #region Argument 4

    // PersonId - Name
    Models.SchemaPerson.Avatar GetByPersonId_Name
        (Guid personId, byte[] name, bool isExceptPersonId = false, bool isExceptName = false);

    Task<Models.SchemaPerson.Avatar> GetByPersonId_NameAsync
        (Guid personId, byte[] name, bool isExceptPersonId = false, bool isExceptName = false);

    #endregion /Argument 4

    #region All Items

    IEnumerable<Models.SchemaPerson.Avatar> GetAllAvatar
        ();

    Task<List<Models.SchemaPerson.Avatar>> GetAllAvatarAsync
        ();

    #endregion
}