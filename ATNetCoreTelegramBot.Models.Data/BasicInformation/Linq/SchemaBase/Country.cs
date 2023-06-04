using System.Linq;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Linq.SchemaBase
{
    public static class Country : object
    {
        public static Guid GuidCountry(
            string country)
        {
            DatabaseContext db = new DatabaseContext();

            Models.SchemaBase.Country singleOrDefault = db.Countries
                .SingleOrDefault(current => current.Name.Contains(country));

            if (singleOrDefault != null)
            {
                Guid guidCountyIran =
                    singleOrDefault
                        .Id;

                return guidCountyIran;
            }

            System.Diagnostics.Debug.Assert(condition: singleOrDefault != null, message: "singleOrDefault != null");
            return singleOrDefault.Id;
        }
    }
}