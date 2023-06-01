namespace ATNetCoreTelegramBot.DAL.ID;

public interface IGuidRepository<T> where T :
    Models.ID.BaseEntityGuid
{
    #region Method(s)

    void Insert(T entity);

    void Update(T entity);

    void Delete(T entity);

    IQueryable<T> Get();

    IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

    #endregion
}