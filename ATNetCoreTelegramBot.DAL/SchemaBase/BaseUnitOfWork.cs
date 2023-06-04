namespace ATNetCoreTelegramBot.DAL.SchemaBase
{
    public class BaseUnitOfWork :
        object, IBaseUnitOfWork
    {
        #region Field(s)

        private City.ICityRepository _cityRepository;
        private Country.ICountryRepository _countryRepository;
        private Province.IProvinceRepository _provinceRepository;

        #endregion

        #region Constructor

        public BaseUnitOfWork(Models.DatabaseContext databaseContext)
        {
            if (databaseContext == null)
            {
                throw (new System.ArgumentNullException("databaseContext"));
            }

            DatabaseContext = databaseContext;
        }

        #endregion

        #region Properties

        protected Models.DatabaseContext DatabaseContext { get; set; }

        #endregion /Properties

        #region Implement Interface(s)

        public City.ICityRepository CityRepository
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository =
                        new City.CityRepository(DatabaseContext);
                }
                return (_cityRepository);
            }
        }

        public Country.ICountryRepository CountryRepository
        {
            get
            {
                if (_countryRepository == null)
                {
                    _countryRepository =
                        new Country.CountryRepository(DatabaseContext);
                }
                return (_countryRepository);
            }
        }

        public Province.IProvinceRepository ProvinceRepository
        {
            get
            {
                if (_provinceRepository == null)
                {
                    _provinceRepository =
                        new Province.ProvinceRepository(DatabaseContext);
                }
                return (_provinceRepository);
            }
        } 

        #endregion
    }
}