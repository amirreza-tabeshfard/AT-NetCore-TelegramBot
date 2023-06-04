using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Address,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Address : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Address>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasIndex(current => current.CultureId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Address.CultureId");
            // **********
            builder.HasIndex(current => current.PersonId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Address.PersonId");
            // **********
            builder.HasIndex(current => current.CityId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Address.CityId");
            // **********
            builder.HasIndex(current => current.AddressTypeId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Address.AddressTypeId");
            // **********
            builder.HasOne(current => current.Culture)
                    .WithMany(current => current.Addresses)
                    .HasForeignKey(current => current.CultureId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.Person)
                    .WithMany(current => current.Addresses)
                    .HasForeignKey(current => current.PersonId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.City)
                    .WithMany(current => current.Addresses)
                    .HasForeignKey(current => current.CityId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.AddressType)
                    .WithMany(current => current.Addresses)
                    .HasForeignKey(current => current.AddressTypeId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }

    #endregion /Configuration

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 1)]
    public int CultureId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid PersonId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Cities.City),
            Name = nameof(Resource.Models.SchemaBase.Cities.City.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public Guid CityId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.AddressTypes.AddressType),
            Name = nameof(Resource.Models.SchemaPerson.AddressTypes.AddressType.EntityName))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 4)]
    public int AddressTypeId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 5)]
    public string Location { get; set; }
    // **********

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]
    public virtual SchemaBase.Culture Culture { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.Cities.City),
            Name = nameof(Resource.Models.SchemaBase.Cities.City.EntityName))]
    public virtual SchemaBase.City City { get; set; }
    // ********** 

    #endregion

    #region SchemaPerson

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.AddressTypes.AddressType),
            Name = nameof(Resource.Models.SchemaPerson.AddressTypes.AddressType.EntityName))]
    public virtual AddressType AddressType { get; set; }
    // ********** 

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.People.Person),
            Name = nameof(Resource.Models.SchemaPerson.People.Person.EntityName))]
    public virtual Person Person { get; set; }
    // ********** 

    #endregion

    #endregion
}