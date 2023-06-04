using ATNetCoreTelegramBot.DAL;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.DataRow.SchemaBase
{
    internal class City : Infrastructure.BaseController
    {
        public static int Insert(
            string countryName,
            string provinceName,
            string cityName,
            int correctInsert,
            bool isPrintAllFailedValueInTheDatabase)
        {
            try
            {
                Models.SchemaBase.Country? country = default;
                Models.SchemaBase.Province? province = default;
                Models.SchemaBase.City? city = default;

                country = UnitOfWork
                            .SchemaBaseUnitOfWork
                            .CountryRepository
                            .GetByName(countryName)
                            .FirstOrDefault()
                            ;

                if (country is not null)
                {
                    province = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .ProvinceRepository
                                .GetByName(provinceName)
                                .FirstOrDefault()
                                ;

                    if (province is not null)
                    {
                        city = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CityRepository
                                .GetByName(cityName)
                                .FirstOrDefault()
                                ;

                        if (city is null)
                        {
                            city = new Models.SchemaBase.City()
                            {
                                ProvinceId = province.Id,
                                Name = cityName,
                                InsertDateTime = DateTime.Now
                            };

                            UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CityRepository
                                .Insert(city)
                                ;

                            UnitOfWork
                                .SaveChanges();

                            correctInsert++;
                        }
                    }
                }

                return correctInsert;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}