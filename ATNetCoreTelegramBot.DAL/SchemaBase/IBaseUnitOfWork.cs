namespace ATNetCoreTelegramBot.DAL.SchemaBase
{
    public interface IBaseUnitOfWork
    {
        #region Properties

        City.ICityRepository CityRepository { get; }

        Country.ICountryRepository CountryRepository { get; }

        Culture.ICultureUnitOfWork CultureRepository { get; }

        Province.IProvinceRepository ProvinceRepository { get; } 

        #endregion
    }
}