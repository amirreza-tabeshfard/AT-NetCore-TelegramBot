using Microsoft.EntityFrameworkCore;

using ATNetCoreTelegramBot.Models.SchemaPerson;

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
            modelBuilder.ApplyConfiguration(new Gender.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaBase.Province.Configuration());
        }
    }

    internal static class Person
        : System.Object
    {
        internal static void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchemaPerson.Address.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.AddressType.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.Email.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.EmailType.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.Gender.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.InstantMessage.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.InstantMessageType.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.MaritalStatus.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.MilitaryServiceStatus.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.Phone.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.PhoneType.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.Social.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.SocialType.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.Url.Configuration());
            modelBuilder.ApplyConfiguration(new SchemaPerson.UrlType.Configuration());
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