namespace ATNetCoreTelegramBot.DAL.ID;

internal interface ILongRepository<T> where T :
    Models.ID.BaseEntityLong
{
    #region Method(s)

    void Insert(T entity);

    void Update(T entity);

    void Delete(T entity);

    IQueryable<T> Get();

    IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

    #endregion
}