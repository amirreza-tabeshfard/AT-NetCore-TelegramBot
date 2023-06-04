namespace ATNetCoreTelegramBot.Models.Infrastructure;

public static class TableName
{
    public static class SchemaBase
    {
        public const string City = "Cities";
        public const string Country = "Countries";
        public const string Province = "Provinces";
    }

    public static class SchemaTelegram
    {
        public const string Channel = "Channels";
        public const string Group = "Groups";
        public const string User = "Users";
    }
}