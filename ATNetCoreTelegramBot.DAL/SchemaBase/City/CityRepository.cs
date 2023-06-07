using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.DAL.SchemaBase.City;

public class CityRepository : 
    ID.GuidRepository<Models.SchemaBase.City>, ICityRepository
{
    #region Constructor

    public CityRepository(Models.DatabaseContext databaseContext)
        : base(databaseContext)
    {

    } 

    #endregion

    #region Argument 2

    // ID
    public Models.SchemaBase.City GetByID
        (Guid id, bool isExceptID = false)
    {
        Models.SchemaBase.City? oEntities = null;

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

    public Task<Models.SchemaBase.City> GetByIdAsync
        (Guid id, bool isExceptID = false)
    {
        Task<Models.SchemaBase.City?> oEntities = null;

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

    // CultureId 
    public IEnumerable<Models.SchemaBase.City> GetByCultureId
        (int cultureId, bool isExceptCultureId = false)
    {
        IEnumerable<Models.SchemaBase.City> oEntities = null;

        if (isExceptCultureId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .OrderBy(current => current.CultureId)
                .ToList()
                ;
        }
        else if (isExceptCultureId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .OrderBy(current => current.CultureId)
                .ToList()
                ;
        }

        return (oEntities);
    }

    public Task<List<Models.SchemaBase.City>> GetByCultureIdAsync
        (int cultureId, bool isExceptCultureId = false)
    {
        Task<List<Models.SchemaBase.City>> oEntities = null;

        if (isExceptCultureId == false)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId == cultureId)
                .OrderBy(current => current.CultureId)
                .ToListAsync()
                ;
        }
        else if (isExceptCultureId == true)
        {
            oEntities =
                Get()
                .Where(current => current.CultureId != cultureId)
                .OrderBy(current => current.CultureId)
                .ToListAsync()
                ;
        }

        return (oEntities);
    }

    // ProvinceId 
    public IEnumerable<Models.SchemaBase.City> GetByProvinceId
        (Guid provinceId, bool isExceptProvinceId = false)
    {
        IEnumerable<Models.SchemaBase.City> oEntities = null;

        if (isExceptProvinceId == false)
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.ProvinceId)
                .ToList()
                ;
        }
        else if (isExceptProvinceId == true)
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.ProvinceId)
                .ToList()
                ;
        }

        return (oEntities);
    }

    public Task<List<Models.SchemaBase.City>> GetByProvinceIdAsync
        (Guid provinceId, bool isExceptProvinceId = false)
    {
        Task<List<Models.SchemaBase.City>> oEntities = null;

        if (isExceptProvinceId == false)
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.ProvinceId)
                .ToListAsync()
                ;
        }
        else if (isExceptProvinceId == true)
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.ProvinceId)
                .ToListAsync()
                ;
        }

        return (oEntities);
    }

    // Name 
    public IEnumerable<Models.SchemaBase.City> GetByName
        (string name, bool isExceptName = false)
    {
        IEnumerable<Models.SchemaBase.City> oEntities = null;

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
                .Where(current => current.Name == name)
                .OrderBy(current => current.Name)
                .ToList()
                ;
        }

        return (oEntities);
    }

    public Task<List<Models.SchemaBase.City>> GetByNameAsync
        (string name, bool isExceptName = false)
    {
        Task<List<Models.SchemaBase.City>> oEntities = null;

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
                .Where(current => current.Name == name)
                .OrderBy(current => current.Name)
                .ToListAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 2

    #region Argument 4

    // Id - ProvinceId
    public Models.SchemaBase.City GetById_ProvinceId
        (Guid id, Guid provinceId, bool isExceptID = false, bool isExceptProvinceId = false)
    {
        Models.SchemaBase.City oEntities = null;

        if ((isExceptID == false) && (isExceptProvinceId == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaBase.City> GetById_ProvinceIdAsync
        (Guid id, Guid provinceId, bool isExceptID = false, bool isExceptProvinceId = false)
    {
        Task<Models.SchemaBase.City> oEntities = null;

        if ((isExceptID == false) && (isExceptProvinceId == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    // Id - Name
    public Models.SchemaBase.City GetById_Name
        (Guid id, string name, bool isExceptID = false, bool isExceptName = false)
    {
        Models.SchemaBase.City oEntities = null;

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

    public Task<Models.SchemaBase.City> GetById_NameAsync
        (Guid id, string name, bool isExceptID = false, bool isExceptName = false)

    {
        Task<Models.SchemaBase.City> oEntities = null;

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

    // ProvinceId - Name
    public IEnumerable<Models.SchemaBase.City> GetByProvinceId_Name
        (Guid provinceId, string name, bool isExceptProvinceId = false, bool isExceptName = false)
    {
        IEnumerable<Models.SchemaBase.City> oEntities = null;

        if ((isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToList()
                ;
        }
        else if ((isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToList()
                ;
        }
        else if ((isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToList()
                ;
        }
        else if ((isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToList()
                ;
        }

        return (oEntities);
    }

    public Task<List<Models.SchemaBase.City>> GetByProvinceId_NameAsync
        (Guid provinceId, string name, bool isExceptProvinceId = false, bool isExceptName = false)

    {
        Task<List<Models.SchemaBase.City>> oEntities = null;

        if ((isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToListAsync()
                ;
        }
        else if ((isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToListAsync()
                ;
        }
        else if ((isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToListAsync()
                ;
        }
        else if ((isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .ToListAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 4

    #region Argument 6

    // Id - ProvinceId - Name
    public Models.SchemaBase.City GetById_ProvinceId_Name
        (Guid id, Guid provinceId, string name, bool isExceptID = false, bool isExceptProvinceId = false, bool isExceptName = false)
    {
        Models.SchemaBase.City oEntities = null;

        if ((isExceptID == false) && (isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefault()
                ;
        }

        return (oEntities);
    }

    public Task<Models.SchemaBase.City> GetById_ProvinceId_NameAsync
        (Guid id, Guid provinceId, string name, bool isExceptID = false, bool isExceptProvinceId = false, bool isExceptName = false)

    {
        Task<Models.SchemaBase.City> oEntities = null;

        if ((isExceptID == false) && (isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == false) && (isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id == id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == false) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId == provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true) && (isExceptName == false))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name == name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }
        else if ((isExceptID == true) && (isExceptProvinceId == true) && (isExceptName == true))
        {
            oEntities =
                Get()
                .Where(current => current.Id != id)
                .Where(current => current.ProvinceId != provinceId)
                .Where(current => current.Name != name)
                .OrderBy(current => current.Id)
                .ThenBy(current => current.ProvinceId)
                .ThenBy(current => current.Name)
                .FirstOrDefaultAsync()
                ;
        }

        return (oEntities);
    }

    #endregion /Argument 6

    #region Full Items

    public IEnumerable<Models.SchemaBase.City> GetByAllCities
        ()
    {
        IEnumerable<Models.SchemaBase.City> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToList()
            ;

        return oEntities;
    }

    public Task<List<Models.SchemaBase.City>> GetByAllCitiesAsync
        ()
    {
        Task<List<Models.SchemaBase.City>> oEntities =
            Get()
            .OrderBy(current => current.Name)
            .ToListAsync()
            ;

        return oEntities;
    }

    #endregion /Full Items
}