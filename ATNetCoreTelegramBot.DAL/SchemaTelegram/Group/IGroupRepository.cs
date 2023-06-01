namespace ATNetCoreTelegramBot.DAL.SchemaTelegram.Group;

public interface IGroupRepository :
    ID.IGuidRepository<Models.SchemaTelegram.Group>
{
    #region Argument 2

    // ID
    Models.SchemaTelegram.Group GetByID
        (Guid id, bool isExceptID = false);

    Task<Models.SchemaTelegram.Group> GetByIdAsync
        (Guid id, bool isExceptID = false);

    // Name
    Models.SchemaTelegram.Group GetByName
        (string name, bool isExceptName = false);

    Task<Models.SchemaTelegram.Group> GetByNameAsync
        (string name, bool isExceptName = false);

    #endregion

    #region Full Items

    // All Items
    System.Collections.Generic.IEnumerable<Models.SchemaTelegram.Group> GetByAllGroups
        ();

    Task<System.Collections.Generic.List<Models.SchemaTelegram.Group>> GetByAllGroupsAsync
        ();

    #endregion /Full Items
}