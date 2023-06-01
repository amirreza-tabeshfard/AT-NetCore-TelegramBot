using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL;

public interface IUnitOfWork : 
    IDisposable
{
    #region Method(s)

    T GetContext<T>() where T : DbContext;

    UnitOfWork BeginTransaction();

    DbContext GetContext();

    void SaveChanges();

    Task SaveChangesAsync();

    void RollBack();

    Task<T> FindAsync<T>(Guid id); 

    #endregion

    #region Properties

    SchemaTelegram.ITelegramUnitOfWork SchemaTelegramUnitOfWork { get; }

    #endregion
}