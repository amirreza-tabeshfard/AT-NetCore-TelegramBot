using ATNetCoreTelegramBot.DAL;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.DataRow.SchemaBase
{
    internal class Province : Infrastructure.BaseController
    {
        public static int Insert(
            string countryName,
            string provinceName,
            int correctInsert,
            bool isPrintAllFailedValueInTheDatabase)
        {
            try
            {
                Models.SchemaBase.Country? country = default;
                Models.SchemaBase.Province? province = default;

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

                    if (province is null)
                    {
                        province = new Models.SchemaBase.Province()
                        {
                            CountryId = country.Id,
                            Name = provinceName,
                            InsertDateTime = DateTime.Now
                        };

                        UnitOfWork
                            .SchemaBaseUnitOfWork
                            .ProvinceRepository
                            .Insert(province);

                        UnitOfWork
                            .SaveChanges();

                        correctInsert++;
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