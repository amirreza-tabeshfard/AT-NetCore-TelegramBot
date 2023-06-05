using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models;

namespace ATNetCoreTelegramBot.DAL.SchemaPerson.Person;

public class PersonRepository :
    ID.GuidRepository<Models.SchemaPerson.Person>, IPersonRepository
{
    #region Constructor

    public PersonRepository(DatabaseContext databaseContext)
        : base(databaseContext)
    {

    }

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaPerson.Person GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaPerson.Person? oEntities = default;

        if (isExceptID == false)
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .OrderBy(current => current.Id)
                .FirstOrDefault()
                ;
        }
        else if (isExceptID == true)
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .OrderBy(current => current.Id)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Person> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaPerson.Person?> oEntities = default;

        if (isExceptID == false)
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .OrderBy(current => current.Id)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptID == true)
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .OrderBy(current => current.Id)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // UserId
    public Models.SchemaPerson.Person GetByUserId
        (Guid userId, bool isExceptUserId = false)
    {
        Models.SchemaPerson.Person? oEntities = default;

        if (isExceptUserId == false)
        {
            oEntities =
                Get()
                .Where(current => current.UserId == userId)
                .OrderBy(current => current.UserId)
                .FirstOrDefault()
                ;
        }
        else if (isExceptUserId == true)
        {
            oEntities =
                Get()
                .Where(current => current.UserId != userId)
                .OrderBy(current => current.UserId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaPerson.Person> GetByUserIdAsync
        (Guid userId, bool isExceptUserId = false)
    {
        Task<Models.SchemaPerson.Person?> oEntities = default;

        if (isExceptUserId == false)
        {
            oEntities =
                Get()
                .Where(current => current.UserId == userId)
                .OrderBy(current => current.UserId)
                .FirstOrDefaultAsync()
                ;
        }
        else if (isExceptUserId == true)
        {
            oEntities =
                Get()
                .Where(current => current.UserId != userId)
                .OrderBy(current => current.UserId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2

    #region All Items

    public IEnumerable<Models.SchemaPerson.Person> GetAllPeople
        ()
    {
        IEnumerable<Models.SchemaPerson.Person> oEntities =
            Get()
            .OrderBy(current => current.FirstName)
            .ThenBy(current => current.LastName)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaPerson.Person>> GetAllPeopleAsync
        ()
    {
        Task<List<Models.SchemaPerson.Person>> oEntities =
            Get()
            .OrderBy(current => current.FirstName)
            .ThenBy(current => current.LastName)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion
}