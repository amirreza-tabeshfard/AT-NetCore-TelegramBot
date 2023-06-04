namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.DataRow.SchemaBase
{
    internal class Country : Infrastructure.BaseController
    {
        internal static int Insert(
            string countryName,
            int correctInsert,
            bool isPrintAllFailedValueInTheDatabase)
        {
            try
            {
                Models.SchemaBase.Country? country = default;

                country = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CountryRepository
                                .GetByName(countryName)
                                .FirstOrDefault()
                                ;

                if (country is null)
                {
                    country = new Models.SchemaBase.Country()
                    {
                        Name = countryName,
                        InsertDateTime = DateTime.Now
                    };

                    UnitOfWork
                        .SchemaBaseUnitOfWork
                        .CountryRepository
                        .Insert(country);

                    UnitOfWork
                        .SaveChanges();

                    correctInsert++;
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