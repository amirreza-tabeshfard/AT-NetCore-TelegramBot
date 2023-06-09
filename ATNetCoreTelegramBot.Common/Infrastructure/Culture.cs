﻿namespace ATNetCoreTelegramBot.Common.Infrastructure;

public static class Culture : object
{
    private const string Afrikaans_SouthAfrica = "af-ZA";
    private const string Albanian_Albania = "sq-AL";
    private const string Arabic_Algeria = "ar-DZ";
    private const string Arabic_Bahrain = "ar-BH";
    private const string Arabic_Egypt = "ar-EG";
    private const string Arabic_Iraq = "ar-IQ";
    private const string Arabic_Jordan = "ar-JO";
    private const string Arabic_Kuwait = "ar-KW";
    private const string Arabic_Lebanon = "ar-LB";
    private const string Arabic_Libya = "ar-LY";
    private const string Arabic_Morocco = "ar-MA";
    private const string Arabic_Oman = "ar-OM";
    private const string Arabic_Qatar = "ar-QA";
    private const string Arabic_SaudiArabia = "ar-SA";
    private const string Arabic_Syria = "ar-SY";
    private const string Arabic_Tunisia = "ar-TN";
    private const string Arabic_UnitedArabEmirates = "ar-AE";
    private const string Arabic_Yemen = "ar-YE";
    private const string Armenian_Armenia = "hy-AM";
    private const string Azeri_Cyrillic_Azerbaijan = "Cy-az-AZ";
    private const string Azeri_Latin_Azerbaijan = "Lt-az-AZ";
    private const string Basque_Basque = "eu-ES";
    private const string Belarusian_Belarus = "be-BY";
    private const string Bulgarian_Bulgaria = "bg-BG";
    private const string Catalan_Catalan = "ca-ES";
    private const string Chinese_China = "zh-CN";
    private const string Chinese_HongKongSAR = "zh-HK";
    private const string Chinese_MacauSAR = "zh-MO";
    private const string Chinese_Singapore = "zh-SG";
    private const string Chinese_Taiwan = "zh-TW";
    private const string Chinese_Simplified = "zh-CHS";
    private const string Chinese_Traditional = "zh-CHT";
    private const string Croatian_Croatia = "hr-HR";
    private const string Czech_CzechReprivate = "cs-CZ";
    private const string Danish_Denmark = "da-DK";
    private const string Dhivehi_Maldives = "div-MV";
    private const string Dutch_Belgium = "nl-BE";
    private const string Dutch_TheNetherlands = "nl-NL";
    private const string English_Australia = "en-AU";
    private const string English_Belize = "en-BZ";
    private const string English_Canada = "en-CA";
    private const string English_Caribbean = "en-CB";
    private const string English_Ireland = "en-IE";
    private const string English_Jamaica = "en-JM";
    private const string English_NewZealand = "en-NZ";
    private const string English_Philippines = "en-PH";
    private const string English_SouthAfrica = "en-ZA";
    private const string English_TrinidadAndTobago = "en-TT";
    private const string English_UnitedKingdom = "en-GB";
    public const string English_UnitedStates = "en-US";
    private const string English_Zimbabwe = "en-ZW";
    private const string Estonian_Estonia = "et-EE";
    private const string Faroese_FaroeIslands = "fo-FO";
    public const string Farsi_Iran = "fa-IR";
    private const string Finnish_Finland = "fi-FI";
    private const string French_Belgium = "fr-BE";
    private const string French_Canada = "fr-CA";
    private const string French_France = "fr-FR";
    private const string French_Luxembourg = "fr-LU";
    private const string French_Monaco = "fr-MC";
    private const string French_Switzerland = "fr-CH";
    private const string Galician_Galician = "gl-ES";
    private const string Georgian_Georgia = "ka-GE";
    private const string German_Austria = "de-AT";
    private const string German_Germany = "de-DE";
    private const string German_Liechtenstein = "de-LI";
    private const string German_Luxembourg = "de-LU";
    private const string German_Switzerland = "de-CH";
    private const string Greek_Greece = "el-GR";
    private const string Gujarati_India = "gu-IN";
    private const string Hebrew_Israel = "he-IL";
    private const string Hindi_India = "hi-IN";
    private const string Hungarian_Hungary = "hu-HU";
    private const string Icelandic_Iceland = "is-IS";
    private const string Indonesian_Indonesia = "id-ID";
    private const string Italian_Italy = "it-IT";
    private const string Italian_Switzerland = "it-CH";
    private const string Japanese_Japan = "ja-JP";
    private const string Kannada_India = "kn-IN";
    private const string Kazakh_Kazakhstan = "kk-KZ";
    private const string Konkani_India = "kok-IN";
    private const string Korean_Korea = "ko-KR";
    private const string Kyrgyz_Kazakhstan = "ky-KZ";
    private const string Latvian_Latvia = "lv-LV";
    private const string Lithuanian_Lithuania = "lt-LT";
    private const string Macedonian_FYROM = "mk-MK";
    private const string Malay_Brunei = "ms-BN";
    private const string Malay_Malaysia = "ms-MY";
    private const string Marathi_India = "mr-IN";
    private const string Mongolian_Mongolia = "mn-MN";
    private const string Norwegian_Bokmål_Norway = "nb-NO";
    private const string Norwegian_Nynorsk_Norway = "nn-NO";
    private const string Polish_Poland = "pl-PL";
    private const string Portuguese_Brazil = "pt-BR";
    private const string Portuguese_Portugal = "pt-PT";
    private const string Punjabi_India = "pa-IN";
    private const string Romanian_Romania = "ro-RO";
    private const string Russian_Russia = "ru-RU";
    private const string Sanskrit_India = "sa-IN";
    private const string Serbian_Cyrillic_Serbia = "Cy-sr-SP";
    private const string Serbian_Latin_Serbia = "Lt-sr-SP";
    private const string Slovak_Slovakia = "sk-SK";
    private const string Slovenian_Slovenia = "sl-SI";
    private const string Spanish_Argentina = "es-AR";
    private const string Spanish_Bolivia = "es-BO";
    private const string Spanish_Chile = "es-CL";
    private const string Spanish_Colombia = "es-CO";
    private const string Spanish_CostaRica = "es-CR";
    private const string Spanish_DominicanReprivate = "es-DO";
    private const string Spanish_Ecuador = "es-EC";
    private const string Spanish_ElSalvador = "es-SV";
    private const string Spanish_Guatemala = "es-GT";
    private const string Spanish_Honduras = "es-HN";
    private const string Spanish_Mexico = "es-MX";
    private const string Spanish_Nicaragua = "es-NI";
    private const string Spanish_Panama = "es-PA";
    private const string Spanish_Paraguay = "es-PY";
    private const string Spanish_Peru = "es-PE";
    private const string Spanish_PuertoRico = "es-PR";
    private const string Spanish_Spain = "es-ES";
    private const string Spanish_Uruguay = "es-UY";
    private const string Spanish_Venezuela = "es-VE";
    private const string Swahili_Kenya = "sw-KE";
    private const string Swedish_Finland = "sv-FI";
    private const string Swedish_Sweden = "sv-SE";
    private const string Syriac_Syria = "syr-SY";
    private const string Tamil_India = "ta-IN";
    private const string Tatar_Russia = "tt-RU";
    private const string Telugu_India = "te-IN";
    private const string Thai_Thailand = "th-TH";
    private const string Turkish_Turkey = "tr-TR";
    private const string Ukrainian_Ukraine = "uk-UA";
    private const string Urdu_Pakistan = "ur-PK";
    private const string Uzbek_Cyrillic_Uzbekistan = "Cy-uz-UZ";
    private const string Uzbek_Latin_Uzbekistan = "Lt-uz-UZ";
    private const string Vietnamese_Vietnam = "vi-VN";
}