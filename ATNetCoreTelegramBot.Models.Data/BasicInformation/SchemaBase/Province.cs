namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

internal class Province : Infrastructure.BaseController
{
    #region Field(s)

    private readonly CRUD _crud;

    #endregion

    #region Constructor

    public Province()
    {
        _crud = new CRUD();
    }

    #endregion

    #region Private Method(s)

    private void Persian(ref int countInsert)
    {
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان شرقی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "آذربایجان غربی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اردبیل", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "اصفهان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "البرز", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "ایلام", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "بوشهر", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "تهران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "چهارمحال و بختیاری", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان جنوبی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان رضوی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خراسان شمالی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "خوزستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "زنجان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سمنان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "سیستان و بلوچستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "فارس", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قزوین", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "قم", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گلستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "گیلان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "لرستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مازندران", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "مرکزی", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "هرمزگان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "همدان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کردستان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمان", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کرمانشاه", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "کهگیلویه و بویراحمد", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, countryName: "ایران", provinceName: "یزد", ref countInsert);
    }

    private void English(ref int countInsert)
    {
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "East Azarbaijan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Western Azerbaijan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ardebil", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Esfahan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Alborz", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Ilam", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Bushehr", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Tehran", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Chaharmahal va Bakhtiari", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "southern Khorasan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Khorasan Razavi", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "North Khorasan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Khuzestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Zanjan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Semnan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Sistan and Baluchestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Fars", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Qazvin", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Qom", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Golestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Gilan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Lorestan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Mazandaran", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Central", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Hormozgan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Hamedan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Kurdistan", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Kerman", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Kermanshah", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Kohgiloyeh and Boyerahmad", ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, countryName: "Iran", provinceName: "Yazd", ref countInsert);
    }

    #endregion

    #region Method(s)

    internal void CreateByDefault()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Table [ Province ]  ==> ");

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

        private int GetByCultureID(string languageCultureName)
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

        private Guid GetByCountryID(string countryName)
        {
            Guid result = default;

            if (!string.IsNullOrEmpty(countryName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .CountryRepository
                                .GetByName(countryName)
                                .FirstOrDefault()
                                .Id
                                ;

            return result;
        }

        private Models.SchemaBase.Province GetByProvince(string provinceName)
        {
            Models.SchemaBase.Province result = default;

            if (!string.IsNullOrEmpty(provinceName))
                result = UnitOfWork
                                .SchemaBaseUnitOfWork
                                .ProvinceRepository
                                .GetByName(provinceName)
                                .FirstOrDefault()
                                ;

            return result;
        }

        #endregion

        internal void Insert(string languageCultureName,
                             string countryName,
                             string provinceName,
                             ref int countInsert)
        {
            Models.SchemaBase.Province province = GetByProvince(provinceName);

            if (province is default(Models.SchemaBase.Province))
            {
                province = new Models.SchemaBase.Province()
                {
                    CultureId = GetByCultureID(languageCultureName),
                    CountryId = GetByCountryID(countryName),
                    Name = provinceName
                };

                UnitOfWork
                    .SchemaBaseUnitOfWork
                    .ProvinceRepository
                    .Insert(province);

                UnitOfWork
                    .SaveChanges();

                countInsert++;
            }
        }
    }
}