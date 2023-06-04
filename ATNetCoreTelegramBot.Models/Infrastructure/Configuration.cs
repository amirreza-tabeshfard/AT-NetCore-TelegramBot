using Microsoft.EntityFrameworkCore;

namespace ATNetCoreTelegramBot.Models.Infrastructure;

internal static class Configuration
    : object
{
    internal static class Base
        : object
    {
        internal static void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchemaBase.City.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaBase.Country.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaBase.Province.Configuration());
        }
    }

    internal static class Telegram
        : object
    {
        internal static void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchemaTelegram.Channel.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaTelegram.Group.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaTelegram.User.Configuration());
        }
    }
}