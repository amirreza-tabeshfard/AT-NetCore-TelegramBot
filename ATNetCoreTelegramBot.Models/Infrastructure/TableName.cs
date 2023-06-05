namespace ATNetCoreTelegramBot.Models.Infrastructure;

public static class TableName
{
    public static class SchemaBase
    {
        public const string City = "City";
        public const string Country = "Country";
        public const string Culture = "Culture";
        public const string Province = "Province";
    }

    public static class SchemaPerson
    {
        public const string Address = "Address";
        public const string AddressType = "AddressType";
        public const string BirthCertificate = "BirthCertificate";
        public const string Birthday = "Birthday";
        public const string Email = "Email";
        public const string EmailType = "EmailType";
        public const string Gender = "Gender";
        public const string InstantMessage = "InstantMessage";
        public const string InstantMessageType = "InstantMessageType";
        public const string MaritalStatus = "MaritalStatus";
        public const string MilitaryServiceStatus = "MilitaryServiceStatus";
        public const string NationalCode = "NationalCode";
        public const string Person = "Person";
        public const string Phone = "Phone";
        public const string PhoneType = "PhoneType";
        public const string Social = "Social";
        public const string SocialType = "SocialType";
        public const string Url = "Url";
        public const string UrlType = "UrlType";
    }


    public static class SchemaTelegram
    {
        public const string Channel = "Channels";
        public const string Group = "Groups";
        public const string User = "Users";
    }
}