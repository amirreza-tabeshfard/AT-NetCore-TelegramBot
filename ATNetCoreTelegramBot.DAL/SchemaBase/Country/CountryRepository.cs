using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Country
{
    public class CountryRepository : 
        ID.GuidRepository<Models.SchemaBase.Country>, ICountryRepository
    {
        #region Constructor

        public CountryRepository(Models.DatabaseContext databaseContext)
            : base(databaseContext)
        {

        } 

        #endregion

        #region Argument 2

        // ID
        public Models.SchemaBase.Country GetByID
            (Guid id, bool isExceptID = false)
        {
            Models.SchemaBase.Country oEntities = null;

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

        public Task<Models.SchemaBase.Country> GetByIdAsync
            (Guid id, bool isExceptID = false)
        {
            Task<Models.SchemaBase.Country> oEntities = null;

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

        // Name 
        public IEnumerable<Models.SchemaBase.Country> GetByName
            (string name, bool isExceptName = false)
        {
            IEnumerable<Models.SchemaBase.Country> oEntities = null;

            if (isExceptName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Name)
                    .ToList()
                    ;
            }
            else if (isExceptName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Name)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Country>> GetByNameAsync
            (string name, bool isExceptName = false)
        {
            Task<List<Models.SchemaBase.Country>> oEntities = null;

            if (isExceptName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Name)
                    .ToListAsync()
                    ;
            }
            else if (isExceptName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Name)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        #endregion /Argument 2

        #region Argument 4

        // Id - Name 
        public Models.SchemaBase.Country GetById_Name
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false)
        {
            Models.SchemaBase.Country oEntities = null;

            if ((isExceptID == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Country> GetById_NameAsync
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false)
        {
            Task<Models.SchemaBase.Country> oEntities = null;

            if ((isExceptID == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        #endregion /Argument 4

        #region Full Items

        // Name
        public IEnumerable<string> GetByCountriesName
            ()
        {
            var oEntities =
                Get()
                .Select(current => current.Name)
                .ToList()
                ;

            return oEntities;
        }

        public Task<List<string>> GetByCountriesNameAsync
            ()
        {
            var oEntities =
                Get()
                .Select(current => current.Name)
                .ToListAsync()
                ;

            return oEntities;
        }

        // All Items
        public IEnumerable<Models.SchemaBase.Country> GetByAllCountries
            ()
        {
            IEnumerable<Models.SchemaBase.Country> oEntities =
                Get()
                .OrderBy(current => current.Name)
                .ToList()
                ;

            return oEntities;
        }

        public Task<List<Models.SchemaBase.Country>> GetByAllCountriesAsync
            ()
        {
            Task<List<Models.SchemaBase.Country>> oEntities =
                Get()
                .OrderBy(current => current.Name)
                .ToListAsync()
                ;

            return oEntities;
        }

        #endregion /Full Items
    }
}