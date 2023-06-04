using System.Linq;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.Linq.SchemaBase
{
    public static class City : object
    {
        public static System.Guid GuidCity(
            string country,
            string province,
            string city)
        {
            DatabaseContext db = new DatabaseContext();

            /*
                    SELECT				BASE.Cities.ID
                    FROM				BASE.Countries INNER JOIN
					                    BASE.Provinces ON BASE.Countries.ID = BASE.Provinces.CountryID INNER JOIN
					                    BASE.Cities ON BASE.Provinces.ID = BASE.Cities.ProvinceID
                    Where				BASE.Countries.Title = N'ایران' and
					                    BASE.Provinces.Title = N'تهران' and
					                    BASE.Cities.Title = N'تهران'

            */

            //var GuidCityID =
            //    from oCountries in DC.Countries
            //    join oProvinces in DC.Provinces on oCountries.ID equals oProvinces.CountryID
            //    join oCities in DC.Cities on oProvinces.ID equals oCities.ProvinceID
            //    where
            //        oCountries.Title == strCountryName && oProvinces.Title == strProvinceName &&
            //        oCities.Title == strCityName
            //    select oCities.ID;

            System.Guid guidCity =
                db.Countries
                .Join(inner: db.Provinces,
                      outerKeySelector: oCountries => oCountries.Id,
                      innerKeySelector: oProvinces => oProvinces.CountryId,
                      resultSelector: (oCountries, oProvinces) => new { oCountries, oProvinces })
                .Join(inner: db.Cities,
                      outerKeySelector: current => current.oProvinces.Id,
                      innerKeySelector: oCities => oCities.ProvinceId,
                      resultSelector: (current, oCities) => new { current, oCities })
                .Where(current => current.current.oCountries.Name == country &&
                       current.current.oProvinces.Name == province &&
                       current.oCities.Name == city)
                .Select(current => current.oCities.Id)
                .SingleOrDefault();

            return guidCity;
        }
    }
}