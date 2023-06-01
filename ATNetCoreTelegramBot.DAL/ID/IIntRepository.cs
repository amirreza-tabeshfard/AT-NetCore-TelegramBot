namespace ATNetCoreTelegramBot.DAL.ID;

public interface IIntRepository<T> where T : 
    Models.ID.BaseEntityIdentifier
{
    #region Method(s)

    void Insert(T entity);

    void Update(T entity);

    void Delete(T entity);

    IQueryable<T> Get();

    IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

    #endregion
}