using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaBase;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaBase.Culture,
                                                    Schema = Infrastructure.SchemaName.SchemaBase)]
public class Culture : ID.BaseEntityInt
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Culture>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Culture> builder)
        {
            builder.HasIndex(current => current.LanguageCultureName)
                   .IsUnique(unique: true)
                   .HasName("IX_base.Culture.LanguageCultureName");

            builder.HasIndex(current => current.DisplayName)
                   .IsUnique(unique: true)
                   .HasName("IX_base.Culture.DisplayName");

            builder.HasIndex(current => current.CultureCode)
                   .IsUnique(unique: true)
                   .HasName("IX_base.Culture.CultureCode");
        }
    }

    #endregion /Configuration

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.LanguageCultureName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 8,
            MinimumLength = 5,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public string LanguageCultureName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.DisplayName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 50,
            MinimumLength = 10,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public string DisplayName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.CultureCode))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 6,
            MinimumLength = 6,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public string CultureCode { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.IsActive))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 4)]
    public bool IsActive { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.InsertDateTime), Order = 500)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 500)]
    public DateTime InsertDateTime { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.LastUpdateDateTime), Order = 501)]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 501)]
    public DateTime? LastUpdateDateTime { get; set; }
    // **********

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Cities.City),
            Name = nameof(Resource.Models.SchemaBase.Cities.City.EntitiesName))]
    public virtual IList<City> Cities { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Countries.Country),
            Name = nameof(Resource.Models.SchemaBase.Countries.Country.EntitiesName))]
    public virtual IList<Country> Countries { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Provinces.Province),
            Name = nameof(Resource.Models.SchemaBase.Provinces.Province.EntitiesName))]
    public virtual IList<Province> Provinces { get; set; }
    // **********

    #endregion

    #region SchemaPerson

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Addresses.Address),
            Name = nameof(Resource.Models.SchemaPerson.Addresses.Address.EntitiesName))]
    public virtual IList<SchemaPerson.Address> Addresses { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.AddressTypes.AddressType),
            Name = nameof(Resource.Models.SchemaPerson.AddressTypes.AddressType.EntitiesName))]
    public virtual IList<SchemaPerson.AddressType> AddressTypes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.EmailTypes.EmailType),
            Name = nameof(Resource.Models.SchemaPerson.EmailTypes.EmailType.EntitiesName))]
    public virtual IList<SchemaPerson.EmailType> EmailTypes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Genders.Gender),
            Name = nameof(Resource.Models.SchemaPerson.Genders.Gender.EntitiesName))]
    public virtual IList<SchemaPerson.Gender> Genders { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType),
            Name = nameof(Resource.Models.SchemaPerson.InstantMessageTypes.InstantMessageType.EntitiesName))]
    public virtual IList<SchemaPerson.InstantMessageType> InstantMessageTypes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus),
            Name = nameof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus.EntitiesName))]
    public virtual IList<SchemaPerson.MaritalStatus> MaritalStatuses { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus),
            Name = nameof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus.EntitiesName))]
    public virtual IList<SchemaPerson.MilitaryServiceStatus> MilitaryServiceStatuses { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntitiesName))]
    public virtual IList<SchemaPerson.Person> People { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType),
            Name = nameof(Resource.Models.SchemaPerson.PhoneTypes.PhoneType.EntitiesName))]
    public virtual IList<SchemaPerson.PhoneType> PhoneTypes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.SocialTypes.SocialType),
            Name = nameof(Resource.Models.SchemaPerson.SocialTypes.SocialType.EntitiesName))]
    public virtual IList<SchemaPerson.SocialType> SocialTypes { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.UrlTypes.UrlType),
            Name = nameof(Resource.Models.SchemaPerson.UrlTypes.UrlType.EntitiesName))]
    public virtual IList<SchemaPerson.UrlType> UrlTypes { get; set; }
    // **********

    #endregion

    #endregion
}