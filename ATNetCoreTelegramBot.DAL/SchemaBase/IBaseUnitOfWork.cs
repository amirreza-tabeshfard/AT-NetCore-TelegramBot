namespace ATNetCoreTelegramBot.DAL.SchemaBase
{
    public interface IBaseUnitOfWork
    {
        #region Properties

        City.ICityRepository CityRepository { get; }

        Country.ICountryRepository CountryRepository { get; }

        Culture.ICultureRepository CultureRepository { get; }

        Province.IProvinceRepository ProvinceRepository { get; } 

        #endregion
    }
}