using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.Culture
{
    public class CultureRepository :
        ID.IntRepository<Models.SchemaBase.Culture>, ICultureRepository
    {
        #region Constructor

        public CultureRepository(Models.DatabaseContext databaseContext)
            : base(databaseContext)
        {
        } 

        #endregion

        #region Argument 2

        // ID
        public Models.SchemaBase.Culture GetByID
            (int id, bool isExceptID = false)
        {
            Models.SchemaBase.Culture oEntities = null;

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

        public Task<Models.SchemaBase.Culture> GetByIdAsync
            (int id, bool isExceptID = false)
        {
            Task<Models.SchemaBase.Culture> oEntities = null;

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

        // LanguageCultureName
        public IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName
            (string languageCultureName, bool isExceptLanguageCultureName = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptLanguageCultureName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ToList()
                    ;
            }
            else if (isExceptLanguageCultureName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureNameAsync
            (string languageCultureName, bool isExceptLanguageCultureName = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptLanguageCultureName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ToListAsync()
                    ;
            }
            else if (isExceptLanguageCultureName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // DisplayName
        public IEnumerable<Models.SchemaBase.Culture> GetByDisplayName
            (string displayName, bool isExceptDisplayName = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptDisplayName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.DisplayName)
                    .ToList()
                    ;
            }
            else if (isExceptDisplayName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.DisplayName)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByDisplayNameAsync
            (string displayName, bool isExceptDisplayName = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptDisplayName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }
            else if (isExceptDisplayName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // CultureCode
        public IEnumerable<Models.SchemaBase.Culture> GetByCultureCode
            (string cultureCode, bool isExceptCultureCode = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptCultureCode == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if (isExceptCultureCode == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.CultureCode)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByCultureCodeAsync
            (string cultureCode, bool isExceptCultureCode = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptCultureCode == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if (isExceptCultureCode == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // IsActive
        public IEnumerable<Models.SchemaBase.Culture> GetByIsActive
            (bool isActive)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            oEntities =
                Get()
                .Where(current => current.IsActive == isActive)
                .OrderBy(current => current.IsActive)
                .ToList()
                ;

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByIsActiveAsync
            (bool isActive)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            oEntities =
                Get()
                .Where(current => current.IsActive == isActive)
                .OrderBy(current => current.IsActive)
                .ToListAsync()
                ;

            return (oEntities);
        }

        #endregion /Argument 2

        #region Argument 4

        // Id - LanguageCultureName 
        public Models.SchemaBase.Culture GetById_LanguageCultureName
            (int id, string languageCultureName, bool isExceptID = false, bool isExceptLanguageCultureName = false)
        {
            Models.SchemaBase.Culture oEntities = null;

            if ((isExceptID == false) && (isExceptLanguageCultureName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptLanguageCultureName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptLanguageCultureName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptLanguageCultureName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Culture> GetById_LanguageCultureNameAsync
            (int id, string languageCultureName, bool isExceptID = false, bool isExceptLanguageCultureName = false)
        {
            Task<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptID == false) && (isExceptLanguageCultureName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptLanguageCultureName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptLanguageCultureName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptLanguageCultureName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.LanguageCultureName)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        // Id - DisplayName 
        public Models.SchemaBase.Culture GetById_DisplayName
            (int id, string displayName, bool isExceptID = false, bool isExceptDisplayName = false)
        {
            Models.SchemaBase.Culture oEntities = null;

            if ((isExceptID == false) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Culture> GetById_DisplayNameAsync
            (int id, string displayName, bool isExceptID = false, bool isExceptDisplayName = false)
        {
            Task<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptID == false) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.DisplayName)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        // Id - CultureCode 
        public Models.SchemaBase.Culture GetById_CultureCode
            (int id, string cultureCode, bool isExceptID = false, bool isExceptCultureCode = false)
        {
            Models.SchemaBase.Culture oEntities = null;

            if ((isExceptID == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefault()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefault()
                    ;
            }

            return (oEntities);
        }

        public Task<Models.SchemaBase.Culture> GetById_CultureCodeAsync
            (int id, string cultureCode, bool isExceptID = false, bool isExceptCultureCode = false)
        {
            Task<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptID == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if ((isExceptID == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.CultureCode)
                    .FirstOrDefaultAsync()
                    ;
            }

            return (oEntities);
        }

        // Id - IsActive 
        public Models.SchemaBase.Culture GetById_IsActive
            (int id, bool isActive, bool isExceptID = false)
        {
            Models.SchemaBase.Culture oEntities = null;

            if (isExceptID == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.IsActive)
                    .FirstOrDefault()
                    ;
            }
            else if (isExceptID == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.IsActive)
                    .FirstOrDefault()
                    ;
            }
            return (oEntities);
        }

        public Task<Models.SchemaBase.Culture> GetById_IsActiveAsync
            (int id, bool isActive, bool isExceptID = false)
        {
            Task<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptID == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Id == id)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.IsActive)
                    .FirstOrDefaultAsync()
                    ;
            }
            else if (isExceptID == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.Id != id)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.Id)
                    .ThenBy(current => current.IsActive)
                    .FirstOrDefaultAsync()
                    ;
            }
            return (oEntities);
        }

        // LanguageCultureName - DisplayName 
        public IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_DisplayName
            (string languageCultureName, string displayName, bool isExceptLanguageCultureName = false, bool isExceptDisplayName = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptLanguageCultureName == false) && (isExceptDisplayName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == false) && (isExceptDisplayName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptDisplayName == false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptDisplayName == true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_DisplayNameAsync
            (string languageCultureName, string displayName, bool isExceptLanguageCultureName = false, bool isExceptDisplayName = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if ((isExceptLanguageCultureName == false) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == false) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptDisplayName = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.DisplayName == displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptDisplayName = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.DisplayName != displayName)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.DisplayName)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // LanguageCultureName - CultureCode 
        public IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_CultureCode
            (string languageCultureName, string cultureCode, bool isExceptLanguageCultureName = false, bool isExceptCultureCode = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptLanguageCultureName == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_CultureCodeAsync
            (string languageCultureName, string cultureCode, bool isExceptLanguageCultureName = false, bool isExceptCultureCode = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if ((isExceptLanguageCultureName == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptLanguageCultureName == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // LanguageCultureName - IsActive
        public IEnumerable<Models.SchemaBase.Culture> GetByLanguageCultureName_IsActive
            (string languageCultureName, bool isActive, bool isExceptLanguageCultureName = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptLanguageCultureName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }
            else if (isExceptLanguageCultureName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByLanguageCultureName_IsActiveAsync
            (string languageCultureName, bool isActive, bool isExceptLanguageCultureName = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptLanguageCultureName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName == languageCultureName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }
            else if (isExceptLanguageCultureName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.LanguageCultureName != languageCultureName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.LanguageCultureName)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // DisplayName - CultureCode
        public IEnumerable<Models.SchemaBase.Culture> GetByDisplayName_CultureCode
            (string displayName, string cultureCode, bool isExceptDisplayName = false, bool isExceptCultureCode = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if ((isExceptDisplayName == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptDisplayName == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptDisplayName == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }
            else if ((isExceptDisplayName == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByDisplayName_CultureCodeAsync
            (string displayName, string cultureCode, bool isExceptDisplayName = false, bool isExceptCultureCode = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if ((isExceptDisplayName == false) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptDisplayName == false) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptDisplayName == true) && (isExceptCultureCode = false))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.CultureCode == cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }
            else if ((isExceptDisplayName == true) && (isExceptCultureCode = true))
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.CultureCode != cultureCode)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.CultureCode)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // DisplayName - IsActive
        public IEnumerable<Models.SchemaBase.Culture> GetByDisplayName_IsActive
            (string displayName, bool isActive, bool isExceptDisplayName = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptDisplayName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }
            else if (isExceptDisplayName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByDisplayName_IsActiveAsync
            (string displayName, bool isActive, bool isExceptDisplayName = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptDisplayName == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName == displayName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }
            else if (isExceptDisplayName == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.DisplayName != displayName)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.DisplayName)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        // CultureCode - IsActive
        public IEnumerable<Models.SchemaBase.Culture> GetByCultureCode_IsActive
            (string cultureCode, bool isActive, bool isExceptCultureCode = false)
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities = null;

            if (isExceptCultureCode == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode == cultureCode)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.CultureCode)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }
            else if (isExceptCultureCode == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode != cultureCode)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.CultureCode)
                    .ThenBy(current => current.IsActive)
                    .ToList()
                    ;
            }

            return (oEntities);
        }

        public Task<List<Models.SchemaBase.Culture>> GetByCultureCode_IsActiveAsync
            (string cultureCode, bool isActive, bool isExceptCultureCode = false)
        {
            Task<List<Models.SchemaBase.Culture>> oEntities = null;

            if (isExceptCultureCode == false)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode == cultureCode)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.CultureCode)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }
            else if (isExceptCultureCode == true)
            {
                oEntities =
                    Get()
                    .Where(current => current.CultureCode != cultureCode)
                    .Where(current => current.IsActive == isActive)
                    .OrderBy(current => current.CultureCode)
                    .ThenBy(current => current.IsActive)
                    .ToListAsync()
                    ;
            }

            return (oEntities);
        }

        #endregion /Argument 4

        #region Full Items

        public IEnumerable<Models.SchemaBase.Culture> GetByAllCultures
            ()
        {
            IEnumerable<Models.SchemaBase.Culture> oEntities =
                Get()
                .OrderBy(current => current.DisplayName)
                .ToList()
                ;

            return oEntities;
        }

        public Task<List<Models.SchemaBase.Culture>> GetByAllCulturesAsync
            ()
        {
            Task < List<Models.SchemaBase.Culture>> oEntities =
                Get()
                .OrderBy(current => current.DisplayName)
                .ToListAsync()
                ;

            return oEntities;
        }

        #endregion /Full Items

    }
}