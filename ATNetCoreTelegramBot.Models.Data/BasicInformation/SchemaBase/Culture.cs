using System.Data;

namespace ATNetCoreTelegramBot.Models.Data.BasicInformation.SchemaBase;

internal class Culture : Infrastructure.BaseController
{
    #region Field(s)

    private readonly CRUD _crud;

    #endregion

    #region Constructor

    public Culture()
    {
        _crud = new CRUD();
    }

    #endregion

    #region Method(s)

    internal void CreateByDefault()
    {
        Console.Write("Table [ Culture ]  ==> ");

        int countInsert = default;

        _crud.Insert(languageCultureName: "af-ZA", displayName: "Afrikaans - South Africa", cultureCode: "0x0436", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sq-AL", displayName: "Albanian - Albania", cultureCode: "0x041C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-DZ", displayName: "Arabic - Algeria", cultureCode: "0x1401", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-BH", displayName: "Arabic - Bahrain", cultureCode: "0x3C01", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-EG", displayName: "Arabic - Egypt", cultureCode: "0x0C01", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-IQ", displayName: "Arabic - Iraq", cultureCode: "0x0801", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-JO", displayName: "Arabic - Jordan", cultureCode: "0x2C01", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-KW", displayName: "Arabic - Kuwait", cultureCode: "0x3401", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-LB", displayName: "Arabic - Lebanon", cultureCode: "0x3001", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-LY", displayName: "Arabic - Libya", cultureCode: "0x1001", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-MA", displayName: "Arabic - Morocco", cultureCode: "0x1801", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-OM", displayName: "Arabic - Oman", cultureCode: "0x2001", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-QA", displayName: "Arabic - Qatar", cultureCode: "0x4001", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-SA", displayName: "Arabic - Saudi Arabia", cultureCode: "0x0401", isActive: true, ref countInsert);
        _crud.Insert(languageCultureName: "ar-SY", displayName: "Arabic - Syria", cultureCode: "0x2801", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-TN", displayName: "Arabic - Tunisia", cultureCode: "0x1C01", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-AE", displayName: "Arabic - United Arab Emirates", cultureCode: "0x3801", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ar-YE", displayName: "Arabic - Yemen", cultureCode: "0x2401", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "hy-AM", displayName: "Armenian - Armenia", cultureCode: "0x042B", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Cy-az-AZ", displayName: "Azeri (Cyrillic) - Azerbaijan", cultureCode: "0x082C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Lt-az-AZ", displayName: "Azeri (Latin) - Azerbaijan", cultureCode: "0x042C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "eu-ES", displayName: "Basque - Basque", cultureCode: "0x042D", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "be-BY", displayName: "Belarusian - Belarus", cultureCode: "0x0423", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "bg-BG", displayName: "Bulgarian - Bulgaria", cultureCode: "0x0402", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ca-ES", displayName: "Catalan - Catalan", cultureCode: "0x0403", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-CN", displayName: "Chinese - China", cultureCode: "0x0804", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-HK", displayName: "Chinese - Hong Kong SAR", cultureCode: "0x0C04", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-MO", displayName: "Chinese - Macau SAR", cultureCode: "0x1404", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-SG", displayName: "Chinese - Singapore", cultureCode: "0x1004", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-TW", displayName: "Chinese - Taiwan", cultureCode: "0x0404", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-CHS", displayName: "Chinese (Simplified)", cultureCode: "0x0004", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "zh-CHT", displayName: "Chinese (Traditional)", cultureCode: "0x7C04", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "hr-HR", displayName: "Croatian - Croatia", cultureCode: "0x041A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "cs-CZ", displayName: "Czech - Czech Republic", cultureCode: "0x0405", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "da-DK", displayName: "Danish - Denmark", cultureCode: "0x0406", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "div-MV", displayName: "Dhivehi - Maldives", cultureCode: "0x0465", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "nl-BE", displayName: "Dutch - Belgium", cultureCode: "0x0813", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "nl-NL", displayName: "Dutch - The Netherlands", cultureCode: "0x0413", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-AU", displayName: "English - Australia", cultureCode: "0x0C09", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-BZ", displayName: "English - Belize", cultureCode: "0x2809", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-CA", displayName: "English - Canada", cultureCode: "0x1009", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-CB", displayName: "English - Caribbean", cultureCode: "0x2409", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-IE", displayName: "English - Ireland", cultureCode: "0x1809", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-JM", displayName: "English - Jamaica", cultureCode: "0x2009", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-NZ", displayName: "English - New Zealand", cultureCode: "0x1409", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-PH", displayName: "English - Philippines", cultureCode: "0x3409", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-ZA", displayName: "English - South Africa", cultureCode: "0x1C09", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-TT", displayName: "English - Trinidad and Tobago", cultureCode: "0x2C09", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "en-GB", displayName: "English - United Kingdom", cultureCode: "0x0809", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.English_UnitedStates, displayName: "English - United States", cultureCode: "0x0409", isActive: true, ref countInsert);
        _crud.Insert(languageCultureName: "en-ZW", displayName: "English - Zimbabwe", cultureCode: "0x3009", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "et-EE", displayName: "Estonian - Estonia", cultureCode: "0x0425", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fo-FO", displayName: "Faroese - Faroe Islands", cultureCode: "0x0438", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: Common.Infrastructure.Culture.Farsi_Iran, displayName: "Farsi - Iran", cultureCode: "0x0429", isActive: true, ref countInsert);
        _crud.Insert(languageCultureName: "fi-FI", displayName: "Finnish - Finland", cultureCode: "0x040B", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-BE", displayName: "French - Belgium", cultureCode: "0x080C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-CA", displayName: "French - Canada", cultureCode: "0x0C0C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-FR", displayName: "French - France", cultureCode: "0x040C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-LU", displayName: "French - Luxembourg", cultureCode: "0x140C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-MC", displayName: "French - Monaco", cultureCode: "0x180C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "fr-CH", displayName: "French - Switzerland", cultureCode: "0x100C", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "gl-ES", displayName: "Galician - Galician", cultureCode: "0x0456", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ka-GE", displayName: "Georgian - Georgia", cultureCode: "0x0437", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "de-AT", displayName: "German - Austria", cultureCode: "0x0C07", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "de-DE", displayName: "German - Germany", cultureCode: "0x0407", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "de-LI", displayName: "German - Liechtenstein", cultureCode: "0x1407", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "de-LU", displayName: "German - Luxembourg", cultureCode: "0x1007", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "de-CH", displayName: "German - Switzerland", cultureCode: "0x0807", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "el-GR", displayName: "Greek - Greece", cultureCode: "0x0408", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "gu-IN", displayName: "Gujarati - India", cultureCode: "0x0447", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "he-IL", displayName: "Hebrew - Israel", cultureCode: "0x040D", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "hi-IN", displayName: "Hindi - India", cultureCode: "0x0439", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "hu-HU", displayName: "Hungarian - Hungary", cultureCode: "0x040E", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "is-IS", displayName: "Icelandic - Iceland", cultureCode: "0x040F", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "id-ID", displayName: "Indonesian - Indonesia", cultureCode: "0x0421", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "it-IT", displayName: "Italian - Italy", cultureCode: "0x0410", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "it-CH", displayName: "Italian - Switzerland", cultureCode: "0x0810", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ja-JP", displayName: "Japanese - Japan", cultureCode: "0x0411", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "kn-IN", displayName: "Kannada - India", cultureCode: "0x044B", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "kk-KZ", displayName: "Kazakh - Kazakhstan", cultureCode: "0x043F", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "kok-IN", displayName: "Konkani - India", cultureCode: "0x0457", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ko-KR", displayName: "Korean - Korea", cultureCode: "0x0412", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ky-KZ", displayName: "Kyrgyz - Kazakhstan", cultureCode: "0x0440", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "lv-LV", displayName: "Latvian - Latvia", cultureCode: "0x0426", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "lt-LT", displayName: "Lithuanian-Lithuania", cultureCode: "0x0427", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "mk-MK", displayName: "Macedonian(FYROM)", cultureCode: "0x042F", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ms-BN", displayName: "Malay - Brunei", cultureCode: "0x083E", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ms-MY", displayName: "Malay - Malaysia", cultureCode: "0x043E", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "mr-IN", displayName: "Marathi - India", cultureCode: "0x044E", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "mn-MN", displayName: "Mongolian - Mongolia", cultureCode: "0x0450", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "nb-NO", displayName: "Norwegian(Bokmål) - Norway", cultureCode: "0x0414", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "nn-NO", displayName: "Norwegian(Nynorsk) - Norway", cultureCode: "0x0814", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "pl-PL", displayName: "Polish - Poland", cultureCode: "0x0415", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "pt-BR", displayName: "Portuguese - Brazil", cultureCode: "0x0416", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "pt-PT", displayName: "Portuguese - Portugal", cultureCode: "0x0816", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "pa-IN", displayName: "Punjabi - India", cultureCode: "0x0446", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ro-RO", displayName: "Romanian - Romania", cultureCode: "0x0418", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ru-RU", displayName: "Russian - Russia", cultureCode: "0x0419", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sa-IN", displayName: "Sanskrit - India", cultureCode: "0x044F", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Cy-sr-SP", displayName: "Serbian(Cyrillic) - Serbia", cultureCode: "0x0C1A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Lt-sr-SP", displayName: "Serbian(Latin) - Serbia", cultureCode: "0x081A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sk-SK", displayName: "Slovak - Slovakia", cultureCode: "0x041B", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sl-SI", displayName: "Slovenian - Slovenia", cultureCode: "0x0424", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-AR", displayName: "Spanish - Argentina", cultureCode: "0x2C0A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-BO", displayName: "Spanish - Bolivia", cultureCode: "0x400A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-CL", displayName: "Spanish - Chile", cultureCode: "0x340A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-CO", displayName: "Spanish - Colombia", cultureCode: "0x240A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-CR", displayName: "Spanish - Costa Rica", cultureCode: "0x140A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-DO", displayName: "Spanish - Dominican Republic", cultureCode: "0x1C0A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-EC", displayName: "Spanish - Ecuador", cultureCode: "0x300A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-SV", displayName: "Spanish - El Salvador", cultureCode: "0x440A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-GT", displayName: "Spanish - Guatemala", cultureCode: "0x100A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-HN", displayName: "Spanish - Honduras", cultureCode: "0x480A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-MX", displayName: "Spanish - Mexico", cultureCode: "0x080A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-NI", displayName: "Spanish - Nicaragua", cultureCode: "0x4C0A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-PA", displayName: "Spanish - Panama", cultureCode: "0x180A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-PY", displayName: "Spanish - Paraguay", cultureCode: "0x3C0A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-PE", displayName: "Spanish - Peru", cultureCode: "0x280A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-PR", displayName: "Spanish - Puerto Rico", cultureCode: "0x500A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-ES", displayName: "Spanish - Spain", cultureCode: "0x0C0A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-UY", displayName: "Spanish - Uruguay", cultureCode: "0x380A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "es-VE", displayName: "Spanish - Venezuela", cultureCode: "0x200A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sw-KE", displayName: "Swahili - Kenya", cultureCode: "0x0441", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sv-FI", displayName: "Swedish - Finland", cultureCode: "0x081D", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "sv-SE", displayName: "Swedish - Sweden", cultureCode: "0x041D", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "syr-SY", displayName: "Syriac - Syria", cultureCode: "0x045A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ta-IN", displayName: "Tamil - India", cultureCode: "0x0449", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "tt-RU", displayName: "Tatar - Russia", cultureCode: "0x0444", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "te-IN", displayName: "Telugu - India", cultureCode: "0x044A", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "th-TH", displayName: "Thai - Thailand", cultureCode: "0x041E", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "tr-TR", displayName: "Turkish - Turkey", cultureCode: "0x041F", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "uk-UA", displayName: "Ukrainian - Ukraine", cultureCode: "0x0422", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "ur-PK", displayName: "Urdu - Pakistan", cultureCode: "0x0420", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Cy-uz-UZ", displayName: "Uzbek(Cyrillic) - Uzbekistan", cultureCode: "0x0843", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "Lt-uz-UZ", displayName: "Uzbek(Latin) - Uzbekistan", cultureCode: "0x0443", isActive: default, ref countInsert);
        _crud.Insert(languageCultureName: "vi-VN", displayName: "Vietnamese - Vietnam", cultureCode: "0x042A", isActive: default, ref countInsert);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Insert Culture: ");

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

        private Models.SchemaBase.Culture GetByLanguageCultureName_DisplayName(string languageCultureName, string displayName)
        {
            Models.SchemaBase.Culture? result = default;

            result = UnitOfWork
                            .SchemaBaseUnitOfWork
                            .CultureRepository
                            .GetByLanguageCultureName_DisplayName(languageCultureName, displayName)
                            .FirstOrDefault()
                            ;

            return result;
        }

        #endregion

        internal void Insert(string languageCultureName,
                             string displayName,
                             string cultureCode,
                             bool isActive,
                             ref int countInsert)
        {
            Models.SchemaBase.Culture culture = GetByLanguageCultureName_DisplayName(languageCultureName, displayName);

            if (culture is null)
            {
                culture = new Models.SchemaBase.Culture()
                {
                    LanguageCultureName = languageCultureName,
                    DisplayName = displayName,
                    CultureCode = cultureCode,
                    IsActive = isActive,
                    InsertDateTime = DateTime.Now
                };

                UnitOfWork
                    .SchemaBaseUnitOfWork
                    .CultureRepository
                    .Insert(culture);

                UnitOfWork
                    .SaveChanges();

                countInsert++;
            }
        }
    }
}