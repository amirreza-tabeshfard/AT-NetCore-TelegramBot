using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Province
{
    public class ProvinceRepository : 
        ID.GuidRepository<Models.SchemaBase.Province>, IProvinceRepository
    {
        #region Constructor

        public ProvinceRepository(Models.DatabaseContext databaseContext)
            : base(databaseContext)
        {

        } 

        #endregion

        #region Argument 2

        // ID
        public Models.SchemaBase.Province GetByID
            (Guid id, bool isExceptID = false)
        {
            Models.SchemaBase.Province oEntities = null;

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

        public Task<Models.SchemaBase.Province> GetByIdAsync
            (Guid id, bool isExceptID = false)
        {
            Task<Models.SchemaBase.Province> oEntities = null;

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

        // CountryId 
        public IEnumerable<Models.SchemaBase.Province> GetByCountryId
            (Guid countryId, bool isExceptCountryId = false)
        {
            IEnumerable<Models.SchemaBase.Province> oEntities = null;

            if (isExceptCountryId == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.CountryId)
                    .ToList()
                    ;
            }
            else if (isExceptCountryId == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.CountryId)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Province>> GetByCountryIdAsync
            (Guid countryId, bool isExceptCountryId = false)
        {
            Task<List<Models.SchemaBase.Province>> oEntities = null;

            if (isExceptCountryId == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.CountryId)
                    .ToListAsync()
                    ;
            }
            else if (isExceptCountryId == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.CountryId)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // Name 
        public IEnumerable<Models.SchemaBase.Province> GetByName
            (string name, bool isExceptName = false)
        {
            IEnumerable<Models.SchemaBase.Province> oEntities = null;

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

        public Task<List<Models.SchemaBase.Province>> GetByNameAsync
            (string name, bool isExceptName = false)
        {
            Task<List<Models.SchemaBase.Province>> oEntities = null;

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

        // Id - CountryId
        public Models.SchemaBase.Province GetById_CountryId
            (Guid id, Guid countryId, bool isExceptID = false, bool isExceptCountryId = false)
        {
            Models.SchemaBase.Province oEntities = null;

            if ((isExceptID == false) && (isExceptCountryId == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Province> GetById_CountryIdAsync
            (Guid id, Guid countryId, bool isExceptID = false, bool isExceptCountryId = false)
        {
            Task<Models.SchemaBase.Province> oEntities = null;

            if ((isExceptID == false) && (isExceptCountryId == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        // Id - Name
        public Models.SchemaBase.Province GetById_Name
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false)
        {
            Models.SchemaBase.Province oEntities = null;

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

        public Task<Models.SchemaBase.Province> GetById_NameAsync
            (Guid id, string name, bool isExceptID = false, bool isExceptName = false)
        {
            Task<Models.SchemaBase.Province> oEntities = null;

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

        // CountryId - Name
        public IEnumerable<Models.SchemaBase.Province> GetByCountryId_Name
            (Guid countryId, string name, bool isExceptCountryId = false, bool isExceptName = false)
        {
            IEnumerable<Models.SchemaBase.Province> oEntities = null;

            if ((isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToList()
                    ;
            }
            else if ((isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToList()
                    ;
            }
            else if ((isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToList()
                    ;
            }
            else if ((isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Province>> GetByCountryId_NameAsync
            (Guid countryId, string name, bool isExceptCountryId = false, bool isExceptName = false)
        {
            Task<List<Models.SchemaBase.Province>> oEntities = null;

            if ((isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        #endregion /Argument 4

        #region Argument 6

        // Id - CountryId - Name
        public Models.SchemaBase.Province GetById_CountryId_Name
            (Guid id, Guid countryId, string name, bool isExceptID = false, bool isExceptCountryId = false, bool isExceptName = false)
        {
            Models.SchemaBase.Province oEntities = null;

            if ((isExceptID == false) && (isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Province> GetById_CountryId_NameAsync
            (Guid id, Guid countryId, string name, bool isExceptID = false, bool isExceptCountryId = false, bool isExceptName = false)
        {
            Task<Models.SchemaBase.Province> oEntities = null;

            if ((isExceptID == false) && (isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == false) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId == countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true) && (isExceptName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name == name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCountryId == true) && (isExceptName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CountryId != countryId)
                    .Where(current => current.Name != name)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CountryId)
                    .ThenBy(current => current.Name)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        #endregion /Argument 6

        #region Full Items

        public IEnumerable<Models.SchemaBase.Province> GetByAllProvinces
            ()
        {
            IEnumerable<Models.SchemaBase.Province> oEntities =
                Get()
                .OrderBy(current => current.Name)
                .ToList()
                ;

            return oEntities;
        }

        public Task<List<Models.SchemaBase.Province>> GetByAllProvincesAsync
            ()
        {
            Task<List<Models.SchemaBase.Province>> oEntities =
                Get()
                .OrderBy(current => current.Name)
                .ToListAsync()
                ;

            return oEntities;
        }

        #endregion /Full Items
    }
}