using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.All;

internal class AllRepository :
    ID.IntRepository<Models.SchemaBase.Culture>, IAllRepository
{
    #region Constructor

    public AllRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Implementation(s): IAllRepository

    public IEnumerable<Models.SchemaBase.Culture> GetByAllCultures
        ()
    {
        IEnumerable<Models.SchemaBase.Culture> oEntities =
            Get()
            .OrderBy(current => current.DisplayName)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaBase.Culture>> GetByAllCulturesAsync
        ()
    {
        Task<List<Models.SchemaBase.Culture>> oEntities =
            Get()
            .OrderBy(current => current.DisplayName)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}