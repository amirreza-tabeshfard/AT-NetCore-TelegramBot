using System.Linq;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Linq.SchemaBase
{
    public static class Province : object
    {
        public static System.Guid GuidProvince(
            string country,
            string province)
        {
            DatabaseContext db = new DatabaseContext();

            /*
                SELECT        BASE.Provinces.ID
                FROM          BASE.Provinces INNER JOIN
                              BASE.Countries ON BASE.Provinces.CountryID = BASE.Countries.ID
                Where		  BASE.Countries.Title = N'ایران' and
			                  BASE.Provinces.Title = N'آذربایجان شرقی'

            */

            //var GuidCityID =
            //    from oProvinces in DC.Provinces
            //    join oCountries in DC.Countries on oProvinces.CountryID equals oCountries.ID
            //    where oCountries.Title == strCountryName && oProvinces.Title == strProvinceName
            //    select oProvinces.ID;

            System.Guid guidCity =
                db.Provinces
                .Join(inner: db.Countries,
                        outerKeySelector: oProvinces => oProvinces.CountryId,
                        innerKeySelector: oCountries => oCountries.Id,
                        resultSelector: (oProvinces, oCountries) => new { oProvinces, oCountries })
                .Where(current => current.oCountries.Name == country && current.oProvinces.Name == province)
                .Select(current => current.oProvinces.Id)
                .SingleOrDefault();

            return guidCity;
        }
    }
}