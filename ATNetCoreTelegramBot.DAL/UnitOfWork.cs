using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL;

public class UnitOfWork :
    object, IUnitOfWork
{
    #region Field(s)

    private DatabaseContext _databaseContext;

    private SchemaPerson.IPersonUnitOfWork _schemaPersonUnitOfWork;

    private SchemaTelegram.ITelegramUnitOfWork _schemaTelegramUnitOfWork;

    #endregion /Field(s)

    #region Constructor

    public UnitOfWork()
    {
        IsDisposed = false;
    }

    #endregion

    #region Properties

    private IDbContextTransaction Transaction { get; set; }

    protected bool IsDisposed { get; set; }

    protected virtual DatabaseContext DatabaseContext
    {
        get
        {
            if (_databaseContext == null)
            {
                _databaseContext =
                    new DatabaseContext();
            }
            return (_databaseContext);
        }
    }

    #endregion /Properties

    #region Methodes

    public T GetContext<T>() where T : DbContext
    {
        return GetContext() as T;
    }

    public UnitOfWork BeginTransaction()
    {
        Transaction = DatabaseContext.Database.BeginTransaction();
        return this;
    }

    public DbContext GetContext() => _databaseContext;

    public void SaveChanges()
    {
        try
        {
            DatabaseContext.SaveChanges();
        }
        catch (System.Exception ex)
        {
            throw new System.Exception(ex.Message);
        }
    }

    public Task SaveChangesAsync()
    {
        try
        {
            return DatabaseContext.SaveChangesAsync();
        }
        catch (System.Exception ex)
        {
            throw new System.Exception(ex.Message);
        }
    }

    public void RollBack()
    {
        Transaction.Rollback();
        Dispose();
    }

    public Task<T> FindAsync<T>(Guid id)
    {
        return FindAsync<T>(id);
    }

    #endregion

    #region Implement Interface(s)

    public SchemaPerson.IPersonUnitOfWork SchemaPersonUnitOfWork
    {
        get
        {
            if (_schemaPersonUnitOfWork == null)
            {
                _schemaPersonUnitOfWork =
                    new SchemaPerson.PersonUnitOfWork(DatabaseContext);
            }
            return (_schemaPersonUnitOfWork);
        }
    }

    public SchemaTelegram.ITelegramUnitOfWork SchemaTelegramUnitOfWork
    {
        get
        {
            if (_schemaTelegramUnitOfWork == null)
            {
                _schemaTelegramUnitOfWork =
                    new SchemaTelegram.TelegramUnitOfWork(DatabaseContext);
            }
            return (_schemaTelegramUnitOfWork);
        }
    }

    #endregion

    #region Dispose

    public void Dispose()
    {
        Dispose(disposing: true);
        System.GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (IsDisposed == false)
        {
            if (disposing)
            {
                if (_databaseContext != null)
                    _databaseContext.Dispose();
            }
        }
        IsDisposed = true;
    }

    ~UnitOfWork()
    {
        Dispose(disposing: false);
    }

    #endregion /Dispose
}