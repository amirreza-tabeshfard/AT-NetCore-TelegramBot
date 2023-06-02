using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.ID;

public class LongRepository<T> :
    Object, ILongRepository<T> where T : Models.ID.BaseEntityLong
{
    #region Constructor

    public LongRepository(DatabaseContext databaseContext)
    {
        DatabaseContext = databaseContext ?? throw new ArgumentNullException("DatabaseContext");
        DbSet = DatabaseContext.Set<T>();
    }

    #endregion

    #region Properties

    protected DbSet<T> DbSet { get; set; }

    protected DatabaseContext DatabaseContext { get; set; }

    #endregion /Properties

    #region Implement Interface(s)

    public void Insert(T entity)
    {
        if (entity == null)
        {
            throw (new ArgumentNullException("entity"));
        }

        DbSet.Add(entity);
    }

    public void Update(T entity)
    {
        if (entity == null)
        {
            throw (new ArgumentNullException("entity"));
        }

        EntityState oEntityState = DatabaseContext.Entry(entity).State;

        switch (oEntityState)
        {
            //case EntityState.Detached:
            //    DbSet.Attach(entity);
            //    break;

            case EntityState.Detached:
            case EntityState.Modified:
                DatabaseContext.Entry(entity).State =
                    EntityState.Modified;
                break;

            default:
                break;
        }
    }

    public void Delete(T entity)
    {
        if (entity == null)
        {
            throw (new ArgumentNullException("entity"));
        }

        EntityState oEntityState = DatabaseContext.Entry(entity).State;

        switch (oEntityState)
        {
            case EntityState.Detached:
                DbSet.Attach(entity);
                break;

            case EntityState.Unchanged:
            case EntityState.Deleted:
                DbSet.Remove(entity);
                break;

            default:
                break;
        }
    }

    public IQueryable<T> Get()
    {
        return (DbSet);
    }

    public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
    {
        return (DbSet.Where(predicate));
    }

    #endregion
}