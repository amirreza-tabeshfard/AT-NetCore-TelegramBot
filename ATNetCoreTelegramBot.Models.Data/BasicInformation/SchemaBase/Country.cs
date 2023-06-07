namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

internal class Country : Infrastructure.BaseController
{
    #region Field(s)

    private readonly CRUD _crud;

    #endregion

    #region Constructor

    public Country()
    {
        _crud = new CRUD();
    }

    #endregion

    #region Private Method(s)

    private void Persian(ref int countInsert)
    {
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", ref countInsert);
    }

    private void English(ref int countInsert)
    {
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", ref countInsert);
    }

    #endregion

    #region Method(s)

    internal void CreateByDefault()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Table [ Country ]  ==> ");

        int countInsert = default;

        Persian(ref countInsert);
        English(ref countInsert);

        if (countInsert is default(int))
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(countInsert);
    }
    
    #endregion

    internal class CRUD
    {
        #region Private Method(s)

        private int GetByLanguageCultureName(string languageCultureName)
        {
            int result = default;

            if (!string.IsNullOrEmpty(languageCultureName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CultureRepository
                                .Argument2Repository
                                .GetByLanguageCultureName(languageCultureName)
                                .Id
                                ;

            return result;
        }

        private Models.SchemaBase.Country GetByName(string countryName)
        {
            Models.SchemaBase.Country? result = default;

            result = UnitOfWork
                            .SchemaBaseUnitOfWork
                            .CountryRepository
                            .GetByName(countryName)
                            .FirstOrDefault()
                            ;

            return result;
        }

        #endregion

        internal void Insert(string languageCultureName,
                             string countryName,
                             ref int countInsert)
        {
            Models.SchemaBase.Country country = GetByName(countryName);

            if (country is default(Models.SchemaBase.Country))
            {
                country = new Models.SchemaBase.Country()
                {
                    CultureId = GetByLanguageCultureName(languageCultureName),
                    Name = countryName
                };

                UnitOfWork
                    .SchemaBaseUnitOfWork
                    .CountryRepository
                    .Insert(country);

                UnitOfWork
                    .SaveChanges();

                countInsert++;
            }
        }
    }
}