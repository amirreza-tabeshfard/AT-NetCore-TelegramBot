using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATNetCoreTelegramBot.Models.SchemaPerson;

[System.ComponentModel.DataAnnotations.Schema.Table(name: Infrastructure.TableName.SchemaPerson.Person,
                                                    Schema = Infrastructure.SchemaName.SchemaPerson)]
public class Person : ID.BaseEntityGuid
{
    #region Configuration

    internal class Configuration : IEntityTypeConfiguration<Person>
    {
        [Obsolete]
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasIndex(current => new
            {
                current.UserId,
                current.GenderId
            })
            .IsUnique(unique: true)
            .HasName("IX_person.Person.UserId_GenderId");
            // **********
            builder.HasIndex(current => new
            {
                current.UserId,
                current.MaritalStatusId
            })
            .IsUnique(unique: true)
            .HasName("IX_person.Person.UserId_MaritalStatusId");
            // **********
            builder.HasIndex(current => new
            {
                current.UserId,
                current.MilitaryServiceStatusId
            })
            .IsUnique(unique: true)
            .HasName("IX_person.Person.UserId_MilitaryServiceStatusId");
            // **********
            builder.HasIndex(current => new
            {
                current.CultureId,
                current.UserId
            })
            .IsUnique(unique: true)
            .HasName("IX_person.Person.CultureId_UserId");
            // **********
            builder.HasIndex(current => current.GenderId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Person.GenderId");
            // **********
            builder.HasIndex(current => current.MaritalStatusId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Person.MaritalStatusId");
            // **********
            builder.HasIndex(current => current.MilitaryServiceStatusId)
                   .IsUnique(unique: false)
                   .HasName("IX_person.Person.MilitaryServiceStatusId");
            // **********
            builder.HasOne(current => current.User)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.UserId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.Culture)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.CultureId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
            // **********
            builder.HasOne(current => current.Gender)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.GenderId)
                    .OnDelete(DeleteBehavior.NoAction);
            // **********
            builder.HasOne(current => current.MaritalStatus)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.MaritalStatusId)
                    .OnDelete(DeleteBehavior.NoAction);
            // **********
            builder.HasOne(current => current.MilitaryServiceStatus)
                    .WithMany(current => current.People)
                    .HasForeignKey(current => current.MilitaryServiceStatusId)
                    .OnDelete(DeleteBehavior.NoAction);
            // **********
            
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
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 2)]
    public Guid UserId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 3)]
    public Nullable<int> GenderId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 4)]
    public Nullable<int> MaritalStatusId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 5)]
    public Nullable<int> MilitaryServiceStatusId { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.FirstName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 20,
            MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 6)]
    public string FirstName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Generals.General),
            Name = nameof(Resource.Generals.General.LastName))]

    [System.ComponentModel.DataAnnotations.Required
        (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.Required))]

    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 20,
            MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 7)]
    public string LastName { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 8)]
    public DateTime? Birthday { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 10,
            MinimumLength = 10,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 9)]
    public string? BirthCertificate { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 10,
            MinimumLength = 10,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 10)]
    public string? NationalCode { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.StringLength
        (maximumLength: 5000,
            MinimumLength = 30,
            ErrorMessageResourceType = typeof(Resource.Messages.Message),
            ErrorMessageResourceName = nameof(Resource.Messages.Message.MaxLength))]

    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 11)]
    public string? AboutMe { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Schema.Column
        (Order = 12)]
    public byte[]? Avatar { get; set; }
    // **********

    #region RelationShip

    #region SchemaBase

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaBase.CultureNames.CultureName),
            Name = nameof(Resource.Models.SchemaBase.CultureNames.CultureName.EntityName))]
    public virtual SchemaBase.Culture Culture { get; set; }
    // **********

    #endregion /SchemaBase

    #region SchemaPerson

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Addresses.Address),
            Name = nameof(Resource.Models.SchemaPerson.Addresses.Address.EntitiesName))]
    public virtual IList<Address> Addresses { get; set; }
    // ********** 

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Emails.Email),
            Name = nameof(Resource.Models.SchemaPerson.Emails.Email.EntitiesName))]
    public virtual IList<Email> Emails { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Genders.Gender),
            Name = nameof(Resource.Models.SchemaPerson.Genders.Gender.EntityName))]
    public virtual Gender Gender { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.InstantMessages.InstantMessage),
            Name = nameof(Resource.Models.SchemaPerson.InstantMessages.InstantMessage.EntitiesName))]
    public virtual IList<InstantMessage> InstantMessages { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus),
            Name = nameof(Resource.Models.SchemaPerson.MaritalStatuses.MaritalStatus.EntityName))]
    public virtual MaritalStatus MaritalStatus { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus),
            Name = nameof(Resource.Models.SchemaPerson.MilitaryServiceStatuses.MilitaryServiceStatus.EntityName))]
    public virtual MilitaryServiceStatus MilitaryServiceStatus { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Phones.Phone),
            Name = nameof(Resource.Models.SchemaPerson.Phones.Phone.EntitiesName))]
    public virtual IList<Phone> Phones { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Socials.Social),
            Name = nameof(Resource.Models.SchemaPerson.Socials.Social.EntitiesName))]
    public virtual IList<Social> Socials { get; set; }
    // **********

    // **********
    [System.ComponentModel.DataAnnotations.Display
        (ResourceType = typeof(Resource.Models.SchemaPerson.Urls.Url),
            Name = nameof(Resource.Models.SchemaPerson.Urls.Url.EntitiesName))]
    public virtual IList<Url> Urls { get; set; }

    // **********

    #endregion

    #region SchemaTelegram

    public virtual SchemaTelegram.User User { get; set; }

    #endregion

    #endregion /RelationShip
}