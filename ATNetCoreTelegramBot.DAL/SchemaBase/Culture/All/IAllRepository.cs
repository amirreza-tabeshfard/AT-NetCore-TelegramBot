namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture.All;

public interface IAllRepository :
    ID.IIntRepository<Models.SchemaBase.Culture>
{
    IEnumerable<Models.SchemaBase.Culture> GetByAllCultures
        ();

    Task<List<Models.SchemaBase.Culture>> GetByAllCulturesAsync
        ();
}